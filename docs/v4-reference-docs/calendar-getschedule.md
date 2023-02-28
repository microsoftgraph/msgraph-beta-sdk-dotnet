---
title: "calendar: getSchedule"
description: "Get the free/busy availability information for a collection of users, distributions lists, or resources, for a specified time period."
ms.localizationpriority: high
author: "tariq-sharif"
ms.prod: "outlook"
doc_type: apiPageType
---

# calendar: getSchedule

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Calendars.Read, Calendars.ReadWrite    |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Calendars.Read, Calendars.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/calendar/getSchedule
POST /users/{id|userPrincipalName}/calendar/getSchedule
```

## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type  | string | Nature of the data in the body of an entity, which is application/json. Required.  |
| Prefer: outlook.timezone | string | Use this to specify the time zone for start and end times in the response. If not specified, those time values are returned in UTC. Optional. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|availabilityViewInterval|Int32|Represents the duration of a time slot in an **availabilityView** in the response. The default is 30 minutes, minimum is 5, maximum is 1440. Optional.|
|endTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date, time, and time zone that the period ends.|
|schedules|String collection|A collection of SMTP addresses of users, distribution lists, or resources to get availability information for.|
|startTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date, time, and time zone that the period starts.|

## Response

If successful, this method returns a `200 OK` response code and a collection of [scheduleInformation](../resources/scheduleinformation.md) objects for each object in the `schedules` parameter.
## Example
##### Request
The following example gets the availability information for two users for the specified date, time, and time zone.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "calendar_getSchedule"
}-->
```http
POST https://graph.microsoft.com/beta/me/calendar/getSchedule
Prefer: outlook.timezone="Pacific Standard Time"
Content-Type: application/json

{
    "schedules": ["adelev@contoso.onmicrosoft.com", "meganb@contoso.onmicrosoft.com"],
    "startTime": {
        "dateTime": "2019-03-15T09:00:00",
        "timeZone": "Pacific Standard Time"
    },
    "endTime": {
        "dateTime": "2019-03-15T18:00:00",
        "timeZone": "Pacific Standard Time"
    },
    "availabilityViewInterval": 60
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var schedules = new List<String>()
{
	"adelev@contoso.onmicrosoft.com",
	"meganb@contoso.onmicrosoft.com"
};

var startTime = new DateTimeTimeZone
{
	DateTime = "2019-03-15T09:00:00",
	TimeZone = "Pacific Standard Time"
};

var endTime = new DateTimeTimeZone
{
	DateTime = "2019-03-15T18:00:00",
	TimeZone = "Pacific Standard Time"
};

var availabilityViewInterval = 60;

await graphClient.Me.Calendar
	.GetSchedule(schedules,endTime,startTime,availabilityViewInterval)
	.Request()
	.Header("Prefer","outlook.timezone=\"Pacific Standard Time\"")
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

