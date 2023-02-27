---
title: "message: createReply"
description: "Create a draft to reply to the sender of a message in either JSON or MIME format."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# message: createReply

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a draft to reply to the sender of a [message](../resources/message.md) in either JSON or MIME format.

When using JSON format:
- Specify either a comment or the **body** property of the `message` parameter. Specifying both will return an HTTP 400 Bad Request error.
- If **replyTo** is specified in the original message, per Internet Message Format ([RFC 2822](https://www.rfc-editor.org/info/rfc2822)), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.
- You can [update](../api/message-update.md) the draft later to add reply content to the **body** or change other message properties.

When using MIME format:
- Provide the applicable [Internet message headers](https://tools.ietf.org/html/rfc2076) and the [MIME content](https://tools.ietf.org/html/rfc2045), all encoded in **base64** format in the request body.
- Add any attachments and S/MIME properties to the MIME content.

[Send](../api/message-send.md) the draft message in a subsequent operation.

Alternatively, [reply to a message](../api/message-reply.md) in a single operation.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.ReadWrite    |
|Delegated (personal Microsoft account) | Mail.ReadWrite    |
|Application | Mail.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/messages/{id}/createReply
POST /users/{id | userPrincipalName}/messages/{id}/createReply
POST /me/mailFolders/{id}/messages/{id}/createReply
POST /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}/createReply
```
## Request headers
| Name       | Type | Description| 
|:---------------|:--------|:----------
| Authorization  | string  | Bearer {token}. Required.|
| Content-Type | string  | Nature of the data in the body of an entity. Required. <br/> Use `application/json` for a JSON object and `text/plain` for MIME content.|
| Prefer: outlook.timezone | string | Sets the time zone for the `Sent` field of the reply draft message in HTML that this API creates based on the request body. The value can be any of the [supportedTimeZones](outlookuser-supportedtimezones.md) configured for the user. If not specified, that `Sent` field is in UTC.<br><br> Use this header only if you're specifying the `Content-Type: application/json` header to create the reply draft message in HTML. If you use the `Content-Type: text/plain` header, this `Prefer` header does not have any effect. Optional.|

## Request body
When using JSON format, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|comment|String|A comment to include. Can be an empty string.|
|message|[message](../resources/message.md)|Any writeable properties to update in the reply message.|

When specifying the body in MIME format, provide the MIME content with the applicable Internet message headers, all encoded in **base64** format in the request body.

## Response
If successful, this method returns `201 Created` response code and [message](../resources/message.md) object in the response body.

If the request body includes malformed MIME content, this method returns `400 Bad request` and the following error message: "Invalid base64 string for MIME content".

## Examples
### Example 1: Create a draft in JSON format to reply to an existing message
The following example creates a reply draft, adds a comment and a recipient in the request body.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "message_createreply",
  "sampleKeys": ["AAMkADA1MTAAAAqldOAAA="]
}-->
```http
POST https://graph.microsoft.com/beta/me/messages/AAMkADA1MTAAAAqldOAAA=/createReply
Content-Type: application/json

{
  "message":{  
    "toRecipients":[
      {
        "emailAddress": {
          "address":"samanthab@contoso.onmicrosoft.com",
          "name":"Samantha Booth"
        }
      },
      {
        "emailAddress":{
          "address":"randiw@contoso.onmicrosoft.com",
          "name":"Randi Welch"
        }
      }
     ]
  },
  "comment": "Samantha, Randi, would you name the group if the project is approved, please?" 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var message = new Message
{
	ToRecipients = new List<Recipient>()
	{
		new Recipient
		{
			EmailAddress = new EmailAddress
			{
				Address = "samanthab@contoso.onmicrosoft.com",
				Name = "Samantha Booth"
			}
		},
		new Recipient
		{
			EmailAddress = new EmailAddress
			{
				Address = "randiw@contoso.onmicrosoft.com",
				Name = "Randi Welch"
			}
		}
	}
};

var comment = "Samantha, Randi, would you name the group if the project is approved, please?";

await graphClient.Me.Messages["{message-id}"]
	.CreateReply(message,comment)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

