---
title: "List conversations"
description: "Retrieve the list of conversations in this group."
author: "psaffaie"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# List conversations

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the list of [conversations](../resources/conversation.md) in this group.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Group.Read.All, Group.ReadWrite.All         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Group.Read.All, Group.ReadWrite.All         |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /groups/{id}/conversations
```

## Optional query parameters

This method supports the `$select` and `$filter` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [conversation](../resources/conversation.md) objects in the response body.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "get_conversations"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/groups/{id}/conversations
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conversations = await graphClient.Groups["{group-id}"].Conversations
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.conversation",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#groups('f448435d-3ca7-4073-8152-a1fd73c0fd09')/conversations",
    "value": [
        {
            "id": "AAQkAGFhZDhkNGI1LTliZmEtNGEzMi04NTkzLWZjMWExZDkyMWEyZgAQAH4o7SknOTNKqAqMhqJHtUM=",
            "topic": "The new All Company group is ready",
            "hasAttachments": false,
            "lastDeliveredDateTime": "2021-08-02T10:34:00Z",
            "uniqueSenders": [
                "All Company"
            ],
            "preview": "Welcome to the All Company group.Use the group to share ideas, files, and important dates.Start a conversationRead group conversations or start your own.Share filesView, edit, and share all group files, including email attachments.Connect your"
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List conversations",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
