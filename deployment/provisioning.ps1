$rgName = "ControlesVolumetricos-RVE"
$templateFile = ".\template.json"
$paramsFile = ".\parameters.json"
$location = "South Central US"
If ($(az group exists --name $rgName) -eq $False) {az group create --name $rgName --location $location }
az group deployment create --resource-group $rgName --template-file $templateFile --parameters $paramsFile --name $([guid]::NewGuid().ToString())