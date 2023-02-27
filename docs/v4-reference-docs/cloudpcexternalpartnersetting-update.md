---
title: "Update cloudPcExternalPartnerSetting"
description: "Update the properties of a cloudPcExternalPartnerSetting object."
author: "Shaowei-Dong"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Update cloudPcExternalPartnerSetting
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [cloudPcExternalPartnerSetting](../resources/cloudpcexternalpartnersetting.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /deviceManagement/virtualEndpoint/externalPartnerSettings/{cloudPcExternalPartnerSettingId}
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
|enableConnection|Boolean|Enable or disable the connection to an external partner. If `true`, an external partner API will accept incoming calls from external partners. Required.|



## Response

If successful, this method returns a `200 OK` response code and an updated [cloudPcExternalPartnerSetting](../resources/cloudpcexternalpartnersetting.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_cloudpcexternalpartnersetting"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/externalPartnerSettings/b3548526-e615-3785-3118-be70b3968ec5
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcExternalPartnerSetting",
  "enableConnection": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcExternalPartnerSetting = new CloudPcExternalPartnerSetting
{
	EnableConnection = true
};

await graphClient.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings["{cloudPcExternalPartnerSetting-id}"]
	.Request()
	.UpdateAsync(cloudPcExternalPartnerSetting);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcExternalPartnerSetting"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcExternalPartnerSetting",
  "id": "b3548526-e615-3785-3118-be70b3968ec5",
  "partnerId": "198d7140-80bb-4843-8cc4-811377a49a92",
  "enableConnection": true,
  "lastSyncDateTime": "2020-11-03T12:43:14Z",
  "status": "available",
  "statusDetails": "The external partner is available"
}
```
