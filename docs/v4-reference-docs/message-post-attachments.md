---
title: "Add attachment"
description: "Use this API to add an attachment to a message. "
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Add attachment

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Use this API to add an [attachment](../resources/attachment.md) to a message. 

An attachment can be one of the following types:

* A file ([fileAttachment](../resources/fileattachment.md) resource).
* An item (contact, event or message, represented by an [itemAttachment](../resources/itemattachment.md) resource).
* A link to a file ([referenceAttachment](../resources/referenceattachment.md) resource).

All these types of attachment resources are derived from the [attachment](../resources/attachment.md)
resource. 

You can add an attachment to an existing [message](../resources/message.md) by posting to its attachments collection, or to a new 
message that is being [drafted](../api/user-post-messages.md), or [created and sent on the fly](../api/user-sendmail.md).

>**Note**: This operation limits the size of the attachment you can add to under 3 MB.
>
> However, if you're attaching to a message a file that is between 3MB and 150MB, you can [create an upload session](attachment-createuploadsession.md) and iteratively upload ranges of the file to attach it. See [attach large files to Outlook messages](/graph/outlook-large-attachments) for an example.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.ReadWrite    |
|Delegated (personal Microsoft account) | Mail.ReadWrite    |
|Application | Mail.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
Attachments for a [message](../resources/message.md) in a user's mailbox.
```http
POST /me/messages/{id}/attachments
POST /users/{id | userPrincipalName}/messages/{id}/attachments
```
Attachments for a [message](../resources/message.md) contained in a top level [mailFolder](../resources/mailfolder.md) in a user's mailbox.
```http
POST /me/mailFolders/{id}/messages/{id}/attachments
POST /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}/attachments
```
Attachments for a [message](../resources/message.md) contained in a child folder of a [mailFolder](../resources/mailfolder.md) in a user's mailbox.  The
example below shows one level of nesting, but a message can be located in a child of a child and so on.
```http
POST /me/mailFolders/{id}/childFolders/{id}/.../messages/{id}/attachments/{id}
POST /users/{id | userPrincipalName}/mailFolders/{id}/childFolders/{id}/messages/{id}/attachments/{id}
```
## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type | string  | Nature of the data in the body of an entity. Required. |

## Request body
In the request body, supply a JSON representation of [Attachment](../resources/attachment.md) object.

## Response

If successful, this method returns `201 Created` response code and the [Attachment](../resources/attachment.md) object in the response body.

## Example (file attachment)

##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_file_attachment_from_message_beta",
  "sampleKeys": ["AAMkpsDRVK"]
}-->
```http
POST https://graph.microsoft.com/beta/me/messages/AAMkpsDRVK/attachments
Content-type: application/json

{
  "@odata.type": "#microsoft.graph.fileAttachment",
  "name": "smile",
  "contentBytes": "a0b1c76de9f7="
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachment = new FileAttachment
{
	Name = "smile",
	ContentBytes = Convert.FromBase64String("a0b1c76de9f7=")
};

await graphClient.Me.Messages["{message-id}"].Attachments
	.Request()
	.AddAsync(attachment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_item_attachment_from_message_beta",
  "sampleKeys": ["AAMkpsDRVK"]
}-->

```
POST https://graph.microsoft.com/beta/me/messages/AAMkpsDRVK/attachments
Content-type: application/json

{
  "@odata.type": "#microsoft.graph.itemAttachment",
  "name": "Holiday event", 
  "item": {
    "@odata.type": "microsoft.graph.event",
    "subject": "Discuss gifts for children",
    "body": {
      "contentType": "HTML",
      "content": "Let's look for funding!"
    },
    "start": {
      "dateTime": "2016-12-02T18:00:00",
      "timeZone": "Pacific Standard Time"
    },
    "end": {
      "dateTime": "2016-12-02T19:00:00",
      "timeZone": "Pacific Standard Time"
    }
  }
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachment = new ItemAttachment
{
	Name = "Holiday event",
	Item = new Event
	{
		Subject = "Discuss gifts for children",
		Body = new ItemBody
		{
			ContentType = BodyType.Html,
			Content = "Let's look for funding!"
		},
		Start = new DateTimeTimeZone
		{
			DateTime = "2016-12-02T18:00:00",
			TimeZone = "Pacific Standard Time"
		},
		End = new DateTimeTimeZone
		{
			DateTime = "2016-12-02T19:00:00",
			TimeZone = "Pacific Standard Time"
		}
	}
};

await graphClient.Me.Messages["{message-id}"].Attachments
	.Request()
	.AddAsync(attachment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_reference_attachment_from_message",
  "@odata.type": "microsoft.graph.referenceAttachment",
  "sampleKeys": ["AAMkAGE1M88AADUv0uFAAA="]
}-->

```
POST https://graph.microsoft.com/beta/me/messages/AAMkAGE1M88AADUv0uFAAA=/attachments
Content-type: application/json

{ 
    "@odata.type": "#microsoft.graph.referenceAttachment", 
    "name": "Personal pictures", 
    "sourceUrl": "https://contoso.com/personal/mario_contoso_net/Documents/Pics", 
    "providerType": "oneDriveConsumer", 
    "permission": "Edit", 
    "isFolder": "True" 
} 
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachment = new ReferenceAttachment
{
	Name = "Personal pictures",
	SourceUrl = "https://contoso.com/personal/mario_contoso_net/Documents/Pics",
	ProviderType = ReferenceAttachmentProvider.OneDriveConsumer,
	Permission = ReferenceAttachmentPermission.Edit,
	IsFolder = true
};

await graphClient.Me.Messages["{message-id}"].Attachments
	.Request()
	.AddAsync(attachment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

