---
title: "Get cloudPcSnapshot"
description: "Read the properties and relationships of a cloudPcSnapshot object."
author: "xintaozMS"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Get cloudPcSnapshot
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [cloudPcSnapshot](../resources/cloudpcsnapshot.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.Read.All, CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.Read.All, CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /deviceManagement/virtualEndpoint/snapshots/{cloudPcSnapshotId}
```

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [cloudPcSnapshot](../resources/cloudpcsnapshot.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpcsnapshot",
  "sampleKeys": ["A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8"]
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/snapshots/A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcSnapshot = await graphClient.DeviceManagement.VirtualEndpoint.Snapshots["{cloudPcSnapshot-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcSnapshot"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.cloudPcSnapshot",
    "cloudPcId": "662009bc-7732-4f6f-8726-25883518b33e",
    "createdDateTime": "2021-08-23T09:28:32.8260335Z",
    "id": "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8",
    "lastRestoredDateTime": "2021-09-01T09:28:32.8260338Z",
    "status": "ready"
  }
}
```

