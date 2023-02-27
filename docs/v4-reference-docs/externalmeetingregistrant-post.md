---
title: "Create externalMeetingRegistrant"
description: "Enroll an external meeting registrant."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Create externalMeetingRegistrant

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Enroll an [externalMeetingRegistrant](../resources/externalmeetingregistrant.md) in an online meeting which has [externalMeetingRegistration](../resources/externalmeetingregistration.md) enabled. The meeting organizer enrolls someone by providing a unique **id** in the external registration system and gets the unique **joinWebUrl** of this registrant.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
| Delegated (work or school account) | OnlineMeetings.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application | OnlineMeetings.ReadWrite.All |

To use application permission for this API, tenant administrators must create an [application access policy](/graph/cloud-communication-online-meeting-application-access-policy) and grant it to a user to authorize the app configured in the policy to fetch online meetings and/or online meeting artifacts on behalf of that user (with user ID specified in the request path).

## HTTP request

To create an external meeting registrant with delegated (`/me`) and app (`/users/{userId}/`) permission:

<!-- { "blockType": "ignored" } -->
```http
POST /me/onlineMeetings/{meetingId}/registration/registrants
POST /users/{userId}/onlineMeetings/{meetingId}/registration/registrants
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

- If the value of the **allowedRegistrant** property of the [externalMeetingRegistration](../resources/externalmeetingregistration.md) object is `organization`, supply the **id** from the external registration system, the registrant's **tenantId** and **userId** in Azure Active Directory.
- If the value of the **allowedRegistrant** property of the [externalMeetingRegistration](../resources/externalmeetingregistration.md) object is `everyone`, only supply the **id** from the external registration system.

> [!IMPORTANT]
>
>- The **id** from the external registration system can be any form of string.
>- You must supply the **@odata.type** property to specify the registrant type. For more details, see the following [examples](#examples).

## Response

If successful, this method returns a `200 OK` response code and an [externalMeetingRegistrant](../resources/externalmeetingregistrant.md) object in the response body.

## Examples

### Example 1: Enroll a registrant when the meeting registration has allowedRegistrant set to 'everyone'

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "add-externalregistratrant-public",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ"]
}-->

```http
POST https://graph.microsoft.com/beta/me/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration/registrants
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.externalMeetingRegistrant",
  "id": "9d96988d-a66a-46ce-aad7-0b245615b297"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var meetingRegistrantBase = new ExternalMeetingRegistrant
{
	Id = "9d96988d-a66a-46ce-aad7-0b245615b297"
};

await graphClient.Me.OnlineMeetings["{onlineMeeting-id}"].Registration.Registrants
	.Request()
	.AddAsync(meetingRegistrantBase);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "name": "add-externalregistratrant-public",
  "@odata.type": "microsoft.graph.externalMeetingRegistrant"
}-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('16664f75-11dc-4870-bec6-38c1aaa81431')/onlineMeetings('MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ')/registration/registrants/$entity",
  "@odata.type": "#microsoft.graph.externalMeetingRegistrant",
  "id": "30494ab7-7338-4592-bfec-a4333be2a0a6",
  "joinWebUrl": "https://teams.microsoft.com/l/meetup-join/19%3ameeting_NjliNTYxNjktNzAwNi00OTlhLWFmMWEtMGZhY2JjZGM5NmEy%40thread.v2/0?context=%7b%22Tid%22%3a%22909c6581-5130-43e9-88f3-fcb3582cde37%22%2c%22Oid%22%3a%2216664f75-11dc-4870-bec6-38c1aaa81431%22%2c%22prid%22%3a%229d96988d-a66a-46ce-aad7-0b245615b297%22%2c%22isPublic%22%3atrue%7d",
  "userId": null,
  "tenantId": null
}
```

### Example 2: Enroll a registrant when the meeting registration has allowedRegistrant set to 'organization'

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "add-externalregistratrant-private",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ"]
}-->

```http
POST https://graph.microsoft.com/beta/me/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration/registrants
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.externalMeetingRegistrant",
  "id": "30494ab7-7338-4592-bfec-a4333be2a0a6",
  "tenantId": "909c6581-5130-43e9-88f3-fcb3582cde37",
  "userId": "cc515404-b55c-466e-b896-992c918ecc01"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var meetingRegistrantBase = new ExternalMeetingRegistrant
{
	Id = "30494ab7-7338-4592-bfec-a4333be2a0a6",
	TenantId = "909c6581-5130-43e9-88f3-fcb3582cde37",
	UserId = "cc515404-b55c-466e-b896-992c918ecc01"
};

await graphClient.Me.OnlineMeetings["{onlineMeeting-id}"].Registration.Registrants
	.Request()
	.AddAsync(meetingRegistrantBase);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "name": "add-externalregistratrant-private",
  "@odata.type": "microsoft.graph.externalMeetingRegistrant"
}-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('16664f75-11dc-4870-bec6-38c1aaa81431')/onlineMeetings('MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ')/registration/registrants/$entity",
  "@odata.type": "#microsoft.graph.externalMeetingRegistrant",
  "id": "30494ab7-7338-4592-bfec-a4333be2a0a6",
  "joinWebUrl": "https://teams.microsoft.com/l/meetup-join/19%3ameeting_NjliNTYxNjktNzAwNi00OTlhLWFmMWEtMGZhY2JjZGM5NmEy%40thread.v2/0?context=%7b%22Tid%22%3a%22909c6581-5130-43e9-88f3-fcb3582cde37%22%2c%22Oid%22%3a%2216664f75-11dc-4870-bec6-38c1aaa81431%22%2c%22prid%22%3a%2230494ab7-7338-4592-bfec-a4333be2a0a6%22%2c%22isPublic%22%3afalse%7d",
  "userId": "909c6581-5130-43e9-88f3-fcb3582cde37",
  "tenantId": "cc515404-b55c-466e-b896-992c918ecc01"
}
```
