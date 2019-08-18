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

# Component Names
# TEMPLATE: $ComponentName = "$($ResourceGroupName)ComponentName"

Write-Verbose "------------------------Resource Group Provisioning [Started]------------------------"
# Login to Azure
Write-Verbose "Logging in to Azure [Started]"
&az login --service-principal --username $SP_App_ID --password $SP_PASSWORD --tenant $SP_TENANT_ID
Write-Verbose "Logging in to Azure [Done]"

# Create a resource group
Write-Verbose "Creating Resource Group $($ResourceGroupName) [Started]"
&az group create --location $Location --name $ResourceGroupName

Write-Verbose "------------------------Resource Group Provisioning [Done]------------------------"

$ResourceGroupId = &az group show --name "$ResourceGroupName" --query 'id' --output tsv
$UniquePrefix = Get-UniqueString($ResourceGroupId)

$WebAppName = 'app-' + $UniquePrefix
$WebApiName = 'api-' + $UniquePrefix

$DbFirewallRuleName = 'sqlsvrfirewallrule-' + $UniquePrefix
$SqlServerName = 'sqlserver-' + $UniquePrefix

$WebAppAddress = "https://$($WebAppName).azurewebsites.net"
$WebApiAddress = "https://$($WebApiName).azurewebsites.net"
$DbPasswordText = (New-Object PSCredential $DbUsername, $DbPassword).GetNetworkCredential().Password

$DbConnectionString = "Server=tcp:$($SqlServerName).database.windows.net,1433;Database=$($DbName);User ID=$($DbUsername);Password=$($DbPasswordText);Encrypt=true;Connection Timeout=30;"

Write-Verbose "------------------------Provisioning [Started]------------------------"

# Create a SQL Database logical server
Write-Verbose "Creating SQL Server $($SqlServerName) [Started]"
&az sql server create --name $SqlServerName --resource-group $ResourceGroupName --location $Location --admin-user """$DbUsername""" --admin-password """$DbPasswordText"""
Write-Verbose "Creating SQL Server $($SqlServerName) [Done]"

# Configure a server firewall rule
Write-Verbose "Configuring SQL Server Firewall Rule [Started]"
&az sql server firewall-rule create --resource-group $ResourceGroupName --server $SqlServerName --name $DbFirewallRuleName --start-ip-address 0.0.0.0 --end-ip-address 0.0.0.0
Write-Verbose "Configuring SQL Server Firewall Rule [Done]"

# Create a database
Write-Verbose "Creating Database [Started]"
&az sql db create --resource-group $ResourceGroupName --server $SqlServerName --name $DbName --service-objective "Basic"
Write-Verbose "Creating Database [Done]"

# Create an App Service plan
Write-Verbose "Creating App Service Plan $($WebAppServicePlan) [Started]"
&az appservice plan create --name $WebAppServicePlan --resource-group $ResourceGroupName --sku "F1"
Write-Verbose "Creating App Service Plan $($WebAppServicePlan) [Done]"

# Create an App Resource for the WebApp
Write-Verbose "Creating App Service Resource $($WebAppName) [Started]"
&az webapp create --resource-group $ResourceGroupName --plan $WebAppServicePlan --name $WebAppName
Write-Verbose "Creating App Service Resource $($WebAppName) [Done]"

# Create an App Resource for the WebApi
Write-Verbose "Creating App Service Resource $($WebApiName) [Started]"
&az webapp create --resource-group $ResourceGroupName --plan $WebAppServicePlan --name $WebApiName
Write-Verbose "Creating App Service Resource $($WebApiName) [Done]"

Write-Verbose "------------------------Provisioning [Done]------------------------"

Write-Verbose "------------------------Injecting Environment Variables [Started]------------------------"
$WebAppNameList = @(
    $WebAppName
    $WebApiName
)

foreach ($WebAppToConfigureName in $WebAppNameList) {
    Write-Verbose "Injecting Connection String for $WebAppToConfigureName [Started]"
    &az webapp config connection-string set --resource-group $ResourceGroupName --name $WebAppToConfigureName --connection-string-type "SQLServer" --settings "DefaultConnection=$($DbConnectionString)"
    Write-Verbose "Injecting Connection String [Done]"
}
Write-Verbose "------------------------Injecting Environment Variables [Done]------------------------"

Write-Verbose "------------------------Setting Up Error Logs [Started]------------------------"
Write-Verbose "Setting Up Error Logs for $WebApiName [Started]"
&az webapp log config --name $WebApiName --resource-group $ResourceGroupName --application-logging true --level error
Write-Verbose "Setting Up Error Logs for $WebApiName [Done]"
Write-Verbose "------------------------Setting Up Error Logs [Done]------------------------"

$Results = [Ordered] @{
    BaseAppName = $BaseAppName
    ResourceGroupName = $ResourceGroupName
    WebAppServicePlan = $WebAppServicePlan
    DbName = $DbName

    WebAppName = $WebAppName
    WebApiName = $WebApiName

    SqlServerName = $SqlServerName

    WebAppAddress = $WebAppAddress
    WebApiAddress = $WebApiAddress

    DbConnectionString = $DbConnectionString
}

Write-Verbose ($Results | Format-Table | Out-String)

Return $Results