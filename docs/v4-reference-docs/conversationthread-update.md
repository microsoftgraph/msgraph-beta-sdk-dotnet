---
title: "Update conversationthread"
description: "Lock or unlock a thread, to allow or avoid further posting to the thread."
ms.localizationpriority: medium
author: "dkershaw10"
ms.prod: "groups"
doc_type: apiPageType
---

# Update conversationthread

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Lock or unlock a thread, to allow or avoid further posting to the thread.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Group.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /groups/{group id}/threads/{thread id}
PATCH /groups/{group id}/conversations/{conversation id}/threads/{thread id}

```
## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|isLocked|Boolean|Indicates if the thread is locked. Set to `true` to disallow posting.|

## Response

If successful, this method returns a `200 OK` response code and an empty object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "ignored",
  "name": "update_conversationthread"
}-->
```http
PATCH https://graph.microsoft.com/beta/groups/0fbf2921-5d17-4c2b-bae4-cc581de72c13/threads/AAQkAGU3OGZjZTE2LTFlOWItNGExYi1hMGMzLTMwZWU4OGUzYjU5MQMkABAALmW2hn6Ui0_7hOBeAIFdWhAALmW2hn6Ui0_7hOBeAIFdWg==
Content-type: application/json

{
  "isLocked": true
}
```
# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conversationThread = new ConversationThread
{
	IsLocked = true
};

await graphClient.Groups["{group-id}"].Threads["{conversationThread-id}"]
	.Request()
	.UpdateAsync(conversationThread);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

