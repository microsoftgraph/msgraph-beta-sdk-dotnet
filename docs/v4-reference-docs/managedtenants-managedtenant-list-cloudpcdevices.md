---
title: "List cloudPcDevices"
description: "Get a list of the cloudPcDevice objects and their properties."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# List cloudPcDevices
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [cloudPcDevice](../resources/managedtenants-cloudpcdevice.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.Read.All, CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/managedTenants/cloudPcDevices
```

## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response, including `$apply`, `$count`, `$filter`, `$orderBy`, `$select`, `$skip`, and `$top`.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [cloudPcDevice](../resources/managedtenants-cloudpcdevice.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_cloudpcdevice"
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/managedTenants/cloudPcDevices
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcDevices = await graphClient.TenantRelationships.ManagedTenants.CloudPcDevices
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
  "@odata.type": "Collection(microsoft.graph.managedTenants.cloudPcDevice)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "value": [
        {
            "id": "2fd04a0b-ed49-46c0-a62d-e7980d829058",
            "organizationId": "8fd04a0b-ed49-46c0-a62d-e7980d829118",
            "organizationDisplayName": "Fabrikam",
            "displayName": "Test Cloud PC Device - Deprovisioning",
            "managedDeviceId": "618f7b25-b146-4c0e-a21b-2f1c67e78648",
            "managedDeviceName": "device01",
            "userPrincipalName": "lisa@fabrikam.com",
            "servicePlanName": "Cloud PC Business 2vCPU/8GB/128GB",
            "servicePlanType": "Business",
            "deviceSpecification": "2vCPU/8GB/128GB",
            "status": "deprovisioning",
            "lastRefreshedDateTime": "2022-02-16T11:32:37.5389729Z"
        },
        {
            "id": "1fd04a0b-ed49-46c0-a62d-e7980d829058",
            "organizationId": "4fd04a0b-ed49-46c0-a62d-e7980d829118",
            "organizationDisplayName": "Fabrikam",
            "displayName": "Test Cloud PC Device - Not Provisioned",
            "managedDeviceId": "318f7b25-b146-4c0e-a21b-2f1c67e78648",
            "managedDeviceName": "device02",
            "userPrincipalName": "john@fabrikam.com",
            "servicePlanName": "Cloud PC Enterprise 2vCPU/4GB/64GB",
            "servicePlanType": "Enterprise",
            "deviceSpecification": "2vCPU/4GB/64GB",
            "status": "notProvisioned",
            "lastRefreshedDateTime": "2022-01-16T11:32:33.5382129Z"
        }
    ]
}
```
