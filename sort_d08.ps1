
Write-Output "test"
$sDir = "c:\Users\hedii\Desktop\d08"
Set-Location -Path $sDir
$Files=(Get-ChildItem $sDir)
foreach($File in $Files){
    $wFile = $File.BaseName
   
    if ($wFile -match 'e0808'){
        $mwFile = $wFile[5]
        if (Test-Path -Path $mwFile){
            Move-Item -Path $file -Destination $mwFile
        }
        else{
            New-Item -Path $mwFile -ItemType Directory
        }

        
        

    }

    
}



