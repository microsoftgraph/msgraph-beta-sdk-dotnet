---
title: "Add a scopedRoleMember"
description: "Assign an Azure Active Directory (Azure AD) role with administrative unit scope."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: apiPageType
---

# Add a scopedRoleMember

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Assign an Azure Active Directory (Azure AD) role with administrative unit scope. For a list of roles that can be assigned with administrative unit scope, see [Assign Azure AD roles with administrative unit scope](/azure/active-directory/roles/admin-units-assign-roles).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | RoleManagement.ReadWrite.Directory    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.ReadWrite.Directory |

To assign Azure AD roles with an administrative unit scope, the calling principal must be assigned one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference):

* Privileged Role Administrator
* Global Administrator

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /administrativeUnits/{id}/scopedRoleMembers
```
## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required.|

## Request body
In the request body, supply a JSON representation of [scopedRoleMembership](../resources/scopedrolemembership.md) object.

## Response

If successful, this method returns `201 Created` response code and [scopedRoleMembership](../resources/scopedrolemembership.md) object in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_scopedrolemembership_from_administrativeunit"
}-->
```http
POST https://graph.microsoft.com/beta/administrativeUnits/{id}/scopedRoleMembers
Content-type: application/json

{
  "roleId": "roleId-value",
  "roleMemberInfo": {
    "id": "id-value"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var scopedRoleMembership = new ScopedRoleMembership
{
	RoleId = "roleId-value",
	RoleMemberInfo = new Identity
	{
		Id = "id-value"
	}
};

await graphClient.AdministrativeUnits["{administrativeUnit-id}"].ScopedRoleMembers
	.Request()
	.AddAsync(scopedRoleMembership);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

