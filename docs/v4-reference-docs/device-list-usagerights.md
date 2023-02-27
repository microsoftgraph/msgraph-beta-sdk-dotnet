---
title: "List device usageRights"
description: "Retrieve a list of usageRights objects for a device."
author: "jeeshnair"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List device usageRights
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [usageRight](../resources/usageright.md) objects for a given device.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Device.Read.All, Directory.Read.All, Directory.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Device.Read.All, Device.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All|

## HTTP request

You can address the device using either its **id** or **deviceId**.
<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /devices/{objectId}/usageRights
GET /devices(deviceId='{deviceId}')/usageRights
```

## Optional query parameters
This API supports the `$filter` [OData query parameter](/graph/query-parameters). The following patterns of `$filter` are supported:

- $filter = state eq 'value'
- $filter = serviceIdentifier eq 'value'
- $filter = state eq 'value' and serviceIdentifier eq 'value'
- $filter = state in ('value1', 'value2')
- $filter = serviceIdentifier in ('value1', 'value2')
- $filter = state in ('value1', 'value2') and serviceIdentifier in ('value1', 'value2')

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|odata.maxpagesize|Set the max result page size pereference. Optional.|

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and a collection of [usageRight](../resources/usageright.md) objects in the response body.

Additionally, if there are more pages in the response an @odata.nextLink is returned.

## Examples

### Example 1: Get all usage rights for a device
 
#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_usageright_1"
}
-->
``` http
GET https://graph.microsoft.com/beta/devices/{objectId}/usageRights
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var usageRights = await graphClient.Devices["{device-id}"].UsageRights
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.usageRight)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#devices('fead5c35-ebc5-47c4-a909-c43b4faf2160')/usageRights",
  "@odata.nextLink": "https://graph.microsoft.com/beta/devices/fead5c35-ebc5-47c4-a909-c43b4faf2160/usageRights?$skiptoken=W4diD29cGKX1bX",
  "value": [
    {
      "id": "99f828b9-09f2-445d-a758-b6727316dbe1",
      "catalogId": "CFQ7TTC0KCRG:0001",
      "serviceIdentifier": "mscrm.f6d23ec7-255c-4bd8-8c99-dc041d5cb8b3.517f7ddd-df45-4f1c-83ec-a081a047f546",
      "state": "active"
    }
  ]
}
```

### Example 2: Get usage rights for a device with specific service identifiers and states

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_usageright_2"
}
-->
``` http
GET https://graph.microsoft.com/beta/devices/{objectId}/usageRights?$filter=state in ('active', 'suspended') and serviceIdentifier in ('ABCD')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var usageRights = await graphClient.Devices["{device-id}"].UsageRights
	.Request()
	.Filter("state in ('active', 'suspended') and serviceIdentifier in ('ABCD')")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.usageRight)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#devices('fead5c35-ebc5-47c4-a909-c43b4faf2160')/usageRights",
  "value": [
    {
      "id": "9905e6b1-9040-4926-b028-fdb748c359d6",
      "catalogId": "CFQ7TTC0KCRG:0001",
      "serviceIdentifier": "ABCD",
      "state": "active"
    }
  ]
}
```
