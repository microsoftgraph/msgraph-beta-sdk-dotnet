---
title: "message: forward"
description: "Forward a message using either JSON or MIME format"
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# message: forward

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Forward a message using either JSON or MIME format.

When using JSON format, you can:
- Specify either a comment or the **body** property of the `message` parameter. Specifying both will return an HTTP 400 Bad Request error.
- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter. Specifying both or specifying neither will return an HTTP 400 Bad Request error.

When using MIME format:
- Provide the applicable [Internet message headers](https://tools.ietf.org/html/rfc2076) and the [MIME content](https://tools.ietf.org/html/rfc2045), all encoded in **base64** format in the request body.
- Add any attachments and S/MIME properties to the MIME content.

This method saves the message in the **Sent Items** folder.

Alternatively, [create a draft to forward a message](../api/message-createforward.md), and [send](../api/message-send.md) it later.

## Permissions
One of the following permissions are required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.Send    |
|Delegated (personal Microsoft account) | Mail.Send    |
|Application | Mail.Send |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/messages/{id}/forward
POST /users/{id | userPrincipalName}/messages/{id}/forward
POST /me/mailFolders/{id}/messages/{id}/forward
POST /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}/forward
```
## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type | string  | Nature of the data in the body of an entity. Required. <br/> Use `application/json` for a JSON object and `text/plain` for MIME content. |

## Request body
When using JSON format, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|comment|String|A comment to include. Can be an empty string.|
|toRecipients|[recipient](../resources/recipient.md) collection|The list of recipients.|
|message|[message](../resources/message.md)|Any writeable properties to update in the reply message.|

When specifying the body in MIME format, provide the MIME content with the applicable Internet message headers ("To", "CC", "BCC", "Subject"), all encoded in **base64** format in the request body.

## Response

If successful, this method returns `202 Accepted` response code. It does not return anything in the response body.

If the request body includes malformed MIME content, this method returns `400 Bad request` and the following error message: "Invalid base64 string for MIME content".

## Examples
### Example 1: Forward a message using JSON format
The following example sets the **isDeliveryReceiptRequested** property to true, adds a comment and forwards the message.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "message_forward",
  "sampleKeys": ["AAMkADA1MTAAAH5JaLAAA="]
}-->
```http
POST https://graph.microsoft.com/beta/me/messages/AAMkADA1MTAAAH5JaLAAA=/forward
Content-Type: application/json

{
  "message":{  
    "isDeliveryReceiptRequested": true,
    "toRecipients":[
      {
        "emailAddress": {
          "address":"danas@contoso.onmicrosoft.com",
          "name":"Dana Swope"
        }
      }
     ]
  },
  "comment": "Dana, just want to make sure you get this." 
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var message = new Message
{
	IsDeliveryReceiptRequested = true,
	ToRecipients = new List<Recipient>()
	{
		new Recipient
		{
			EmailAddress = new EmailAddress
			{
				Address = "danas@contoso.onmicrosoft.com",
				Name = "Dana Swope"
			}
		}
	}
};

var comment = "Dana, just want to make sure you get this.";

await graphClient.Me.Messages["{message-id}"]
	.Forward(null,message,comment)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

