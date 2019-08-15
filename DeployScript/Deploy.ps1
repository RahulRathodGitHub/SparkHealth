$ResourceGroupname="LapbaseResourceGroup"
$Location="eastus"

# SP = Service Principal
$SP_App_ID="61ff10ba-5b86-4b20-8dde-9ca53c6a6586"
$SP_PASSWORD="69ef97df-d5c1-491c-a888-d2289d21dd9e"
$SP_TENANT_ID="9aee26d8-97c2-4fad-8900-96735f6dc73f"

$VMName="LapbaseVM"
$VMImage="Win2012R2Datacenter"
$VMSize="Standard_B1s"
$VMAdminUsername="BestUser"
$VMAdminPassword="Bestest123User_"

$StorageAccountName="lapbasestorageaccount"
$StorageAccountKey="LapbaseStorageKey"
$StorageContainerName="lapbasestoragecontainer"
$StorageAccountSKU="Standard_LRS"
$BlobFileName="SetupVM.ps1"

# Login
write-host "Login"
az login --service-principal --username $SP_App_ID --password $SP_PASSWORD --tenant $SP_TENANT_ID

# Clean up resources
az group delete --name $ResourceGroupname --yes

# Create resource group
write-host "Creating resource group $ResourceGroupname"
az group create --name $ResourceGroupname --location $Location

# Create virtual machine
write-host "Creating virtual machine $VMName"
az vm create `
    --resource-group $ResourceGroupname `
    --name $VMName `
    --image $VMImage `
	--size $VMSize `
    --admin-username $VMAdminUsername `
    --admin-password $VMAdminPassword

# Open port 80 for web traffic
write-host "Opening port 80 for web traffic"
az vm open-port --port 80 --resource-group $ResourceGroupname --name $VMName

# Create storage account
write-host "Creating storage account $StorageAccountName"
az storage account create --name $StorageAccountName --resource-group $ResourceGroupname --location $Location --sku $StorageAccountSKU

# Create storage container
write-host "Creating storage container $StorageContainerName"
write-host "az storage container create --name $StorageContainerName --account-name $StorageAccountName # --account-key $StorageAccountKey"
az storage container create --name $StorageContainerName --account-name $StorageAccountName

# Upload script files
write-host "Uploading script files $BlobFileName"
az storage blob upload `
    --container-name $StorageContainerName `
    --account-name $StorageAccountName `
    --name "$BlobFileName" `
    --file "$PSScriptRoot\$BlobFileName"

$BlobScriptPath="https://$StorageAccountName.blob.core.windows.net/$StorageContainerName/$BlobFileName"

# Execute custom script
$Settings="{'storageAccountName':'$StorageAccountName','fileUris': ['$BlobScriptPath'], 'commandToExecute':'powershell -ExecutionPolicy Unrestricted -File $BlobFileName'}"
write-host "Executing custom script at uri: $BlobScriptPath"
az vm extension set `
	--publisher "Microsoft.Compute" `
	--version "1.8" `
	--name "CustomScriptExtension" `
	--vm-name $VMName `
	--resource-group $ResourceGroupname `
	--settings $Settings