---
title: "contentType: addCopyFromContentTypeHub"
description: "Add or sync a copy of a published content type from content type hub to a target site or a list."
author: "swapnil1993"
ms.localizationpriority: medium
ms.prod: "sites-and-lists"
doc_type: apiPageType
---

# contentType: addCopyFromContentTypeHub
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add or sync a copy of a published content type from the content type hub to a target [site](../resources/site.md) or a [list](../resources/list.md).

This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a "push everywhere" to "pull as needed" approach. The method allows users to pull content types directly from the content type hub to a site or list. For more information, see [getCompatibleHubContentTypes](contenttype-getcompatiblehubcontenttypes.md) and the blog post [Syntex Product Updates – August 2021](https://techcommunity.microsoft.com/t5/sharepoint-syntex-blog/syntex-product-updates-august-2021/ba-p/2606438).
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) | Sites.Manage.All, Sites.FullControl.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Sites.Manage.All, Sites.FullControl.All |


## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /sites/{siteId}/lists/{listId}/contentTypes/addCopyFromContentTypeHub
POST /sites/{siteId}/contentTypes/addCopyFromContentTypeHub
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|contentTypeId|String| ID of the content type in the content type hub that is to be added to the target site or a list.|



## Response

If successful, this action returns a `200 OK` response code and a [contentType](../resources/contenttype.md) object in the response body if the content type is added synchronously, or a `202 Accepted` response code if the content type will be synced asynchronously. The response will also contain a `Location` header, which contains the location of the [richLongRunningOperation](../resources/richLongRunningOperation.md) that was created to handle the copy/sync.
In case of an asynchronous operation, it can take up to 70 minutes to sync or add a content type.

## Examples

### Example 1: Synchronous pull

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "contenttype_addcopyfromcontenttypehub_sync_pull"
}
-->
``` http
POST https://graph.microsoft.com/beta/sites/{siteId}/lists/{listId}/contentTypes/addCopyFromContentTypeHub
Content-Type: application/json
Content-length: 33

{
  "contentTypeId": "0x0101"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contentTypeId = "0x0101";

await graphClient.Sites["{site-id}"].Lists["{list-id}"].ContentTypes
	.AddCopyFromContentTypeHub(contentTypeId)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.contentType"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.contentType",
    "id": "0x0101",
    "description": "Document content type",
    "group": "Document Content Types",
    "hidden": false,
    "isBuiltIn": true,
    "name": "Document"
}
```
### Example 2: Asynchronous pull

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "contenttype_addcopyfromcontenttypehub_async_pull"
}
-->
``` http
POST https://graph.microsoft.com/beta/sites/{siteId}/lists/{listId}/contentTypes/addCopyFromContentTypeHub
Content-Type: application/json
Content-length: 33

{
  "contentTypeId": "String"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contentTypeId = "String";

await graphClient.Sites["{site-id}"].Lists["{list-id}"].ContentTypes
	.AddCopyFromContentTypeHub(contentTypeId)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
}
-->
``` http
HTTP/1.1 202 Accepted
location: https://graph.microsoft.com/beta/sites/{siteId}/lists/{listId}/operations/{operationId}
```
