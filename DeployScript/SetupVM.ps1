# Disable NLA for RDP
Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp' -name "SecurityLayer" -value 0
Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp' -name "UserAuthentication" -value 0
Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp' -name "fAllowSecProtocolNegotiation" -value 0
Set-ItemProperty -Path 'HKLM:\System\CurrentControlSet\Control\Terminal Server' -name "fDenyTSConnections" -Value 0

# Setup IIS
write-host "Setting up IIS"
Install-WindowsFeature -Name Web-Server -IncludeManagementTools

# Download Node.js
write-host "Retrieving Node.js .msi file"
$version = "10.16.2"
$url = "https://nodejs.org/dist/v$version/node-v$version-x64.msi"
write-host "url : $url"
$filename = "node.msi"
$node_msi = "$PSScriptRoot\$filename"
$start_time = Get-Date
$wc = New-Object System.Net.WebClient
$wc.DownloadFile($url, $node_msi)
write-Output "$filename downloaded"
write-Output "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"

# Install Node.js
write-host "Installing Node.js"
Start-Process $node_msi -Wait
$env:Path = [System.Environment]::GetEnvironmentVariable("Path","Machine") + ";" + [System.Environment]::GetEnvironmentVariable("Path","User")

# Download Git
write-host "Retrieving Git .exe file"
$git_version = "2.22.0"
$git_url = "https://github.com/git-for-windows/git/releases/download/v$git_version.windows.1/Git-$git_version-64-bit.exe"
write-host "git_url : $git_url"
$git_filename = "$PSScriptRoot\git-installer.exe"
$start_time = Get-Date
$wc = New-Object System.Net.WebClient
$wc.DownloadFile($git_url, $git_filename)
write-Output "$git_filename downloaded"
write-Output "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"

# Install Git
write-host "Installing Git"
Start-Process $git_exe -Wait

# Done
write-host "Done"