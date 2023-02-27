---
title: "directoryObject: getMemberObjects"
description: "Return all the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device or directory object is a member of. This function is transitive."
ms.localizationpriority: medium
author: "keylimesoda"
ms.prod: "directory-management"
doc_type: apiPageType
---

# directoryObject: getMemberObjects

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Return all IDs for the groups, administrative units, and directory roles that a [user](../resources/user.md), [group](../resources/group.md), [service principal](../resources/serviceprincipal.md), [organizational contact](../resources/orgcontact.md), [device](../resources/device.md), or [directory object](../resources/directoryobject.md) is a member of. This function is transitive.

**Note:** Only users and role-enabled groups can be members of directory roles.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Memberships for a directory object

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.Read.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Directory.Read.All |

### Memberships for a user

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, User.Read.All, Directory.Read.All, User.ReadWrite.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | User.Read.All, Directory.Read.All, User.ReadWrite.All, Directory.ReadWrite.All |

### Memberships for a group

| Permission type                        | Permissions (from least to most privileged)                                                 |
| :------------------------------------- | :------------------------------------------------------------------------------------------ |
| Delegated (work or school account)     | GroupMember.Read.All, Group.Read.All, Directory.Read.All, Group.ReadWrite.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                                                                              |
| Application                            | GroupMember.Read.All, Group.Read.All, Directory.Read.All, Group.ReadWrite.All, Directory.ReadWrite.All                             |

### Memberships for a service principal

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.Read.All, Directory.Read.All, Application.ReadWrite.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Application.Read.All, Directory.Read.All, Application.ReadWrite.All, Directory.ReadWrite.All |

### Memberships for an organizational contact

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.Read.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Directory.Read.All, Directory.ReadWrite.All |

### Memberships for a device

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Device.Read.All, Directory.Read.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Device.Read.All, Device.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |


## HTTP request

Memberships for a directory object.
<!-- { "blockType": "ignored" } -->
```http
POST /directoryObjects/{id}/getMemberObjects
```

Memberships for a user.
<!-- { "blockType": "ignored" } -->
```http
POST /me/getMemberObjects
POST /users/{id | userPrincipalName}/getMemberObjects
```

Memberships for a group.
<!-- { "blockType": "ignored" } -->
```http
POST /groups/{id}/getMemberObjects
```

Memberships for a service principal.
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/getMemberObjects
```

Memberships for an organizational contact.
<!-- { "blockType": "ignored" } -->
```http
POST /contacts/{id}/getMemberObjects
```

Memberships for a device.
<!-- { "blockType": "ignored" } -->
```http
POST /devices/{id}/getMemberObjects
```

## Request headers
| Name       | Description|
|:---------------|:--------|
| Authorization  | Bearer {token}. Required. |
| Content-Type  | application/json  |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|securityEnabledOnly|Boolean| `true` to specify that only security groups that the entity is a member of should be returned; `false` to specify that all groups, administrative units, and directory roles that the entity is a member of should be returned. |

## Response

If successful, this method returns `200 OK` response code and String collection object in the response body.

## Example

##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "directoryobject_getmemberobjects"
}-->
```http
POST https://graph.microsoft.com/beta/me/getMemberObjects
Content-type: application/json

{
  "securityEnabledOnly": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var securityEnabledOnly = true;

await graphClient.Me
	.GetMemberObjects(securityEnabledOnly)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

