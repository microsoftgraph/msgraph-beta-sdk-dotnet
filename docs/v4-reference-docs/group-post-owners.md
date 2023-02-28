---
title: "Add owners"
description: "Add a user or service principal to a Microsoft 365 or security group's owners. The owners are a set of users or service principals who are allowed to modify the group object."
ms.localizationpriority: medium
author: "psaffaie"
ms.prod: "groups"
doc_type: apiPageType
---

# Add owners

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a user or service principal to a Microsoft 365 or security group's owners. The owners are a set of users or service principals who are allowed to modify the group object.

> **Important:** If you update the group owners and you created a team for the group, it can take up to 2 hours for the owners to be synchronized with Microsoft Teams. Also, if you want the owner to be able to make changes in a team - for example, by creating a Planner plan - the owner also needs to be added as a group/team member.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)  |
| :------------------------------------- | :------------------------------------------- |
| Delegated (work or school account)     | Group.ReadWrite.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                               |
| Application                            | Group.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groups/{id}/owners/$ref
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation with the **@odata.id** of a [user](../resources/user.md) or [servicePrincipal](../resources/serviceprincipal.md) object to be added.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body. This method returns a `400 Bad Request` response code when the object is already a member of the group. This method returns a `404 Not Found` response code when the object being added doesn't exist.

## Example

### Request

The following is an example of the request that adds a user as a group owner.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "create_owner_from_group"
}-->

```http
POST https://graph.microsoft.com/beta/groups/{id}/owners/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/users/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryObject = new DirectoryObject
{
	Id = "{id}"
};

await graphClient.Groups["{group-id}"].Owners.References
	.Request()
	.AddAsync(directoryObject);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

## See also

- [Add member to team](team-post-members.md)
- [Update member's role in team](team-update-members.md)
- [Remove member from team](team-delete-members.md)

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create owner",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
