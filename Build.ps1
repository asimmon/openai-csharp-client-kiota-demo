#Requires -Version 5.0

Begin {
    $ErrorActionPreference = "stop"
}

Process {
    function Exec([scriptblock]$Command) {
        & $Command
        if ($LASTEXITCODE -ne 0) {
            throw ("An error occurred while executing command: {0}" -f $Command)
        }
    }
    
    $workingDir = Join-Path $PSScriptRoot "src"

    try {
        Push-Location $workingDir
    
        Exec { & dotnet clean -c Release }
        Exec { & dotnet build -c Release }
    }
    finally {
        Pop-Location
    }
}