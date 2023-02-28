---
title: "Update message"
description: "Update the properties of message object."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Update message

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a message object.
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
PATCH /me/messages/{id}
PATCH /users/{id | userPrincipalName}/messages/{id}
PATCH /me/mailFolders/{id}/messages/{id}
PATCH /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}
```
## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type | string  | Nature of the data in the body of an entity. Required. |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed. The following properties can be updated.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|bccRecipients|Recipient|The Bcc recipients for the message. |
|body|ItemBody|The body of the message. Updatable only if isDraft = true.|
|categories|String collection|The categories associated with the message.|
|ccRecipients|Recipient collection|The Cc recipients for the message. |
|flag|[followupFlag](../resources/followupflag.md)|The flag value that indicates the status, start date, due date, or completion date for the message.|
|from|Recipient|The mailbox owner and sender of the message. Must correspond to the actual mailbox used. |
|importance|String|The importance of the message. Possible values are: `Low`, `Normal`, `High`.|
|inferenceClassification | String | The classification of the message for the user, based on inferred relevance or importance, or on an explicit override. Possible values are: `focused` or `other`. |
|internetMessageId |String |The message ID in the format specified by [RFC2822](https://www.ietf.org/rfc/rfc2822.txt). Updatable only if isDraft = true.|
|isDeliveryReceiptRequested|Boolean|Indicates whether a read receipt is requested for the message.|
|isRead|Boolean|Indicates whether the message has been read.|
|isReadReceiptRequested|Boolean|Indicates whether a read receipt is requested for the message.|
|multiValueExtendedProperties|[multiValueLegacyExtendedProperty](../resources/multivaluelegacyextendedproperty.md) collection| The collection of multi-value extended properties defined for the message. Nullable.|
|replyTo|Recipient collection|The email addresses to use when replying. Updatable only if isDraft = true.|
|sender|Recipient|The account that is actually used to generate the message. Updatable when sending a message from a [shared mailbox](/exchange/collaboration/shared-mailboxes/shared-mailboxes), or sending a message as a [delegate](https://support.office.com/article/allow-someone-else-to-manage-your-mail-and-calendar-41c40c04-3bd1-4d22-963a-28eafec25926). In any case, the value must correspond to the actual mailbox used.|
|singleValueExtendedProperties|[singleValueLegacyExtendedProperty](../resources/singlevaluelegacyextendedproperty.md) collection| The collection of single-value extended properties defined for the message. Nullable.|
|subject|String|The subject of the message. Updatable only if isDraft = true.|
|toRecipients|Recipient collection|The To recipients for the message. |

Since the **message** resource supports [extensions](/graph/extensibility-overview), you can use the `PATCH` operation to
add, update, or delete your own app-specific data in custom properties of an extension in an existing **message** instance.

## Response

If successful, this method returns a `200 OK` response code and updated [message](../resources/message.md) object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_message"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/messages/{id}
Content-type: application/json

{
  "subject": "subject-value",
  "body": {
    "contentType": "",
    "content": "content-value"
  },
  "inferenceClassification": "other"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var message = new Message
{
	Subject = "subject-value",
	Body = new ItemBody
	{
		ContentType = BodyType.Text,
		Content = "content-value"
	},
	InferenceClassification = InferenceClassificationType.Other
};

await graphClient.Me.Messages["{message-id}"]
	.Request()
	.UpdateAsync(message);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

