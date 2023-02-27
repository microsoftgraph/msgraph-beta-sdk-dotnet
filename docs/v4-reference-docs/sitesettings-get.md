---
title: "Get siteSettings"
description: "Get the settings of a site."
author: "k-tsoi"
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---

# Get siteSettings
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the settings of a [site].

>**Note:** This API is currently only available on SharePoint and OneDrive for Business.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged) |
|:--------------------------------------|:--------------------------------------------|
|Delegated (work or school account)     | Sites.Read.All, Sites.ReadWrite.All         |
|Delegated (personal Microsoft account) | Not supported.                              |
|Application                            | Sites.Read.All, Sites.ReadWrite.All         |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /sites/{sitesId}/settings
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [siteSettings](../resources/sitesettings.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_sitesettings"
}
-->
``` http
GET https://graph.microsoft.com/beta/sites/03164a2b-a288-486a-993e-c41454113e2a/settings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var sites = await graphClient.Sites["{site-id}"]
	.Request()
	.Select("Settings")
	.GetAsync();

var settings = sites.Settings;

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
  "@odata.type": "microsoft.graph.siteSettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
  "languageTag": "String",
  "timeZone": "String"
  }
}
```

[site]: ../resources/site.md
