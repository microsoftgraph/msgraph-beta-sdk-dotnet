---
title: "List conditionalAccessPolicyCoverages"
description: "Get a list of the conditionalAccessPolicyCoverage objects and their properties."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# List conditionalAccessPolicyCoverages
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [conditionalAccessPolicyCoverage](../resources/managedtenants-conditionalaccesspolicycoverage.md) objects and their properties. Use this operation to list of Azure Active Directory conditional access policy coverage across all tenants that are being managed by the multi-tenant management platform.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, and Application.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/managedTenants/conditionalAccessPolicyCoverages
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

If successful, this method returns a `200 OK` response code and a collection of [conditionalAccessPolicyCoverage](../resources/managedtenants-conditionalaccesspolicycoverage.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_conditionalaccesspolicycoverage"
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/managedTenants/conditionalAccessPolicyCoverages
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conditionalAccessPolicyCoverages = await graphClient.TenantRelationships.ManagedTenants.ConditionalAccessPolicyCoverages
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
  "@odata.type": "Collection(microsoft.graph.managedTenants.conditionalAccessPolicyCoverage)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.managedTenants.conditionalAccessPolicyCoverage",
      "id": "38227791-a88b-4fcc-81c5-58cf77668320",
      "conditionalAccessPolicyState": "enabled",
      "requiresDeviceCompliance": false,
      "latestPolicyModifiedDateTime": "2021-07-11T14:56:13.598304Z",
      "tenantDisplayName": "Consolidated Messenger"
    }
  ]
}
```
