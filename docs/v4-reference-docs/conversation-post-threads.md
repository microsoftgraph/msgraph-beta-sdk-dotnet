---
title: "Create thread"
description: "Create a new thread in the specified conversation."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# Create thread

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new thread in the specified conversation.

A thread and post are created as specified. Use [reply thread](conversationthread-reply.md) to further post
to that thread. Or, if you get the post ID, you can also [reply](post-reply.md) to that post in that thread.

Note: You can also [start a new conversation by first creating a thread](group-post-threads.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /groups/{id}/conversations/{id}/threads
```
## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body
In the request body, supply a JSON representation of the [conversationThread](../resources/conversationthread.md) object.

## Response

If successful, this method returns `201 Created` response code and a [conversationThread](../resources/conversationthread.md) object in the response body.

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_conversationthread_from_conversation",
  "sampleKeys": ["4d81ce71-486c-41e9-afc5-e41bf2d0722a", "AAQkAGRhZmRhMWM3LTYwZTktNDZmYy1hNWU1LThhZWU4NzI2YTEyZgAQABKPPJ682apIiV1UFlj7XxY="]
}-->
```msgraph-interactive
}-->
```http
POST https://graph.microsoft.com/beta/groups/4d81ce71-486c-41e9-afc5-e41bf2d0722a/conversations/AAQkAGRhZmRhMWM3LTYwZTktNDZmYy1hNWU1LThhZWU4NzI2YTEyZgAQABKPPJ682apIiV1UFlj7XxY=/threads
Content-type: application/json

{
    "topic": "Take your wellness days and rest",
    "posts": [
        {
            "body": {
                "contentType": "html",
                "content": "Waiting for the summer holidays."
            }
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conversationThread = new ConversationThread
{
	Topic = "Take your wellness days and rest",
	Posts = new ConversationThreadPostsCollectionPage()
	{
		new Post
		{
			Body = new ItemBody
			{
				ContentType = BodyType.Html,
				Content = "Waiting for the summer holidays."
			}
		}
	}
};

await graphClient.Groups["{group-id}"].Conversations["{conversation-id}"].Threads
	.Request()
	.AddAsync(conversationThread);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

If successful, this method returns `201 Created` response code and the `id` of the new thread in the response body.

The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.conversationThread"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#groups('4d81ce71-486c-41e9-afc5-e41bf2d0722a')/conversations('AAQkAGRhZmRhMWM3LTYwZTktNDZmYy1hNWU1LThhZWU4NzI2YTEyZgAQABKPPJ682apIiV1UFlj7XxY%3D')/threads/$entity",
    "id": "AAQkAGRhZmRhMWM3LTYwZTktNDZmYy1hNWU1LThhZWU4NzI2YTEyZgMkABAAMgNmxDXX0UO0DI-I807i0hAAMgNmxDXX0UO0DI-I807i0g=="
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create thread",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


