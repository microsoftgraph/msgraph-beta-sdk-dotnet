---
title: "user: reminderView"
description: "Return a list of calendar reminders within the specified start and end times. "
author: "iamgirishck"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# user: reminderView

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Return a list of event reminders in a user calendar within the specified start and end times. 

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Calendars.Read, Calendars.ReadWrite    |
|Delegated (personal Microsoft account) | Calendars.Read, Calendars.ReadWrite    |
|Application | Calendars.Read, Calendars.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /users/{id | userPrincipalName}/reminderView(startDateTime=startDateTime-value,endDateTime=endDateTime-value)
```

## Function parameters
In the request URL, provide the following function parameters with values.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|startDateTime|String|The start date and time of the event for which the reminder is set up. The value is represented in ISO 8601 format, for example, "2015-11-08T19:00:00.0000000".|
|endDateTime|String|The end date and time of the event for which the reminder is set up. The value is represented in ISO 8601 format, for example, "2015-11-08T20:00:00.0000000".|

## Request headers
| Header       | Value|
|:-----------|:------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type   | application/json |
| Prefer | {Time-zone}. Optional, UTC assumed if absent.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `200 OK` response code and [reminder](../resources/reminder.md) collection object in the response body.

## Example
Here is an example of how to call this API.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_reminderview"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/reminderView(startDateTime='2017-06-05T10:00:00.0000000',endDateTime='2017-06-11T11:00:00.0000000')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reminderView = await graphClient.Me
	.ReminderView("2017-06-05T10:00:00.0000000","2017-06-11T11:00:00.0000000")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

