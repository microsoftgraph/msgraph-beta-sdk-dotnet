---
title: "Update calendarpermission"
description: "Update the properties of calendarpermission object."
author: "iamgirishck"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: "apiPageType"
---

# Update calendarPermission

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the permissions assigned to an existing sharee or delegate, through the corresponding [calendarPermission](../resources/calendarpermission.md) object for a calendar.

## Permissions

Depending on the type of calendar that the event is in and the permission type (delegated or application) requested, one of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Calendar | Delegated (work or school account) | Delegated (personal Microsoft account) | Application |
|:-----|:-----|:-----|:-----|
| user calendar | Calendars.ReadWrite | Calendars.ReadWrite | Calendars.ReadWrite |
| group calendar | Group.ReadWrite.All | Not supported. | Not supported. |

## HTTP request

Update the specified permissions of a user's calendar:
<!-- { "blockType": "ignored" } -->
```http
PATCH /users/{id}/calendar/calendarPermissions/{id}
```

Update the specified permissions of a group calendar:
<!-- { "blockType": "ignored" } -->
```http
PATCH /groups/{id}/calendar/calendarPermissions/{id}
```

Update the specified permissions of the user calendar that contains the identified event:
<!-- { "blockType": "ignored" } -->
```http
PATCH /users/{id}/events/{id}/calendar/calendarPermissions/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|role|[calendarRoleType](../resources/calendarpermission.md#calendarroletype-values)| The permission level to change to for the calendar sharee or delegate. |

## Response

If successful, this method returns a `200 OK` response code and an updated [calendarPermission](../resources/calendarpermission.md) object in the response body.

## Examples

### Request

The following example changes the permission level of the sharee, Adele, to `write`.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["RGVmYXVsdA=="],
  "name": "update_calendarpermission"
}-->

```http
PATCH https://graph.microsoft.com/beta/users/{id}/calendar/calendarPermissions/RGVmYXVsdA==
Content-type: application/json

{
  "role": "write"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var calendarPermission = new CalendarPermission
{
	Role = CalendarRoleType.Write
};

await graphClient.Users["{user-id}"].Calendar.CalendarPermissions["{calendarPermission-id}"]
	.Request()
	.UpdateAsync(calendarPermission);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "name": "update_calendarpermission",
  "truncated": true,
  "@odata.type": "microsoft.graph.calendarPermission"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "id": "RGVmYXVsdA==",
    "isRemovable": true,
    "isInsideOrganization": true,
    "role": "write",
    "allowedRoles": [
        "freeBusyRead",
        "limitedRead",
        "read",
        "write"
    ],
    "emailAddress": {
        "name": "Adele Vance",
        "address": "AdeleV@contoso.OnMicrosoft.com"
    }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update calendarpermission",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


