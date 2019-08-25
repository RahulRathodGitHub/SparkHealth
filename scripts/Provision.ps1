$ServicePrincipal_App_ID="61ff10ba-5b86-4b20-8dde-9ca53c6a6586"
$ServicePrincipal_TENANT_ID="9aee26d8-97c2-4fad-8900-96735f6dc73f"
$ServicePrincipal_PASSWORD="69ef97df-d5c1-491c-a888-d2289d21dd9e"
$SQLServerAdminUsername="bestuser"
$DbUsername="bestusername"
$DbPassword=ConvertTo-SecureString -String "Bestpassword1" -AsPlainText -Force
$AppNameSuffix="test"
$Location = "australiaeast"

function Get-UniqueString ([string] $Id, $Length=13)
{
    $HashArray = (New-Object System.Security.Cryptography.SHA512Managed).ComputeHash($Id.ToCharArray())
    Return -join ($HashArray[1..$Length] | ForEach-Object { [char]($_ % 26 + [byte][char]'a') })
}

$ErrorActionPreference = "Stop"

# Static config values
$BaseAppName = "Lapbase"
$ResourceGroupName = $BaseAppName + $AppNameSuffix
$WebAppServicePlan = "$($ResourceGroupName)ServicePlan"
$DbName = $BaseAppName
$DbNewName = $BaseAppName + "New"

# Component Names
# TEMPLATE: $ComponentName = "$($ResourceGroupName)ComponentName"

Write-Output "------------------------Resource Group Provisioning [Started]------------------------"
# Login to Azure
Write-Output "Logging in to Azure [Started]"
az login --service-principal --username $ServicePrincipal_App_ID --password $ServicePrincipal_PASSWORD --tenant $ServicePrincipal_TENANT_ID
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
$DbPasswordText = (New-Object PSCredential $DbUsername, $DbPassword).GetNetworkCredential().Password
$SQLServerAdminPasswordText = (New-Object PSCredential $SQLServerAdminUsername, $DbPassword).GetNetworkCredential().Password

$DbConnectionString = "Server=tcp:$($SqlServerName).database.windows.net,1433;Database=$($DbName);User ID=$($DbUsername);Password=$($DbPasswordText);Encrypt=true;Connection Timeout=30;"
$DbNewConnectionString = "Server=tcp:$($SqlServerName).database.windows.net,1433;Database=$($DbNewName);User ID=$($SQLServerAdminUsername);Password=$($SQLServerAdminPasswordText);Encrypt=true;Connection Timeout=30;"

Write-Output "------------------------Provisioning [Started]------------------------"

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

Write-Output "------------------------Provisioning [Done]------------------------"

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

$Results = [Ordered] @{
    BaseAppName = $BaseAppName
    ResourceGroupName = $ResourceGroupName
    WebAppServicePlan = $WebAppServicePlan
    DbName = $DbName

    WebAppName = $WebAppName
    WebApiName = $WebApiName

	StorageAccountName = $StorageAccountName
	StorageContainerName = $StorageContainerName
	StorageAccountKey = $StorageAccountKey
    SqlServerName = $SqlServerName
    SQLServerAdminUsername=$SQLServerAdminUsername

    WebAppAddress = $WebAppAddress
    WebApiAddress = $WebApiAddress

    DbConnectionString = $DbConnectionString
}

Write-Output ($Results | Format-Table | Out-String)

Return $Results