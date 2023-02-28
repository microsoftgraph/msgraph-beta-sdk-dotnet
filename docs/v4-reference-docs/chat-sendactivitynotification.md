---
title: "chat: sendActivityNotification"
description: Send an activity feed notification in scope of a chat.
author: RamjotSingh
ms.localizationpriority: medium
ms.prod: microsoft-teams
doc_type: apiPageType
---

# chat: sendActivityNotification
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Send an activity feed notification in scope of a chat. For more details about sending notifications and the requirements for doing so, see [sending Teams activity notifications](/graph/teams-send-activityfeednotifications).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|TeamsActivity.Send|
|Delegated (personal Microsoft account)|Not supported.|
|Application|TeamsActivity.Send.Chat*, TeamsActivity.Send|

>**Note:** Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /chats/{chatId}/sendActivityNotification
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|topic|[teamworkActivityTopic](../resources/teamworkactivitytopic.md)|Topic of the notification. Specifies the resource being talked about.|
|activityType|String|Activity type. This must be declared in the [Teams app manifest](/microsoftteams/platform/overview).|
|chainId|Int64|Optional. Used to override a previous notification. Use the same `chainId` in subsequent requests to override the previous notification.|
|previewText|[itemBody](../resources/itembody.md)|Preview text for the notification. Microsoft Teams will only show first 150 characters.|
|templateParameters|[keyValuePair](../resources/keyvaluepair.md) collection|Values for template variables defined in the activity feed entry corresponding to `activityType` in [Teams app manifest](/microsoftteams/platform/overview).|
|recipient|[teamworkNotificationRecipient](../resources/teamworknotificationrecipient.md)|Recipient of the notification. For more details, see [aadUserNotificationRecipient](../resources/aadusernotificationrecipient.md) and [chatMembersNotificationRecipient](../resources/chatmembersnotificationrecipient.md). |

The following resources are supported when setting the `source` value of the **topic** property to `entityURL`:

- [chat](../resources/chat.md)
- [chatMessage](../resources/chatmessage.md)

> **Note:** The entity URL must be the same as or a child resource of the chat in the URL. Additionally, the [Teams app](/microsoftteams/platform/overview) must be installed in the chat.

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Example 1: Notify a user about a task created in a chat

The following example shows how you can send an activity feed notification for a new task created in a chat. For more details, see [sending Teams activity notifications](/graph/teams-send-activityfeednotifications).

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chat_sendactivitynotification_1"
}
-->
``` http
POST https://graph.microsoft.com/beta/chats/{chatId}/sendActivityNotification
Content-Type: application/json

{
    "topic": {
        "source": "entityUrl",
        "value": "https://graph.microsoft.com/beta/chats/{chatId}"
    },
    "activityType": "taskCreated",
    "previewText": {
        "content": "New Task Created"
    },
    "recipient": {
        "@odata.type": "microsoft.graph.aadUserNotificationRecipient",
        "userId": "569363e2-4e49-4661-87f2-16f245c5d66a"
    },
    "templateParameters": [
        {
            "name": "taskId",
            "value": "Task 12322"
        }
    ] 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var topic = new TeamworkActivityTopic
{
	Source = TeamworkActivityTopicSource.EntityUrl,
	Value = "https://graph.microsoft.com/beta/chats/{chatId}"
};

var activityType = "taskCreated";

var previewText = new ItemBody
{
	Content = "New Task Created"
};

var recipient = new AadUserNotificationRecipient
{
	UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
};

var templateParameters = new List<KeyValuePair>()
{
	new KeyValuePair
	{
		Name = "taskId",
		Value = "Task 12322"
	}
};

await graphClient.Chats["{chat-id}"]
	.SendActivityNotification(topic,activityType,null,previewText,templateParameters,recipient)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": false
}
-->
``` http
HTTP/1.1 204 No Content
```

### Example 2: Notify a user about an approval needed in a chat message

Similar to the previous example, this example uses `entityUrl` for the `topic`. However, in this case, it links to a message in the chat. The message can contains a card with the approval button on it.

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chat_sendactivitynotification_2"
}
-->
``` http
POST https://graph.microsoft.com/beta/chats/{chatId}/sendActivityNotification
Content-Type: application/json

