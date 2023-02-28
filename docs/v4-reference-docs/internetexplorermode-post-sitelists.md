---
title: "Create browserSiteList"
description: "Create a new browserSiteList object to support Internet Explorer mode."
author: "edward-day-vii"
ms.localizationpriority: medium
ms.prod: "browser-management"
doc_type: apiPageType
---

# Create browserSiteList
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [browserSiteList](../resources/browsersitelist.md) object to support [Internet Explorer mode](/deployedge/edge-ie-mode).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BrowserSiteLists.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BrowserSiteLists.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /admin/edge/internetExplorerMode/siteLists
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [browserSiteList](../resources/browsersitelist.md) object.

You can specify the following properties when you create a **browserSiteList**.

|Property|Type|Description|
|:---|:---|:---|
|description|String|Description for the site list. Required.|
|displayName|String|Display name of the site list. Required.|


## Response

If successful, this method returns a `201 Created` response code and a [browserSiteList](../resources/browsersitelist.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_browsersitelist_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/edge/internetExplorerMode/siteLists
Content-Type: application/json
Content-length: 283

{
    "displayName": "Production Site List A",
    "description": "Production site list for team A"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var browserSiteList = new BrowserSiteList
{
	DisplayName = "Production Site List A",
	Description = "Production site list for team A"
};

await graphClient.Admin.Edge.InternetExplorerMode.SiteLists
	.Request()
	.AddAsync(browserSiteList);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.browserSiteList"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.browserSiteList",
    "id": "36ba61eb-c492-4283-a38b-963a1dbb2f69",
    "revision": "",
    "displayName": "Production Site List A",
    "description": "Production site list for team A",
    "lastModifiedDateTime": "2022-06-28T18:05:05.9569126Z",
    "publishedDateTime": null,
    "status": "draft",
    "lastModifiedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    },
    "publishedBy": null
}
```

