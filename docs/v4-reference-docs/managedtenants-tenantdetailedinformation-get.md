---
title: "Get tenantDetailedInformation"
description: "Read the properties and relationships of a tenantDetailedInformation object."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# Get tenantDetailedInformation
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [tenantDetailedInformation](../resources/managedtenants-tenantdetailedinformation.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ManagedTenants.Read.All, ManagedTenants.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/managedTenants/tenantsDetailedInformation/{tenantDetailedInformationId}
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

If successful, this method returns a `200 OK` response code and a [tenantDetailedInformation](../resources/managedtenants-tenantdetailedinformation.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_tenantdetailedinformation"
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/managedTenants/tenantsDetailedInformation/{tenantDetailedInformationId}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantDetailedInformation = await graphClient.TenantRelationships.ManagedTenants.TenantsDetailedInformation["{managedTenants.tenantDetailedInformation-id}"]
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
  "@odata.type": "microsoft.graph.managedTenants.tenantDetailedInformation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.managedTenants.tenantDetailedInformation",
  "id": "34298981-4fc8-4974-9486-c8909ed1521b",
  "tenantId": "34298981-4fc8-4974-9486-c8909ed1521b",
  "companyName": "Fourth Coffee",
  "defaultDomainName": "fourthcoffee001.onmicrosoft.com",
  "countryName": "United States",
  "countryCode": "US",
  "city": "Redmond",
  "region": "NA",
  "verticalName": "Software",
  "industryName": "Computer",
  "segmentName": "Service"
}
```
