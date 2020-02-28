[![État de la build](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Bibliothèque cliente .NET Microsoft Graph Bêta

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

Intégrez l'[API Bêta Microsoft Graph](https://graph.microsoft.io) dans votre projet .NET !

Cibles de la bibliothèque cliente Microsoft Graph Bêta .NET. NetStandard 1.1 et .NET Framework 4.5.

## Installation via NuGet

Installation de la bibliothèque cliente via NuGet :

* Recherchez `Microsoft.Graph.Beta` dans la bibliothèque NuGet, ou
* Tapez `Installe-package Microsoft.Graph.Beta` dans la console du Gestionnaire de package.

## Utilisation du client bêta avec la bibliothèque v1.0

Les points de terminaison v1.0 et bêta Microsoft Graph partagent le même espace de nom. Ainsi, les bibliothèques générées v1.0 et bêta partagent le même espace de nom. Vous pouvez utiliser la bibliothèque bêta seule, sans apporter de modifications à votre environnement. Si vous envisagez d’utiliser le point de terminaison bêta en plus du point de terminaison v1.0, vous êtes à quelques étapes de l’intégration à suivre afin d’autoriser un client bêta à être utilisé parallèlement au client v1.0 qui est obtenu avec le package NuGet `Microsoft Graph` (v1.0).

Si votre projet (.csproj) utilise un élément de référence pour référencer la bibliothèque Microsoft.Graph.Beta, vous devez spécifier l’alias DLL au sein de l’élément de <Aliases>. Nous vous suggérons d’utiliser l’alias BetaLib, même si tout alias sera valable :

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

Si votre projet (.csproj) utilise un élément PackageReference pour référencer la bibliothèque Microsoft.Graph.Beta, vous devez spécifier l’alias DLL au sein de l’élément <Aliases>. Une fois de plus, nous vous recommandons d’utiliser l’alias BetaLib, même si tout alias est possible :

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> L’approche de projet de référence pour les DLL d’alias est mise à jour et se trouve sur la [journalisation](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) NuGet.

Vous pouvez désormais définir la directive d'`extern alias` (au-dessus de toutes les directives d’utilisation) pour accéder à la bibliothèque Microsoft.Graph.Beta. Nous vous suggérons de donner un alias à l’espace de nom pour `Bêta` :

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

Vous pouvez désormais référencer les objets Microsoft.Graph.Beta comme suit :

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## Prise en main

Pour plus d’informations sur la prise en main de cette bibliothèque, consultez [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet).

## Remarques

Installez tout d'abord NewtonSoft.Json si vous voulez utiliser une version ultérieure à NewtonSoft.json 6.0.1. Par exemple, vous devez installer NewtonSoft.json 9.0.1 au préalable si vous voulez utiliser la bibliothèque tout en ciblant .Net Core avec standard1.0.

Installez System.Runtime.InteropServices.RuntimeInformation avant d'installer Microsoft.Graph >=1.3 si vous rencontrez un problème lors de la mise à jour de package d'une solution Xamarin. Vous devrez peut-être également mettre à jour les références sur Microsoft.NETCore.UniversalWindowsPlatform vers > = 5.2.2.

## Problèmes

Pour afficher ou enregistrer des problèmes, voir [problèmes](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues).

Ce projet a adopté le [Code de conduite Open Source de Microsoft](https://opensource.microsoft.com/codeofconduct/). Pour en savoir plus, reportez-vous à la [FAQ relative au code de conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou tout commentaire.

## Autres ressources

* Package NuGet : [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## Création d’une bibliothèque locale

Si vous envisagez de créer la bibliothèque localement à des fins de codes de contribution ou d’exécution de tests, vous devez :

- Installer le .NET Core SDK (> 1.0)
- Exécuter `dotnet restore` à partir de la ligne de commande dans le répertoire de votre package
- Exécuter `nuget restore` et `msbuild` à partir de l'interface de ligne de commande (CLI) ou exécutez la Build à partir de Visual Studio pour restaurer les packages Nuget et créer le projet

## Licence

Copyright (c) Microsoft Corporation. Tous droits réservés. Sous [licence MIT](LICENSE.txt). Pour plus d'informations sur les packages référencés via NuGet, voir les [Notifications tierces](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES).
