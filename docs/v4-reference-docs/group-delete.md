---
title: "Delete group - Microsoft Graph API"
description: "Delete a group resource."
author: "psaffaie"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# Delete group

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Deletes a group.

When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days. After that time, they are permanently deleted. This isn't applicable to Security groups and Distribution groups which are permanently deleted immediately. To learn more, see [deletedItems](../resources/directory.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Group.ReadWrite.All                         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Group.ReadWrite.All                         |

The following conditions apply for apps to delete role-assignable groups:
+ For delegated scenarios, the app must be assigned the _RoleManagement.ReadWrite.Directory_ delegated permission, and the calling user must be the creator of the group or a global administrator or a privileged role administrator.
+ For app-only scenarios, the calling app must be the owner of the group or be assigned the _RoleManagement.ReadWrite.Directory_ application permission or be assigned the Global Administrator or Privileged Role Administrator Azure AD role.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /groups/{id}
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

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
  "name": "delete_group_byID"
}-->

```http
DELETE https://graph.microsoft.com/beta/groups/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Groups["{group-id}"]
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

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete group",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
