$project = ".\src\Microsoft.Graph\Microsoft.Graph.Beta.csproj"

[xml]$xmlDoc = Get-Content $project

# Assumption: VersionPrefix is set in the first property group.
$versionPrefixString = $xmlDoc.Project.PropertyGroup[0].VersionPrefix

# System.Version
$versionObj = [version]"$versionPrefixString"

# Increment minor version.
$majorVersion = $versionObj.Major.ToString()
$minorVersion = ($versionObj.Minor + 1).ToString()
$patchVersion = $versionObj.Build.ToString()

# increment minor version. 
$updatedVersionPrefixString = "{0}.{1}.{2}" -f $majorVersion, $minorVersion, $patchVersion
$xmlDoc.Project.PropertyGroup[0].VersionPrefix = $updatedVersionPrefixString

$fullFileName = $PWD.ToString() + "\src\Microsoft.Graph\Microsoft.Graph.Beta.csproj"
$xmlDoc.Save($fullFileName)