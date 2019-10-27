$SP_App_ID="b9e4a478-e93e-4bea-bb73-cf23d5bfefe0"
$SP_PASSWORD= ConvertTo-SecureString "81vScoeJx3a2ukg.FXu:Puh.Y[3fDIAW" -AsPlainText -Force
$SP_TENANT_ID="2e833ca0-6a32-45e7-b968-1faae0218ea4"
$AppNameSuffix="test"
$Location="australiaeast"

#$ScriptPath = $env:USERPROFILE + "\source\repos\lapbase\scripts\Deploy.ps1"
$ScriptPath = $PSScriptRoot + ".\Deploy.ps1"

#$command = $ScriptPath + " –ServicePrincipal_App_ID $SP_App_ID –ServicePrincipal_TENANT_ID $SP_TENANT_ID -ServicePrincipal_PASSWORD $SP_PASSWORD -DbUsername $DbUsername -DbPassword $DbPassword -AppNameSuffix $AppNameSuffix -Location $Location"

#Invoke-Expression $command

#Invoke-Expression $ScriptPath –ServicePrincipal_App_ID $SP_App_ID –ServicePrincipal_TENANT_ID $SP_TENANT_ID -ServicePrincipal_PASSWORD $SP_PASSWORD -DbUsername $DbUsername -DbPassword $DbPassword -AppNameSuffix $AppNameSuffix -Location $Location

#$params = @{ServicePrincipal_App_ID=$SP_App_ID;ServicePrincipal_TENANT_ID=$SP_TENANT_ID;ServicePrincipal_PASSWORD=$SP_PASSWORD;DbUsername=$DbUsername;DbPassword=$DbPassword;AppNameSuffix=$AppNameSuffix;Location=$Location}
#& $ScriptPath @params

& $ScriptPath -v