---
title: "Add members"
description: "Add a member to a Microsoft 365 or security group through the members navigation property."
ms.localizationpriority: medium
author: "psaffaie"
ms.prod: "groups"
doc_type: apiPageType
---

# Add members

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a member to a security or Microsoft 365 group through the **members** navigation property.

The following table shows the types of members that can be added to either security groups or Microsoft 365 groups.

| Object type             | Member of security group     | Member of Microsoft 365 group |
|-------------------------|-------------------------------|-------------------------------|
| User                   | ![Can be group member][Yes]   | ![Can be group member][Yes]   |
| Security group         | ![Can be group member][Yes]   | ![Cannot be group member][No] |
| Microsoft 365 group    | ![Cannot be group member][No] | ![Cannot be group member][No] |
| Device                 | ![Can be group member][Yes]   | ![Cannot be group member][No] |
| Service principal      | ![Can be group member][Yes]   | ![Cannot be group member][No] |
| Organizational contact | ![Can be group member][Yes]   | ![Cannot be group member][No] |

[Yes]: /graph/images/yesandnosymbols/greencheck.svg
[No]: /graph/images/yesandnosymbols/no.svg
## Permissions

The following table shows the least privileged permission that's required by each resource type when calling this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Supported resource                        | Delegated (work or school account)                      | Delegated (personal Microsoft account) | Application                                             |
|:-------------------------------------------|:---------------------------------------------------------|:----------------------------------------|:---------------------------------------------------------|
| [device](../resources/device.md)          | GroupMember.ReadWrite.All and Device.ReadWrite.All      | Not supported.                         | GroupMember.ReadWrite.All and Device.ReadWrite.All      |
| [group](../resources/group.md)            | GroupMember.ReadWrite.All and Group.ReadWrite.All       | Not supported.                         | GroupMember.ReadWrite.All and Group.ReadWrite.All       |
| [orgContact](../resources/device.md)      | GroupMember.ReadWrite.All and OrgContact.Read.All       | Not supported.                         | GroupMember.ReadWrite.All and OrgContact.Read.All       |
| [servicePrincipal](../resources/group.md) | GroupMember.ReadWrite.All and Application.ReadWrite.All | Not supported.                         | GroupMember.ReadWrite.All and Application.ReadWrite.All |
| [user](../resources/user.md)              | GroupMember.ReadWrite.All and User.ReadWrite.All        | Not supported.                         | UGroupMember.ReadWrite.All and User.ReadWrite.All       |

> [!IMPORTANT]
> To add members to a role-assignable group, the calling user must also be assigned the _RoleManagement.ReadWrite.Directory_ permission.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groups/{group-id}/members/$ref
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of a [directoryObject](../resources/directoryobject.md), [user](../resources/user.md) or [group](../resources/group.md) object to be added.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body. This method returns a `400 Bad Request` response code when the object is already a member of the group. This method returns a `404 Not Found` response code when the object being added doesn't exist.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "add_group_member"
}-->

```http
POST https://graph.microsoft.com/beta/groups/{group-id}/members/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/directoryObjects/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryObject = new DirectoryObject
{
	Id = "{id}"
};

await graphClient.Groups["{group-id}"].Members.References
	.Request()
	.AddAsync(directoryObject);

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



[Yes]: /graph/images/yesandnosymbols/greencheck.svg
[No]: /graph/images/yesandnosymbols/no.svg

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create member",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
