[![Состояние сборки](https://o365exchange.visualstudio.com/O365%20Sandbox/_apis/build/status/Microsoft%20Graph/.Net/msgraph-beta-sdk-dotnet.preview.build?branchName=master)](https://o365exchange.visualstudio.com/O365%20Sandbox/_build/latest?definitionId=2634&branchName=master) [![nuget](https://img.shields.io/nuget/v/Microsoft.Graph.Beta.svg)](https://www.nuget.org/packages/Microsoft.Graph.Beta/)

# Клиентская библиотека .NET Microsoft Graph бета-версии

<!--
[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)
-->

Интегрируйте [API Microsoft Graph бета-версии](https://graph.microsoft.io) в свой проект .NET!

Клиентская библиотека .NET Microsoft Graph бета-версии предназначена для .NetStandard 1.1 и .Net Framework 4.5.

## Установка с помощью NuGet

Чтобы установить клиентскую библиотеку с помощью NuGet:

* Найдите `Microsoft.Graph.Beta` в библиотеке NuGet или
* Введите `Install-Package Microsoft.Graph.Beta` в консоли диспетчера пакетов.

## Использование клиента бета-версии с библиотекой версии 1.0

Конечные точки Microsoft Graph версии 1.0 и бета-версии используют одинаковое пространство имен. Вследствие этого библиотеки, созданные в версии 1.0 и бета-версии, используют одинаковое пространство имен. Библиотеку бета-версии можно использовать отдельно без изменений в среде. Если вы планируете использовать конечную точку бета-версии в дополнение к конечной точке версии 1.0, потребуется выполнить несколько действий интеграции, чтобы разрешить использование клиента бета-версии вместе с клиентом версии 1.0, полученным с помощью пакета NuGet `Microsoft.Graph` (версии 1.0).

Если в проекте (.csproj) используется элемент Reference для ссылки на библиотеку Microsoft.Graph.Beta, потребуется указать псевдоним DLL в элементе <Aliases>. Мы рекомендуем использовать псевдоним BetaLib, но это не принципиально:

```
<Reference Include="Microsoft.Graph.Beta, Version=0.1.0.0, Culture=neutral>
      <SpecificVersion>False</SpecificVersion>
      <HintPath>Resources\Microsoft.Graph.Beta.dll</HintPath>
      <Aliases>BetaLib</Aliases>
</Reference>
```

Если в проекте (.csproj) используется элемент PackageReference для ссылки на библиотеку Microsoft.Graph.Beta, потребуется указать псевдоним DLL в элементе <Aliases>. Мы вновь рекомендуем использовать псевдоним BetaLib, но это не принципиально:

```
  <Target Name="ChangeAliasesOfStrongNameAssemblies" BeforeTargets="FindReferenceAssembliesForReferences;ResolveReferences">
    <ItemGroup>
      <ReferencePath Condition="'%(FileName)' == 'Microsoft.Graph.Beta'">
        <Aliases>BetaLib</Aliases>
      </ReferencePath>
    </ItemGroup>
  </Target>
```

> Способ ссылок проекта для псевдонимов DLL будет обновлен и указывается в [списке невыполненных работ](https://github.com/NuGet/Home/issues/4989#issuecomment-311042085) NuGet.

Теперь вам нужно настроить директиву `extern alias` (над всеми используемыми директивами), чтобы получить доступ к библиотеке Microsoft.Graph.Beta. Рекомендуем использовать для пространства имен псевдоним `бета-версии`: 

```
extern alias BetaLib;
using Beta = BetaLib.Microsoft.Graph;
```

Теперь вы можете ссылаться на объекты Microsoft.Graph.Beta следующим образом:

```
var contact = new Beta.Contact();
Beta.GraphServiceClient betaClient = new Beta.GraphServiceClient();
```

## Начало работы

Сведения о начале работы с этой библиотекой см. в статье [msgraph-sdk-dotnet](https://github.com/microsoftgraph/msgraph-sdk-dotnet).

## Примечания

Сначала установите NewtonSoft.Json, если хотите использовать более позднюю версию, чем NewtonSoft.Json 6.0.1. Например, вам потребуется сначала установить NewtonSoft.Json 9.0.1, если вы хотите использовать эту библиотеку с целью применения .NET Core со стандартом 1.0.

Установите System.Runtime.InteropServices.RuntimeInformation перед установкой Microsoft.Graph версии 1.3 и более поздней, если у вас возникла проблема с обновлением пакета для решения Xamarin. Вам также могут потребоваться обновленные ссылки на Microsoft.NETCore.UniversalWindowsPlatform для версии 5.2.2 и более поздней.

## Проблемы

Для просмотра и регистрации проблем см. раздел [проблем](https://github.com/microsoftgraph/msgraph-sdk-dotnet-beta/issues).

Этот проект соответствует [Правилам поведения разработчиков открытого кода Майкрософт](https://opensource.microsoft.com/codeofconduct/). Дополнительные сведения см. в разделе [часто задаваемых вопросов о правилах поведения](https://opensource.microsoft.com/codeofconduct/faq/). Если у вас возникли вопросы или замечания, напишите нам по адресу [opencode@microsoft.com](mailto:opencode@microsoft.com).

## Другие ресурсы

* Пакет NuGet: [https://www.nuget.org/packages/Microsoft.Graph.Beta](https://www.nuget.org/packages/Microsoft.Graph)

## Локальное создание библиотеки

Если вы собираетесь создать библиотеку в локальном расположении для добавления кода или выполнения тестов, вам потребуется выполнить следующие действия:

- Установить пакет SDK .NET Core (> 1.0)
- Выполнить команду `dotnet restore` из командной строки в каталоге пакета
- Выполнить команды `nuget restore` и `msbuild` из CLI или запустить сборку из Visual Studio, чтобы восстановить пакеты Nuget и создать проект

## Лицензия

© Корпорация Майкрософт. Все права защищены. Предоставляется по [лицензии](LICENSE.txt) MIT. Сведения о пакетах, указанных в NuGet, см. в разделе [Уведомления третьих лиц](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES).
