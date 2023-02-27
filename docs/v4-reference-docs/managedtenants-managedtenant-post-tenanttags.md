---
title: "Create tenantTag"
description: "Create a new tenantTag object."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# Create tenantTag
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [tenantTag](../resources/managedtenants-tenanttag.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ManagedTenants.WriteRead.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /tenantRelationships/managedTenants/tenantTags
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [tenantTag](../resources/managedtenants-tenanttag.md) object.

The following table shows the properties that are required when you create the [tenantTag](../resources/managedtenants-tenanttag.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The display name for the tenant tag.|
|description|String|The description for the tenant tag.|

## Response

If successful, this method returns a `201 Created` response code and a [tenantTag](../resources/managedtenants-tenanttag.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_tenanttag_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/tenantRelationships/managedTenants/tenantTags
Content-Type: application/json

{
  "displayName": "Support",
  "description": "Tenants that have purchased extended support"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantTag = new Microsoft.Graph.ManagedTenants.TenantTag
{
	DisplayName = "Support",
	Description = "Tenants that have purchased extended support"
};

await graphClient.TenantRelationships.ManagedTenants.TenantTags
	.Request()
	.AddAsync(tenantTag);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.managedTenants.tenantTag"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#tenantTags/$entity",
  "id": "11103b2b-0e28-456b-901d-45f98890ab1d",
  "displayName": "Support",
  "description": "Tenants that have purchased extended support",
  "tenantIds": [],
  "isDeleted": null,
  "createdDateTime": "2021-07-11T19:31:49.807267Z",
  "createdByUserId": "cad28f13-0158-43c5-9c59-952f2caa62c0",
  "lastActionDateTime": "2021-07-11T19:31:49.8072716Z",
  "lastActionByUserId": "cad28f13-0158-43c5-9c59-952f2caa62c0"
}
```
