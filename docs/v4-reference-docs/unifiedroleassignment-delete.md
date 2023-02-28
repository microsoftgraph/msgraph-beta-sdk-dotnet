---
title: "Delete unifiedRoleAssignment"
description: "Delete a unifiedRoleAssignment object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "directory-management"
doc_type: "apiPageType"
---

# Delete unifiedRoleAssignment

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [unifiedRoleAssignment](../resources/unifiedRoleAssignment.md) object.

## Permissions

Depending on the RBAC provider and the permission type (delegated or application) that is needed, choose from the following table the least privileged permission required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in [Permissions](/graph/permissions-reference).

### For Directory (Azure AD) provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  RoleManagement.ReadWrite.Directory   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.ReadWrite.Directory |

### For Entitlement management provider

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  EntitlementManagement.ReadWrite.All  |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request

Remove a role assignment from a directory provider:

<!-- { "blockType": "ignored" } -->

```http
DELETE /roleManagement/directory/roleAssignments/{id}
```

Remove a role assignment from the entitlement management provider:

<!-- { "blockType": "ignored" } -->

```http
DELETE /roleManagement/entitlementManagement/roleAssignments/{id}
```


## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token} |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_unifiedroleassignment",
  "sampleKeys": ["lAPpYvVpN0KRkAEhdxReEJC2sEqbR_9Hr48lds9SGHI-1"]
}-->

```http
DELETE https://graph.microsoft.com/beta/roleManagement/directory/roleAssignments/lAPpYvVpN0KRkAEhdxReEJC2sEqbR_9Hr48lds9SGHI-1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.RoleManagement.Directory.RoleAssignments["{unifiedRoleAssignment-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Delete unifiedRoleAssignment",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


