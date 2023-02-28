---
title: "managedDevice: bulkReprovisionCloudPc"
description: "Bulk reprovision a set of Cloud PC devices with Intune managed device IDs."
author: "RuiHou105"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# managedDevice: bulkReprovisionCloudPc

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Bulk reprovision a set of Cloud PC devices with Intune [managed device](../resources/cloudpc.md) IDs.

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
POST /deviceManagement/managedDevices/bulkReprovisionCloudPc
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the IDs of the Intune managed devices.

The following table shows the properties that are required when you bulk reprovision a set of Cloud PC devices.

|Property|Type|Description|
|:---|:---|:---|
|managedDeviceIds|Collection(String)|The IDs of the Cloud PC devices.|

## Response

If successful, this action returns a `200 OK` response code and a [cloudPcBulkRemoteActionResult](../resources/cloudpcbulkremoteactionresult.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "managedDevice_bulkReprovisionCloudPc"
}
-->

``` http
POST https://graph.microsoft.com/beta/deviceManagement/managedDevices/bulkReprovisionCloudPc
Content-Type: application/json

{
  managedDeviceIds: ["30d0e128-de93-41dc-89ec-33d84bb662a0", "7c82a3e3-9459-44e4-94d9-b92f93bf78dd"] 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var managedDeviceIds = new List<String>()
{
	"30d0e128-de93-41dc-89ec-33d84bb662a0",
	"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
};

await graphClient.DeviceManagement.ManagedDevices
	.BulkReprovisionCloudPc(managedDeviceIds)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcBulkRemoteActionResult"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "microsoft.graph.cloudPcBulkRemoteActionResult",
    "successfulDeviceIds": [
        "30d0e128-de93-41dc-89ec-33d84bb662a0"
    ],
    "failedDeviceIds": [
        "7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
    ],
    "notFoundDeviceIds": [
    ],
    "notSupportedDeviceIds": [
    ]
  }
}
```
