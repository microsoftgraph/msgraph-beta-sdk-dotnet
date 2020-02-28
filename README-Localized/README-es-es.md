[![Estado de la compilación](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![NuGet](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Biblioteca cliente .NET Beta de Microsoft Graph 

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

¡Integre la [Beta de la API de Microsoft Graph](https://graph.microsoft.io) en su proyecto de .NET!

La biblioteca cliente .NET Beta de Microsoft Graph se dirige a .NetStandard 1.1 y .NET Framework 4.5.

## Instalación mediante NuGet

Para instalar la biblioteca cliente a través de NuGet:

* Busque `Microsoft.Graph.Beta` en la biblioteca NuGet o
* Escriba `Install-Package Microsoft.Graph.Beta` en la Consola del Administrador de paquetes.

## Usar el cliente beta junto con la biblioteca v1.0

Tanto los extremos de Microsoft Graph beta y de la v1.0 comparten el mismo espacio de nombres. Esto da lugar a que tanto las bibliotecas generadas de la v1.0 y la beta compartan el mismo espacio de nombres. Puede usar la biblioteca beta por sí misma sin realizar cambios en el entorno. Si planea usar el extremo beta además del extremo v1.0, tendrá que seguir un par de pasos de integración para habilitar a un cliente beta que se usará junto al cliente v1.0 que se obtiene con el paquete NuGet (v1.0) `Microsoft.Graph`.

Si el proyecto (.csproj) usa un elemento Reference para hacer referencia a la biblioteca Microsoft.Graph.Beta, tendrá que especificar el alias del archivo DLL dentro del elemento <Aliases>. Le sugerimos que use el alias BetaLib, aunque cualquier alias servirá:

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

Si el proyecto (.csproj) usa un elemento PackageReference para hacer referencia a la biblioteca Microsoft.Graph.Beta, tendrá que especificar el alias del archivo DLL dentro del elemento <Aliases>. De nuevo, le sugerimos que use el alias BetaLib, aunque cualquier alias servirá:

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> El enfoque de referencia del proyecto para la creación de alias de las DLL se actualizará y se encontrará en el [registro](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) de NuGet.

Ahora, establezca la directiva de `alias externo` (por encima de todas las directivas Using) para obtener acceso a la biblioteca Microsoft.Graph.Beta. Le sugerimos que use el alias `Beta` para el espacio de nombres:

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

Ahora puede hacer referencia a los objetos Microsoft.Graph.Beta de la siguiente forma:

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## Introducción

Vea [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet) para obtener información sobre la introducción a esta biblioteca.

## Notas

Si desea usar una versión mayor que NewtonSoft.Json 6.0.1, instale primero NewtonSoft.Json. Por ejemplo, primero tendrá que instalar NewtonSoft.Json 9.0.1, si desea usar esta biblioteca mientras dirige .Net Core con standard1.0.

Instale System.Runtime.InteropServices.RuntimeInformation antes de instalar Microsoft Graph >= 1.3, si tiene un problema al actualizar el paquete para una solución Xamarin. Es posible que también tenga que actualizar las referencias a Microsoft.NETCore.UniversalWindowsPlatform para >=5.2.2.

## Problemas

Para ver o registrar problemas, consulte [problemas](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues).

Este proyecto ha adoptado el [Código de conducta de código abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/). Para obtener más información, vea [Preguntas frecuentes sobre el código de conducta](https://opensource.microsoft.com/codeofconduct/faq/) o póngase en contacto con [opencode@microsoft.com](mailto:opencode@microsoft.com) si tiene otras preguntas o comentarios.

## Otros recursos

* Paquete NuGet: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## Creación local de la biblioteca

Si está pensando en crear la biblioteca de forma local con el fin de contribuir al código o ejecutar pruebas, tendrá que:

- Tener instalado el SDK de .NET Core (> 1.0)
- Ejecutar `dotnet restore` desde la línea de comandos en el directorio de paquetes
- Ejecutar `nuget restore` y `msbuild` desde CLI o ejecutar Crear desde Visual Studio para restaurar paquetes de Nuget y crear el proyecto

## Licencia

Copyright (c) Microsoft Corporation. Reservados todos los derechos. Publicado bajo la [licencia](LICENSE.txt) MIT. Consulte [Avisos de terceros](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES) para obtener información sobre los paquetes a los que se hace referencia mediante NuGet.
