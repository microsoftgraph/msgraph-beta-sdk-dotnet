---
author: JeremyKelley
description: "Retrieve the list of Drive resources available for a target User, Group, or Site."
ms.date: 09/10/2017
title: List Drives
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# List available drives

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the list of [Drive](../resources/drive.md) resources available for a target User, Group, or [Site](../resources/site.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All    |
|Delegated (personal Microsoft account) | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All    |
|Application | Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All |

## List a group's drives

To list the document libraries for a group, your app requests the **drives** relationship on the Group.

### HTTP request


# [HTTP](#tab/http)
<!-- {"blockType": "request", "name": "group-list-drives", "scopes": "groups.read.all" } -->

```msgraph-interactive
GET /groups/{groupId}/drives
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var drives = await graphClient.Groups["{group-id}"].Drives
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {"blockType": "request", "name": "site-list-drives", "scopes": "sites.read.all" } -->

```msgraph-interactive
GET /sites/{siteId}/drives
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var drives = await graphClient.Sites["{site-id}"].Drives
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {"blockType": "request", "name": "user-list-drives", "scopes": "files.read.all" } -->

```msgraph-interactive
GET /users/{userId}/drives
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var drives = await graphClient.Users["{user-id}"].Drives
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {"blockType": "request", "name": "enum-drives", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drives
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var drives = await graphClient.Me.Drives
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

