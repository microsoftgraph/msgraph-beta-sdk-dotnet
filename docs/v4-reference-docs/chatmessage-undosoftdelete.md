---
title: "chatMessage: undoSoftDelete"
description: "Undelete a single message or a message reply in a channel or a chat."
author: "RamjotSingh"
ms.prod: "microsoft-teams"
doc_type: apiPageType
ms.localizationpriority: medium
---

# chatMessage: undoSoftDelete

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Undo soft deletion of a single [message](../resources/chatmessage.md) or a [message reply](../resources/chatmessage.md) in a [channel](../resources/channel.md) or a [chat](../resources/chat.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Permissions for channel

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
|Delegated (work or school account)| ChannelMessage.ReadWrite |
|Delegated (personal Microsoft account)| Not supported |
|Application| Not supported |

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

### Permissions for chat

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
|Delegated (work or school account)| Chat.ReadWrite |
|Delegated (personal Microsoft account)| Not supported |
|Application| Not supported |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /users/{userId}/chats/{chatsId}/messages/{chatMessageId}/undoSoftDelete
POST /teams/{teamsId}/channels/{channelId}/messages/{chatMessageId}/undoSoftDelete
POST /teams/{teamId}/channels/{channelId}/messages/{messageId}/replies/{replyId}/undoSoftDelete
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Example 1: Undo soft deletion of a message in a chat

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chatmessagethis-undosoftdelete1",
  "samplekeys": ["8f98f01d-1a73-401a-b9e9-9fd1e6f5e5ap", "19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2", "1649864053377"]
}
-->
``` http
POST https://graph.microsoft.com/beta/users/8f98f01d-1a73-401a-b9e9-9fd1e6f5e5ap/chats/19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2/messages/1649864053377/undoSoftDelete
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Users["{user-id}"].Chats["{chat-id}"].Messages["{chatMessage-id}"]
	.UndoSoftDelete()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

``` http
HTTP/1.1 204 No Content
```

### Example 2: Undo soft deletion of a message in a channel

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chatmessagethis2undosoftdelete2",
  "sampleKeys": ["172b0cce-e65d-44ce-9a49-91d9f2e8593a", "19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2", "1649864053377"]
}
-->
``` http
POST https://graph.microsoft.com/beta/teams/172b0cce-e65d-44ce-9a49-91d9f2e8593a/channels/19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2/messages/1649864053377/undoSoftDelete
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.UndoSoftDelete()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

``` http
HTTP/1.1 204 No Content
```

### Example 3: Undo soft deletion of a message of a reply in a channel

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chatmessagethis-undosoftdelete3",
  "sampleKeys": ["172b0cce-e65d-44ce-9a49-91d9f2e8593a", "19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2", "1649864053377"]
}
-->
``` http
POST https://graph.microsoft.com/beta/teams/172b0cce-e65d-44ce-9a49-91d9f2e8593a/channels/19:22273db3497f4b32bue61f6e82be21c5@thread.tacv2/messages/1649864053377/undoSoftDelete
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.UndoSoftDelete()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

``` http
HTTP/1.1 204 No Content
```
