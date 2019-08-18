[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)]
    [string] $ServicePrincipal_App_ID,

    [Parameter(Mandatory=$true)]
    [string] $ServicePrincipal_TENANT_ID,

    [Parameter(Mandatory=$true)]
    [SecureString] $ServicePrincipal_PASSWORD,
    
    [Parameter(Mandatory=$true)]
    [string] $DbUsername,

    [Parameter(Mandatory=$true)]
    [SecureString] $DbPassword,

    [Parameter(Mandatory=$false)]
    [string] $AppNameSuffix,

    [Parameter(Mandatory=$false)]
    [string] $Location = 'australiaeast'
)
$ErrorActionPreference = "Stop"

$DeployedResources = Invoke-Expression ($PSScriptRoot + ".\Provision.ps1") @PSBoundParameters

$BaseAppName = $DeployedResources.BaseAppName
$ResourceGroupName = $DeployedResources.ResourceGroupName
$WebAppServicePlan = $DeployedResources.WebAppServicePlan
$DbName = $DeployedResources.DbName

$WebAppName = $DeployedResources.WebAppName
$ServiceHostApiName = $DeployedResources.ServiceHostApiName

$SqlServerName = $DeployedResources.SqlServerName

$WebAppAddress = $DeployedResources.WebAppAddress
$WebApiAddress = $DeployedResources.WebApiAddress

$DbConnectionString = $DeployedResources.DbConnectionString

$BuildArtifactsPath = (New-Item -Path '..\publish' -ItemType 'Directory' -Force).FullName
$WebAppPath = '..\lapbase-app'
$WebApiPath = '..\Lapbase'

Write-Verbose "Publish Directory: $BuildArtifactsPath"

Write-Verbose "------------------------Building [Started]------------------------"
Write-Verbose "Building WebApi [Started]"
Push-Location $WebApiPath
& dotnet publish -c Release
Compress-Archive -Path "$WebApiPath\bin\Release\netcoreapp2.2\publish\*" -DestinationPath "$($BuildArtifactsPath)\$($WebApiName).zip" -Force
Pop-Location
Write-Verbose "Building WebApi [Done]"

# Build the Lapbase Webapp for the production environment
Write-Verbose "Building WebApp [Started]"
Write-Verbose "Generate Web App Environment Settings [Started]"
Push-Location $WebAppPath
$ReactConfig = @"
export const environment = {
    production: true
    LAPBASE_API_ADDRESS: $($DeployedResources.WebApiAddress)
};
"@
Out-File -FilePath "src\environments\environment.prod.ts" -InputObject $ReactConfig -Encoding "UTF8"

Write-Verbose "Generate Web App Environment Settings [Done]"
& npm install
(& cmd.exe /c 'npm run build --loglevel=error') 2> $null
Compress-Archive -Path "build\*" -DestinationPath "$($BuildArtifactsPath)\$($WebAppName).zip" -Force
Pop-Location
Write-Verbose "Building WebApp [Done]"
Write-Verbose "------------------------Building [Done]------------------------"

Write-Verbose "------------------------Deploying [Started]------------------------"
# Login to Azure
Write-Verbose "Logging in to Azure [Started]"
&az login --service-principal --username $SP_App_ID --password $SP_PASSWORD --tenant $SP_TENANT_ID
Write-Verbose "Logging in to Azure [Done]"

Write-Verbose "------------------------Force SSL Only [Started]------------------------"
&az webapp update --https-only true --resource-group $ResourceGroupName --name $WebAppName
Write-Verbose "------------------------Force SSL Only [Done]------------------------"

Write-Verbose "Deploying WebApi [Started]"
&az webapp deployment source config-zip --src "$($BuildArtifactsPath)\$($WebApiName).zip" --resource-group $ResourceGroupName --name $WebApiName
Write-Verbose "Deploying WebApi [Done]"

Write-Verbose "Deploying WebApp [Started]"
&az webapp deployment source config-zip --src "$($BuildArtifactsPath)\$($WebAppName).zip" --resource-group $ResourceGroupName --name $WebAppName
Write-Verbose "Deploying WebApp [Done]"
Write-Verbose "------------------------Deploying [Done]------------------------"

Write-Verbose "Restarting WebApi [Started]"
&az webapp restart --resource-group $ResourceGroupName --name $WebApiName
Write-Verbose "Restarting WebApi [Done]"