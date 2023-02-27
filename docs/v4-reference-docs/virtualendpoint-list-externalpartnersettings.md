---
title: "List cloudPcExternalPartnerSettings"
description: "Get a list of the cloudPcExternalPartnerSetting objects and their properties."
author: "Shaowei-Dong"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# List cloudPcExternalPartnerSettings
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [cloudPcExternalPartnerSetting](../resources/cloudpcexternalpartnersetting.md) objects and their properties.

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
GET /deviceManagement/virtualEndpoint/externalPartnerSettings
```

## Optional query parameters
This method supports the `$select` and `$filter` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [cloudPcExternalPartnerSetting](../resources/cloudpcexternalpartnersetting.md) objects in the response body.

## Examples

### Example 1: Get all external partner settings

#### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_cloudpcexternalpartnersetting_and_properties"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/externalPartnerSettings
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalPartnerSettings = await graphClient.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcExternalPartnerSetting",
  "isCollection": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://canary.graph.microsoft.com/testprodbeta_cpc_int/$metadata#deviceManagement/virtualEndpoint/externalPartnerSettings",
  "value": [
    {
      "id": "b3548526-e615-3785-3118-be70b3968ec5",
      "partnerId": "198d7140-80bb-4843-8cc4-811377a49a92",
      "enableConnection": true,
      "lastSyncDateTime": "2020-11-03T12:43:14Z",
      "status": "available",
      "statusDetails": "The external partner is available"
    },
    {
      "id": "dc6422cb-3001-45a7-9dcd-21207eea6b0e",
      "partnerId": "459a0e56-da26-4ba1-a729-8eeef733425b",
      "enableConnection": true,
      "lastSyncDateTime": "2020-11-03T12:43:14Z",
      "status": "available",
      "statusDetails": "The external partner is available"
    }
  ]
}
```

### Example 2: Use $select to get all external partner settings

#### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_cloudpcexternalpartnersetting_usingselect"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/externalPartnerSettings?$select=id,partnerId,enableConnection
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalPartnerSettings = await graphClient.DeviceManagement.VirtualEndpoint.ExternalPartnerSettings
	.Request()
	.Select("id,partnerId,enableConnection")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcExternalPartnerSetting",
  "isCollection": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#deviceManagement/virtualEndpoint/externalPartnerSettings(id,partnerId,enableConnection)",
  "value": [
    {
      "id": "b3548526-e615-3785-3118-be70b3968ec5",
      "partnerId": "198d7140-80bb-4843-8cc4-811377a49a92",
      "enableConnection": true
    },
    {
      "id": "dc6422cb-3001-45a7-9dcd-21207eea6b0e",
      "partnerId": "459a0e56-da26-4ba1-a729-8eeef733425b",
      "enableConnection": true
    }
  ]
}
```
