
Write-Output "test line"
$sDir = "c:\Users\hedii\Downloads"
Set-Location -Path $sDir
$Files=(Get-ChildItem $sDir -File)
foreach($File in $Files){
    $extFile = $File.Extension.split('.')[1]
    if(Test-Path -Path $extFile){
        Write-Output $extFile
        Move-Item -Path $file -Destination $extFile
    }
    else{
        New-Item -Path $extFile -ItemType Director
    }

    
}



