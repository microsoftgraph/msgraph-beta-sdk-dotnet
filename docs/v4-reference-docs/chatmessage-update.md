---
title: "Update chatMessage"
description: "Update the properties of a chatMessage object."
author: "RamjotSingh"
doc_type: apiPageType
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
---

# Update chatMessage

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.


Update a [chatMessage](../resources/chatMessage.md) object. 

All properties of a **chatMessage** can be updated in delegated permissions scenarios, 
except for read-only properties and the **policyViolation** property.
Only the **policyViolation** property of a **chatMessage** can be updated in application permissions scenarios.

The update only works for chats where members are Microsoft Teams users. If one of the participants is using Skype, the operation will fail.

This method does not support federation. Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.


>**Note**: 
> This API has [licensing and payment requirements](/graph/teams-licenses).
> It supports the `model=A` query parameter.
> If no model is specified, [evaluation mode](/graph/teams-licenses#evaluation-mode-default-requirements) will be used.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Permissions for channel
| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ChannelMessage.ReadWrite, Group.ReadWrite.All** |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ChannelMessage.UpdatePolicyViolation.All, ChannelMessage.ReadWrite.All, Group.ReadWrite.All** |

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

### Permissions for chat
| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Chat.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Chat.UpdatePolicyViolation.All, Chat.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /teams/(team-id)/channels/{channel-id}/messages/{message-id}
PATCH /teams/(team-id)/channels/{channel-id}/messages/{message-id}/replies/{reply-id}
PATCH /chats/{chatThread-id}/messages/{message-id}
```

## Optional query parameters

You can use `model` query parameter, which only supports the value `A`, as shown in the following examples.

```http
PATCH /teams/(team-id)/channels/{channel-id}/messages/{message-id}?model=A
PATCH /teams/(team-id)/channels/{channel-id}/messages/{message-id}/replies/{reply-id}?model=A
PATCH /chats/{chatThread-id}/messages/{message-id}?model=A
```
If no `model` is specified, [evaluation mode](/graph/teams-licenses#evaluation-mode-default-requirements) will be used. 

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization  | Bearer {token}. Required. |
| Content-Type | application/json. Required. |

## Request body
For applications that use delegated permissions:
In the request body, supply a JSON representation of a [chatMessage](../resources/chatMessage.md) object, 
specifying the properties that need to be changed.

For applications that use application permissions:
In the request body, supply a JSON representation of a [chatMessage](../resources/chatMessage.md) object, 
specifying only the **policyViolation** property.

## Response body
For applications that use delegated permissions:
If successful, this method returns a `204 No Content` response.

For applications that use application permissions:
If successful, this method returns a `200 OK` response.

## Examples

### Example 1: Update policyViolation using application permissions

#### Request

The following is an example of the request to update the **policyViolation** property on a Microsoft Teams channel message by using application permissions.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "chatMessage.PatchPolicyViolation.All",
  "sampleKeys": ["e1234567-e123-4276-55555-6232b0e3a89a", "a7654321-e321-0000-0000-123b0e3a00a", "19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype"]
}-->
```http
PATCH https://graph.microsoft.com/beta/teams/e1234567-e123-4276-55555-6232b0e3a89a/channels/a7654321-e321-0000-0000-123b0e3a00a/messages/19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype
Content-Type: application/json

{
  "policyViolation": {
    "policyTip": {
      "generalText" : "This item has been blocked by the administrator.",
      "complianceUrl" : "https://contoso.com/dlp-policy-page",
      "matchedConditionDescriptions" : ["Credit Card Number"]
    },
    "verdictDetails" : "AllowOverrideWithoutJustification,AllowFalsePositiveOverride",
    "dlpAction" : "BlockAccess"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	PolicyViolation = new ChatMessagePolicyViolation
	{
		PolicyTip = new ChatMessagePolicyViolationPolicyTip
		{
			GeneralText = "This item has been blocked by the administrator.",
			ComplianceUrl = "https://contoso.com/dlp-policy-page",
			MatchedConditionDescriptions = new List<String>()
			{
				"Credit Card Number"
			}
		},
		VerdictDetails = ChatMessagePolicyViolationVerdictDetailsTypes.AllowFalsePositiveOverride | ChatMessagePolicyViolationVerdictDetailsTypes.AllowOverrideWithoutJustification,
		DlpAction = ChatMessagePolicyViolationDlpActionTypes.BlockAccess
	}
};

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.Request()
	.UpdateAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.

<!-- {
  "blockType": "response",
} -->

```http
HTTP/1.1 200 OK
```
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "chatMessage.UpdatePolicyViolation.All",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


### Example 2: Update any property of a message using delegated permissions

#### Request

The following is an example of the request to update the properties on a Microsoft Teams channel message by using delegated permissions.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_chatMessage_1",
  "sampleKeys": ["e1234567-e123-4276-55555-6232b0e3a89a", "a7654321-e321-0000-0000-123b0e3a00a", "19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype"]
}-->

```http
PATCH https://graph.microsoft.com/beta/teams/e1234567-e123-4276-55555-6232b0e3a89a/channels/a7654321-e321-0000-0000-123b0e3a00a/messages/19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype
Content-Type: application/json

{
  "messageType": "message",
  "subject": null,
  "summary": null,
  "importance": "normal",
  "locale": "en-us",
  "from": {
    "application": null,
    "device": null,
    "user": {
      "id": "3b102402-813e-4e17-a6b2-f841aef1fdfc",
      "displayName": "Sumit Gupta",
      "userIdentityType": "aadUser"
    },
    "conversation": null
  },
  "body": {
    "contentType": "text",
    "content": "Edit text only"
  },
  "attachments": [],
  "mentions": [],
  "reactions": [],
  "messageHistory": []
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	MessageType = ChatMessageType.Message,
	Subject = null,
	Summary = null,
	Importance = ChatMessageImportance.Normal,
	Locale = "en-us",
	From = new ChatMessageFromIdentitySet
	{
		Application = null,
		Device = null,
		User = new Identity
		{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc",
			DisplayName = "Sumit Gupta",
			UserIdentityType = TeamworkUserIdentityType.AadUser
		},
		AdditionalData = new Dictionary<string, object>()
		{
			{"conversation", "null"}
		}
	},
	Body = new ItemBody
	{
		ContentType = BodyType.Text,
		Content = "Edit text only"
	},
	Attachments = new List<ChatMessageAttachment>()
	{
	},
	Mentions = new List<ChatMessageMention>()
	{
	},
	Reactions = new List<ChatMessageReaction>()
	{
	},
	MessageHistory = new List<ChatMessageHistoryItem>()
	{
	}
};

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.Request()
	.UpdateAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.

<!-- {
  "blockType": "response",
} -->

```http
HTTP/1.1 204 NoContent
```

### Example 3: Update the mentions of a message using delegated permissions
#### Request

The following is an example of the request to update the mentions on a Microsoft Teams channel message by using delegated permissions.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_chatMessage_2",
  "sampleKeys": ["e1234567-e123-4276-55555-6232b0e3a89a", "a7654321-e321-0000-0000-123b0e3a00a", "19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype"]
}-->

```http
PATCH https://graph.microsoft.com/beta/teams/e1234567-e123-4276-55555-6232b0e3a89a/channels/a7654321-e321-0000-0000-123b0e3a00a/messages/19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype
Content-Type: application/json

{
  "messageType": "message",
  "deletedDateTime": null,
  "subject": null,
  "summary": null,
  "importance": "normal",
  "locale": "en-us",
  "from": {
    "application": null,
    "device": null,
    "conversation": null,
    "user": {
      "id": "6b3f3c54-d09c-4fdd-b146-9b514a8a4f40",
      "displayName": "Sumit Gupta",
      "userIdentityType": "aadUser"
    }
  },
  "body": {
    "contentType": "html",
    "content": "<div><div>\n<div>\n<div>\n<div>\n<div><at id=\"0\">Raghav</at><at id=\"1\">TestGlobalBot</at> YEAH"
  },
  "attachments": [],
  "mentions": [
    {
      "id": 0,
      "mentionText": "Raghav",
      "mentioned": {
        "application": null,
        "device": null,
        "conversation": null,
        "user": {
          "id": "f1b66449-b46d-49b0-9c3c-53c10234c818e",
          "displayName": "Raghav Mankad",
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "id": 1,
      "mentionText": "TestGlobalBot",
      "mentioned": {
        "application": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": "TestGlobalBot",
          "applicationIdentityType": "bot"
        },
        "device": null,
        "conversation": null,
        "user": null
      }
    }
  ],
  "reactions": [],
  "messageHistory": []
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	MessageType = ChatMessageType.Message,
	DeletedDateTime = null,
	Subject = null,
	Summary = null,
	Importance = ChatMessageImportance.Normal,
	Locale = "en-us",
	From = new ChatMessageFromIdentitySet
	{
		Application = null,
		Device = null,
		User = new Identity
		{
			Id = "6b3f3c54-d09c-4fdd-b146-9b514a8a4f40",
			DisplayName = "Sumit Gupta",
			UserIdentityType = TeamworkUserIdentityType.AadUser
		},
		AdditionalData = new Dictionary<string, object>()
		{
			{"conversation", "null"}
		}
	},
	Body = new ItemBody
	{
		ContentType = BodyType.Html,
		Content = "<div><div>\n<div>\n<div>\n<div>\n<div><at id=\"0\">Raghav</at><at id=\"1\">TestGlobalBot</at> YEAH"
	},
	Attachments = new List<ChatMessageAttachment>()
	{
	},
	Mentions = new List<ChatMessageMention>()
	{
		new ChatMessageMention
		{
			Id = 0,
			MentionText = "Raghav",
			Mentioned = new ChatMessageMentionedIdentitySet
			{
				Application = null,
				Device = null,
				Conversation = null,
				User = new Identity
				{
					Id = "f1b66449-b46d-49b0-9c3c-53c10234c818e",
					DisplayName = "Raghav Mankad",
					UserIdentityType = TeamworkUserIdentityType.AadUser
				}
			}
		},
		new ChatMessageMention
		{
			Id = 1,
			MentionText = "TestGlobalBot",
			Mentioned = new ChatMessageMentionedIdentitySet
			{
				Application = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = "TestGlobalBot",
					ApplicationIdentityType = TeamworkApplicationIdentityType.Bot
				},
				Device = null,
				Conversation = null,
				User = null
			}
		}
	},
	Reactions = new List<ChatMessageReaction>()
	{
	},
	MessageHistory = new List<ChatMessageHistoryItem>()
	{
	}
};

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.Request()
	.UpdateAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.

<!-- {
  "blockType": "response",
} -->

```http
HTTP/1.1 204 NoContent
```

### Example 4: Update the content with attachments of a message using delegated permissions
#### Request

The following is an example of the request to update the attachments on a Microsoft Teams channel message by using delegated permissions.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_chatMessage_3",
  "sampleKeys": ["e1234567-e123-4276-55555-6232b0e3a89a", "a7654321-e321-0000-0000-123b0e3a00a", "19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype"]
}-->

