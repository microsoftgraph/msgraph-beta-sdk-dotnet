---
title: "Delete openTypeExtension"
description: "Delete an open extension (openTypeExtension object) from the specified instance of a resource. "
ms.localizationpriority: medium
author: "dkershaw10"
doc_type: apiPageType
ms.prod: "extensions"
---

# Delete openTypeExtension

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
Delete an open extension ([openTypeExtension](../resources/opentypeextension.md) object) from the specified instance of a resource. 

See the table in the [Permissions](#permissions) section for the list of resources that support open extensions.

## Permissions

Depending on the resource you're deleting the extension from and the permission type (delegated or application) requested, the permission specified in the following table is the least privileged required to call this API. To learn more, including [taking caution](/graph/auth/auth-concepts#best-practices-for-requesting-permissions) before choosing more privileged permissions, search for the following permissions in [Permissions](/graph/permissions-reference).

| Supported resource | Delegated (work or school account) | Delegated (personal Microsoft account) | Application |
|:-----|:-----|:-----|:-----|
| [baseTask](../resources/basetask.md) (deprecated) | Tasks.ReadWrite | Tasks.ReadWrite | Tasks.ReadWrite.All |
| [baseTasklist](../resources/basetasklist.md) (deprecated) | Tasks.ReadWrite | Tasks.ReadWrite | Tasks.ReadWrite.All |
| [device](../resources/device.md) | Directory.AccessAsUser.All | Not supported | Device.ReadWrite.All |
| [event](../resources/event.md) | Calendars.ReadWrite | Calendars.ReadWrite | Calendars.ReadWrite |
| [group](../resources/group.md) | Group.ReadWrite.All | Not supported | Group.ReadWrite.All |
| [group event](../resources/event.md) | Group.ReadWrite.All | Not supported | Not supported |
| [group post](../resources/post.md) | Group.ReadWrite.All | Not supported | Group.ReadWrite.All |
| [message](../resources/message.md) | Mail.ReadWrite | Mail.ReadWrite | Mail.ReadWrite | 
| [organization](../resources/organization.md) | Organization.ReadWrite.All | Not supported | Organization.ReadWrite.All |
| [personal contact](../resources/contact.md) | Contacts.ReadWrite | Contacts.ReadWrite | Contacts.ReadWrite |
| [todoTask](../resources/todotask.md) | Tasks.ReadWrite | Tasks.ReadWrite | Tasks.ReadWrite.All |
| [todoTasklist](../resources/todotasklist.md)  | Tasks.ReadWrite | Tasks.ReadWrite | Tasks.ReadWrite.All |
| [user](../resources/user.md) | User.ReadWrite | User.ReadWrite | User.ReadWrite.All |

## HTTP request

In the request, identify the resource instance, use the **extensions** 
navigation property of that instance to identify the extension, and do a `DELETE` on that extension instance.

<!-- { "blockType": "ignored" } -->
```http
DELETE /administrativeUnits/{administrativeUnitId}/extensions/{extensionId}
DELETE /devices/{deviceId}/extensions/{extensionId}
DELETE /users/{userId|userPrincipalName}/events/{eventId}/extensions/{extensionId}
DELETE /groups/{groupId}/extensions/{extensionId}
DELETE /groups/{groupId}/events/{eventId}/extensions/{extensionId}
DELETE /groups/{groupId}/threads/{threadIid}/posts/{postId}/extensions/{extensionId}
DELETE /users/{userIid|userPrincipalName}/messages/{messageId}/extensions/{extensionId}
DELETE /organization/{organizationId}/extensions/{extensionId}
DELETE /users/{userId|userPrincipalName}/contacts/{contactId}/extensions/{extensionId}
DELETE /users/{userId|userPrincipalName}/extensions/{extensionId}
DELETE /users/me/todo/lists/{listId}/extensions/{extensionId}
DELETE /users/me/todo/lists/{listId}/tasks/{taskId}/extensions/{extensionId}
DELETE /users/me/tasks/lists/{listId}/extensions/{extensionId}
DELETE /users/me/tasks/lists/{listId}/tasks/{taskId}/extensions/{extensionId}
```

>**Note:** The above syntax shows some common ways to identify a resource instance, in order to delete an extension from it. 
All other syntax that allows you to identify these resource instances supports deleting open extensions from them in a similar way.

## Request headers
| Name       | Value |
|:---------------|:----------|
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
The first example references an extension by its name and deletes the extension in the specified message.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_opentypeextension",
  "sampleKeys": ["AAMkAGE1M2IyNGNmLTI5MTktNDUyZi1iOTVl===", "Com.Contoso.Referral"]
}-->
```http
DELETE https://graph.microsoft.com/beta/me/messages/AAMkAGE1M2IyNGNmLTI5MTktNDUyZi1iOTVl===/extensions/Com.Contoso.Referral/
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Messages["{message-id}"].Extensions["{extension-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

