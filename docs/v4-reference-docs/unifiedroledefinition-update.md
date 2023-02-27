---
title: "Update unifiedRoleDefinition"
description: "Update the properties of a unifiedRoleDefinition object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: "apiPageType"
---

# Update unifiedRoleDefinition

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [unifiedRoleDefinition](../resources/unifiedroledefinition.md) object for an RBAC provider. You cannot update built-in roles. This feature requires an Azure AD Premium P1 or P2 license.

The following RBAC providers are currently supported:
- Cloud PC
- device management (Intune)
- directory (Azure AD) 


## Permissions

Depending on the RBAC provider and the permission type (delegated or application) that is needed, choose from the following tables the least privileged permission required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in the [Permissions reference](/graph/permissions-reference). 

### For a Cloud PC provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | RoleManagement.ReadWrite.CloudPC, CloudPC.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.ReadWrite.CloudPC, CloudPC.ReadWrite.All  |

### For a device management (Intune) provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  DeviceManagementRBAC.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | DeviceManagementRBAC.ReadWrite.All |

### For a directory (Azure AD) provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All |

## HTTP request

To update a role definition for a device management provider:
<!-- { "blockType": "ignored" } -->
```http
PATCH /roleManagement/deviceManagement/roleDefinitions/{id}
```

To update a role definition for a directory provider:
<!-- { "blockType": "ignored" } -->
```http
PATCH /roleManagement/directory/roleDefinitions/{id}
```

To update a role definition for a Cloud PC provider:
<!-- { "blockType": "ignored" } -->
```http
PATCH /roleManagement/cloudPc/roleDefinitions/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token} |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|description|String| The description for the role definition. Read-only when isBuiltIn is true. |
|displayName|String| The display name for the role definition. Read-only when isBuiltIn is true. Required.|
|id|String| The unique identifier for the role definition. Key, not nullable, Read-only. |
|isBuiltIn|Boolean| Flag indicating if the role definition is part of the default set included with the product or custom. Read-only. |
|isEnabled|Boolean| Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true. |
|resourceScopes|String collection| List of scopes permissions granted by the role definition apply to. Currently only "/" is supported. Read-only when isBuiltIn is true. **DO NOT USE. This property will be deprecated soon. Attach scope to role assignment.**|
|rolePermissions|[unifiedRolePermission](../resources/unifiedrolepermission.md) collection| List of permissions included in the role. Read-only when isBuiltIn is true. Required. |
|templateId|String| Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true. |
|inheritsPermissionsFrom| [unifiedRoleDefinition](../resources/unifiedroledefinition.md) collection| Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute. |
|version|String| Indicates version of the role definition. Read-only when isBuiltIn is true.|

## Response

If successful, this method returns a `204 No Content` response code.

## Example 1: Updates a **unifiedRoleDefinition** for a directory provider

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_unifiedroledefinition",
  "sampleKeys": ["0d55728d-3e24-4309-9b1b-5ac09921475a"]
}-->

```http
PATCH https://graph.microsoft.com/beta/roleManagement/directory/roleDefinitions/0d55728d-3e24-4309-9b1b-5ac09921475a
Content-type: application/json

{
  "description": "Update basic properties of application registrations",
  "displayName": "Application Registration Support Administrator",
  "rolePermissions":
    [
        {
            "allowedResourceActions": 
            [
                "microsoft.directory/applications/basic/read"
            ]
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleDefinition = new UnifiedRoleDefinition
{
	Description = "Update basic properties of application registrations",
	DisplayName = "Application Registration Support Administrator",
	RolePermissions = new List<UnifiedRolePermission>()
	{
		new UnifiedRolePermission
		{
			AllowedResourceActions = new List<String>()
			{
				"microsoft.directory/applications/basic/read"
			}
		}
	}
};

await graphClient.RoleManagement.Directory.RoleDefinitions["{unifiedRoleDefinition-id}"]
	.Request()
	.UpdateAsync(unifiedRoleDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
Content-type: application/json

```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update unifiedroledefinition",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->

## Example 2: Updates a **unifiedRoleDefinition** for a CloudPC provider

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_unifiedroledefinition_cloudpc",
  "sampleKeys": ["b7f5ddc1-b7dc-4d37-abce-b9d6fc15ffff"]
}-->

```http
PATCH https://graph.microsoft.com/beta/roleManagement/cloudPC/roleDefinitions/b7f5ddc1-b7dc-4d37-abce-b9d6fc15ffff
Content-type: application/json

{
  "description": "Update basic properties and permission of application registrations",
  "displayName": "ExampleCustomRole",
  "rolePermissions":
    [
        {
            "allowedResourceActions": 
            [
                "Microsoft.CloudPC/CloudPCs/Read",
                "Microsoft.CloudPC/CloudPCs/Reprovision"
            ]
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleDefinition = new UnifiedRoleDefinition
{
	Description = "Update basic properties and permission of application registrations",
	DisplayName = "ExampleCustomRole",
	RolePermissions = new List<UnifiedRolePermission>()
	{
		new UnifiedRolePermission
		{
			AllowedResourceActions = new List<String>()
			{
				"Microsoft.CloudPC/CloudPCs/Read",
				"Microsoft.CloudPC/CloudPCs/Reprovision"
			}
		}
	}
};

await graphClient.RoleManagement.CloudPC.RoleDefinitions["{unifiedRoleDefinition-id}"]
	.Request()
	.UpdateAsync(unifiedRoleDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
Content-type: application/json

```
