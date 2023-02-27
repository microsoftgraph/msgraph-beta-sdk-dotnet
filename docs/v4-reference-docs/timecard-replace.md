---
title: "Replace timeCard"
description: "Update an existing timeCard entry."
author: "akumar39"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Replace timeCard

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Replace an existing [timeCard](../resources/timecard.md) with updated values.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Schedule.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Schedule.ReadWrite.All*  |

>\* **Important:** When you use application permissions, you must include the `MS-APP-ACTS-AS` header in the request.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PUT /teams/{teamId}/schedule/timecards/{timeCardID}
```

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |
| MS-APP-ACTS-AS | The ID of the user on behalf of whom the app is acting. Required when you use the application permission scope. |

## Request body

In the request body, supply a JSON representation of a [timeCard](../resources/timecard.md) object.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "timecard_replace",
  "sampleKeys": ["fd15cad8-80f6-484f-9666-3caf695fbf32", "TCK_3cd7413f-0337-433b-9a49-da0923185b3f"]
}-->

```http
PUT https://graph.microsoft.com/beta/teams/fd15cad8-80f6-484f-9666-3caf695fbf32/schedule/timeCards/TCK_3cd7413f-0337-433b-9a49-da0923185b3f
Content-type: application/json

{
    "userId": "70e47528-2fae-42b5-9d8e-ee73ccd90603",
    "state": "clockedOut",
    "confirmedBy": "None",
    "notes": null,
    "clockInEvent": {
        "dateTime": "2021-05-21T21:58:41.327Z",
        "atApprovedLocation": null,
        "notes": {
            "contentType": "text",
            "content": "update sample notes"
        }
    },
    "clockOutEvent": {
        "dateTime": "2021-05-21T22:01:46.205Z",
        "atApprovedLocation": null,
        "notes": {
            "contentType": "text",
            "content": "update sample notes"
        }
    },
    "breaks": [
        {
            "breakId": "BRK_138f4751-68b1-44c1-aca2-2b26cba9e73f",
            "notes": null,
            "start": {
                "dateTime": "2021-05-21T21:59:59.328Z",
                "atApprovedLocation": null,
                "notes": {
                    "contentType": "text",
                    "content": "update sample notes"
                }
            },
            "end": {
                "dateTime": "2021-05-21T22:01:10.205Z",
                "atApprovedLocation": null,
                "notes": {
                    "contentType": "text",
                    "content": "update sample notes"
                }
            }
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var timeCard = new TimeCard
{
	UserId = "70e47528-2fae-42b5-9d8e-ee73ccd90603",
	State = TimeCardState.ClockedOut,
	ConfirmedBy = ConfirmedBy.None,
	Notes = null,
	ClockInEvent = new TimeCardEvent
	{
		DateTime = DateTimeOffset.Parse("2021-05-21T21:58:41.327Z"),
		AtApprovedLocation = null,
		Notes = new ItemBody
		{
			ContentType = BodyType.Text,
			Content = "update sample notes"
		}
	},
	ClockOutEvent = new TimeCardEvent
	{
		DateTime = DateTimeOffset.Parse("2021-05-21T22:01:46.205Z"),
		AtApprovedLocation = null,
		Notes = new ItemBody
		{
			ContentType = BodyType.Text,
			Content = "update sample notes"
		}
	},
	Breaks = new List<TimeCardBreak>()
	{
		new TimeCardBreak
		{
			BreakId = "BRK_138f4751-68b1-44c1-aca2-2b26cba9e73f",
			Notes = null,
			Start = new TimeCardEvent
			{
				DateTime = DateTimeOffset.Parse("2021-05-21T21:59:59.328Z"),
				AtApprovedLocation = null,
				Notes = new ItemBody
				{
					ContentType = BodyType.Text,
					Content = "update sample notes"
				}
			},
			End = new TimeCardEvent
			{
				DateTime = DateTimeOffset.Parse("2021-05-21T22:01:10.205Z"),
				AtApprovedLocation = null,
				Notes = new ItemBody
				{
					ContentType = BodyType.Text,
					Content = "update sample notes"
				}
			}
		}
	}
};

await graphClient.Teams["{team-id}"].Schedule.TimeCards["{timeCard-id}"]
	.Request()
	.PutAsync(timeCard);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response. 
<!-- {
  "blockType": "response",
  "name": "timecard_replace"
} -->

```http
HTTP/1.1 204 No Content
```


<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Replace an existing timeCard",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
