[![ビルドの状態](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![NuGet](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Microsoft Graph Beta .NET クライアント ライブラリ

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

[Microsoft Graph Beta API](https://graph.microsoft.io) を.NET プロジェクトに統合する。

Microsoft Graph ベータ版 .NET クライアント ライブラリは、NetStandard 1.1 および .Net Framework 4.5 を対象としています。

## NuGet 経由のインストール

NuGet 経由でクライアント ライブラリをインストールするには、

* NuGet ライブラリで `Microsoft.Graph.Beta` を検索するか、
* パッケージ マネージャー コンソールに `Install-Package Microsoft.Graph.Beta` と入力します。

## ベータ版クライアントを v 1.0 ライブラリと共に使用

v1.0 およびベータ版の Microsoft Graph エンドポイントはいずれも同じ名前空間を共有します。これにより、v1.0 およびベータ版の両方が同じ名前空間を共有するライブラリを生成します。ベータ版ライブラリは、環境を変更することなく単独で使用できます。v1.0 エンドポイントに加えてベータ版エンドポイントを使用する場合は、ベータ版クライアントを有効にして、`Microsoft.Graph` (v1.0) NuGetv パッケージから得られる v1.0 クライアントと一緒に使用するための統合の手順に従う必要があります。

プロジェクト (.csproj) が参照要素を使用して、Microsoft.Graph.Beta ライブラリを参照している場合は、<Aliases> 要素内の DLL エイリアスを指定する必要があります。どのエイリアスでも対応できますが、BetaLib エイリアスの使用をお勧めします。

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

プロジェクト (.csproj) が PackageReference 要素を使用して、Microsoft.Graph.Beta ライブラリを参照している場合は、<Aliases> 要素内の DLL エイリアスを指定する必要があります。この場合も、どのエイリアスでも対応できますが、BetaLib エイリアスの使用をお勧めします。

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> エイリアシングの DLL へのプロジェクト参照アプローチは更新され、NuGet [バックログ](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) にあります。

ここで、`extern エイリアス` ディレクティブ (使用中のすべてのディレクティブ) を設定して、Microsoft.Graph.Beta ライブラリにアクセスします。名前空間を `ベータ版` にすることをお勧めします。

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

これで、次のような Microsoft.Graph.Beta オブジェクトを参照できるようになりました。

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## はじめに

このライブラリの使用を開始する方法については、「[msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet)」 を参照してください。

## 備考

NewtonSoft.Json 6.0.1 より後のバージョンを使用する場合は、最初に　NewtonSoft.Json をインストールしてください。たとえば、.Net Core with standard1.0 を対象にしてこのライブラリを使用する場合は、最初に NewtonSoft.Json 9.0.1 をインストールする必要があります。

Xamarin ソリューションのパッケージを更新するときに問題が発生した場合は、Microsoft.Graph >=1.3 をインストールする前に、System.Runtime.InteropServices.RuntimeInformation をインストールしてください。Microsoft.NETCore.UniversalWindowsPlatform to >=5.2.2 への参照の更新が必要な場合があります。

## 問題

問題を表示、記録するには、「[問題](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues)」 を参照してください。

このプロジェクトでは、[Microsoft オープン ソース倫理規定](https://opensource.microsoft.com/codeofconduct/) が採用されています。詳細については、「[Code of Conduct の FAQ (倫理規定の FAQ)](https://opensource.microsoft.com/codeofconduct/faq/)」 を参照してください。また、その他の質問やコメントがあれば、[opencode@microsoft.com](mailto:opencode@microsoft.com) までお問い合わせください。

## その他のリソース

* NuGet パッケージ: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## ローカルでライブラリを作成

コードの投稿やテストの実行を目的としてローカルでライブラリを作成する場合は、次のものが必要です。

- .NET Core SDK (> 1.0) をインストールする
- パッケージ ディレクトリ内のコマンド ラインから `dotnet restore` を実行する
- CLI から `NuGet の復元` および `MSBuild` を実行するか、Visual Studio からビルドを実行し、NuGet パッケージを復元して、プロジェクトをビルドする

## ライセンス

Copyright (c) Microsoft Corporation.All Rights Reserved.MIT [ライセンス](LICENSE.txt)に基づきライセンスされています。NuGet 経由で参照されたパッケージの詳細については、「[サード パーティについての通知](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES)」 を参照してください。
