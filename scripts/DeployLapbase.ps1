$SP_App_ID="61ff10ba-5b86-4b20-8dde-9ca53c6a6586"
$SP_PASSWORD= ConvertTo-SecureString "69ef97df-d5c1-491c-a888-d2289d21dd9e" -AsPlainText -Force
$SP_TENANT_ID="9aee26d8-97c2-4fad-8900-96735f6dc73f"
$DbUsername="bestusername"
$DbPassword= ConvertTo-SecureString "bestpassword" -AsPlainText -Force
$AppNameSuffix="test"
$Location="eastus"

$ScriptPath = $env:USERPROFILE + "\source\repos\lapbase\scripts\Deploy.ps1"

#$command = $ScriptPath + " –ServicePrincipal_App_ID $SP_App_ID –ServicePrincipal_TENANT_ID $SP_TENANT_ID -ServicePrincipal_PASSWORD $SP_PASSWORD -DbUsername $DbUsername -DbPassword $DbPassword -AppNameSuffix $AppNameSuffix -Location $Location"

#Invoke-Expression $command

#Invoke-Expression $ScriptPath –ServicePrincipal_App_ID $SP_App_ID –ServicePrincipal_TENANT_ID $SP_TENANT_ID -ServicePrincipal_PASSWORD $SP_PASSWORD -DbUsername $DbUsername -DbPassword $DbPassword -AppNameSuffix $AppNameSuffix -Location $Location

#$params = @{ServicePrincipal_App_ID=$SP_App_ID;ServicePrincipal_TENANT_ID=$SP_TENANT_ID;ServicePrincipal_PASSWORD=$SP_PASSWORD;DbUsername=$DbUsername;DbPassword=$DbPassword;AppNameSuffix=$AppNameSuffix;Location=$Location}
#& $ScriptPath @params

& $ScriptPath -v