---
title: "Delete calendar"
description: "Delete a calendar other than the default calendar."
author: "iamgirishck"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Delete calendar

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a calendar other than the default calendar.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Calendars.ReadWrite    |
|Delegated (personal Microsoft account) | Calendars.ReadWrite    |
|Application | Calendars.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
A user's [calendar](../resources/calendar.md) other than the default calendar in the default [calendarGroup](../resources/calendargroup.md).
```http
DELETE /me/calendars/{id}
DELETE /users/{id | userPrincipalName}/calendars/{id}
```
A [calendar](../resources/calendar.md) other than the default calendar, in a specific [calendarGroup](../resources/calendargroup.md).
```http
DELETE /me/calendarGroups/{id}/calendars/{id}
DELETE /users/{id | userPrincipalName}/calendarGroups/{id}/calendars/{id}
```
## Request headers
| Name           |  Type    | Description|
|:---------------|:---------|:----------|
| Authorization  |  string  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_calendar"
}-->
```http
DELETE https://graph.microsoft.com/beta/me/calendar
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Calendar
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

