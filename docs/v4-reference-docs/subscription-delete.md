---
title: "Delete subscription"
description: "Delete a subscription."
ms.localizationpriority: medium
author: "jumasure"
doc_type: apiPageType
ms.prod: "change-notifications"
---

# Delete subscription

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

---
author: "angelgolfer-ms"
ms.localizationpriority: high
ms.prod: "outlook"
ms.topic: include
---

<!-- markdownlint-disable MD041-->
>[!CAUTION]
>Existing apps that use this feature with [baseTask](/graph/api/resources/basetask?view=graph-rest-beta&preserve-view=true) or [baseTaskList](/graph/api/resources/basetasklist?view=graph-rest-beta&preserve-view=true) should be updated, as the to-do API set built on these resources is deprecated as of May 31, 2022. That API set will stop returning data on August 31, 2022. Please use the API set built on [todoTask](/graph/api/resources/todotask?view=graph-rest-beta&preserve-view=true). 
Delete a subscription.

For the list of resources that support subscribing to change notifications, see the table in the [Permissions](#permissions) section.

## Permissions

Depending on the resource and the permission type (delegated or application) requested, the permission specified in the following table is the least privileged required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in [Permissions](/graph/permissions-reference).

> **Note**: 
>
> Some resources support change notifications in multiple scenarios, each of which may require different permissions. In those cases, use the resource path to differentiate the scenarios.
>
> Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).

