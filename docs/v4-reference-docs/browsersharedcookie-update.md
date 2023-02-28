---
title: "Update browserSharedCookie"
description: "Update the properties of a browserSharedCookie object."
author: "edward-day-vii"
ms.localizationpriority: medium
ms.prod: "browser-management"
doc_type: apiPageType
---

# Update browserSharedCookie
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [browserSharedCookie](../resources/browsersharedcookie.md) object.

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
PATCH /admin/edge/internetExplorerMode/siteLists/{browserSiteListId}/sharedCookies/{browserSharedCookieId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|comment|String|The comment of the cookie.|
|displayName|String|The name of the cookie.|
|hostOnly|Boolean|Determines whether a cookie is a host-only or domain cookie.|
|hostOrDomain|String|The URL of the cookie.|
|path|String|The path of the cookie.|
|sourceEnvironment|browserSharedCookieSourceEnvironment|Specifies how the cookies are shared between Microsoft Edge and Internet Explorer. The possible values are: `microsoftEdge`, `internetExplorer11`, `both`, `unknownFutureValue`.|


## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_browsersharedcookie",
  "sampleKeys": ["20579923-e6c8-425a-b728-47f43c10bc05", "972a5778-df43-45fd-9c2a-5dd944c7a1ce"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/admin/edge/internetExplorerMode/siteLists/20579923-e6c8-425a-b728-47f43c10bc05/sharedCookies/972a5778-df43-45fd-9c2a-5dd944c7a1ce
Content-Type: application/json
Content-length: 349

{
  "hostOrDomain": "www.microsoft.com",
  "sourceEnvironment": "microsoftEdge",
  "displayName": "Microsoft Cookie",
  "path": "/",
  "hostOnly": true,
  "comment": "Updating source environment."
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var browserSharedCookie = new BrowserSharedCookie
{
	HostOrDomain = "www.microsoft.com",
	SourceEnvironment = BrowserSharedCookieSourceEnvironment.MicrosoftEdge,
	DisplayName = "Microsoft Cookie",
	Path = "/",
	HostOnly = true,
	Comment = "Updating source environment."
};

await graphClient.Admin.Edge.InternetExplorerMode.SiteLists["{browserSiteList-id}"].SharedCookies["{browserSharedCookie-id}"]
	.Request()
	.UpdateAsync(browserSharedCookie);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

