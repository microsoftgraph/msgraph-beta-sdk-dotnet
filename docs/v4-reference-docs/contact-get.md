---
title: "Get contact"
description: "Retrieve the properties and relationships of contact object."
author: "kevinbellinger"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Get contact

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of contact object.

There are two scenarios where an app can get a contact in another user's contact folder:

* If the app has application permissions, or,
* If the app has the appropriate delegated [permissions](#permissions) from one user, and another user has shared a contact folder with that user, or, has given delegated access to that user. See [details and an example](/graph/outlook-get-shared-contacts-folders).


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Contacts.Read, Contacts.ReadWrite    |
|Delegated (personal Microsoft account) | Contacts.Read, Contacts.ReadWrite    |
|Application | Contacts.Read, Contacts.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
A [contact](../resources/contact.md) in the user's mailbox.
```http
GET /me/contacts/{id}
GET /users/{id | userPrincipalName}/contacts/{id}
```
A [contact](../resources/contact.md) from a top level [contactFolder](../resources/contactfolder.md) of the user's.
```http
GET /me/contactfolders/{Id}/contacts/{id}
GET /users/{id | userPrincipalName}/contactfolders/{id}/contacts/{id}
```
A [contact](../resources/contact.md) contained in a child folder of a [contactFolder](../resources/mailfolder.md).  The 
example below shows one level of nesting, but a contact can be located in a child of a child and so on.
```http
GET /me/contactFolders/{id}/childFolders/{id}/.../contacts/{id}
GET /users/{id | userPrincipalName}/contactFolders/{id}/childFolders/{id}/contacts/{id}
```
## Optional query parameters
|Name|Value|Description|
|:---------------|:--------|:-------|
|$expand|string|Comma-separated list of relationships to expand and include in the response. See relationships table of [contact](../resources/contact.md) object for supported names. |
|$select|string|Comma-separated list of properties to include in the response.|

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and [contact](../resources/contact.md) object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_contact",
  "sampleKeys": ["AAMkAGI2THk0AAA="]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/contacts/AAMkAGI2THk0AAA=
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contact = await graphClient.Me.Contacts["{contact-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

