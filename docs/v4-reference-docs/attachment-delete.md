---
title: "Delete attachment"
description: "Delete an attachment from a calendar event, message, Outlook task, or post."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "outlook"
author: "abheek-das"
---

# Delete attachment

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> Existing apps that use this feature with Outlook tasks should be updated, as Outlook tasks are being deprecated. See [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/) for more information.

Delete an attachment from a user calendar [event](../resources/event.md), [message](../resources/message.md), [Outlook task](../resources/outlooktask.md), or [post](../resources/post.md).

## Permissions

Depending on the resource (**event**, **message**, **outlookTask**, or **post**) that the attachment is attached to and the permission type (delegated or application) requested, the permission specified in the following table is the least privileged required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in [Permissions](/graph/permissions-reference).

| Supported resource | Delegated (work or school account) | Delegated (personal Microsoft account) | Application |
|:-----|:-----|:-----|:-----|
| [event](../resources/event.md) | Calendars.ReadWrite | Calendars.ReadWrite | Calendars.ReadWrite |
| [message](../resources/message.md) | Mail.ReadWrite | Mail.ReadWrite | Mail.ReadWrite |
| [outlookTask](../resources/outlooktask.md) |  Tasks.ReadWrite | Tasks.ReadWrite | Not supported |
| [post](../resources/post.md) | Group.ReadWrite.All | Not supported | Not supported |


<!--
* If accessing attachments in Group Events or Posts: Group.ReadWrite.All
-->

## HTTP request

Attachments for an [event](../resources/event.md) in the user's default [calendar](../resources/calendar.md).
<!-- { "blockType": "ignored" } -->
```http
DELETE /me/events/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/events/{id}/attachments/{id}

DELETE /me/calendar/events/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/calendar/events/{id}/attachments/{id}
```

Attachments for an [event](../resources/event.md) in the specified [calendar](../resources/calendar.md) belonging to the user.
<!-- { "blockType": "ignored" } -->
```http
DELETE /me/calendars/{id}/events/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/calendars/{id}/events/{id}/attachments/{id}
```

<!-- Tried adding and getting group event with attachment, event exists but without attachment. Group event attachment not supported.
DELETE /groups/{id}/events/{id}/attachments/{id}
DELETE /groups/{id}/calendar/events/{id}/attachments/{id}
-->

Attachments for an [event](../resources/event.md) in a [calendar](../resources/calendar.md) belonging to the user's default [calendarGroup](../resources/calendargroup.md).
<!-- { "blockType": "ignored" } -->
```http
DELETE /me/calendars/{id}/events/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/calendars/{id}/events/{id}/attachments/{id}
```
Attachments for an [event](../resources/event.md) in a [calendar](../resources/calendar.md) belonging to a user's [calendarGroup](../resources/calendargroup.md).
<!-- { "blockType": "ignored" } -->
```http
DELETE /me/calendargroups/{id}/calendars/{id}/events/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/calendargroups/{id}/calendars/{id}/events/{id}/attachments/{id}
```
Attachments for a [message](../resources/message.md) in a user's mailbox.
<!-- { "blockType": "ignored" } -->

```http
DELETE /me/messages/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/messages/{id}/attachments/{id}
```

Attachments for a [message](../resources/message.md) contained in a top level [mailFolder](../resources/mailfolder.md) in a user's mailbox.
<!-- { "blockType": "ignored" } -->

```http
DELETE /me/mailFolders/{id}/messages/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}/attachments/{id}
```

Attachments for a [message](../resources/message.md) contained in a child folder of a [mailFolder](../resources/mailfolder.md) in a user's mailbox.  The
example below shows one level of nesting, but a message can be located in a child of a child and so on.
<!-- { "blockType": "ignored" } -->

```http
DELETE /me/mailFolders/{id}/childFolders/{id}/.../messages/{id}/attachments/{id}
DELETE /users/{id | userPrincipalName}/mailFolders/{id}/childFolders/{id}/messages/{id}/attachments/{id}
```

Attachments for an [Outlook task](../resources/outlooktask.md).
<!-- { "blockType": "ignored" } -->

```http
DELETE /me/outlook/tasks/{id}/attachments/{id}
DELETE /users/{id}/outlook/tasks/{id}/attachments/{id}
```

Attachments for a [post](../resources/post.md) in a [thread](../resources/conversationthread.md) belonging to a [conversation](../resources/conversation.md) of a group.
<!-- { "blockType": "ignored" } -->

```http
DELETE /groups/{id}/threads/{id}/posts/{id}/attachments/{id}
DELETE /groups/{id}/conversations/{id}/threads/{id}/posts/{id}/attachments/{id}
```

## Request headers

| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

Here is an example of the request to delete an attachment on an event.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_attachment"
}-->

```http
DELETE https://graph.microsoft.com/beta/me/events/{id}/attachments/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Events["{event-id}"].Attachments["{attachment-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Here is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete attachment",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


