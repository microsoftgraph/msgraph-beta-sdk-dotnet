---
title: "Pin a message in a chat"
description: "Pin a chat message in the specified chat."
author: "sumanac"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Pin a message in a chat
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Pin a chat message in the specified [chat](../resources/chat.md). This API cannot create a new chat; you must use the [list chats](chat-list.md) method to retrieve the ID of an existing chat before you can pin a chat message.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
| Delegated (work or school account)     | ChatMessage.Send, Chat.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Chat.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /chats/{chat-Id}/pinnedMessages
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply the ID of a chat message to pin.

## Response

If successful, this method returns a `201 Created` response code and a [pinnedChatMessageInfo](../resources/pinnedchatmessageinfo.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_pinnedchatmessageinfo_from_",
  "sampleKeys": ["19:2da4c29f6d7041eca70b638b43d45437@thread.v2"]
}
-->
``` http
POST https://graph.microsoft.com/beta/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/pinnedMessages
Content-Type: application/json
Content-length: 63

{
   "message@odata.bind":"https://graph.microsoft.com/beta/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/messages/1616964509832"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var pinnedChatMessageInfo = new PinnedChatMessageInfo
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"message@odata.bind", "https://graph.microsoft.com/beta/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/messages/1616964509832"}
	}
};

await graphClient.Chats["{chat-id}"].PinnedMessages
	.Request()
	.AddAsync(pinnedChatMessageInfo);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.pinnedChatMessageInfo"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.pinnedChatMessageInfo",
  "id": "1616964509832"
}
```
