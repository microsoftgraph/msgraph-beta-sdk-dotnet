---
author: swapnil1993
title: "contentType: associateWithHubSites"
description: "Associate a content type with list of hubsites."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# contentType: associateWithHubSites

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
Associate a [content type][contentType] with a list of hub sites.

>**Note:** This feature is limited to tenants that have a SharePoint Syntex license.
  

## Permissions  

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

  

|Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------
|Delegated (work or school account) | Sites.Manage.All, Sites.FullControl.All  |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Sites.Manage.All, Sites.FullControl.All |

  

## HTTP request
<!-- {
  "blockType": "ignored"
}
-->
```http
POST /sites/{siteId}/contentTypes/{contentTypeId}/associateWithHubSites
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
|-|-|-|
|hubSiteUrls| Collection(string) |List of cannonical URLs to the hub sites where the content type needs to be enforced. Required.|
|propagateToExistingLists| Boolean |If `true`, content types will be enforced on existing lists in the hub sites; otherwise, it will be applied only to newly created lists. 

## Response

If successful, this action returns a `204 No Content` response code.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "contenttype_associatewithhubsites"
}
-->
```http
POST https://graph.microsoft.com/beta/sites/{siteId}/contentTypes/{contentTypeId}/associateWithHubSites
Content-Type: application/json

{
   "hubSiteUrls":[
      "https://graph.microsoft.com/beta/sites/id"
   ],
   "propagateToExistingLists":false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var hubSiteUrls = new List<String>()
{
	"https://graph.microsoft.com/beta/sites/id"
};

var propagateToExistingLists = false;

await graphClient.Sites["{site-id}"].ContentTypes["{contentType-id}"]
	.AssociateWithHubSites(hubSiteUrls,propagateToExistingLists)
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
