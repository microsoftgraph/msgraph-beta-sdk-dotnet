---
title: "Get unifiedRoleManagementPolicy"
description: "Retrieve the details of a role management policy."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Get unifiedRoleManagementPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the details of a role management policy. To read a policy that applies to Azure RBAC, use the [Azure REST PIM API for role management policies](/rest/api/authorization/role-management-policies/get).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleManagementPolicy.Read.Directory, RoleManagement.Read.Directory, RoleManagement.Read.All, RoleManagementPolicy.ReadWrite.Directory, RoleManagement.ReadWrite.Directory|
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.Read.Directory, RoleManagement.Read.All, RoleManagement.ReadWrite.Directory|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /policies/roleManagementPolicies/{unifiedRoleManagementPolicyId}
```

## Optional query parameters
This method supports the `$select` and `$expand` OData query parameters to help customize the response. You can also specify the wildcard value `*` to expand all supported relationships, that is, `?$expand=*`. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [unifiedRoleManagementPolicy](../resources/unifiedrolemanagementpolicy.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_unifiedrolemanagementpolicy"
}
-->
``` http
GET https://graph.microsoft.com/beta/policies/roleManagementPolicies/f93a5c37-5c37-f93a-375c-3af9375c3af9
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleManagementPolicy = await graphClient.Policies.RoleManagementPolicies["{unifiedRoleManagementPolicy-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleManagementPolicy"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "id": "f93a5c37-5c37-f93a-375c-3af9375c3af9",
    "displayName": "Policy1",
    "description": "Policy for privileged admins",
    "isOrganizationDefault": true,
    "scopeId": "f93a5c37-5c37-f93a-375c-3af9375c3af9",
    "scopeType": "subscription",
    "lastModifiedDateTime": "2020-09-09T21:35:27.91Z",
    "lastModifiedBy": {
      "@odata.type": "microsoft.graph.identity"
    }
  }
}
```

