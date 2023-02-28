---
title: "Create externalMeetingRegistration"
description: "Enable external registration for an online meeting."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Create externalMeetingRegistration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Enable registration for an [onlineMeeting](../resources/onlinemeeting.md) using an external registration system. An online meeting can only have one registration enabled.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
| Delegated (work or school account) | OnlineMeetings.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application | OnlineMeetings.ReadWrite.All |

To use application permission for this API, tenant administrators must create an [application access policy](/graph/cloud-communication-online-meeting-application-access-policy) and grant it to a user to authorize the app configured in the policy to fetch online meetings and/or online meeting artifacts on behalf of that user (with user ID specified in the request path).

## HTTP request

To create external meeting registration with delegated (`/me`) and app (`/users/{userId}/`) permission:

<!-- { "blockType": "ignored" } -->
```http
POST /me/onlineMeetings/{meetingId}/registration
POST /users/{userId}/onlineMeetings/{meetingId}/registration
```

> [!TIP]
>
>- `userId` is the **objectId** of the meeting organizer.
>- `meetingId` is the **id** of the [onlineMeeting](../resources/onlinemeeting.md) object.

## Request headers

| Name            | Description               |
| :-------------- | :------------------------ |
| Authorization   | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of an [externalMeetingRegistration](../resources/externalmeetingregistration.md) object.

> [!IMPORTANT]
> You must supply the **@odata.type** property to specify the registration type. For more details, see the following [example](#example).

## Response

If successful, this method returns a `201 Created` response code and an [externalMeetingRegistration](../resources/externalmeetingregistration.md) object in the response body.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create-externalregistration",
  "@odata.type": "microsoft.graph.externalMeetingRegistration",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ"]
}-->

```http
POST https://graph.microsoft.com/beta/me/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.externalMeetingRegistration",
  "allowedRegistrant": "everyone"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var meetingRegistration = new ExternalMeetingRegistration
{
	AllowedRegistrant = MeetingAudience.Everyone
};

await graphClient.Me.OnlineMeetings["{onlineMeeting-id}"].Registration
	.Request()
	.AddAsync(meetingRegistration);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

> **Note**: The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "name": "create-externalregistration",
  "truncated": true,
  "@odata.type": "microsoft.graph.externalMeetingRegistration"
}-->

```http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('16664f75-11dc-4870-bec6-38c1aaa81431')/onlineMeetings('MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ')/registration/$entity",
  "@odata.type": "#microsoft.graph.externalMeetingRegistration",
  "id": "f23714a3-a2f4-4b1d-96d2-bfe9097e7163",
  "allowedRegistrant": "everyone"
}
```