| Supported resource | Delegated (work or school account) | Delegated (personal Microsoft account) | Application |
|:-----|:-----|:-----|:-----|
|[baseTask](../resources/todotask.md) (deprecated) | Tasks.ReadWrite | Tasks.ReadWrite | Not supported. |
|[callRecord](../resources/callrecords-callrecord.md) | Not supported. | Not supported. | CallRecords.Read.All  |
|[channel](../resources/channel.md) <br />/teams/getAllChannels <br /> All channels in an organization. | Not supported.  | Not supported. | Channel.ReadBasic.All, ChannelSettings.Read.All |
|[channel](../resources/channel.md) <br />/teams/{id}/channels <br /> All channels in a particular team in an organization.  | Channel.ReadBasic.All, ChannelSettings.Read.All  | Not supported. | Channel.ReadBasic.All, ChannelSettings.Read.All  |
|[chat](../resources/chat.md) <br />/chats <br />All chats in an organization.  | Not supported. | Not supported. | Chat.ReadBasic.All, Chat.Read.All, Chat.ReadWrite.All |
|[chat](../resources/chat.md) <br />/chats/{id} <br /> A particular chat. | Chat.ReadBasic, Chat.Read, Chat.ReadWrite | Not supported. | ChatSettings.Read.Chat*, ChatSettings.ReadWrite.Chat*, Chat.Manage.Chat*, Chat.ReadBasic.All, Chat.Read.All, Chat.ReadWrite.All |
|[chat](../resources/chat.md) <br />/appCatalogs/teamsApps/{id}/installedToChats <br />All chats in an organization where a particular Teams app is installed. | Not supported | Not supported | Chat.ReadBasic.WhereInstalled, Chat.Read.WhereInstalled, Chat.ReadWrite.WhereInstalled |
|[chatMessage](../resources/chatmessage.md) <br />/teams/{id}/channels/{id}/messages <br /> All messages and replies in a particular channel. | ChannelMessage.Read.All, Group.Read.All, Group.ReadWrite.All | Not supported. | ChannelMessage.Read.Group*, ChannelMessage.Read.All  |
|[chatMessage](../resources/chatmessage.md) <br />/teams/getAllMessages <br />All channel messages in organization. | Not supported. | Not supported. | ChannelMessage.Read.All  |
|[chatMessage](../resources/chatmessage.md) <br />/chats/{id}/messages <br /> All messages in a chat. | Chat.Read, Chat.ReadWrite | Not supported. | Chat.Read.All  |
|[chatMessage](../resources/chatmessage.md) <br />/chats/getAllMessages. <br /> All chat messages in an organization. | Not supported. | Not supported. | Chat.Read.All  |
|[chatMessage](../resources/chatmessage.md) <br />/users/{id}/chats/getAllMessages <br />Chat messages for all chats a particular user is part of. | Chat.Read, Chat.ReadWrite | Not supported. | Chat.Read.All, Chat.ReadWrite.All |
|[chatMessage](../resources/chatmessage.md) <br />/appCatalogs/teamsApps/{id}/installedToChats/getAllMessages <br />Chat messages for all chats in an organization where a particular Teams app is installed. | Not supported | Not supported | Chat.Read.WhereInstalled, Chat.ReadWrite.WhereInstalled |
|[contact](../resources/contact.md) | Contacts.Read | Contacts.Read | Contacts.Read |
|[conversationMember](../resources/conversationmember.md) <br />/chats/getAllMembers <br /> Members of all chats in an organization. | Not supported. | Not supported. | ChatMember.Read.All, ChatMember.ReadWrite.All, Chat.ReadBasic.All, Chat.Read.All, Chat.ReadWrite.All |
|[conversationMember](../resources/conversationmember.md) <br />/chats/{id}/members <br /> Members of a particular chat. | ChatMember.Read, ChatMember.ReadWrite, Chat.ReadBasic, Chat.Read, Chat.ReadWrite | Not supported. | ChatMember.Read.Chat*, Chat.Manage.Chat*, ChatMember.Read.All, ChatMember.ReadWrite.All, Chat.ReadBasic.All, Chat.Read.All, Chat.ReadWrite.All |
|[conversationMember](../resources/conversationmember.md) <br />/appCatalogs/teamsApps/{id}/installedToChats/getAllMembers <br />Chat members for all chats in an organization where a particular Teams app is installed. | Not supported. | Not supported. | ChatMember.Read.WhereInstalled, ChatMember.ReadWrite.WhereInstalled, Chat.ReadBasic.WhereInstalled, Chat.Read.WhereInstalled, Chat.ReadWrite.WhereInstalled |
|[conversationMember](../resources/conversationmember.md) <br />/teams/getAllMembers <br /> Members in all teams in an organization. | Not supported. | Not supported. | TeamMember.Read.All, TeamMember.ReadWrite.All |
|[conversationMember](../resources/conversationmember.md) <br />/teams/{id}/members <br /> Members in a particular team. | TeamMember.Read.All | Not supported. | TeamMember.Read.All |
|[conversationMember](../resources/conversationmember.md) <br />/teams/{id}/channels/getAllMembers <br /> Members in all private channels of a particular team. | Not supported. | Not supported. | ChannelMember.Read.All |
|[conversationMember](../resources/conversationmember.md) (/teams/getAllChannels/getAllMembers) | Not supported. | Not supported. | ChannelMember.Read.All |
|[driveItem](../resources/driveitem.md) (user's personal OneDrive) | Not supported. | Files.ReadWrite | Not supported. |
|[driveItem](../resources/driveitem.md) (OneDrive for Business) | Files.ReadWrite.All | Not supported. | Files.ReadWrite.All |
|[event](../resources/event.md) | Calendars.Read | Calendars.Read | Calendars.Read |
|[group](../resources/group.md) | Group.Read.All | Not supported. | Group.Read.All |
|[group conversation](../resources/conversation.md) | Group.Read.All | Not supported. | Not supported. |
|[list](../resources/list.md) | Sites.ReadWrite.All | Not supported. | Sites.ReadWrite.All |
|[message](../resources/message.md) | Mail.ReadBasic, Mail.Read | Mail.ReadBasic, Mail.Read | Mail.Read |
|[online meeting](../resources/onlinemeeting.md) | Not supported | Not supported | OnlineMeetings.Read.All, OnlineMeetings.ReadWrite.All |
|[presence](../resources/presence.md) | Presence.Read.All | Not supported. | Not supported. |
|[printer](../resources/printer.md) | Not supported. | Not supported. | Printer.Read.All, Printer.ReadWrite.All |
|[printTaskDefinition](../resources/printtaskdefinition.md) | Not supported. | Not supported. | PrintTaskDefinition.ReadWrite.All |
|[security alert](../resources/alert.md) | SecurityEvents.ReadWrite.All | Not supported. | SecurityEvents.ReadWrite.All |
|[team](../resources/team.md) <br />/teams <br />All teams in an organization. | Not supported. | Not supported. | Team.ReadBasic.All, TeamSettings.Read.All |
|[team](../resources/team.md) <br />/teams/{id} <br />A particular team. | Team.ReadBasic.All, TeamSettings.Read.All | Not supported. | Team.ReadBasic.All, TeamSettings.Read.All |
|[todoTask](../resources/todotask.md) | Tasks.ReadWrite | Tasks.ReadWrite | Not supported. |
|[user](../resources/user.md) | User.Read.All | User.Read.All | User.Read.All |


### chatMessage

**chatMessage** subscriptions can be specified to include resource data. If specified to include resource data (**includeResourceData** set to `true`), [encryption](/graph/webhooks-with-resource-data) is required. The subscription creation fails if an [encryptionCertificate](/graph/api/resources/subscription) isn't specified for such subscriptions. Before you can create a **chatMessage** subscription with application permissions, you might need to request access. For details, see [Protected APIs in Microsoft Teams](/graph/teams-protected-apis).

You must use the `Prefer: include-unknown-enum-members` request header to get the following values in **chatMessage** **messageType** [evolvable enum](/graph/best-practices-concept#handling-future-members-in-evolvable-enumerations): `systemEventMessage` for `/teams/{id}/channels/{id}/messages` and `/chats/{id}/messages` resource.

> [!NOTE]
>`/teams/getAllMessages`, `/chats/getAllMessages`, `/me/chats/getAllMessages`, `/users/{id}/chats/getAllMessages`, and `/appCatalogs/teamsApps/{id}/installedToChats/getAllMessages` 
> have [licensing and payment requirements](/graph/teams-licenses).
> `/teams/getAllMessages` and `/chats/getAllMessages` support both `model=A` and `model=B` query parameters,
> `/me/chats/getAllMessages`, `/users/{id}/chats/getAllMessages`, and `/appCatalogs/teamsApps/{id}/installedToChats/getAllMessages`  support only `model=B`.
> If no model is specified, [evaluation mode](/graph/teams-licenses#evaluation-mode-default-requirements) will be used.

### conversationMember
**conversationMember** subscriptions can be specified to include resource data. If specified to include resource data (**includeResourceData** set to `true`), [encryption](/graph/webhooks-with-resource-data) is required. The subscription creation fails if an [encryptionCertificate](/graph/api/resources/subscription) isn't specified.

> [!NOTE]
>`/teams/getAllMembers`, `/chats/getAllMembers`, and `/appCatalogs/teamsApps/{id}/installedToChats/getAllMembers ` have [licensing and payment requirements](/graph/teams-licenses).
> `/teams/getAllMembers` and `/chats/getAllMembers` support both `model=A` and `model=B` query parameters. `/appCatalogs/teamsApps/{id}/installedToChats/getAllMembers` supports only `model=B`.
> If no model is specified, [evaluation mode](/graph/teams-licenses#evaluation-mode-default-requirements) will be used.

### team, channel, and chat
**team**, **channel**, and **chat** subscriptions can be specified to include resource data. If specified to include resource data (**includeResourceData** set to `true`), [encryption](/graph/webhooks-with-resource-data) is required. The subscription creation fails if an [encryptionCertificate](/graph/api/resources/subscription) isn't specified.

> [!NOTE]
>`/appCatalogs/teamsApps/{id}/installedToChats` has [licensing and payment requirements](/graph/teams-licenses), specifically supporting only `model=B`.
> If no model is specified, [evaluation mode](/graph/teams-licenses#evaluation-mode-default-requirements) will be used.


#### Request example

Specify the `model` query parameter in the **resource** property in the request body.

```http
POST https://graph.microsoft.com/v1.0/subscriptions
Content-type: application/json

{
   "changeType": "created",
   "notificationUrl": "https://webhook.azurewebsites.net/api/send/myNotifyClient",
   "resource": "chats/getAllMessages?model=A",
   "expirationDateTime":"2016-11-20T18:23:45.9356913Z",
   "clientState": "secretClientValue",
   "latestSupportedTlsVersion": "v1_2"
}
```

### driveItem

Additional limitations apply for subscriptions on OneDrive items. The limitations apply to creating as well as managing (getting, updating, and deleting) subscriptions.

On a personal OneDrive, you can subscribe to the root folder or any subfolder in that drive. On OneDrive for Business, you can subscribe to only the root folder. Change notifications are sent for the requested types of changes on the subscribed folder, or any file, folder, or other **driveItem** instances in its hierarchy. You cannot subscribe to **drive** or **driveItem** instances that are not folders, such as individual files.

### contact, event, and message

You can subscribe to changes in Outlook **contact**, **event**, or **message** resources and optionally specify in the POST request payload whether to include encrypted resource data in notifications.

Creating and managing (getting, updating, and deleting) a subscription requires a read scope to the resource. For example, to get change notifications on messages, your app needs the Mail.Read permission. Outlook change notifications support delegated and application permission scopes. Note the following limitations:

- Delegated permission supports subscribing to items in folders in only the signed-in user's mailbox. For example, you cannot use the delegated permission Calendars.Read to subscribe to events in another user’s mailbox.
- To subscribe to change notifications of Outlook contacts, events, or messages in _shared or delegated_ folders:

  - Use the corresponding application permission to subscribe to changes of items in a folder or mailbox of _any_ user in the tenant.
  - Do not use the Outlook sharing permissions (Contacts.Read.Shared, Calendars.Read.Shared, Mail.Read.Shared, and their read/write counterparts), as they do **not** support subscribing to change notifications on items in shared or delegated folders.
### onlineMeetings, presence

**onlineMeetings** and **presence** subscriptions require [encryption](/graph/webhooks-with-resource-data) for notifications with resource data. Subscription creation will fail if [encryptionCertificate](../resources/subscription.md) and [encryptionCertificateId](../resources/subscription.md) are not specified if resource data is desired in notifications.
For details about online meeting subscriptions, see [Get change notifications for online meetings](/graph/changenotifications-for-onlinemeeting).

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /subscriptions/{subscription-id}
```

## Request headers

| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

For details about how errors are returned, see [Error responses][error-response].

## Example

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_subscription"
}-->

```http
DELETE https://graph.microsoft.com/beta/subscriptions/7f105c7d-2dc5-4530-97cd-4e7ae6534c07
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Subscriptions["{subscription-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

[error-response]: /graph/errors

<!--
{
  "type": "#page.annotation",
  "description": "Delete subscription",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->

