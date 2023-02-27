---
title: "Create Contact"
description: "Add a contact to the root Contacts folder or to the `contacts` endpoint of another contact folder."
author: "kevinbellinger"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create Contact

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a contact to the root Contacts folder or to the `contacts` endpoint of another contact folder.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Contacts.ReadWrite    |
|Delegated (personal Microsoft account) | Contacts.ReadWrite    |
|Application | Contacts.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/contacts
POST /users/{id | userPrincipalName}/contacts

POST /me/contactFolders/{id}/contacts
POST /users/{id | userPrincipalName}/contactFolders/{id}/contacts
```

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
In the request body, supply a JSON representation of [Contact](../resources/contact.md) object.

## Response

If successful, this method returns `201 Created` response code and [Contact](../resources/contact.md) object in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_contact_from_contactfolder"
}-->
```http
POST https://graph.microsoft.com/beta/me/contactFolders/{id}/contacts
Content-type: application/json

{
  "parentFolderId": "parentFolderId-value",
  "birthday": "2016-10-19T10:37:00Z",
  "fileAs": "fileAs-value",
  "displayName": "displayName-value",
  "givenName": "givenName-value",
  "initials": "initials-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contact = new Contact
{
	ParentFolderId = "parentFolderId-value",
	Birthday = DateTimeOffset.Parse("2016-10-19T10:37:00Z"),
	FileAs = "fileAs-value",
	DisplayName = "displayName-value",
	GivenName = "givenName-value",
	Initials = "initials-value"
};

await graphClient.Me.ContactFolders["{contactFolder-id}"].Contacts
	.Request()
	.AddAsync(contact);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

