---
title: "List teamworkDevices"
description: "Get a list of all Microsoft Teams-enabled devices provisioned for a tenant."
author: "adsrivastava2"
ms.localizationpriority: medium
ms.prod: "teamwork"
doc_type: apiPageType
---

# List teamworkDevices
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of all Microsoft Teams-enabled [devices](../resources/teamworkdevice.md) provisioned for a tenant.

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
GET /teamwork/devices
```

## Optional query parameters
This method supports the `$filter` (**deviceType**, **hardwareDetail/uniqueId**, and **currentUser/id** properties), `$top`, `$select`, and `$skipToken` [OData query parameters](/graph/query-parameters) to help customize the response.

### Supported query patterns

| Pattern                | Syntax                                 | Notes |
| ---------------------- | -------------------------------------- | ----- |
| Server-side pagination | `@odata.nextLink`                      | You will get a continuation token in the response, when a result set spans multiple pages. |
| Filter                 | `/devices?$filter=deviceType eq 'TeamsRoom'` | Filter devices based on the device category. |
| Filter                 | `/devices?$filter=hardwareDetail/uniqueId eq 'value'` | Filter devices based on the **uniqueId** assigned to a device. |
| Filter                 | `/devices?$filter=currentUser/id eq 'value'` |  Filter devices based on the signed-in user on a device.|
| Page limit             | `/devices?$top=10` | Get devices with a page size of 10. Default page limit is 20. Max page limit is 50. |

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [teamworkDevice](../resources/teamworkdevice.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_teamworkdevice"
}
-->
``` http
GET https://graph.microsoft.com/beta/teamwork/devices
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var devices = await graphClient.Teamwork.Devices
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
  "@odata.type": "microsoft.graph.teamworkDevice",
  "isCollection": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#teamwork/devices",
  "@odata.count": 2,
  "@odata.nextLink": "/teamwork/devices?$filter=deviceType+eq+Microsoft.Teams.GraphSvc.teamworkDeviceType%collaborationBar%27&$top=2&$skiptoken=%2bRID%3a~z9snAP1BE88Zlz0AAAAADg%3d%3d%23RT%3a1%23TRC%3a3%23RTD%3auCNd2ZP%2fZ5zLgoPeFGRGBTMxMzIuMTcuMzJVMTY7NTc7MjEvNTozNjEyM1sA%23ISV%3a2%23IEO%3a65551%23QCF%3a4%23FPC%3aAggBAAAAADgAAPcAAAAAOAAAAQAAAAA4AAACADiI9AAAAAA4AAACABCP9QAAAAA4AAAEAFEu4AD2AAAAADgAAAQANoXZkfcAAAAAOAAABAAlgIiK",
  "value": [
    {
      "@odata.type": "#microsoft.graph.teamworkDevice",
      "id": "0f3ce432-e432-0f3c-32e4-3c0f32e43c0f",
      "deviceType": "CollaborationBar",
      "hardwareDetail": {
        "serialNumber": "0189",
        "uniqueId": "5abcdefgh",
        "macAddresses": [],
        "manufacturer": "yealink",
        "model": "vc210"
      },
      "notes": "CollaborationBar device.",
      "companyAssetTag": "Tag1",
      "healthStatus": "Healthy",
      "activityState": "Idle",
      "createdDateTime": "2021-06-19T19:01:04.185Z",
      "createdBy": null,
      "lastModifiedDateTime": "2021-06-19T19:01:04.185Z",
      "lastModifiedBy": null,
      "currentUser": {
        "id": "2a610f6f-adf6-4205",
        "displayName": "Evan Lewis",
        "userIdentityType": "aadUser"
      }
    },
    {
      "@odata.type": "#microsoft.graph.teamworkDevice",
      "id": "55ab555-e432-0f3c-32e4-3c0f32e43c0f",
      "deviceType": "CollaborationBar",
      "hardwareDetail": {
        "serialNumber": "0189",
        "uniqueId": "5abcdefgh",
        "macAddresses": [],
        "manufacturer": "yealink",
        "model": "vc210"
      },
      "notes": "CollaborationBar device.",
      "companyAssetTag": "Tag2",
      "healthStatus": "Healthy",
      "activityState": "Idle",
      "createdDateTime": "2021-06-10T19:01:04.185Z",
      "createdBy": null,
      "lastModifiedDateTime": "2021-06-19T19:01:04.185Z",
      "lastModifiedBy": null,
      "currentUser": {
        "id": "2a610f6f-adf6-4205",
        "displayName": "Evan Lewis",
        "userIdentityType": "aadUser"
      }
    }
  ]
}
```