{
    "topic": {
        "source": "entityUrl",
        "value": "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
    },
    "activityType": "approvalRequired",
    "previewText": {
        "content": "Deployment requires your approval"
    },
    "recipient": {
        "@odata.type": "microsoft.graph.aadUserNotificationRecipient",
        "userId": "569363e2-4e49-4661-87f2-16f245c5d66a"
    },
    "templateParameters": [
        {
            "name": "approvalTaskId",
            "value": "2020AAGGTAPP"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var topic = new TeamworkActivityTopic
{
	Source = TeamworkActivityTopicSource.EntityUrl,
	Value = "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
};

var activityType = "approvalRequired";

var previewText = new ItemBody
{
	Content = "Deployment requires your approval"
};

var recipient = new AadUserNotificationRecipient
{
	UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
};

var templateParameters = new List<KeyValuePair>()
{
	new KeyValuePair
	{
		Name = "approvalTaskId",
		Value = "2020AAGGTAPP"
	}
};

await graphClient.Chats["{chat-id}"]
	.SendActivityNotification(topic,activityType,null,previewText,templateParameters,recipient)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": false
}
-->
``` http
HTTP/1.1 204 No Content
```

### Example 3: Notify a user about an approval needed in a chat message using user principal name

Similar to the previous example, this example uses `entityUrl` for the `topic`. However, in this case, it links to a message in the chat. The message can contains a card with the approval button on it.

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chat_sendactivitynotification_upn"
}
-->
``` http
POST https://graph.microsoft.com/beta/chats/{chatId}/sendActivityNotification
Content-Type: application/json

{
    "topic": {
        "source": "entityUrl",
        "value": "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
    },
    "activityType": "approvalRequired",
    "previewText": {
        "content": "Deployment requires your approval"
    },
    "recipient": {
        "@odata.type": "microsoft.graph.aadUserNotificationRecipient",
        "userId": "jacob@contoso.com"
    },
    "templateParameters": [
        {
            "name": "approvalTaskId",
            "value": "2020AAGGTAPP"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var topic = new TeamworkActivityTopic
{
	Source = TeamworkActivityTopicSource.EntityUrl,
	Value = "https://graph.microsoft.com/beta/chats/{chatId}/messages/{messageId}"
};

var activityType = "approvalRequired";

var previewText = new ItemBody
{
	Content = "Deployment requires your approval"
};

var recipient = new AadUserNotificationRecipient
{
	UserId = "jacob@contoso.com"
};

var templateParameters = new List<KeyValuePair>()
{
	new KeyValuePair
	{
		Name = "approvalTaskId",
		Value = "2020AAGGTAPP"
	}
};

await graphClient.Chats["{chat-id}"]
	.SendActivityNotification(topic,activityType,null,previewText,templateParameters,recipient)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": false
}
-->
``` http
HTTP/1.1 204 No Content
```

### Example 4: Notify a user about an event in relation to a chat

As shown in the previous examples, you can link to different aspects of the chat. However, if you want to link to an aspect that is not part of the chat, or is not represented by Microsoft Graph, you can set the source of the `topic` to `text` and pass in a custom value for it. Also, `webUrl` is required when setting `topic` source to `text`.

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chat_sendactivitynotification_3"
}
-->
``` http
POST https://graph.microsoft.com/beta/chats/{chatId}/sendActivityNotification
Content-Type: application/json

{
    "topic": {
        "source": "text",
        "value": "Deployment Approvals Channel",
        "webUrl": "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
    },
    "activityType": "deploymentApprovalRequired",
    "previewText": {
        "content": "New deployment requires your approval"
    },
    "recipient": {
        "@odata.type": "microsoft.graph.aadUserNotificationRecipient",
        "userId": "569363e2-4e49-4661-87f2-16f245c5d66a"
    },
    "templateParameters": [
        {
            "name": "deploymentId",
            "value": "6788662"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var topic = new TeamworkActivityTopic
{
	Source = TeamworkActivityTopicSource.Text,
	Value = "Deployment Approvals Channel",
	WebUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
};

var activityType = "deploymentApprovalRequired";

var previewText = new ItemBody
{
	Content = "New deployment requires your approval"
};

var recipient = new AadUserNotificationRecipient
{
	UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
};

var templateParameters = new List<KeyValuePair>()
{
	new KeyValuePair
	{
		Name = "deploymentId",
		Value = "6788662"
	}
};

await graphClient.Chats["{chat-id}"]
	.SendActivityNotification(topic,activityType,null,previewText,templateParameters,recipient)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": false
}
-->
``` http
HTTP/1.1 204 No Content
```

### Example 5: Notify the chat members about a task created in a chat

The following example shows how you can send an activity feed notification to all chat members. This example is similar to previous examples. However, in this case, the **recipient** is a [chatMembersNotificationRecipient](../resources/chatmembersnotificationrecipient.md). Note that the **chatId** specified in the **recipient** must match the **chatId** specified in the request URL.

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chat_sendactivitynotification_5",
  "sampleKeys": ["19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"]
}
-->

``` http
POST https://graph.microsoft.com/beta/chats/19:1c3af46e9e0f4a5293343c8813c47619@thread.v2/sendActivityNotification
Content-Type: application/json

{
    "topic": {
        "source": "entityUrl",
        "value": "https://graph.microsoft.com/beta/chats/19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
    },
    "activityType": "taskCreated",
    "previewText": {
        "content": "New Task Created"
    },
    "recipient": {
        "@odata.type": "microsoft.graph.chatMembersNotificationRecipient",
        "chatId": "19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
    },
    "templateParameters": [
        {
            "name": "taskId",
            "value": "Task 12322"
        }
    ] 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var topic = new TeamworkActivityTopic
{
	Source = TeamworkActivityTopicSource.EntityUrl,
	Value = "https://graph.microsoft.com/beta/chats/19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
};

var activityType = "taskCreated";

var previewText = new ItemBody
{
	Content = "New Task Created"
};

var recipient = new ChatMembersNotificationRecipient
{
	ChatId = "19:1c3af46e9e0f4a5293343c8813c47619@thread.v2"
};

var templateParameters = new List<KeyValuePair>()
{
	new KeyValuePair
	{
		Name = "taskId",
		Value = "Task 12322"
	}
};

await graphClient.Chats["{chat-id}"]
	.SendActivityNotification(topic,activityType,null,previewText,templateParameters,recipient)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": false
}
-->
``` http
HTTP/1.1 204 No Content
```
