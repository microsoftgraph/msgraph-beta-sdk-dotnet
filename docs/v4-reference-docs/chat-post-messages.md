---
title: "Send message in a chat"
description: "Send a new message in a chat."
ms.localizationpriority: medium
author: "RamjotSingh"
ms.prod: "microsoft-teams"
doc_type: "apiPageType"
---

# Send message in a chat

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Send a new [chatMessage](../resources/chatmessage.md) in the specified [chat](../resources/chat.md). This API cannot create a new chat; you must use the [list chats](chat-list.md) method to retrieve the ID of an existing chat before creating a chat message.

> **Note**: We don't recommend that you use this API for data migration. It does not have the throughput necessary for a typical migration.

> **Note**: It is a violation of the [terms of use](/legal/microsoft-apis/terms-of-use) to use Microsoft Teams as a log file. Only send messages that people will read.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ChatMessage.Send, Chat.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /chats/{chat-id}/messages
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {code}. Required. |

## Request body

In the request body, supply a JSON representation of a [chatMessage](../resources/chatmessage.md) object.

## Response

If successful, this method returns a `201 Created` response code and a new [chatMessage](../resources/chatmessage.md) object in the response body.

## Examples

For a more comprehensive list of examples, see [Create chatMessage in a channel or a chat](chatmessage-post.md).

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_chatmessages_1",
  "sampleKeys": ["19:2da4c29f6d7041eca70b638b43d45437@thread.v2"]
}-->
```http
POST https://graph.microsoft.com/beta/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/messages
Content-type: application/json

{
  "body": {
     "content": "Hello world"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	Body = new ItemBody
	{
		Content = "Hello world"
	}
};

await graphClient.Chats["{chat-id}"].Messages
	.Request()
	.AddAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.chatMessage"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#chats('19%3A2da4c29f6d7041eca70b638b43d45437%40thread.v2')/messages/$entity",
    "id": "1616991463150",
    "replyToId": null,
    "etag": "1616991463150",
    "messageType": "message",
    "createdDateTime": "2021-03-29T04:17:43.15Z",
    "lastModifiedDateTime": "2021-03-29T04:17:43.15Z",
    "lastEditedDateTime": null,
    "deletedDateTime": null,
    "subject": null,
    "summary": null,
    "chatId": "19:2da4c29f6d7041eca70b638b43d45437@thread.v2",
    "importance": "normal",
    "locale": "en-us",
    "webUrl": null,
    "channelIdentity": null,
    "onBehalfOf": null,
    "policyViolation": null,
    "eventDetail": null,
    "from": {
        "application": null,
        "device": null,
        "conversation": null,
        "user": {
            "id": "8ea0e38b-efb3-4757-924a-5f94061cf8c2",
            "displayName": "Robin Kline",
            "userIdentityType": "aadUser"
        }
    },
    "body": {
        "contentType": "text",
        "content": "Hello World"
    },
    "attachments": [],
    "mentions": [],
    "reactions": [],
    "messageHistory": []
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create chatMessage",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->
