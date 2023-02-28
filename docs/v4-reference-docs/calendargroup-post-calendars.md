---
title: "Create Calendar"
description: "Use this API to create a new calendar in a calendar group for a user."
author: "iamgirishck"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create Calendar

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Use this API to create a new calendar in a calendar group for a [user](../resources/user.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Calendars.ReadWrite                         |
| Delegated (personal Microsoft account) | Calendars.ReadWrite                         |
| Application                            | Calendars.ReadWrite                         |

## HTTP request

<!-- { "blockType": "ignored" } -->

A user's default [calendarGroup](../resources/calendargroup.md).

```http
POST /me/calendars
POST /users/{id | userPrincipalName}/calendars
```

Any [calendarGroup](../resources/calendargroup.md) of a user.

```http
POST /me/calendarGroups/{id}/calendars
POST /users/{id | userPrincipalName}/calendarGroups/{id}/calendars
```

## Request headers

| Header        | Value                       |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of [calendar](../resources/calendar.md) object.

## Response

If successful, this method returns `201 Created` response code and [calendar](../resources/calendar.md) object in the response body.

## Example

##### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["AAMkADYAAAR9NR5AAA="],
  "name": "create_calendar_from_calendargroup"
}-->

```http
POST https://graph.microsoft.com/beta/me/calendargroups/AAMkADYAAAR9NR5AAA=/calendars
Content-type: application/json

{
  "name": "Marketing calendar"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var calendar = new Calendar
{
	Name = "Marketing calendar"
};

await graphClient.Me.CalendarGroups["{calendarGroup-id}"].Calendars
	.Request()
	.AddAsync(calendar);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

