# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.Synopsis
    Runs typewriter.exe to generate code files from the metadata.

.Description
    Uses the GitHub Release API to get the latest typewriter.exe release from the
    MSGraph-SDK-Code-Generator repo. typewriter.exe is run against the metadata
    and the generated files are put into the repo. At this point, the changes
    can be manually commited and pushed. This script is epxected to work locally
    and via Azure Pipelines.

    Run this script at the repo root.

.Parameter metadata
    Specifies the URI of the metadata used for generation.

.Parameter gh_owner_and_repo
    Optional. Specifies the organization and repo to target for generation.
#>

Param(
    [parameter(Mandatory = $true)][string]$metadata,
    [parameter(Mandatory = $false)][string]$gh_owner_and_repo = 'microsoftgraph/MSGraph-SDK-Code-Generator'
)

# Create our temporary working directory.
$tempDir = '.\temp'

$dirExists = Test-Path -PathType Container -Path $tempDir
if ($dirExists -eq $true) {
    Remove-Item $tempDir -Force -Recurse
}

md $tempDir

# Assuming the latest release always has typewriter.exe.
$binaryDrop = $tempDir
$typewriterZipDrop = "$binaryDrop\typewriter.zip"
$typewriterFiles = "$binaryDrop\Release\*"

# Get information about the GitHub releases.
$feedQuery = "https://api.github.com/repos/$gh_owner_and_repo/releases"
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$jsonObject = Invoke-WebRequest -Uri $feedQuery -UseBasicParsing | ConvertFrom-Json

# GitHub release API provides the latest
if ($jsonObject.assets[0].name -eq 'typewriter.zip') {
    $downloadURL = $jsonObject.assets[0].browser_download_url
    Invoke-WebRequest -Uri $downloadURL -OutFile $typewriterZipDrop -UseBasicParsing -Verbose | Write-Host
}
else {
    Write-Error 'typewriter.zip was not found using the release API. Check the release on GitHub.'
}

# Unzip and move typewriter.exe to the temp directory.
Expand-Archive -LiteralPath $typewriterZipDrop -DestinationPath $binaryDrop -Force -Verbose | Write-Host
Move-Item $typewriterFiles $binaryDrop -Force -Verbose | Write-Host

# Run typewriter with input metadata and output generated code files.
Write-Host "Running typewriter..."  -ForegroundColor Green
& "$tempDir\typewriter.exe" -v Info -m $metadata -g Files -o $tempDir -e beta | Write-Host
Write-Host "Completed typewriter generation of code files." -ForegroundColor Green

# Remove all existing files in the requests and models directories in the repo.

$repoModelsDir = ".\src\Microsoft.Graph\Models\Generated\"
$repoRequestDir = ".\src\Microsoft.Graph\Requests\Generated\"

Remove-Item -Recurse $repoModelsDir
Remove-Item -Recurse $repoRequestDir
Write-Host "Removed the existing generated files in the repo." -ForegroundColor Green

# Copy generated files to the repo.

$modelsDirectory = $tempDir + "\com\microsoft\graph\model\"
$requestsDirectory = $tempDir + "\com\microsoft\graph\requests\"
Move-Item $modelsDirectory $repoModelsDir
Write-Host "Moved the models from $modelsDirectory into the local repo." -ForegroundColor Green
Move-Item $requestsDirectory $repoRequestDir
Write-Host "Moved the requests from $requestsDirectory into the local repo." -ForegroundColor Green

# Clean up temp dir
Remove-Item $tempDir -Force -Recurse
Write-Host "Removed temporary files." -ForegroundColor Green