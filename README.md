[![Build Status](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master)

[![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Microsoft Graph Beta .NET Client Library

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

Integrate the [Microsoft Graph Beta API](https://graph.microsoft.io) into your .NET
project!

The Microsoft Graph Beta .NET Client Library targets .NetStandard 1.1 and .Net Framework 4.5.

## Installation via NuGet

To install the client library via NuGet:

* Search for `Microsoft.Graph.Beta` in the NuGet Library, or
* Type `Install-Package Microsoft.Graph.Beta` into the Package Manager Console.

## Using the beta client along with the v1.0 library

Both the v1.0 and beta Microsoft Graph endpoints share the same namespace. This results in both the v1.0 and beta generated libraries sharing the same namespace. You can use the beta library by itself with no changes to your environment. If you plan to use the beta endpoint in addition to the v1.0 endpoint, you'l have a couple integration steps you'll need to follow to enable a beta client to be used alongside the v1.0 client which is obtained with the `Microsoft.Graph` (v1.0) NuGet package.

If your project (.csproj) uses a Reference element to reference the Microsoft.Graph.Beta library, you'll need to specify the DLL alias within the <Aliases> element. We suggest that you use the BetaLib alias, although any alias will do:
  
```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

If your project (.csproj) uses a PackageReference element to reference the Microsoft.Graph.Beta library, you'll need to specify the DLL alias within the <Aliases> element. Again, we suggest that you use the BetaLib alias, although any alias will do:

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> The project reference approach to aliasing DLLs will be updated and is on the NuGet [backlog](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085).

Now, you set the `extern alias` directive (above all using directives) to get access to the Microsoft.Graph.Beta library. We suggest that you alias the namespace to `Beta`: 

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

You can now reference the Microsoft.Graph.Beta objects like this:

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## Getting started

Please see [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet) for information on getting started with this library.

## Notes

Install NewtonSoft.Json first if you want to use a version greater than NewtonSoft.Json 6.0.1. For example, you'll need to install NewtonSoft.Json 9.0.1 first if you want to use this to library while targeting .Net Core with standard1.0.

Install System.Runtime.InteropServices.RuntimeInformation before you install Microsoft.Graph >=1.3 if you are having an issue updating the package for a Xamarin solution. You may need to updated references to Microsoft.NETCore.UniversalWindowsPlatform to >=5.2.2 as well.

## Issues

To view or log issues, see [issues](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Other resources

* NuGet Package: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## Building library locally

If you are looking to build the library locally for the purposes of contributing code or running tests, you will need to:

- Have the .NET Core SDK (> 1.0) installed
- Run `dotnet restore` from the command line in your package directory
- Run `nuget restore` and `msbuild` from CLI or run Build from Visual Studio to restore Nuget packages and build the project

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt). See [Third Party Notices](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES) for information on the packages referenced via NuGet.
