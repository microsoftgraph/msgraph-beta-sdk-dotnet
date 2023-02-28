---
author: JeremyKelley
description: "Create a new listItem in a list."
ms.date: 09/11/2017
title: Create a new entry in a SharePoint list
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Create a new item in a list

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [listItem][] in a [list][].

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Sites.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /sites/{site-id}/lists/{list-id}/items
```

## Request body

In the request body, supply a JSON representation of the [listItem][] resource to create.

## Example

Here is an example of how to create a new generic list item.


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "create-listitem-1", "scopes": "sites.readwrite.all" } -->

```http
POST https://graph.microsoft.com/beta/sites/{site-id}/lists/{list-id}/items
Content-Type: application/json

{
  "fields": {
    "Title": "Widget",
    "Color": "Purple",
    "Weight": 32
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var listItem = new ListItem
{
	Fields = new FieldValueSet
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"Title", "Widget"},
			{"Color", "Purple"},
			{"Weight", "32"}
		}
	}
};

await graphClient.Sites["{site-id}"].Lists["{list-id}"].Items
	.Request()
	.AddAsync(listItem);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

