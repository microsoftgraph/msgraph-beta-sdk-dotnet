---
title: "teamworkDevice: updateSoftware"
description: "Update the software for a Microsoft Teams-enabled device."
author: "adsrivastava2"
ms.localizationpriority: medium
ms.prod: "teamwork"
doc_type: apiPageType
---

# teamworkDevice: updateSoftware
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the software for a Microsoft Teams-enabled [device](../resources/teamworkdevice.md). This API triggers a long-running operation.

>**Note**:
> Microsoft is temporarily offering usage of the APIs for managing Microsoft Teams-enabled devices at no charge.
> Microsoft expects to charge for the use of some or all of these APIs in the future. Microsoft will provide advanced notice of pricing changes.
> For details about the current licensing model, see [Licensing and payment requirements](/graph/teams-licenses).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkDevice.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|TeamworkDevice.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /teamwork/devices/{teamworkDeviceId}/updateSoftware
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
|softwareType|teamworkSoftwareType|The software type to update. Valid types are: `adminAgent`, `operatingSystem`, `teamsClient`, `firmware`, `partnerAgent`, `companyPortal`.|
|softwareVersion|String|Specifies the version of the software available for update.|



## Response

If successful, this method returns a `202 Accepted` response code. The response will also contain a `Location` header, which contains the location of the [teamworkDeviceOperation](../resources/teamworkdeviceoperation.md) resource. You can check the status of the software update operation by making a GET request to this location that returns whether the operation is `queued`, `succeeded`, or `failed`.

This method also returns a `409 Conflict` response code if the operation is already in queued state.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "teamworkdevice_updatesoftware"
}
-->
``` http
POST https://graph.microsoft.com/beta/teamwork/devices/0f3ce432-e432-0f3c-32e4-3c0f32e43c0f/updateSoftware
Content-Type: application/json
Content-length: 64

{
  "softwareType": "teamsClient",
  "softwareVersion": "1.0.96.22"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var softwareType = TeamworkSoftwareType.TeamsClient;

var softwareVersion = "1.0.96.22";

await graphClient.Teamwork.Devices["{teamworkDevice-id}"]
	.UpdateSoftware(softwareType,softwareVersion)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 202 Accepted
Location: /teamwork/devices/0f3ce432-e432-0f3c-32e4-3c0f32e43c0f/operations/119eb06d-0c4b-4fb3-a754-33dd0d6b618c
Content-Type: text/plain
Content-Length: 0
```

