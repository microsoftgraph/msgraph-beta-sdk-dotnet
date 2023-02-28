---
title: "List directoryRoles"
description: "List the directory roles that are activated in the tenant."
author: "DougKirschner"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List directoryRoles

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List the directory roles that are activated in the tenant.

This operation only returns roles that have been activated. A role becomes activated when an admin activates the role using the [Activate directoryRole](directoryrole-post-directoryroles.md) API. Not all built-in roles are initially activated. 

When assigning a role using the Azure portal, the role activation step is implicitly done on the admin's behalf. To get the full list of roles that are available in Azure AD, use [List directoryRoleTemplates](directoryroletemplate-list.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | RoleManagement.Read.Directory, Directory.Read.All, RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.Read.Directory, Directory.Read.All, RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /directoryRoles
```
## Optional query parameters
This method supports the `$count`, `$select`, `$search`, `$filter` (`eq`), and `$expand` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name       | Description|
|:-----------|:------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [directoryRole](../resources/directoryrole.md) objects in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_directoryroles"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/directoryRoles
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryRoles = await graphClient.DirectoryRoles
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

