[array]$changes = git status --porcelain

$changeLog = "`r`n"

foreach ($change in $changes) {
    $entry = $change.TrimStart().Split(" ")

    $filename = $entry[1]

    if ($entry[0] -eq "??") {
        $changeLog += "Added file`t`t`t $filename`r`n"
    }

    elseif ($entry[0] -eq "M") {
        $changeLog += "Modified file`t`t $filename`r`n"
    }

    elseif ($entry[0] -eq "D") {
        $changeLog += "Deleted file`t`t $filename`r`n"
    }

    else {
        Write-Error "Unexpected change - investigate"
    }
}

Write-Host "Change log:`r`n$changeLog"

$project = ".\src\Microsoft.Graph\Microsoft.Graph.Beta.csproj"

[xml]$xmlDoc = Get-Content $project

# Assumption: VersionPrefix is set in the first property group.
$xmlDoc.Project.PropertyGroup[0].PackageReleaseNotes = $changeLog

$fullFileName = $PWD.ToString() + "\src\Microsoft.Graph\Microsoft.Graph.Beta.csproj"
$xmlDoc.Save($fullFileName)