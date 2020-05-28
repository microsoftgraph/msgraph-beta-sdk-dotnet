# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.Synopsis
    Increment the minor version string.
#>

$fullFileName = $PWD.ToString() + "\src\Microsoft.Graph\Microsoft.Graph.Beta.csproj"

# Read .csproj file as UTF-8
$xmlDoc = New-Object -TypeName XML
$utf8Encoding = (New-Object System.Text.UTF8Encoding($false))
$streamReader = New-Object System.IO.StreamReader($fullFileName, $utf8Encoding, $false)
$xmlDoc.Load($streamReader)
$streamReader.Close()

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

$xmlDoc.Save($fullFileName)