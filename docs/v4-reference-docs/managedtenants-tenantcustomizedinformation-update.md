---
title: "Update tenantCustomizedInformation"
description: "Update the properties of a tenantCustomizedInformation object."
author: "idwilliams"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# Update tenantCustomizedInformation
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [tenantCustomizedInformation](../resources/managedtenants-tenantcustomizedinformation.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ManagedTenants.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /tenantRelationships/managedTenants/tenantsCustomizedInformation/{tenantCustomizedInformationId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [tenantCustomizedInformation](../resources/managedtenants-tenantcustomizedinformation.md) object.

The following table shows the properties that are required when you update the [tenantCustomizedInformation](../resources/managedtenants-tenantcustomizedinformation.md).

|Property|Type|Description|
|:---|:---|:---|
|id|String|The Azure Active Directory tenant identifier for the managed tenant.|
|tenantId|String|The Azure Active Directory tenant identifier for the [managed tenant](../resources/managedtenants-tenant.md).|
|contacts|[microsoft.graph.managedTenants.tenantContactInformation](../resources/managedtenants-tenantcontactinformation.md) collection|The collection of contacts associated with the managed tenant.|
|website|String|The website for the managed tenant.|

## Response

If successful, this method returns a `200 OK` response code and an updated [tenantCustomizedInformation](../resources/managedtenants-tenantcustomizedinformation.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_tenantcustomizedinformation"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/tenantRelationships/managedTenants/tenantsCustomizedInformation/{tenantCustomizedInformationId}
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.managedTenants.tenantCustomizedInformation",
  "tenantId": "String",
  "contacts": [
    {
      "@odata.type": "microsoft.graph.managedTenants.tenantContactInformation",
      "name": "String",
      "title": "String",
      "email": "String",
      "phone": "String",
      "notes": "String"
    }
  ],
  "website": "String"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantCustomizedInformation = new Microsoft.Graph.ManagedTenants.TenantCustomizedInformation
{
	TenantId = "String",
	Contacts = new List<Microsoft.Graph.ManagedTenants.TenantContactInformation>()
	{
		new TenantContactInformation
		{
			Name = "String",
			Title = "String",
			Email = "String",
			Phone = "String",
			Notes = "String"
		}
	},
	Website = "String"
};

await graphClient.TenantRelationships.ManagedTenants.TenantsCustomizedInformation["{managedTenants.tenantCustomizedInformation-id}"]
	.Request()
	.UpdateAsync(tenantCustomizedInformation);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.managedTenants.tenantCustomizedInformation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.managedTenants.tenantCustomizedInformation",
  "id": "34298981-4fc8-4974-9486-c8909ed1521b",
  "tenantId": "34298981-4fc8-4974-9486-c8909ed1521b",
  "website": "https://www.fourthcoffee.com",
  "contacts": [
    {
      "name": "Sally",
      "email": "sally@fourthcoffee.com",
      "phone": "5558009731"
    },
    {
      "name": "Hector",
      "email": "hector@fourthcoffee.com",
      "phone": "5558009732"
    }
  ]
}
```
