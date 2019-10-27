$DbPassword=ConvertTo-SecureString -String "Bestpassword1" -AsPlainText -Force
$AppNameSuffix="test"
$Location = "australiaeast"

$ErrorActionPreference = "Stop"

function Get-UniqueString ([string] $Id, $Length=13)
{
    $HashArray = (New-Object System.Security.Cryptography.SHA512Managed).ComputeHash($Id.ToCharArray())
    Return -join ($HashArray[1..$Length] | ForEach-Object { [char]($_ % 26 + [byte][char]'a') })
}

Write-Output "------------------------Provisioning [Started]------------------------"
# Static config values
$BaseAppName = "SparkHealth"
$ResourceGroupName = $BaseAppName + $AppNameSuffix
$WebAppServicePlan = "$($ResourceGroupName)ServicePlan"
$DbName = $BaseAppName
$DbNewName = $BaseAppName + "New"

# Component Names
# TEMPLATE: $ComponentName = "$($ResourceGroupName)ComponentName"

Write-Output "------------------------Resource Group Provisioning [Started]------------------------"
# Login to Azure
Write-Output "Logging in to Azure [Started]"
# az login --service-principal --username $ServicePrincipal_App_ID --password $ServicePrincipal_PASSWORD --tenant $ServicePrincipal_TENANT_ID
az login
Write-Output "Logging in to Azure [Done]"

# Create a resource group
Write-Output "Creating Resource Group $($ResourceGroupName) [Started]"
az group create --location $Location --name $ResourceGroupName
Write-Output "Creating Resource Group $($ResourceGroupName) [Done]"
Write-Output "------------------------Resource Group Provisioning [Done]------------------------"

$ResourceGroupId = az group show --name "$ResourceGroupName" --query 'id' --output tsv
$UniquePrefix = Get-UniqueString($ResourceGroupId)

$WebAppName = 'app-' + $UniquePrefix
$WebApiName = 'api-' + $UniquePrefix

$DbFirewallRuleName = 'sqlsvrfirewallrule-' + $UniquePrefix
$StorageAccountName = 'storage' + $UniquePrefix
$StorageContainerName = 'storagec' + $UniquePrefix
$SqlServerName = 'sqlserver-' + $UniquePrefix

$WebAppAddress = "https://$($WebAppName).azurewebsites.net"
$WebApiAddress = "https://$($WebApiName).azurewebsites.net"
$SQLServerAdminUsername="bestuser"
$SQLServerAdminPasswordText = (New-Object PSCredential $SQLServerAdminUsername, $DbPassword).GetNetworkCredential().Password

$DbConnectionString = "Server=tcp:$($SqlServerName).database.windows.net,1433;Database=$($DbName);User ID=$($SQLServerAdminUsername);Password=$($SQLServerAdminPasswordText);Encrypt=true;Connection Timeout=30;"
$DbNewConnectionString = "Server=tcp:$($SqlServerName).database.windows.net,1433;Database=$($DbNewName);User ID=$($SQLServerAdminUsername);Password=$($SQLServerAdminPasswordText);Encrypt=true;Connection Timeout=30;"

# Create a SQL Database logical server
Write-Output "Creating SQL Server $($SqlServerName) [Started]"
az sql server create --name $SqlServerName --resource-group $ResourceGroupName --location $Location --admin-user """$SQLServerAdminUsername""" --admin-password """$SQLServerAdminPasswordText"""
Write-Output "Creating SQL Server $($SqlServerName) [Done]"

# Configure a server firewall rule
Write-Output "Configuring SQL Server Firewall Rule [Started]"
az sql server firewall-rule create --resource-group $ResourceGroupName --server $SqlServerName --name $DbFirewallRuleName --start-ip-address 0.0.0.0 --end-ip-address 0.0.0.0
Write-Output "Configuring SQL Server Firewall Rule [Done]"

# Create a storage account
Write-Output "Creating storage account [Started]"
az storage account create --name $StorageAccountName --resource-group $ResourceGroupName --location $Location --sku Standard_LRS --encryption blob
Write-Output "Creating storage account [Done]"

