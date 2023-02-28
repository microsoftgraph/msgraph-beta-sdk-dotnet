---
title: "Create acceptedSender"
description: "Add a new user or group to the acceptedSender list."
author: "psaffaie"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# Create acceptedSender

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a new user or group to the acceptedSender list.

Specify the user or group in `@odata.id` in the request body. Users in the accepted senders list can post to conversations of the group . Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Group.ReadWrite.All                         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Not supported.                              |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groups/{id}/acceptedSenders/$ref
```

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply the id of a user or group object.

## Response

This method returns `204 No Content` response code and no response body.

## Example

#### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "create_acceptedsender"
}-->

```http
POST https://graph.microsoft.com/beta/groups/{id}/acceptedSenders/$ref
Content-type: application/json

{
  "@odata.id":"https://graph.microsoft.com/beta/users/alexd@contoso.com"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryObject = new DirectoryObject
{
	Id = "alexd@contoso.com"
};

await graphClient.Groups["{group-id}"].AcceptedSenders.References
	.Request()
	.AddAsync(directoryObject);

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
  "description": "Create acceptedSender",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
