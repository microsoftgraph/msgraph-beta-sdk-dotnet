---
author: swapnil1993
title: "Get columnDefinition"
description: " Get a site, list or content type column."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# Get columnDefinition
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the metadata for a [site][], [list][] or [contentType][] [column][columnDefinition].

  

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All  |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All  |

  

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

```http
GET /sites/{site-id}/columns/{column-id}
GET /sites/{site-id}/lists/{list-id}/columns/{column-id}
GET /sites/{site-id}/contentTypes/{contentType-id}/columns/{column-id}
GET /sites/{site-id}/lists/{list-id}/contentTypes/{contentType-id}/columns/{column-id}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|  

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [columnDefinition][columnDefinition] object in the response body.
  
## Example

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "get_column_from_contenttype" } -->

  

```msgraph-interactive
GET /sites/{site-id}/contentTypes/{contentType-id}/columns/{column-id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var columnDefinition = await graphClient.Sites["{site-id}"].ContentTypes["{contentType-id}"].Columns["{columnDefinition-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.  

<!-- { "blockType": "response", "@type": "microsoft.graph.columnDefinition", "truncated": true } -->

  

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "description": "",
  "displayName": "Title",
  "hidden": false,
  "id": "99ddcf45-e2f7-4f17-82b0-6fba34445103",
  "indexed": false,
  "name": "Title",
  "readOnly": false,
  "required": false,
  "text": {
    "allowMultipleLines": false,
    "appendChangesToExistingText": false,
    "linesForEditing": 0,
    "maxLength": 255
  }
}
```

  

[columnDefinition]: ../resources/columnDefinition.md

[list]: ../resources/list.md

[site]: ../resources/site.md

[contentType]: ../resources/contentType.md
  
