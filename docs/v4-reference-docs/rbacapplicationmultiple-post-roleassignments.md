---
title: "Create unifiedRoleAssignmentMultiple"
description: "Create a new unifiedRoleAssignmentMultiple object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: "apiPageType"
---

# Create unifiedRoleAssignmentMultiple

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [unifiedRoleAssignmentMultiple](../resources/unifiedroleassignmentmultiple.md) object for an RBAC provider. 

The following RBAC providers are currently supported:
- Cloud PC 
- device management (Intune)

For other Microsoft 365 applications (like Azure AD), use [unifiedRoleAssignment](../resources/unifiedroleassignment.md).

## Permissions

Depending on the RBAC provider and the permission type (delegated or application) that is needed, choose from the following table the least privileged permission required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, see [Permissions](/graph/permissions-reference). 

### For Cloud PC provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  CloudPC.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | CloudPC.ReadWrite.All  |

### For Device management (Intune) provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  DeviceManagementRBAC.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | DeviceManagementRBAC.ReadWrite.All |


## HTTP request

To create role assignment for a Cloud PC provider:

<!-- { "blockType": "ignored" } -->

```http
POST /roleManagement/cloudPC/roleAssignments
```

To create role assignment for an Intune provider:
<!-- { "blockType": "ignored" } -->

```http
POST /roleManagement/deviceManagement/roleAssignments
```

## Request headers

| Name | Description |
|:---- |:----------- |
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of [unifiedRoleAssignmentMultiple](../resources/unifiedroleassignmentmultiple.md) object. The request must have either a scope defined in Azure AD, such as `directoryScopeIds`, or an application-specific scope, such as `appScopeId`. Examples of Azure AD scope are tenant ("/"), administrative units, or applications. 

## Response

If successful, this method returns a `201 Created` response code and a new [unifiedRoleAssignmentMultiple](../resources/unifiedroleassignmentmultiple.md) object in the response body.

## Examples

### Example 1: Create a role assignment in Intune over two scope groups (which are Azure AD objects)

#### Request

The following is an example of the request.
> **Note:** the use of the **roleTemplateId** for **roleDefinitionId**. **roleDefinitionId** can be either the service-wide template ID or the directory-specific **roleDefinitionId**.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignmentmultiple_from_rbacapplication"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/deviceManagement/roleAssignments
Content-type: application/json

