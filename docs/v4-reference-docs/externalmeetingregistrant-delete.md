---
title: "Delete externalMeetingRegistrant"
description: "Delete an externalMeetingRegistrant from an online meeting."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Delete externalMeetingRegistrant

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

The meeting organizer removes an [externalMeetingRegistrant](../resources/externalmeetingregistrant.md) from an online meeting which has [externalMeetingRegistration](../resources/externalmeetingregistration.md) enabled.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
| Delegated (work or school account) | OnlineMeetings.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application | OnlineMeetings.ReadWrite.All |

To use application permission for this API, tenant administrators must create an [application access policy](/graph/cloud-communication-online-meeting-application-access-policy) and grant it to a user to authorize the app configured in the policy to fetch online meetings and/or online meeting artifacts on behalf of that user (with user ID specified in the request path).

## HTTP request

To remove an external meeting registrant with delegated (`/me`) and app (`/users/{userId}/`) permission:

<!-- { "blockType": "ignored" } -->
```http
DELETE /me/onlineMeetings/{meetingId}/registration/registrants/{registrantId}
DELETE /users/{userId}/onlineMeetings/{meetingId}/registration/registrants/{registrantId}
```

> [!TIP]
>
> - `userId` is the **objectId** of the meeting organizer.
> - `meetingId` is the **id** of an [onlineMeeting](../resources/onlinemeeting.md) object.
> - `registrantId` is the **id** of an [externalMeetingRegistrant](../resources/externalmeetingregistrant.md) object.

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
  "name": "delete-externalregistratrant",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ", "9d96988d-a66a-46ce-aad7-0b245615b297"]
}-->

```http
DELETE https://graph.microsoft.com/beta/me/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration/registrants/9d96988d-a66a-46ce-aad7-0b245615b297
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.OnlineMeetings["{onlineMeeting-id}"].Registration.Registrants["{meetingRegistrantBase-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "name": "delete-externalregistratrant"
}-->

```http
HTTP/1.1 204 No Content
```
