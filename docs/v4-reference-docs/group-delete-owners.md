---
title: "Remove group owner"
description: "Use this API to remove an owner from a Microsoft 365 group or a security group through the owners navigation property."
ms.localizationpriority: medium
author: "psaffaie"
ms.prod: "groups"
doc_type: apiPageType
---

# Remove group owner

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Use this API to remove an owner from a Microsoft 365 group or a security group through the **owners** navigation property. When owners are assigned to a group, the last owner (a user object) of the group cannot be removed.

> **Note:** For issues encountered when removing owner of a group associated with a [team](/graph/api/resources/team.md), see [Known Issues](/graph/known-issues#removing-a-group-owner-also-removes-the-user-as-a-group-member).

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
DELETE /groups/{id}/owners/{id}/$ref
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
  "name": "delete_owner_from_group"
}-->

```http
DELETE https://graph.microsoft.com/beta/groups/{id}/owners/{id}/$ref
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Groups["{group-id}"].Owners["{directoryObject-id}"].Reference
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

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
  "description": "Delete owner",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
