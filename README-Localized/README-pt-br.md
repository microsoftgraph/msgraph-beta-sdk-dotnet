[![Status de criação](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Biblioteca de Clientes do .NET do Microsoft Graph Beta

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

Integre a [API Beta do Microsoft Graph](https://graph.microsoft.io) ao seu projeto .NET!

A Biblioteca de Clientes do .NET do Microsoft Graph Beta se destina ao .NetStandard 1.1 e ao .Net Framework 4.5.

## Instalação via NuGet

Para instalar a biblioteca de cliente por meio do NuGet:

* Pesquise `Microsoft.Graph.Beta` na biblioteca do NuGet ou
* Digite `Install-Package Microsoft.Graph.Beta` no Console do Gerenciador de Pacotes.

## Usando o cliente beta, juntamente com a biblioteca v1.0

Os pontos de extremidade do Microsoft Graph v 1.0 e beta compartilham o mesmo namespace. Isso faz com que as bibliotecas geradas v 1.0 e beta sejam compartilhadas no mesmo namespace. Você pode usar a biblioteca beta sozinha sem qualquer alteração no seu ambiente. Se você planeja usar o ponto de extremidade de beta, além do ponto de extremidade de v1.0, você tem que seguir algumas etapas de integração para permitir que um cliente beta seja usado junto com o cliente v1.0, que é obtido com o pacote do NuGet do `Microsoft.Graph` (v1.0).

Se seu projeto (. csproj) usar um elemento de referência para referenciar a biblioteca Microsoft. Graph. beta, você precisará especificar o alias da DLL dentro do elemento <Aliases>. Sugerimos que você use o alias BetaLib, embora qualquer alias funcione:

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

Se seu projeto (. csproj) usar um elemento PackageReference para referenciar a biblioteca Microsoft. Graph. beta, você precisará especificar o alias da DLL dentro do elemento <Aliases>. Novamente sugerimos que você use o alias BetaLib, embora qualquer alias funcione:

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> A abordagem de referência do projeto para DLLs de alias será atualizada e estará na [lista de pendências](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) do NuGet.

Agora, você define a diretiva de `alias externo` (acima de tudo usando diretivas) para obter acesso à biblioteca Microsoft.Graph.Beta. Sugerimos que você faça um alias do namespace para `Beta`:

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

Agora, você pode referenciar os objetos Microsoft.Graph.Beta da seguinte forma:

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## Introdução

Confira [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet) para saber mais sobre como começar a usar esta biblioteca.

## Observações

Instale o NewtonSoft.json primeiro caso queira usar uma versão posterior à NewtonSoft.Json 6.0.1. Por exemplo, você precisará instalar o NewtonSoft.Json 9.0.1 primeiro se quiser usar essa biblioteca enquanto visa o .NET Core com o padrão 1.0.

Instale System.Runtime.InteropServices.RuntimeInformation antes de instalar o Microsoft.Graph 1.3 e versões posteriores se você estiver com problemas para atualizar o pacote de uma solução do Xamarin. Talvez você também precise de referências atualizadas para Microsoft.NETCore.UniversalWindowsPlatform 5.2.2 e versões posteriores.

## Problemas

Confira [problemas](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues) para exibir ou registrar problemas.

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/).  Para saber mais, confira as [Perguntas frequentes sobre o Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou entre em contato pelo [opencode@microsoft.com](mailto:opencode@microsoft.com) se tiver outras dúvidas ou comentários.

## Outros recursos

* Pacote NuGet: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## Construindo a biblioteca local

Se você quiser construir uma biblioteca local a fim de colaborar em códigos ou testes em execução, você precisará do seguinte:

- Ter o SDK do .NET Core (> 1.0) instalado
- Executar o `dotnet restore` na linha de comando do diretório do pacote
- Executar `nuget restore` e `msbuild` da CLI ou executar o Build do Visual Studio para restaurar pacotes NuGet e compilar o projeto

## Licença

Copyright (c) Microsoft Corporation. Todos os direitos reservados. Licenciada sob a [Licença](LICENSE.txt) do MIT. Confira as informações sobre os pacotes de referência via NuGet nos [Avisos a Terceiros](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES).
