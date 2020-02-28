[![构建状态](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Microsoft Graph Beta .NET 客户端库

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

将 [Microsoft Graph Beta API](https://graph.microsoft.io) 集成到你的 .NET 项目！

Microsoft Graph Beta .NET 客户端库针对 .NetStandard 1.1 和 .Net Framework 4.5。

## 通过 NuGet 安装

若要通过 NuGet 安装客户端库：

* 在 NuGet 库中搜索 `Microsoft.Graph.Beta`，或者
* 在程序包管理器控制台中键入 `Install-Package Microsoft.Graph.Beta`。

## 将 beta 客户端与 v 1.0 库配合使用

V 1.0 和 beta 版 Microsoft Graph 终结点共享同一命名空间。这将导致 v 1.0 和 beta 生成的库共享同一命名空间。你可以单独使用 beta 库，而无需更改环境。如果除了 v1.0 终结点之外你还打算使用 beta 终结点，则需要执行几个集成步骤，以使 beta 客户端与通过 `Microsoft.Graph` (v1.0) NuGet 程序包获得的 v1.0 客户端一起使用。

如果你的项目 (.csproj) 使用 Reference 元素来引用 Microsoft.Graph.Beta 库，则需要在 <Aliases> 元素中指定 DLL 别名。我们建议你使用 BetaLib 别名，尽管任何别名都可以：

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

如果你的项目 (.csproj) 使用 PackageReference 元素来引用 Microsoft.Graph.Beta 库，则需要在 <Aliases> 元素中指定 DLL 别名。我们再次建议你使用 BetaLib 别名，尽管任何别名都可以：

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> 别名 DLL 的项目引用方法将更新，并位于 NuGet [backlog](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) 上。

现在，你可以设置`外部别名`指令（在所有使用的指令之上），以访问 Microsoft.Graph.Beta 库。我们建议你将命名空间的别名设置为 `Beta`：

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

现在，你可以引用 Microsoft.Graph.Beta 对象，如下所示：

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## 入门

有关此库入门的详细信息，请参阅 [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet)。

## 注意

如果要使用高于 NewtonSoft.Json 6.0.1 的版本，请先安装 NewtonSoft.Json。例如，如果要在将 .Net Core（采用标准 1.0）设置为目标时使用此库，则需要先安装 NewtonSoft.Json 9.0.1。

如果在更新 Xamarin 解决方案的程序包时遇到问题，请在安装 Microsoft.Graph 1.3 或更高版本之前先安装 System.Runtime.InteropServices.RuntimeInformation。你可能还需要将对 Microsoft.NETCore.UniversalWindowsPlatform 的引用也更新为 5.2.2 或更高版本。

## 问题

若要查看或记录问题，请参阅[问题](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues)。

此项目已采用 [Microsoft 开放源代码行为准则](https://opensource.microsoft.com/codeofconduct/)。有关详细信息，请参阅[行为准则 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)。如有其他任何问题或意见，也可联系 [opencode@microsoft.com](mailto:opencode@microsoft.com)。

## 其他资源

* NuGet 程序包：[https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## 在本地构建库

如果你出于提供代码或运行测试的目的而在本地构建库，则需要：

- 安装 .NET Core SDK (> 1.0)
- 从程序包目录的命令行运行 `dotnet restore`
- 从 CLI 运行 `nuget restore` 和 `msbuild`，或从 Visual Studio 运行构建，以还原 Nuget 程序包并构建项目

## 许可证

版权所有 (c) Microsoft Corporation。保留所有权利。在 MIT [许可证](LICENSE.txt)下获得许可。有关通过 NuGet 引用的程序包的信息，请参阅[第三方声明](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES)。
