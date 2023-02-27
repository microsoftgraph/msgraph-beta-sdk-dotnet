---
title: "List servicePlans"
description: "List the currently available service plans that an organization can purchase for their Cloud PCs."
author: "RuiHou105"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# List servicePlans

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List the currently available service plans that an organization can purchase for their Cloud PCs.

For examples of currently available service plans, see [Windows 365 compare plans and pricing](https://www.microsoft.com/windows-365/business/compare-plans-pricing). Currently, Microsoft Graph API is available for Windows 365 Enterprise.

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
GET /deviceManagement/virtualEndpoint/servicePlans
```

## Optional query parameters

This method does not support OData query parameters to customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [cloudPcServicePlan](../resources/cloudpcserviceplan.md) objects in the response body.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_servicePlans"
}
-->

``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/servicePlans
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var servicePlans = await graphClient.DeviceManagement.VirtualEndpoint.ServicePlans
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
  "@odata.type": "microsoft.graph.cloudPcServicePlan",
  "isCollection": true
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.cloudPcServicePlan",
      "id": "dea1edd3-edd3-dea1-d3ed-a1ded3eda1de",
      "displayName": "Cloud PC - Level 1 - 1vCPU/2GB",
      "type": "enterprise",
      "vCpuCount": 1,
      "ramInGB": 2,
      "storageInGB": 64,
      "userProfileInGB": 25
    }
  ]
}
```
