[![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Microsoft Graph Beta .NET Client Library

Integrate the [Microsoft Graph Beta API](https://graph.microsoft.com) into your .NET project!

The Microsoft Graph Beta .NET Client Library 0.x targets .NetStandard 1.1 and .Net Framework 4.5.

The Microsoft Graph Beta .NET Client Library 4.x targets .NetStandard 2.0 and .Net Framework 4.6.2.

The Microsoft Graph Beta .NET Client Library 5.x targets .NetStandard 2.0

The current Microsoft Graph Beta .NET Client Library targets .NET Standard 2.0, .NET Standard 2.1, .NET 10.0, and .NET 11.0. As a breaking change for .NET target framework alignment with .NET support lifecycles, it replaces the dedicated .NET 8.0 target with .NET 11.0. .NET 8 applications can still consume the retained compatible .NET Standard assets, but .NET 8 is no longer a dedicated build or test target.

## Installation via NuGet

To install the client library via NuGet:

* Search for `Microsoft.Graph.Beta` in the NuGet Library, or
* Type `Install-Package Microsoft.Graph.Beta -PreRelease` into the Package Manager Console.

## Using the beta client along with the v1.0 library

The Beta library is generated with the `Microsoft.Graph.Beta` namespace. This means that it can be used alongside the V1 package by using the `Microsoft.Graph` namespace while using the `Microsoft.Graph.Beta` namespace from the beta library.

## Getting started

Please see [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet) for information on getting started with this library.

## Notes

### Upgrading to v4

Between 0.x and 4.x there were some major breaking changes:

 * .NET Standard minimum version bumped from `netStandard1.3` to `netstandard2.0`
 * .NET Framework minimum version bumped from `net45` to `net462`
 * Replacing Newtonsoft.Json with System.Text.Json
 * Upgrading Microsoft.Graph.Core dependency to version 2.0.0

View the upgrade guide [here](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/main/docs/upgrade-to-v4.md)..

### Upgrading to v5

View the upgrade guide [here](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/main/docs/upgrade-to-v5.md)..

## Issues

To view or log issues, see [issues](https://github.com/microsoftgraph/msgraph-beta-sdk-dotnet/issues).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Other resources

* NuGet Package: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph.Beta)

## Building library locally

If you are looking to build the library locally for the purposes of contributing code or running tests, you will need to:

- Have the .NET 11 SDK installed, and the .NET 10 runtime to run tests for both supported .NET targets
- Run `dotnet restore Microsoft.Graph.Beta.sln` from the repository root
- Build the library one target framework at a time with `dotnet build src/Microsoft.Graph/Microsoft.Graph.Beta.csproj -f <framework> --no-restore`, using `netstandard2.0`, `netstandard2.1`, `net10.0`, and `net11.0` to avoid exhausting memory
- Run `dotnet test tests/Microsoft.Graph.DotnetCore.Test/Microsoft.Graph.DotnetCore.Test.csproj` to run tests for .NET 10.0 and .NET 11.0

> Due to long file names you may need to run `git config --system core.longpaths true` before cloning the repo to your system.

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt). See [Third Party Notices](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/main/THIRD%20PARTY%20NOTICES) for information on the packages referenced via NuGet.