```http
PATCH https://graph.microsoft.com/beta/teams/e1234567-e123-4276-55555-6232b0e3a89a/channels/a7654321-e321-0000-0000-123b0e3a00a/messages/19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype
Content-Type: application/json

{
  "messageType": "message",
  "subject": null,
  "summary": null,
  "importance": "normal",
  "locale": "en-us",
  "from": {
    "application": null,
    "device": null,
    "user": {
      "id": "3b102402-813e-4e17-a6b2-f841aef1fdfc",
      "displayName": "Sumit Gupta",
      "userIdentityType": "aadUser"
    },
    "conversation": null
  },
  "body": {
    "contentType": "html",
    "content": "<p><em>text</em></p><attachment id=\"e8f78756199240b88448ae0fc6db112d\"></attachment><attachment id=\"638464e32834471ea202007da60a5ae6\"></attachment>"
  },
  "attachments": [
    {
      "id": "e8f78756199240b88448ae0fc6db112d",
      "contentType": "application/vnd.microsoft.card.hero",
      "contentUrl": null,
      "content": "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"image\": \"https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png\",\r\n      \"title\": \"😃😃 click me 😃😃\",\r\n      \"value\": \"http://microsoft.com\"\r\n    },\r\n    {\r\n      \"type\": \"imback\",\r\n      \"title\": \"&i am back& <>= \\\"\",\r\n      \"value\": \"&i am back& <>= \\\"\"\r\n    },\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"title\": \"Open URL\",\r\n      \"value\": \"http://google.com\"\r\n    }\r\n  ]\r\n}",
      "name": null,
      "thumbnailUrl": null
    },
    {
      "id": "638464e32834471ea202007da60a5ae6",
      "contentType": "application/vnd.microsoft.card.hero",
      "contentUrl": null,
      "content": "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"messageBack\",\r\n      \"title\": \"&message back& <>= \\\"\",\r\n      \"text\": \"text = &message back& <>= \\\"\",\r\n      \"displayText\": \"displayText = &message back& <>= \\\"\",\r\n      \"value\": {\r\n        \"text\": \"some text 2\"\r\n      }\r\n    }\r\n  ]\r\n}",
      "name": null,
      "thumbnailUrl": null
    }
  ],
  "mentions": [],
  "reactions": [],
  "messageHistory": []
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	MessageType = ChatMessageType.Message,
	Subject = null,
	Summary = null,
	Importance = ChatMessageImportance.Normal,
	Locale = "en-us",
	From = new ChatMessageFromIdentitySet
	{
		Application = null,
		Device = null,
		User = new Identity
		{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc",
			DisplayName = "Sumit Gupta",
			UserIdentityType = TeamworkUserIdentityType.AadUser
		},
		AdditionalData = new Dictionary<string, object>()
		{
			{"conversation", "null"}
		}
	},
	Body = new ItemBody
	{
		ContentType = BodyType.Html,
		Content = "<p><em>text</em></p><attachment id=\"e8f78756199240b88448ae0fc6db112d\"></attachment><attachment id=\"638464e32834471ea202007da60a5ae6\"></attachment>"
	},
	Attachments = new List<ChatMessageAttachment>()
	{
		new ChatMessageAttachment
		{
			Id = "e8f78756199240b88448ae0fc6db112d",
			ContentType = "application/vnd.microsoft.card.hero",
			ContentUrl = null,
			Content = "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here�s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"image\": \"https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png\",\r\n      \"title\": \" click me \",\r\n      \"value\": \"http://microsoft.com\"\r\n    },\r\n    {\r\n      \"type\": \"imback\",\r\n      \"title\": \"&i am back& <>= \\\"\",\r\n      \"value\": \"&i am back& <>= \\\"\"\r\n    },\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"title\": \"Open URL\",\r\n      \"value\": \"http://google.com\"\r\n    }\r\n  ]\r\n}",
			Name = null,
			ThumbnailUrl = null
		},
		new ChatMessageAttachment
		{
			Id = "638464e32834471ea202007da60a5ae6",
			ContentType = "application/vnd.microsoft.card.hero",
			ContentUrl = null,
			Content = "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here�s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"messageBack\",\r\n      \"title\": \"&message back& <>= \\\"\",\r\n      \"text\": \"text = &message back& <>= \\\"\",\r\n      \"displayText\": \"displayText = &message back& <>= \\\"\",\r\n      \"value\": {\r\n        \"text\": \"some text 2\"\r\n      }\r\n    }\r\n  ]\r\n}",
			Name = null,
			ThumbnailUrl = null
		}
	},
	Mentions = new List<ChatMessageMention>()
	{
	},
	Reactions = new List<ChatMessageReaction>()
	{
	},
	MessageHistory = new List<ChatMessageHistoryItem>()
	{
	}
};

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.Request()
	.UpdateAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.

<!-- {
  "blockType": "response",
} -->

```http
HTTP/1.1 204 NoContent
```

### Example 5: Update the reactions in a message using delegated permissions
#### Request

The following is an example of the request to update the reactions property on a Microsoft Teams channel message by using delegated permissions.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_chatMessage_4",
  "sampleKeys": ["e1234567-e123-4276-55555-6232b0e3a89a", "a7654321-e321-0000-0000-123b0e3a00a", "19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype"]
}-->

```http
PATCH https://graph.microsoft.com/beta/teams/e1234567-e123-4276-55555-6232b0e3a89a/channels/a7654321-e321-0000-0000-123b0e3a00a/messages/19%3Aa21b0b0c05194ebc9e30000000000f61%40thread.skype
Content-Type: application/json

