---
title: "List cloudPcOverviews"
description: "Get a list of the cloudPcOverview objects and their properties."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# List cloudPcOverviews
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [cloudPcOverview](../resources/managedtenants-cloudpcoverview.md) objects and their properties.

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
GET /tenantRelationships/managedTenants/cloudPcsOverview
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

If successful, this method returns a `200 OK` response code and a collection of [cloudPcOverview](../resources/managedtenants-cloudpcoverview.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_cloudpcoverview"
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/managedTenants/cloudPcsOverview
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcsOverview = await graphClient.TenantRelationships.ManagedTenants.CloudPcsOverview
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
  "@odata.type": "Collection(microsoft.graph.managedTenants.cloudPcOverview)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "value": [
        {
            "id":"8fd04a0b-ed49-46c0-a62d-e7980d829022",
            "organizationDisplayName":"Fabrikam",
            "cloudPcStatus_total": 100,
            "numberOfCloudPcStatusNotProvisioned": 10,
            "numberOfCloudPcStatusProvisioning": 20,
            "numberOfCloudPcStatusProvisioned": 30,
            "numberOfCloudPcStatusUpgrading": 1,
            "numberOfCloudPcStatusInGracePeriod": 2,
            "numberOfCloudPcStatusDeprovisioning": 2,
            "numberOfCloudPcStatusFailed": 30,
            "numberOfCloudPcStatusUnknown": 5,
            "totalCloudPcConnectionStatus": 40,
            "numberOfCloudPcConnectionStatusPending": 10,
            "numberOfCloudPcConnectionStatusRunning": 3,
            "numberOfCloudPcConnectionStatusPassed": 12,
            "numberOfCloudPcConnectionStatusFailed": 15,
            "numberOfCloudPcConnectionStatusUnkownFutureValue": 0,
            "totalEnterpriseLicenses":  43,
            "totalEnterpriseLicenses":  57,
            "lastRefreshedDateTime":"2021-02-01T09:28:32.8260338Z"
        },
        {
            "id":"8fd04a0b-ed49-46c0-a62d-e7980d829051",
            "organizationDisplayName":"Alpine Skis",
            "cloudPcStatus_total": 100,
            "numberOfCloudPcStatusNotProvisioned": 10,
            "numberOfCloudPcStatusProvisioning": 20,
            "numberOfCloudPcStatusProvisioned": 30,
            "numberOfCloudPcStatusUpgrading": 1,
            "numberOfCloudPcStatusInGracePeriod": 2,
            "numberOfCloudPcStatusDeprovisioning": 2,
            "numberOfCloudPcStatusFailed": 30,
            "numberOfCloudPcStatusUnknown": 5,
            "totalCloudPcConnectionStatus": 40,
            "numberOfCloudPcConnectionStatusPending": 10,
            "numberOfCloudPcConnectionStatusRunning": 3,
            "numberOfCloudPcConnectionStatusPassed": 12,
            "numberOfCloudPcConnectionStatusFailed": 15,
            "numberOfCloudPcConnectionStatusUnkownFutureValue": 0,
            "totalEnterpriseLicenses": 43,
            "totalEnterpriseLicenses": 57,
            "lastRefreshedDateTime":"2021-03-01T09:28:32.8260338Z"
        }
    ]
}
```
