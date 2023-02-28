---
author: swapnil1993
title: "contentType: publish"
description: "Publish a content type present in content type hub site."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# contentType: publish
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
Publishes a [contentType][] present in a content type hub site.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.FullControl.All    |
|Delegated (personal Microsoft account) | Sites.FullControl.All    |
|Application | Sites.FullControl.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
```http
POST /sites/{siteId}/contentTypes/{contentTypeId}/publish
```

>**Note:** `siteId` represents a content type hub site.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response
If successful, this call returns a `204 No Content` response.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "contenttype_publish"
}
-->
```http
POST https://graph.microsoft.com/beta/sites/{siteId}/contentTypes/{contentTypeId}/publish
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Sites["{site-id}"].ContentTypes["{contentType-id}"]
	.Publish()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- { "blockType": "response" } -->

```http
HTTP/1.1 204 No Content
```

[contentType]: ../resources/contentType.md