{
  "messageType": "message",
  "subject": null,
  "summary": null,
  "importance": "normal",
  "locale": "en-us",
  "from": {
    "application": null,
    "device": null,
    "user": {
      "id": "3b102402-813e-4e17-a6b2-f841aef1fdfc",
      "displayName": "Sumit Gupta",
      "userIdentityType": "aadUser"
    },
    "conversation": null
  },
  "body": {
    "contentType": "html",
    "content": "<p><em>text</em></p><attachment id=\"e8f78756199240b88448ae0fc6db112d\"></attachment><attachment id=\"638464e32834471ea202007da60a5ae6\"></attachment>"
  },
  "attachments": [
    {
      "id": "e8f78756199240b88448ae0fc6db112d",
      "contentType": "application/vnd.microsoft.card.hero",
      "contentUrl": null,
      "content": "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"image\": \"https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png\",\r\n      \"title\": \"😃😃 click me 😃😃\",\r\n      \"value\": \"http://microsoft.com\"\r\n    },\r\n    {\r\n      \"type\": \"imback\",\r\n      \"title\": \"&i am back& <>= \\\"\",\r\n      \"value\": \"&i am back& <>= \\\"\"\r\n    },\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"title\": \"Open URL\",\r\n      \"value\": \"http://google.com\"\r\n    }\r\n  ]\r\n}",
      "name": null,
      "thumbnailUrl": null
    },
    {
      "id": "638464e32834471ea202007da60a5ae6",
      "contentType": "application/vnd.microsoft.card.hero",
      "contentUrl": null,
      "content": "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here’s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"messageBack\",\r\n      \"title\": \"&message back& <>= \\\"\",\r\n      \"text\": \"text = &message back& <>= \\\"\",\r\n      \"displayText\": \"displayText = &message back& <>= \\\"\",\r\n      \"value\": {\r\n        \"text\": \"some text 2\"\r\n      }\r\n    }\r\n  ]\r\n}",
      "name": null,
      "thumbnailUrl": null
    }
  ],
  "mentions": [],
  "reactions": [
    {
      "reactionType": "angry",
      "createdDateTime": "2018-10-21T08:10:30.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "laugh",
      "createdDateTime": "2018-10-21T08:10:32.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "like",
      "createdDateTime": "2018-10-21T02:17:14.67Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "like",
      "createdDateTime": "2018-10-21T02:34:40.3Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "4c9041b7-449a-40f7-8855-56da239b9fd1",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "like",
      "createdDateTime": "2018-10-21T08:10:25.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "heart",
      "createdDateTime": "2018-10-21T08:10:31.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "sad",
      "createdDateTime": "2018-10-21T08:10:33.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    },
    {
      "reactionType": "surprised",
      "createdDateTime": "2018-10-21T08:10:34.489Z",
      "user": {
        "application": null,
        "device": null,
        "user": {
          "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
          "displayName": null,
          "userIdentityType": "aadUser"
        }
      }
    }
  ],
  "messageHistory": [
    {
      "modifiedDateTime": "2018-10-21T08:10:30.489Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "angry",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T08:10:32.489Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "laugh",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T02:17:14.67Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "like",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T02:34:40.3Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "like",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "4c9041b7-449a-40f7-8855-56da239b9fd1",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T08:10:25.489Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "like",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T08:10:31.489Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "heart",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T08:10:33.489Z",
      "actions": "reactionAdded",
      "reaction": {
        "reactionType": "sad",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    },
    {
      "modifiedDateTime": "2018-10-21T08:10:34.489Z",
      "actions": "surprised",
      "reaction": {
        "reactionType": "sad",
        "user": {
          "application": null,
          "device": null,
          "user": {
            "id": "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
            "displayName": null,
            "userIdentityType": "aadUser"
          }
        }
      }
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var chatMessage = new ChatMessage
{
	MessageType = ChatMessageType.Message,
	Subject = null,
	Summary = null,
	Importance = ChatMessageImportance.Normal,
	Locale = "en-us",
	From = new ChatMessageFromIdentitySet
	{
		Application = null,
		Device = null,
		User = new Identity
		{
			Id = "3b102402-813e-4e17-a6b2-f841aef1fdfc",
			DisplayName = "Sumit Gupta",
			UserIdentityType = TeamworkUserIdentityType.AadUser
		},
		AdditionalData = new Dictionary<string, object>()
		{
			{"conversation", "null"}
		}
	},
	Body = new ItemBody
	{
		ContentType = BodyType.Html,
		Content = "<p><em>text</em></p><attachment id=\"e8f78756199240b88448ae0fc6db112d\"></attachment><attachment id=\"638464e32834471ea202007da60a5ae6\"></attachment>"
	},
	Attachments = new List<ChatMessageAttachment>()
	{
		new ChatMessageAttachment
		{
			Id = "e8f78756199240b88448ae0fc6db112d",
			ContentType = "application/vnd.microsoft.card.hero",
			ContentUrl = null,
			Content = "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here�s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"image\": \"https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png\",\r\n      \"title\": \" click me \",\r\n      \"value\": \"http://microsoft.com\"\r\n    },\r\n    {\r\n      \"type\": \"imback\",\r\n      \"title\": \"&i am back& <>= \\\"\",\r\n      \"value\": \"&i am back& <>= \\\"\"\r\n    },\r\n    {\r\n      \"type\": \"openUrl\",\r\n      \"title\": \"Open URL\",\r\n      \"value\": \"http://google.com\"\r\n    }\r\n  ]\r\n}",
			Name = null,
			ThumbnailUrl = null
		},
		new ChatMessageAttachment
		{
			Id = "638464e32834471ea202007da60a5ae6",
			ContentType = "application/vnd.microsoft.card.hero",
			ContentUrl = null,
			Content = "{\r\n  \"title\": \"*title*\",\r\n  \"subtitle\": \"*subtitle*\",\r\n  \"text\": \"Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here�s a small sample of some recipes to whet your appetite.\",\r\n  \"images\": [\r\n    {\r\n      \"url\": \"https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview\"\r\n    }\r\n  ],\r\n  \"buttons\": [\r\n    {\r\n      \"type\": \"messageBack\",\r\n      \"title\": \"&message back& <>= \\\"\",\r\n      \"text\": \"text = &message back& <>= \\\"\",\r\n      \"displayText\": \"displayText = &message back& <>= \\\"\",\r\n      \"value\": {\r\n        \"text\": \"some text 2\"\r\n      }\r\n    }\r\n  ]\r\n}",
			Name = null,
			ThumbnailUrl = null
		}
	},
	Mentions = new List<ChatMessageMention>()
	{
	},
	Reactions = new List<ChatMessageReaction>()
	{
		new ChatMessageReaction
		{
			ReactionType = "angry",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:30.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "laugh",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:32.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "like",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T02:17:14.67Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "like",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T02:34:40.3Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "4c9041b7-449a-40f7-8855-56da239b9fd1",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "like",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:25.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "heart",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:31.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "sad",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:33.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		},
		new ChatMessageReaction
		{
			ReactionType = "surprised",
			CreatedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:34.489Z"),
			User = new ChatMessageReactionIdentitySet
			{
				Application = null,
				Device = null,
				User = new Identity
				{
					Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
					DisplayName = null,
					UserIdentityType = "aadUser"
				}
			}
		}
	},
	MessageHistory = new List<ChatMessageHistoryItem>()
	{
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:30.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "angry",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:32.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "laugh",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T02:17:14.67Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "like",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T02:34:40.3Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "like",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "4c9041b7-449a-40f7-8855-56da239b9fd1",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:25.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "like",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:31.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "heart",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:33.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "sad",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		},
		new ChatMessageHistoryItem
		{
			ModifiedDateTime = DateTimeOffset.Parse("2018-10-21T08:10:34.489Z"),
			Actions = ChatMessageActions.ReactionAdded,
			Reaction = new ChatMessageReaction
			{
				ReactionType = "sad",
				User = new ChatMessageReactionIdentitySet
				{
					Application = null,
					Device = null,
					User = new Identity
					{
						Id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e",
						DisplayName = null,
						UserIdentityType = "aadUser"
					}
				}
			}
		}
	}
};

await graphClient.Teams["{team-id}"].Channels["{channel-id}"].Messages["{chatMessage-id}"]
	.Request()
	.UpdateAsync(chatMessage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.

<!-- {
  "blockType": "response",
} -->

```http
HTTP/1.1 204 NoContent
```
