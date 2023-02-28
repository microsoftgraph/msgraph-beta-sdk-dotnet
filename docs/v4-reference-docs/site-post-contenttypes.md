---
author: swapnil1993
title: "Create contentType"
description: "Create a Content type for a site."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# Create contentType
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [contentType][] for a [site][].

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |Sites.Manage.All, Sites.FullControl.All    |
|Delegated (personal Microsoft account) |Not Supported    |
|Application |Sites.Manage.All, Sites.FullControl.All |


## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /sites/{site-id}/contentTypes
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [contentType][] resource to create.

## Response

If successful, this method returns a `201 Created` response code and a [contentType][] object in the response body.


## Example

The following example shows how to create a new generic content type.

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_contenttype"
}
-->

```http
POST https://graph.microsoft.com/beta/sites/{id}/contentTypes
Content-Type: application/json

{
    "name": "docSet",
    "description": "custom docset",
    "base": {
        "name": "Document Set",
        "id": "0x0120D520"
    },
    "group": "Document Set Content Types" 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contentType = new ContentType
{
	Name = "docSet",
	Description = "custom docset",
	Base = new ContentType
	{
		Name = "Document Set",
		Id = "0x0120D520"
	},
	Group = "Document Set Content Types"
};

await graphClient.Sites["{site-id}"].ContentTypes
	.Request()
	.AddAsync(contentType);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.contentType"
}
-->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "0x01002A2479FF33DD4BC3B1533A012B653717",
  "name": "docSet",
  "group":"Document Set Content Types",
  "description" : "custom docset",
  "base": {
        "name": "Document Set",
        "id": "0x0120D520"
   }
}
```


[contentType]: ../resources/contentType.md
[site]: ../resources/site.md

<!--
{
  "type": "#page.annotation",
  "description": "Create a Content type in a site",
  "keywords": "content type",
  "section": "documentation",
  "tocPath": "sites/Create ContentType",
  "suppressions": [
  ]
}
-->
