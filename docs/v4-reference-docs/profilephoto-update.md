---
title: "Update profilephoto"
description: "Update the photo for any user in the tenant including the signed-in user, or the specified group or contact or team."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "people"
author: "kevinbellinger"
---

# Update profilephoto

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the photo for the specified contact, group, team, or user in a tenant. The size of the photo you can update to must be under 8MB.

Only use PUT for this operation.

> **Note**:  When updating the **user** photo, this operation first attempts to update the photo in Microsoft 365. If that fails (due to the user not having a mailbox), this API will attempt to update the photo in Azure Active Directory.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### To update the profile photo of a contact

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)      |   Contacts.ReadWrite           |
|Delegated (personal Microsoft account)      |   Not supported.            |
|Application      |    Contacts.ReadWrite           |

### To update the profile photo of a group

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)      |   Group.ReadWrite.All           |
|Delegated (personal Microsoft account)      |   Not supported.            |
|Application      |    Group.ReadWrite.All           |

### To update the profile photo of a team

| Permission type                        | Permissions (from least to most privileged)                            |
|:---------------------------------------|:-----------------------------------------------------------------------|
| Delegated (work or school account)     | TeamSettings.ReadWrite.All, Group.ReadWrite.All**, Directory.ReadWrite.All** |
| Delegated (personal Microsoft account) | Not supported.                                                         |
| Application                            | Not supported.                                                         |


<!-- markdownlint-disable MD041-->


> **Note**:
> - Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).
> - Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.
### To update the profile photo of the signed-in user

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)      |   User.ReadWrite, User.ReadWrite.All           |
|Delegated (personal Microsoft account)      |   Not supported.            |
|Application      |    User.ReadWrite.All           |

> [!NOTE]
> 1. To update the photo of any user in the organization, your app must have the *User.ReadWrite.All* application permission and call this API under its own identity, not on behalf of a user. To learn more, see [get access without a signed-in user](/graph/auth-v2-service). Updating the photo of the signed-in user only requires *User.ReadWrite* permission.
> 2. There is currently a [known issue](/graph/known-issues#groups) with accessing group photos using application permissions.
> 3. Updating a user's photo using the Microsoft Graph API is currently not supported in Azure AD B2C tenants.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PUT /me/photo/$value
PUT /users/{id | userPrincipalName}/photo/$value
PUT /groups/{id}/photo/$value
PUT /me/contacts/{id}/photo/$value
PUT /users/{id | userPrincipalName}/contacts/{id}/photo/$value
PUT /me/contactfolders/{contactFolderId}/contacts/{id}/photo/$value
PUT /users/{id | userPrincipalName}/contactfolders/{contactFolderId}/contacts/{id}/photo/$value
```

To update the photo for a team:

<!-- { "blockType": "ignored" } -->

```http
PUT /groups/{teamId}/photo/$value
```

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | image/jpeg. Required.  |

## Request body
In the request body, include the binary data of the photo in the request body.

## Response

If successful, this method returns a `200 OK` response code or a `204 No Content` response code for updating the photo of a team.

## Examples
### Example 1: Update the profile photo of the user
#### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_profilephoto"
}-->
```http
PUT https://graph.microsoft.com/beta/me/photo/$value
Content-type: image/jpeg

Binary data for the image

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

using var stream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(@"Binary data for the image"));

await graphClient.Me.Photo.Content
	.Request()
	.PutAsync(stream);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response. 

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 200 OK
```

### Example 2: Update the photo of a team

#### Request
The following is an example of a request to update a team photo.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_team_photo"
}-->
```http
PUT https://graph.microsoft.com/beta/teams/172b0cce-e65d-44ce-9a49-91d9f2e8491e/photo/$value
Content-type: image/jpeg

Binary data for the image
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

using var stream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(@"Binary data for the image"));

await graphClient.Teams["{team-id}"].Photo.Content
	.Request()
	.PutAsync(stream);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

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
  "description": "Update profilephoto",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
