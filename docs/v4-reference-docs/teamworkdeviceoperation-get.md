---
title: "Get teamworkDeviceOperation"
description: "Get the details of an async, long-running operation on a Microsoft Teams-enabled device."
author: "adsrivastava2"
ms.localizationpriority: medium
ms.prod: "teamwork"
doc_type: apiPageType
---

# Get teamworkDeviceOperation
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the details of an async, long-running operation on a Microsoft Teams-enabled [device](../resources/teamworkdeviceoperation.md).

>**Note**:
> Microsoft is temporarily offering usage of the APIs for managing Microsoft Teams-enabled devices at no charge.
> Microsoft expects to charge for the use of some or all of these APIs in the future. Microsoft will provide advanced notice of pricing changes.
> For details about the current licensing model, see [Licensing and payment requirements](/graph/teams-licenses).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamworkDevice.Read.All, TeamworkDevice.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|TeamworkDevice.Read.All, TeamworkDevice.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /teamwork/devices/{teamworkDeviceId}/operations/{teamworkDeviceOperationId}
```

## Optional query parameters
This operation supports the `$select` [OData query parameter](/graph/query-parameters) to customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [teamworkDeviceOperation](../resources/teamworkdeviceoperation.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamworkdeviceoperation"
}
-->
``` http
GET https://graph.microsoft.com/beta/teamwork/devices/0f3ce432-e432-0f3c-32e4-3c0f32e43c0f/operations/eab261f8-61f8-eab2-f861-b2eaf861b2ea
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamworkDeviceOperation = await graphClient.Teamwork.Devices["{teamworkDevice-id}"].Operations["{teamworkDeviceOperation-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamworkDeviceOperation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.teamworkDeviceOperation",
    "id": "eab261f8-61f8-eab2-f861-b2eaf861b2ea",
    "status": "successful",
    "operationType": "deviceRestart",
    "startedDateTime": "2021-06-19T12-01-03.45Z",
    "completedDateTime": "2021-06-19T12-01-03.45Z",
    "createdDateTime": "2021-06-19T12-01-03.45Z",
    "lastActionDateTime": "2021-06-19T12-01-03.45Z",
    "createdBy": {
      "application": null,
      "device": null,
      "user": {
        "id": "2a610f6f-adf6-4205",
        "displayName": "Evan Lewis",
        "userIdentityType": "aadUser"
      }
    },
    "lastActionBy": {
      "application": null,
      "device": null,
      "user": {
        "id": "2a610f6f-adf6-4205",
        "displayName": "Evan Lewis",
        "userIdentityType": "aadUser"
      }
    }
  }
}
```