{ 
    "@odata.type": "#microsoft.graph.unifiedRoleAssignmentMultiple",
    "displayName": "My test role assignment 1",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalIds": ["f8ca5a85-489a-49a0-b555-0a6d81e56f0d", "c1518aa9-4da5-4c84-a902-a31404023890"],
    "directoryScopeIds": ["28ca5a85-489a-49a0-b555-0a6d81e56f0d", "8152656a-cf9a-4928-a457-1512d4cae295"],
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignmentMultiple = new UnifiedRoleAssignmentMultiple
{
	DisplayName = "My test role assignment 1",
	RoleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034",
	PrincipalIds = new List<String>()
	{
		"f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
		"c1518aa9-4da5-4c84-a902-a31404023890"
	},
	DirectoryScopeIds = new List<String>()
	{
		"28ca5a85-489a-49a0-b555-0a6d81e56f0d",
		"8152656a-cf9a-4928-a457-1512d4cae295"
	}
};

await graphClient.RoleManagement.DeviceManagement.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignmentMultiple);

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
  "@odata.type": "microsoft.graph.unifiedRoleAssignmentMultiple"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#roleManagement/deviceManagement/roleAssignments/$entity",
    "@odata.type": "#microsoft.graph.unifiedRoleAssignmentMultiple",
    "id": "28ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalIds": ["f8ca5a85-489a-49a0-b555-0a6d81e56f0d", "c1518aa9-4da5-4c84-a902-a31404023890"],
    "directoryScopeIds": ["28ca5a85-489a-49a0-b555-0a6d81e56f0d", "8152656a-cf9a-4928-a457-1512d4cae295"]
}
```

### Example 2: Create a role assignment in Intune at Intune-specific scope of "all Devices"

Use the following information for creating Intune role assignments:
- To allow assignments over all Intune devices, use the `AllDevices` value in **appScopeIds**.
- To allow assignments over all Intune licensed users, use the `AllLicensedUsers` value in **appScopeIds**.
- To allow assignments over all Intune devices and licensed users, use the `/` value in **directoryScopeIds**.

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignmentmultiple_intune_specific"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/deviceManagement/roleAssignments
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.unifiedRoleAssignmentMultiple",
    "displayName": "My test role assignment 1",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalIds": ["f8ca5a85-489a-49a0-b555-0a6d81e56f0d", "c1518aa9-4da5-4c84-a902-a31404023890"],
    "appScopeIds": ["allDevices"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignmentMultiple = new UnifiedRoleAssignmentMultiple
{
	DisplayName = "My test role assignment 1",
	RoleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034",
	PrincipalIds = new List<String>()
	{
		"f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
		"c1518aa9-4da5-4c84-a902-a31404023890"
	},
	AppScopeIds = new List<String>()
	{
		"allDevices"
	}
};

await graphClient.RoleManagement.DeviceManagement.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignmentMultiple);

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
  "@odata.type": "microsoft.graph.unifiedRoleAssignmentMultiple"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#roleManagement/deviceManagement/roleAssignments/$entity",
    "@odata.type": "#microsoft.graph.unifiedRoleAssignmentMultiple",
    "id": "28ca5a85-489a-49a0-b555-0a6d81e56f0d",
    "roleDefinitionId": "c2cf284d-6c41-4e6b-afac-4b80928c9034",
    "principalIds": ["f8ca5a85-489a-49a0-b555-0a6d81e56f0d", "c1518aa9-4da5-4c84-a902-a31404023890"],
    "appScopeIds": ["allDevices"]
}
```

### Example 3: Create a role assignment for a Cloud PC provider

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_unifiedroleassignmentmultiple_from_rbacapplication_cloudpc"
}-->

```http
POST https://graph.microsoft.com/beta/roleManagement/cloudPC/roleAssignments
Content-type: application/json

{ 
    "@odata.type": "#microsoft.graph.unifiedRoleAssignmentMultiple",
    "displayName": "My test role assignment 1",
    "description": "My role assignment description",
    "roleDefinitionId": "b5c08161-a7af-481c-ace2-a20a69a48fb1",
    "principalIds": ["f8ca5a85-489a-49a0-b555-0a6d81e56f0d", "c1518aa9-4da5-4c84-a902-a31404023890"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignmentMultiple = new UnifiedRoleAssignmentMultiple
{
	DisplayName = "My test role assignment 1",
	Description = "My role assignment description",
	RoleDefinitionId = "b5c08161-a7af-481c-ace2-a20a69a48fb1",
	PrincipalIds = new List<String>()
	{
		"f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
		"c1518aa9-4da5-4c84-a902-a31404023890"
	}
};

await graphClient.RoleManagement.CloudPC.RoleAssignments
	.Request()
	.AddAsync(unifiedRoleAssignmentMultiple);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
> **Note:** The response object shown here might be shortened for readability. All the properties will be returned from an actual call.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignmentMultiple"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/cloudPC/roleAssignments/$entity",
    "id": "47c88dcd-cc79-4b0c-ba7d-7af2199649c5",
    "displayName": "My role assignment",
    "description": "My role assignment description",
    "roleDefinitionId": "b5c08161-a7af-481c-ace2-a20a69a48fb1",
    "principalIds": [
        "f8ca5a85-489a-49a0-b555-0a6d81e56f0d",
        "c1518aa9-4da5-4c84-a902-a31404023890"
    ],
    "directoryScopeIds": [
        "/"
    ],
    "appScopeIds": []
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create unifiedRoleAssignmentMultiple",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


