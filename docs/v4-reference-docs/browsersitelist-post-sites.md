---
title: "Create browserSite"
description: "Create a new browserSite object in a browserSiteList."
author: "edward-day-vii"
ms.localizationpriority: medium
ms.prod: "browser-management"
doc_type: apiPageType
---

# Create browserSite
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [browserSite](../resources/browsersite.md) object in a [browserSiteList](../resources/browsersitelist.md).

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
POST /admin/edge/internetExplorerMode/siteLists/{browserSiteListId}/sites
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [browserSite](../resources/browsersite.md) object.

You can specify the following properties when you create a **browserSite**.

|Property|Type|Description|
|:---|:---|:---|
|allowRedirect|Boolean|Controls the behavior of redirected sites. If `true`, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain. Required.|
|comment|String|The comment for the site. Required|
|compatibilityMode|browserSiteCompatibilityMode|Controls what compatibility setting is used for specific sites or domains. The possible values are: `default`, `internetExplorer8Enterprise`, `internetExplorer7Enterprise`, `internetExplorer11`, `internetExplorer10`, `internetExplorer9`, `internetExplorer8`, `internetExplorer7`, `internetExplorer5`, `unknownFutureValue`. Required.|
|mergeType|browserSiteMergeType|The merge type of the site. The possible values are: `noMerge`, `default`, `unknownFutureValue`. Required.|
|targetEnvironment|browserSiteTargetEnvironment|The target environment that the site should open in. The possible values are: `internetExplorerMode`, `internetExplorer11`, `microsoftEdge`, `configurable`, `none`, `unknownFutureValue`. Required.<br /><br />Prior to June 15, 2022, the `internetExplorer11` option would allow opening a site in the Internet Explorer 11 (IE11) desktop application. Following the retirement of IE11 on June 15, 2022, the `internetExplorer11` option will no longer open an IE11 window and will instead behave the same as the `internetExplorerMode` option.|
|webUrl|String|The URL of the site. Required.|


## Response

If successful, this method returns a `201 Created` response code and a [browserSite](../resources/browsersite.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_browsersite",
  "sampleKeys": ["e370d818-f650-5ab1-499e-5915e83f4573"]
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/edge/internetExplorerMode/siteLists/e370d818-f650-5ab1-499e-5915e83f4573/sites
Content-Type: application/json
Content-length: 387

{
    "@odata.type": "#microsoft.graph.browserSite",
    "webUrl": "www.microsoft.com",
    "targetEnvironment": "InternetExplorer11",
    "comment": "A site that opens in InternetExplorer11",
    "mergeType": "default",
    "compatibilityMode": "default",
    "allowRedirect": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var browserSite = new BrowserSite
{
	WebUrl = "www.microsoft.com",
	TargetEnvironment = BrowserSiteTargetEnvironment.InternetExplorer11,
	Comment = "A site that opens in InternetExplorer11",
	MergeType = BrowserSiteMergeType.Default,
	CompatibilityMode = BrowserSiteCompatibilityMode.Default,
	AllowRedirect = true
};

await graphClient.Admin.Edge.InternetExplorerMode.SiteLists["{browserSiteList-id}"].Sites
	.Request()
	.AddAsync(browserSite);

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
  "@odata.type": "microsoft.graph.browserSite"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "status": "pendingAdd",
    "id": "a22cbc85-d5d2-4e61-8414-42e6704c36f7",
    "webUrl": "www.microsoft.com",
    "targetEnvironment": "internetExplorer11",
    "mergeType": "default",
    "compatibilityMode": "default",
    "allowRedirect": true,
    "comment": "A site that opens in InternetExplorer11",
    "lastModifiedDateTime": "2022-06-29T14:51:23.8662592Z",
    "createdDateTime": "2022-06-29T14:51:23.8662595Z",
    "deletedDateTime": null,
    "lastModifiedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    },
    "history": []
}
```

