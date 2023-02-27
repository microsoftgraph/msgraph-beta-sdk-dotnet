---
title: "Update unifiedRoleAssignmentMultiple"
description: "Update a new unifiedRoleAssignmentMultiple object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: "apiPageType"
---

# Update unifiedRoleAssignmentMultiple

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update an existing [unifiedRoleAssignmentMultiple](../resources/unifiedroleassignmentmultiple.md) object of an RBAC provider. 

The following RBAC providers are currently supported:
- Cloud PC 
- device management (Intune)

In contrast, [unifiedRoleAssignment](../resources/unifiedroleassignment.md) does not support update.

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

To update an existing unfiedRoleAssignmentMultiple for a Cloud PC provider:
<!-- { "blockType": "ignored" } -->

```http
PATCH /roleManagement/cloudPC/roleAssignments
```

To update an existing unfiedRoleAssignmentMultiple for an Intune provider:
<!-- { "blockType": "ignored" } -->

```http
PATCH /roleManagement/deviceManagement/roleAssignments
```

## Request headers

| Name | Description |
|:---- |:----------- |
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

## Response

If successful, this method returns a `200 OK` response code and an updated [unifiedAssignmentMultiple](../resources/unifiedroleassignmentMultiple.md) object in the response body.

## Example

### Example 1: Update an existing unfiedRoleAssignmentMultiple in an Intune provider
### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_unifiedroleassignmentmultiple_from_rbacapplication",
  "sampleKeys": ["lAPpYvVpN0KRkAEhdxReEJC2sEqbR_9Hr48lds9SGHI-1"]
}-->

```http
PATCH https://graph.microsoft.com/beta/roleManagement/deviceManagement/roleAssignments/lAPpYvVpN0KRkAEhdxReEJC2sEqbR_9Hr48lds9SGHI-1
Content-type: application/json

{ 
    "principalIds": ["0aeec2c1-fee7-4e02-b534-6f920d25b300", "2d5386a7-732f-44db-9cf8-f82dd2a1c0e0"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignmentMultiple = new UnifiedRoleAssignmentMultiple
{
	PrincipalIds = new List<String>()
	{
		"0aeec2c1-fee7-4e02-b534-6f920d25b300",
		"2d5386a7-732f-44db-9cf8-f82dd2a1c0e0"
	}
};

await graphClient.RoleManagement.DeviceManagement.RoleAssignments["{unifiedRoleAssignmentMultiple-id}"]
	.Request()
	.UpdateAsync(unifiedRoleAssignmentMultiple);

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
HTTP/1.1 204 OK

```

## Example 2: update an existing unfiedRoleAssignmentMultiple in a Cloud PC provider

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_unifiedroleassignmentmultiple_from_rbacapplication_cloudpc",
  "sampleKeys": ["dbe9d288-fd87-41f4-b33d-b498ed207096"]
}-->

```http
PATCH https://graph.microsoft.com/beta/roleManagement/cloudPC/roleAssignments/dbe9d288-fd87-41f4-b33d-b498ed207096
Content-type: application/json

{
    "displayName": "NewName",
    "description": "A new roleAssignment"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var unifiedRoleAssignmentMultiple = new UnifiedRoleAssignmentMultiple
{
	DisplayName = "NewName",
	Description = "A new roleAssignment"
};

await graphClient.RoleManagement.CloudPC.RoleAssignments["{unifiedRoleAssignmentMultiple-id}"]
	.Request()
	.UpdateAsync(unifiedRoleAssignmentMultiple);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

> **Note:** The response object shown here might be shortened for readability. All the properties will be returned from an actual call.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.unifiedRoleAssignmentMultiple"
} -->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/cloudPC/roleAssignments/$entity",
    "id": "dbe9d288-fd87-41f4-b33d-b498ed207096",
    "description": "A new roleAssignment",
    "displayName": "NewName",
    "roleDefinitionId": "b5c08161-a7af-481c-ace2-a20a69a48fb1",
    "principalIds": [
        "0aeec2c1-fee7-4e02-b534-6f920d25b300",
        "2d5386a7-732f-44db-9cf8-f82dd2a1c0e0"
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
  "description": "Update unifiedRoleAssignmentMultiple",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


