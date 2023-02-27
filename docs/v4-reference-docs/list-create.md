---
author: JeremyKelley
description: "Create a new list in a site."
title: Create a SharePoint List
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Create a new list

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [list][] in a [site][].

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|            Permission type             | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Sites.Manage.All                            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Sites.ReadWrite.All                         |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST https://graph.microsoft.com/beta/sites/{site-id}/lists
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of a [list][] object.

## Response

If successful, this method returns a `201 Created` response code and a [list][] object in the response body. 

## Examples

### Request

The following is an example of how to create a new generic list.

> **Note:** Custom columns are optional.

In addition to any columns specified here, new lists are created with columns defined in the referenced **template**.
If the **list** facet or **template** is not specified, the list defaults to the `genericList` template, which includes a _Title_ column.


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "create-list", "scopes": "sites.readwrite.all" } -->

```http
POST /sites/{site-id}/lists
Content-Type: application/json

{
  "displayName": "Books",
  "columns": [
    {
      "name": "Author",
      "text": { }
    },
    {
      "name": "PageCount",
      "number": { }
    }
  ],
  "list": {
    "template": "genericList"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var list = new List
{
	DisplayName = "Books",
	Columns = new ListColumnsCollectionPage()
	{
		new ColumnDefinition
		{
			Name = "Author",
			Text = new TextColumn
			{
			}
		},
		new ColumnDefinition
		{
			Name = "PageCount",
			Number = new NumberColumn
			{
			}
		}
	},
	ListInfo = new ListInfo
	{
		Template = "genericList"
	}
};

await graphClient.Sites["{site-id}"].Lists
	.Request()
	.AddAsync(list);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object is truncated for clarity. Default properties will be returned from the actual call.

<!-- { "blockType": "response", "@odata.type": "microsoft.graph.list", "truncated": true } -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "22e03ef3-6ef4-424d-a1d3-92a337807c30",
  "createdDateTime": "2017-04-30T01:21:00Z",
  "createdBy": {
    "user": {
      "displayName": "Ryan Gregg",
      "id": "8606e4d5-d582-4f5f-aeba-7d7c18b20cfd"
    }
  },
  "lastModifiedDateTime": "2016-08-30T08:26:00Z",
  "lastModifiedBy": {
    "user": {
      "displayName": "Ryan Gregg",
      "id": "8606e4d5-d582-4f5f-aeba-7d7c18b20cfd"
    }
  }
}
```

[list]: ../resources/list.md
[site]: ../resources/site.md

<!--
{
  "type": "#page.annotation",
  "description": "Create a new SharePoint list.",
  "keywords": "",
  "section": "documentation",
  "tocPath": "List/Create",
  "suppressions": [
  ]
}
-->