Write-Output "Getting storage account key [Started]"
$KeyList = az storage account keys list --account-name $StorageAccountName | ConvertFrom-Json
$StorageAccountKey = $KeyList[0].value
Write-Output "Getting storage account key [Done]"

# Create a storage container
Write-Output "Creating storage container [Started]"
az storage container create --name $StorageContainerName --account-name $StorageAccountName --account-key $StorageAccountKey
Write-Output "Creating storage container [Done]"

# Create a database for Lapbase and one for LapbaseNew
Write-Output "Creating Database $DbName [Started]"
az sql db create --resource-group $ResourceGroupName --server $SqlServerName --name $DbName --service-objective "Basic"
Write-Output "Creating Database $DbName [Done]"

Write-Output "Creating Database $DbNewName [Started]"
az sql db create --resource-group $ResourceGroupName --server $SqlServerName --name $DbNewName --service-objective "Basic"
Write-Output "Creating Database $DbNewName [Done]"

# Create an App Service plan
Write-Output "Creating App Service Plan $($WebAppServicePlan) [Started]"
az appservice plan create --name $WebAppServicePlan --resource-group $ResourceGroupName --sku "F1"
Write-Output "Creating App Service Plan $($WebAppServicePlan) [Done]"

# Create an App Resource for the WebApp
Write-Output "Creating App Service Resource $($WebAppName) [Started]"
az webapp create --resource-group $ResourceGroupName --plan $WebAppServicePlan --name $WebAppName
Write-Output "Creating App Service Resource $($WebAppName) [Done]"

# Create an App Resource for the WebApi
Write-Output "Creating App Service Resource $($WebApiName) [Started]"
az webapp create --resource-group $ResourceGroupName --plan $WebAppServicePlan --name $WebApiName
Write-Output "Creating App Service Resource $($WebApiName) [Done]"

Write-Output "------------------------Injecting Environment Variables [Started]------------------------"
$WebAppNameList = @(
    $WebAppName
    $WebApiName
)

foreach ($WebAppToConfigureName in $WebAppNameList) {
    Write-Output "Injecting Connection String for $WebAppToConfigureName [Started]"
    az webapp config connection-string set --resource-group $ResourceGroupName --name $WebAppToConfigureName --connection-string-type "SQLServer" --settings "Lapbase=$($DbConnectionString)"
    az webapp config connection-string set --resource-group $ResourceGroupName --name $WebAppToConfigureName --connection-string-type "SQLServer" --settings "LapbaseNew=$($DbNewConnectionString)"
    Write-Output "Injecting Connection String [Done]"
}
Write-Output "------------------------Injecting Environment Variables [Done]------------------------"

Write-Output "------------------------Setting Up Error Logs [Started]------------------------"
Write-Output "Setting Up Error Logs for $WebApiName [Started]"
&az webapp log config --name $WebApiName --resource-group $ResourceGroupName --application-logging true --level error
Write-Output "Setting Up Error Logs for $WebApiName [Done]"
Write-Output "------------------------Setting Up Error Logs [Done]------------------------"

Write-Output "------------------------Provisioning [Done]------------------------"

$SQLServerAdminPasswordText = (New-Object PSCredential $SQLServerAdminUsername, $DbPassword).GetNetworkCredential().Password

$BuildArtifactsPath = (New-Item -Path '..\publish' -ItemType 'Directory' -Force).FullName
$WebAppPath = '..\lapbase-app'
$WebApiPath = '..\Lapbase'

$BacpacFileName = 'Lapbase.bacpac'

Write-Output "Publish Directory: $BuildArtifactsPath"

Write-Output "------------------------Building [Started]------------------------"
Write-Output "Building WebApi [Started]"
Push-Location $WebApiPath
& dotnet publish -c Release
Compress-Archive -Path "$WebApiPath\bin\Release\netcoreapp2.2\publish\*" -DestinationPath "$($BuildArtifactsPath)\$($WebApiName).zip" -Force
Pop-Location
Write-Output "Building WebApi [Done]"

