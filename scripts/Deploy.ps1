$ServicePrincipal_App_ID="61ff10ba-5b86-4b20-8dde-9ca53c6a6586"
$ServicePrincipal_TENANT_ID="9aee26d8-97c2-4fad-8900-96735f6dc73f"
$ServicePrincipal_PASSWORD="69ef97df-d5c1-491c-a888-d2289d21dd9e"
$DbUsername="bestusername"
$DbPassword=ConvertTo-SecureString -String "Bestpassword1" -AsPlainText -Force
$DbPasswordText = (New-Object PSCredential $DbUsername, $DbPassword).GetNetworkCredential().Password
$AppNameSuffix="test"
$Location = "australiaeast"

$ErrorActionPreference = "Stop"

Write-Output "------------------------Provisioning [Started]------------------------"
$DeployedResources = Invoke-Expression ($PSScriptRoot + ".\Provision.ps1")
Write-Output "------------------------Provisioning [Done]------------------------"

$BaseAppName = $DeployedResources.BaseAppName
$ResourceGroupName = $DeployedResources.ResourceGroupName
$WebAppServicePlan = $DeployedResources.WebAppServicePlan
$DbName = $DeployedResources.DbName

$WebAppName = $DeployedResources.WebAppName
$WebApiName = $DeployedResources.WebApiName

$StorageAccountName = $DeployedResources.StorageAccountName
$StorageAccountKey = $DeployedResources.StorageAccountKey
$StorageContainerName = $DeployedResources.StorageContainerName
Write-Output "---------------------------------Storage container name $StorageContainerName---------------------------------"
$SqlServerName = $DeployedResources.SqlServerName

$WebAppAddress = $DeployedResources.WebAppAddress
$WebApiAddress = $DeployedResources.WebApiAddress

$DbConnectionString = $DeployedResources.DbConnectionString

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
    LAPBASE_API_ADDRESS: '$($DeployedResources.WebApiAddress)'
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
# Login to Azure
Write-Output "Logging in to Azure [Started]"
az login --service-principal --username $ServicePrincipal_App_ID --password $ServicePrincipal_PASSWORD --tenant $ServicePrincipal_TENANT_ID
Write-Output "Logging in to Azure [Done]"

# Upload database to blob storage
Write-Output "Upload database to blob storage container $StorageContainerName [Started]"
$old_ErrorActionPreference = $ErrorActionPreference
$ErrorActionPreference = 'SilentlyContinue'
az storage blob upload --container-name $StorageContainerName --name $BacpacFileName --file ($PSScriptRoot + ".\$BacpacFileName") --account-name $StorageAccountName --account-key $StorageAccountKey
$ErrorActionPreference = $old_ErrorActionPreference
Write-Output "Upload database to blob storage $StorageContainerName [Done]"

# Import bacpac into database
Write-Output "Importing bacpac into database $DbName [Started]"
az sql db import --server $SqlServerName --name $DbName -g $ResourceGroupName -p $DbPasswordText -u $DbUsername --storage-key $StorageAccountKey --storage-key-type StorageAccessKey --storage-uri "https://$StorageAccountName.blob.core.windows.net/$StorageContainerName/$BacpacFileName"
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