---
author: "swapnil1993"
title: "contentType: isPublished"
description: "Check the publishing status of a content type in a content type hub site."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# contentType: isPublished
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
Check the publishing status of a [contentType][] in a content type hub site.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.FullControl.All    |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Sites.FullControl.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /sites/{siteId}/contentTypes/{contentTypeId}/isPublished
```
>**Note:** _siteId_ represents a content type hub site.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Response
If successful, this method returns a `200 OK` response code and a Boolean value that specifies the publishing state of the content type.

## Request body
Do not supply a request body for this method.

## Example

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "contenttype_ispublished"
}
-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/sites/{siteId}/contentTypes/{contentTypeId}/isPublished
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var boolean = await graphClient.Sites["{site-id}"].ContentTypes["{contentType-id}"]
	.IsPublished()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "string"
}
-->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": true 
}
```

[contentType]: ../resources/contentType.md
