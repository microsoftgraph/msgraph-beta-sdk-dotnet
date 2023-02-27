---
title: "managedDevice: restoreCloudPc"
description: "Restore a Cloud PC device to a previous state with an Intune managed device ID."
author: "rongting"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# managedDevice: restoreCloudPc
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Restore a Cloud PC device to a previous state with an Intune [managed device](../resources/cloudpc.md) ID.

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
POST /deviceManagement/managedDevices/{managedDeviceId}/restoreCloudPc
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
|cloudPcSnapshotId|String|The unique identifier for the snapshot of the Cloud PC device at a specific point in time.|



## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "manageddevicethis.restorecloudpc"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/managedDevices/5e1387aa-d960-4916-ae7c-293b977e49bf/restoreCloudPc
Content-Type: application/json
Content-length: 37

{
  "cloudPcSnapshotId": "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcSnapshotId = "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8";

await graphClient.DeviceManagement.ManagedDevices["{managedDevice-id}"]
	.RestoreCloudPc(cloudPcSnapshotId)
	.Request()
	.PostAsync();

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