# Build the Lapbase Webapp for the production environment
Write-Output "Building WebApp [Started]"
Write-Output "Generate Web App Environment Settings [Started]"
Push-Location $WebAppPath
$AngularConfig = @"
export const environment = {
  production: true,
  LAPBASE_API_ADDRESS: '$($WebApiAddress)/api/',
  AZURE_AD_CLIENTID: '8c692cb0-4826-466d-8b95-8805ee1e6a93',
  AZURE_AD_TENANTID: '2e833ca0-6a32-45e7-b968-1faae0218ea4',
  REDIRECT_URI: '$($WebAppAddress)/Dashboard',
  POST_LOGOUT_REDIRECT_URI: '$($WebAppAddress)',
  AUTHORITY: 'https://login.microsoftonline.com/2e833ca0-6a32-45e7-b968-1faae0218ea4',
  CONSENT_SCOPES: ['api://b9e4a478-e93e-4bea-bb73-cf23d5bfefe0/.default'],
    PROTECTED_RESOURCE_MAP: [
    ['$($WebApiAddress)/api/', ['api://b9e4a478-e93e-4bea-bb73-cf23d5bfefe0/.default']]
  ]
};
"@
Out-File -FilePath "src\environments\environment.prod.ts" -InputObject $AngularConfig -Encoding "UTF8"

Write-Output "Generate Web App Environment Settings [Done]"
npm install --loglevel=error
npm run build --loglevel=error
Compress-Archive -Path "dist\lapbaseApp\*" -DestinationPath "$($BuildArtifactsPath)\$($WebAppName).zip" -Force
Pop-Location
Write-Output "Building WebApp [Done]"
Write-Output "------------------------Building [Done]------------------------"

Write-Output "------------------------Deploying [Started]------------------------"
# Upload database to blob storage
Write-Output "Upload database to blob storage container $StorageContainerName [Started]"
$old_ErrorActionPreference = $ErrorActionPreference
$ErrorActionPreference = 'SilentlyContinue'
az storage blob upload --container-name $StorageContainerName --name $BacpacFileName --file ($PSScriptRoot + ".\$BacpacFileName") --account-name $StorageAccountName --account-key $StorageAccountKey
$ErrorActionPreference = $old_ErrorActionPreference
Write-Output "Upload database to blob storage $StorageContainerName [Done]"

# Import bacpac into database
Write-Output "Importing bacpac into database $DbName [Started]"
az sql db import --server $SqlServerName --name $DbName -g $ResourceGroupName -p $SQLServerAdminPasswordText -u $SQLServerAdminUsername --storage-key $StorageAccountKey --storage-key-type StorageAccessKey --storage-uri "https://$StorageAccountName.blob.core.windows.net/$StorageContainerName/$BacpacFileName"
Write-Output "Importing bacpac into database $DbName [Done]"

Write-Output "------------------------Force SSL Only [Started]------------------------"
az webapp update --https-only true --resource-group $ResourceGroupName --name $WebAppName
Write-Output "------------------------Force SSL Only [Done]------------------------"

$old_ErrorActionPreference = $ErrorActionPreference
$ErrorActionPreference = 'SilentlyContinue'

Write-Output "Deploying WebApi [Started]"
az webapp deployment source config-zip --src "$($BuildArtifactsPath)\$($WebApiName).zip" --resource-group $ResourceGroupName --name $WebApiName
Write-Output "Deploying WebApi [Done]"

Write-Output "Deploying WebApp [Started]"
az webapp deployment source config-zip --src "$($BuildArtifactsPath)\$($WebAppName).zip" --resource-group $ResourceGroupName --name $WebAppName
Write-Output "Deploying WebApp [Done]"

$ErrorActionPreference = $old_ErrorActionPreference
Write-Output "------------------------Deploying [Done]------------------------"

Write-Output "Restarting WebApi [Started]"
az webapp restart --resource-group $ResourceGroupName --name $WebApiName
Write-Output "Restarting WebApi [Done]"