---
title: "cloudPC: getCloudPcLaunchInfo"
description: "Get the Cloud PC launch information for the signed-in user."
author: "andrewku0409"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: getCloudPcLaunchInfo
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the [cloudPCLaunchInfo](../resources/cloudpclaunchinfo.md) for the signed-in user.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.Read.All, CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/cloudPCs/{cloudPCId}/getCloudPcLaunchInfo
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [cloudPcLaunchInfo](../resources/cloudpclaunchinfo.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpcthis.getcloudpclaunchinfo"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/cloudPCs/{cloudPCId}/getCloudPcLaunchInfo
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcLaunchInfo = await graphClient.Me.CloudPCs["{cloudPC-id}"]
	.GetCloudPcLaunchInfo()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcLaunchInfo"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.cloudPcLaunchInfo",
  "cloudPcId": "a20d556d-85f7-88cc-bb9c-08d9902bb7bb",
  "cloudPcLaunchUrl": "https://rdweb-r0.wvdselfhost.microsoft.com/api/arm/weblaunch/tenants/662009bc-7732-4f6f-8726-25883518b33e/resources/662009bc-7732-4f6f-8726-25883518b33e"
}
```

