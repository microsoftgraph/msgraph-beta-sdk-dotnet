---
title: "Create bookingStaffMember"
description: "Create a new staff member in the specified bookingbusiness."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Create bookingStaffMember

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Create a new [staff member](../resources/bookingstaffmember.md) in the specified [bookingBusiness](../resources/bookingbusiness.md).
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  Bookings.ReadWrite.All, Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /bookingBusinesses/{id}/staffMembers

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}. Required.|

## Request body
In the request body, supply a JSON representation of a [bookingStaffMember](../resources/bookingstaffmember.md) object. You must include the following properties:

- **displayName**
- **emailAddress**
- **role**


## Response
If successful, this method returns a `201 Created` response code and a [bookingStaffMember](../resources/bookingstaffmember.md) object in the response body.

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_bookingstaffmember_from_bookingbusiness"
}-->
```http
POST https://graph.microsoft.com/beta/bookingBusinesses/{id}/staffMembers
Content-type: application/json

{
    "@odata.type":"#microsoft.graph.bookingStaffMember",
    "colorIndex":1,
    "displayName":"Dana Swope",
    "emailAddress":"danas@contoso.com",
    "role@odata.type":"#microsoft.graph.bookingStaffRole",
    "role":"externalGuest",
    "timeZone":"America/Chicago",
    "useBusinessHours":true,
    "workingHours@odata.type":"#Collection(microsoft.graph.bookingWorkHours)",
    "workingHours":[
        {
            "@odata.type":"#microsoft.graph.bookingWorkHours",
            "day@odata.type":"#microsoft.graph.dayOfWeek",
            "day":"monday",
            "timeSlots@odata.type":"#Collection(microsoft.graph.bookingWorkTimeSlot)",
            "timeSlots":[
                {
                    "@odata.type":"#microsoft.graph.bookingWorkTimeSlot",
                    "end":"17:00:00.0000000",
                    "start":"08:00:00.0000000"
                }
            ]
        },
        {
            "@odata.type":"#microsoft.graph.bookingWorkHours",
            "day@odata.type":"#microsoft.graph.dayOfWeek",
            "day":"tuesday",
            "timeSlots@odata.type":"#Collection(microsoft.graph.bookingWorkTimeSlot)",
            "timeSlots":[
                {
                    "@odata.type":"#microsoft.graph.bookingWorkTimeSlot",
                    "end":"17:00:00.0000000",
                    "start":"08:00:00.0000000"
                }
            ]
        },
        {
            "@odata.type":"#microsoft.graph.bookingWorkHours",
            "day@odata.type":"#microsoft.graph.dayOfWeek",
            "day":"wednesday",
            "timeSlots@odata.type":"#Collection(microsoft.graph.bookingWorkTimeSlot)",
            "timeSlots":[
                {
                    "@odata.type":"#microsoft.graph.bookingWorkTimeSlot",
                    "end":"17:00:00.0000000",
                    "start":"08:00:00.0000000"
                }
            ]
        },
        {
            "@odata.type":"#microsoft.graph.bookingWorkHours",
            "day@odata.type":"#microsoft.graph.dayOfWeek",
            "day":"thursday",
            "timeSlots@odata.type":"#Collection(microsoft.graph.bookingWorkTimeSlot)",
            "timeSlots":[
                {
                    "@odata.type":"#microsoft.graph.bookingWorkTimeSlot",
                    "end":"17:00:00.0000000",
                    "start":"08:00:00.0000000"
                }
            ]
        },
        {
            "@odata.type":"#microsoft.graph.bookingWorkHours",
            "day@odata.type":"#microsoft.graph.dayOfWeek",
            "day":"friday",
            "timeSlots@odata.type":"#Collection(microsoft.graph.bookingWorkTimeSlot)",
            "timeSlots":[
                {
                    "@odata.type":"#microsoft.graph.bookingWorkTimeSlot",
                    "end":"17:00:00.0000000",
                    "start":"08:00:00.0000000"
                }
            ]
        }
    ],
    "isEmailNotificationEnabled": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingStaffMember = new BookingStaffMember
{
	ColorIndex = 1,
	DisplayName = "Dana Swope",
	EmailAddress = "danas@contoso.com",
	Role = BookingStaffRole.ExternalGuest,
	TimeZone = "America/Chicago",
	UseBusinessHours = true,
	WorkingHours = new List<BookingWorkHours>()
	{
		new BookingWorkHours
		{
			Day = DayOfWeek.Monday,
			TimeSlots = new List<BookingWorkTimeSlot>()
			{
				new BookingWorkTimeSlot
				{
					End = new TimeOfDay(17, 0, 0),
					Start = new TimeOfDay(8, 0, 0)
				}
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"day@odata.type", "#microsoft.graph.dayOfWeek"},
				{"timeSlots@odata.type", "#Collection(microsoft.graph.bookingWorkTimeSlot)"}
			}
		},
		new BookingWorkHours
		{
			Day = DayOfWeek.Tuesday,
			TimeSlots = new List<BookingWorkTimeSlot>()
			{
				new BookingWorkTimeSlot
				{
					End = new TimeOfDay(17, 0, 0),
					Start = new TimeOfDay(8, 0, 0)
				}
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"day@odata.type", "#microsoft.graph.dayOfWeek"},
				{"timeSlots@odata.type", "#Collection(microsoft.graph.bookingWorkTimeSlot)"}
			}
		},
		new BookingWorkHours
		{
			Day = DayOfWeek.Wednesday,
			TimeSlots = new List<BookingWorkTimeSlot>()
			{
				new BookingWorkTimeSlot
				{
					End = new TimeOfDay(17, 0, 0),
					Start = new TimeOfDay(8, 0, 0)
				}
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"day@odata.type", "#microsoft.graph.dayOfWeek"},
				{"timeSlots@odata.type", "#Collection(microsoft.graph.bookingWorkTimeSlot)"}
			}
		},
		new BookingWorkHours
		{
			Day = DayOfWeek.Thursday,
			TimeSlots = new List<BookingWorkTimeSlot>()
			{
				new BookingWorkTimeSlot
				{
					End = new TimeOfDay(17, 0, 0),
					Start = new TimeOfDay(8, 0, 0)
				}
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"day@odata.type", "#microsoft.graph.dayOfWeek"},
				{"timeSlots@odata.type", "#Collection(microsoft.graph.bookingWorkTimeSlot)"}
			}
		},
		new BookingWorkHours
		{
			Day = DayOfWeek.Friday,
			TimeSlots = new List<BookingWorkTimeSlot>()
			{
				new BookingWorkTimeSlot
				{
					End = new TimeOfDay(17, 0, 0),
					Start = new TimeOfDay(8, 0, 0)
				}
			},
			AdditionalData = new Dictionary<string, object>()
			{
				{"day@odata.type", "#microsoft.graph.dayOfWeek"},
				{"timeSlots@odata.type", "#Collection(microsoft.graph.bookingWorkTimeSlot)"}
			}
		}
	},
	IsEmailNotificationEnabled = false,
	AdditionalData = new Dictionary<string, object>()
	{
		{"role@odata.type", "#microsoft.graph.bookingStaffRole"},
		{"workingHours@odata.type", "#Collection(microsoft.graph.bookingWorkHours)"}
	}
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"].StaffMembers
	.Request()
	.AddAsync(bookingStaffMember);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response. 

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.bookingStaffMember"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context":"https://graph.microsoft.com/beta/$metadata#bookingBusinesses('Contosolunchdelivery%40contoso.onmicrosoft.com')/staffMembers/$entity",
    "id":"8ee1c803-a1fa-406d-8259-7ab53233f148",
    "displayName":"Dana Swope",
    "emailAddress":"danas@contoso.com",
    "availabilityIsAffectedByPersonalCalendar":false,
    "colorIndex":1,
    "role":"externalGuest",
    "timeZone":"America/Chicago",
    "useBusinessHours":true,
    "workingHours":[
        {
            "day":"monday",
            "timeSlots":[
                {
                    "start":"08:00:00.0000000",
                    "end":"17:00:00.0000000"
                }
            ]
        },
        {
            "day":"tuesday",
            "timeSlots":[
                {
                    "start":"08:00:00.0000000",
                    "end":"17:00:00.0000000"
                }
            ]
        },
        {
            "day":"wednesday",
            "timeSlots":[
                {
                    "start":"08:00:00.0000000",
                    "end":"17:00:00.0000000"
                }
            ]
        },
        {
            "day":"thursday",
            "timeSlots":[
                {
                    "start":"08:00:00.0000000",
                    "end":"17:00:00.0000000"
                }
            ]
        },
        {
            "day":"friday",
            "timeSlots":[
                {
                    "start":"08:00:00.0000000",
                    "end":"17:00:00.0000000"
                }
            ]
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create bookingStaffMember",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


