---
title: "Delete meetingRegistrant"
description: "Cancel an onlineMeeting registration for a meetingRegistrant."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Unenroll meeting registrant

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Cancel an [onlineMeeting](../resources/onlinemeeting.md) registration for a [meetingRegistrant](../resources/meetingregistrant.md) on behalf of the registrant.

Only use this method when the **allowedRegistrant** property of the [meetingRegistration](../resources/meetingregistration.md) object has a value of `organization` and the registrant's delegated permission was used to enroll. When the **allowedRegistrant** value is `everyone`, registrants can only use the link in the email they receive to cancel their registration.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
| Delegated (work or school account) | OnlineMeetings.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application | OnlineMeetings.Read.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /users/{userId}/onlineMeetings/{meetingId}/registration/registrants/{id}
```

>**Notes:**
>
> - `userId` is the objectID of the meeting organizer.
> - `meetingId` is the **id** of an [onlineMeeting](../resources/onlineMeeting.md) object.

## Request headers

| Name            | Description               |
| :-------------- | :------------------------ |
| Authorization   | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method only returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete-registratrant-user",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ", "16664f75-11dc-4870-bec6-38c1aaa81431", "gWWckDBR6UOI8_yzWCzeNw,6pAAiSU1bkGqc8soJZw5Pg,3aMJxgQBxEufdo7_Qube_w,YgKy1Rtx-0SFjRbv-ww1ag,Cuzk8JP_iTTWqCOyVcalVA"]
}-->

```http
DELETE https://graph.microsoft.com/beta/users/16664f75-11dc-4870-bec6-38c1aaa81431/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration/registrants/gWWckDBR6UOI8_yzWCzeNw,6pAAiSU1bkGqc8soJZw5Pg,3aMJxgQBxEufdo7_Qube_w,YgKy1Rtx-0SFjRbv-ww1ag,Cuzk8JP_iTTWqCOyVcalVA
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Users["{user-id}"].OnlineMeetings["{onlineMeeting-id}"].Registration.Registrants["{meetingRegistrantBase-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "name": "delete-registratrant-user",
}-->

```http
HTTP/1.1 204 No Content
```
