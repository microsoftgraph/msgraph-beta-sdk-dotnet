---
title: "Create unifiedRoleAssignment"
description: "Create a new unifiedRoleAssignment object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: "apiPageType"
---

# Create unifiedRoleAssignment

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [unifiedRoleAssignment](../resources/unifiedroleassignment.md) object.

## Permissions

Depending on the RBAC provider and the permission type (delegated or application) that is needed, choose from the following table the least privileged permission required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in [Permissions](/graph/permissions-reference).

### For the directory (Azure AD) provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  RoleManagement.ReadWrite.Directory   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.ReadWrite.Directory |

### For the entitlement management provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  EntitlementManagement.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request

Create a role assignment for the directory provider:

<!-- { "blockType": "ignored" } -->

```http
POST /roleManagement/directory/roleAssignments
```

Create a role assignment for the entitlement management provider:

<!-- { "blockType": "ignored" } -->

```http
POST /roleManagement/entitlementManagement/roleAssignments
```


## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token} |

## Request body

In the request body, supply a JSON representation of a [unifiedRoleAssignment](../resources/unifiedroleassignment.md) object. The request must have either a scope defined in Azure AD, such as **directoryScopeId**, or an application-specific scope, such as **appScopeId**. Examples of Azure AD scopes are tenant ("/"), administrative unit, attribute set, or application. Entitlement management uses tenant ("/") and access package catalog scopes. For more information, see [appScope](../resources/appscope.md).

## Response

If successful, this method returns a `201 Created` response code and a new [unifiedRoleAssignment](../resources/unifiedroleassignment.md) object in the response body.

## Examples

### Example 1: Create a role assignment with tenant scope

#### Request

The following is an example of the request. Note the use of the roleTemplateId for roleDefinitionId. roleDefinitionId can be either the service-wide template Id or the directory-specific roleDefinitionId.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignment_from_rbacapplication"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/directory/roleAssignments
Content-type: application/json

{ 
    "@odata.type": "#microsoft.graph.unifiedRoleAssignment",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignment = new UnifiedRoleAssignment
{
	RoleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034",
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
	DirectoryScopeId = "/"
};

await graphClient.RoleManagement.Directory.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignment"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/directory/roleAssignments/$entity",
    "id": "YUb1sHQtUEyvox7IA_Eu_mm3jqnUe4lEhvatluHVi2I-1",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/"
}
```

### Example 2 : Create a role assignment with administrative unit scope

#### Request

The following example assigns the User Administrator role to a principal with administrative unit scope.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignment_over_administrativeunit"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/directory/roleAssignments
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.unifiedRoleAssignment",
    "roleDefinitionId": "fe930be7-5e62-47db-91af-98c3a49a38b1",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignment = new UnifiedRoleAssignment
{
	RoleDefinitionId = "fe930be7-5e62-47db-91af-98c3a49a38b1",
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
	DirectoryScopeId = "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
};

await graphClient.RoleManagement.Directory.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignment"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/directory/roleAssignments/$entity",
    "id": "BH21sHQtUEyvox7IA_Eu_mm3jqnUe4lEhvatluHIWb7-1",
    "roleDefinitionId": "fe930be7-5e62-47db-91af-98c3a49a38b1",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}
```


### Example 3 : Create a role assignment with attribute set scope

#### Request

The following example assigns the Attribute Assignment Administrator role to a principal with an attribute set scope named Engineering. For more information about Azure AD custom security attributes and attribute set scope, see [Manage access to custom security attributes in Azure AD](/azure/active-directory/fundamentals/custom-security-attributes-manage).


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignment_attributeset_scope"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/directory/roleAssignments
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.unifiedRoleAssignment",
    "roleDefinitionId": "58a13ea3-c632-46ae-9ee0-9c0d43cd7f3d",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/attributeSets/Engineering"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignment = new UnifiedRoleAssignment
{
	RoleDefinitionId = "58a13ea3-c632-46ae-9ee0-9c0d43cd7f3d",
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
	DirectoryScopeId = "/attributeSets/Engineering"
};

await graphClient.RoleManagement.Directory.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignment"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/directory/roleAssignments/$entity",
    "id": "oz6hWDLGrkae4JwNQ81_PU-mYqx8m71OpqEQPdN1u",
    "roleDefinitionId": "58a13ea3-c632-46ae-9ee0-9c0d43cd7f3d",
    "principalId": "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "directoryScopeId": "/attributeSets/Engineering"
}
```

### Example 4: Create a role assignment with access package catalog scope

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignment3_from_rbacapplication"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/entitlementManagement/roleAssignments
Content-type: application/json

{
    "principalId": "679a9213-c497-48a4-830a-8d3d25d94ddc",
    "roleDefinitionId": "ae79f266-94d4-4dab-b730-feca7e132178",
    "appScopeId": "/AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignment = new UnifiedRoleAssignment
{
	PrincipalId = "679a9213-c497-48a4-830a-8d3d25d94ddc",
	RoleDefinitionId = "ae79f266-94d4-4dab-b730-feca7e132178",
	AppScopeId = "/AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997"
};

await graphClient.RoleManagement.EntitlementManagement.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignment"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/entitlementManagement/roleAssignments/$entity",
    "id": "f3092518-7874-462e-93e9-0cd6c11ffc52",
    "principalId": "679a9213-c497-48a4-830a-8d3d25d94ddc",
    "roleDefinitionId": "ae79f266-94d4-4dab-b730-feca7e132178",
    "appScopeId": "/AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997"
}
```


<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create unifiedRoleAssignment",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->

