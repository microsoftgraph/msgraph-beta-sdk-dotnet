---
author: JeremyKelley
description: "Returns the metadata for an item in a list."
ms.date: 09/11/2017
title: Get an entry from a SharePoint list
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Get an item in a list

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Returns the metadata for an [item][] in a [list][].

[list]: ../resources/list.md
[item]: ../resources/listitem.md

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.Read.All, Sites.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All |

> **Note**: The application permission Sites.Manage.All is required if the SharePoint list has content approval settings turned on. Otherwise, Microsoft Graph won't retrieve list items that have an approval status other than Approved.

## HTTP request

```http
GET /sites/{site-id}/lists/{list-id}/items/{item-id}
GET /sites/{site-id}/lists/{list-id}/items/{item-id}?expand=fields
GET /sites/{site-id}/lists/{list-id}/items/{item-id}?expand=fields(select=Column1,Column2)
```

## Example

##### Request


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "get-list-item" } -->

```msgraph-interactive
GET https://graph.microsoft.com/beta/sites/{site-id}/lists/{list-id}/items/{item-id}?expand=fields
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("expand", "fields")
};

var listItem = await graphClient.Sites["{site-id}"].Lists["{list-id}"].Items["{listItem-id}"]
	.Request( queryOptions )
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

