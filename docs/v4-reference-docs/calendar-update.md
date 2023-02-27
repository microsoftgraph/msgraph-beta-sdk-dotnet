---
title: "Update calendar"
description: "Update the properties of a calendar object. The calendar can be one for a user, "
ms.localizationpriority: medium
author: "iamgirishck"
ms.prod: "outlook"
doc_type: apiPageType
---

# Update calendar

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [calendar](../resources/calendar.md) object. The calendar can be one for a [user](../resources/user.md), 
or the default calendar of a Microsoft 365 [group](../resources/group.md).
## Permissions
Depending on the type of calendar that the event is in and the permission type (delegated or application) requested, one of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Calendar | Delegated (work or school account) | Delegated (personal Microsoft account) | Application |
|:-----|:-----|:-----|:-----|
| user calendar | Calendars.ReadWrite | Calendars.ReadWrite | Calendars.ReadWrite |
| group calendar | Group.ReadWrite.All | Not supported. | Not supported. |


## HTTP request
<!-- { "blockType": "ignored" } -->
A user's or group's default [calendar](../resources/calendar.md).
```http
PATCH /me/calendar
PATCH /users/{id | userPrincipalName}/calendar
PATCH /groups/{id}/calendar
```
A user's [calendar](../resources/calendar.md) in the default [calendarGroup](../resources/calendargroup.md).
```http
PATCH /me/calendars/{id}
PATCH /users/{id | userPrincipalName}/calendars/{id}
```
A user's [calendar](../resources/calendar.md) in a specific [calendarGroup](../resources/calendargroup.md).
```http
PATCH /me/calendarGroups/{id}/calendars/{id}
PATCH /users/{id | userPrincipalName}/calendarGroups/{id}/calendars/{id}
```
## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|color|String|Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: LightBlue=0, LightGreen=1, LightOrange=2, LightGray=3, LightYellow=4, LightTeal=5, LightPink=6, LightBrown=7, LightRed=8, MaxColor=9, Auto=-1|
|isDefaultCalendar|Boolean|True if this calendar is the user's default calendar, false otherwise.|
|name|String|The calendar name.|

## Response

If successful, this method returns a `200 OK` response code and updated [calendar](../resources/calendar.md) object in the response body.
## Example
##### Request
The following example updates the name of the signed-in user's default calendar.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_calendar"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/calendar
Content-type: application/json

{
  "name": "Social events"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var calendar = new Calendar
{
	Name = "Social events"
};

await graphClient.Me.Calendar
	.Request()
	.UpdateAsync(calendar);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

