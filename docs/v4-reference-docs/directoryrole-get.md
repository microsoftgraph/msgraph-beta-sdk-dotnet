---
title: "Get directoryRole"
description: "Retrieve the properties of a directoryRole object."
author: "DougKirschner"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Get directoryRole

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties of a directoryRole object.

You can use both the object ID and template ID of the **directoryRole** with this API. The template ID of a built-in role is immutable and can be seen in the role description on the Azure portal. For details, see [Role template IDs](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#role-template-ids).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | RoleManagement.Read.Directory, Directory.Read.All, RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | RoleManagement.Read.Directory, Directory.Read.All, RoleManagement.ReadWrite.Directory, Directory.ReadWrite.All |

## HTTP request

You can address the directory role using either its **id** or **roleTemplateId**.
<!-- { "blockType": "ignored" } -->
```http
GET /directoryRoles/{role-id}
GET /directoryRoles(roleTemplateId='{roleTemplateId}')
```

## Optional query parameters
This method supports the `$select` [OData query parameter](/graph/query-parameters) to help customize the response.

## Request headers
| Name       | Description|
|:-----------|:------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and [directoryRole](../resources/directoryrole.md) object in the response body.
## Examples

### Example 1: Get the definition of a directory role using role id
#### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_directoryrole"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/directoryRoles/fe8f10bf-c9c2-47eb-95cb-c26cc85f1830
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryRole = await graphClient.DirectoryRoles["{directoryRole-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.directoryRole"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directoryRoles/$entity",
    "id": "fe8f10bf-c9c2-47eb-95cb-c26cc85f1830",
    "deletedDateTime": null,
    "description": "Can read basic directory information. Commonly used to grant directory read access to applications and guests.",
    "displayName": "Directory Readers",
    "roleTemplateId": "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
}
```


### Example 2: Get the definition of a directory role using roleTemplateId
#### Request
The following is an example of the request.

<!-- {
  "blockType": "request",
  "name": "get_directoryrole_templateId"
}-->
```http
GET https://graph.microsoft.com/beta/directoryRoles(roleTemplateId='88d8e3e3-8f55-4a1e-953a-9b9898b8876b')
```


#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.directoryRole"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directoryRoles/$entity",
    "id": "fe8f10bf-c9c2-47eb-95cb-c26cc85f1830",
    "deletedDateTime": null,
    "description": "Can read basic directory information. Commonly used to grant directory read access to applications and guests.",
    "displayName": "Directory Readers",
    "roleTemplateId": "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get directoryRole",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
