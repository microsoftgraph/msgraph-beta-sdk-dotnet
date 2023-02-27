---
title: "Update shiftPreferences"
description: "Update a user's shift preferences."
author: "akumar39"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Update shiftPreferences

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties and relationships of a [shiftPreferences](../resources/shiftpreferences.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PUT /users/{userId}/settings/shiftPreferences
```

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
In the request body, supply a JSON representation of a [shiftPreferences](../resources/shiftpreferences.md) object.

## Response

If successful, this method returns a `204 NO CONTENT` response code.

## Example

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "shift-get-3"
}-->
```msgraph-interactive
PUT https://graph.microsoft.com/beta/users/871dbd5c-3a6a-4392-bfe1-042452793a50/settings/shiftPreferences
Content-type: application/json

{
    "id": "SHPR_eeab4fb1-20e5-48ca-ad9b-98119d94bee7",
    "@odata.etag": "1a371e53-f0a6-4327-a1ee-e3c56e4b38aa",
    "availability": [
        {
            "recurrence": {
                "pattern": {
                    "type": "Weekly",
                    "daysOfWeek": ["Monday", "Wednesday", "Friday"],
                    "interval": 1
                },
                "range": {
                    "type": "noEnd"
                }
            },
            "timeZone": "Pacific Standard Time",
            "timeSlots": null
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var shiftPreferences = new ShiftPreferences
{
	Id = "SHPR_eeab4fb1-20e5-48ca-ad9b-98119d94bee7",
	Availability = new List<ShiftAvailability>()
	{
		new ShiftAvailability
		{
			Recurrence = new PatternedRecurrence
			{
				Pattern = new RecurrencePattern
				{
					Type = RecurrencePatternType.Weekly,
					DaysOfWeek = new List<DayOfWeek>()
					{
						DayOfWeek.Monday,
						DayOfWeek.Wednesday,
						DayOfWeek.Friday
					},
					Interval = 1
				},
				Range = new RecurrenceRange
				{
					Type = RecurrenceRangeType.NoEnd
				}
			},
			TimeZone = "Pacific Standard Time",
			TimeSlots = null
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.etag", "1a371e53-f0a6-4327-a1ee-e3c56e4b38aa"}
	}
};

await graphClient.Users["{user-id}"].Settings.ShiftPreferences
	.Request()
	.PutAsync(shiftPreferences);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 NO CONTENT
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-12-12 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Update a user's shift preferences",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


