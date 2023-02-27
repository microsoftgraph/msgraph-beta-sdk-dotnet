---
title: "Create bookingService"
description: "Create a new bookingService for the specified bookingbusiness."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Create bookingService

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Create a new [bookingService](../resources/bookingservice.md) for the specified [bookingBusiness](../resources/bookingbusiness.md).
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
POST /bookingBusinesses/{id}/services

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}. Required.|

## Request body
In the request body, supply a JSON representation of a [bookingService](../resources/bookingservice.md) object.


## Response
If successful, this method returns a `201 Created` response code and a [bookingService](../resources/bookingservice.md) object in the response body.

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_bookingservice_from_bookingbusiness",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com"]
}-->
```http
POST https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/services
Content-type: application/json

{
    "@odata.type":"#microsoft.graph.bookingService",
    "defaultDuration":"PT1H30M",
    "defaultLocation":{
        "@odata.type":"#microsoft.graph.location",
        "address":{
            "@odata.type":"#microsoft.graph.physicalAddress",
            "city":"Buffalo",
            "countryOrRegion":"USA",
            "postalCode":"98052",
            "postOfficeBox":null,
            "state":"NY",
            "street":"4567 First Street",
            "type@odata.type":"#microsoft.graph.physicalAddressType",
            "type":null
        },
        "coordinates":null,
        "displayName":"Contoso Lunch Delivery",
        "locationEmailAddress":null,
        "locationType@odata.type":"#microsoft.graph.locationType",
        "locationType":null,
        "locationUri":null,
        "uniqueId":null,
        "uniqueIdType@odata.type":"#microsoft.graph.locationUniqueIdType",
        "uniqueIdType":null
    },
    "defaultPrice":10.0,
    "defaultPriceType@odata.type":"#microsoft.graph.bookingPriceType",
    "defaultPriceType":"fixedPrice",
    "defaultReminders@odata.type":"#Collection(microsoft.graph.bookingReminder)",
    "defaultReminders":[
        {
            "@odata.type":"#microsoft.graph.bookingReminder",
            "message":"Please be reminded that this service is tomorrow.",
            "offset":"P1D",
            "recipients@odata.type":"#microsoft.graph.bookingReminderRecipients",
            "recipients":"allAttendees"
        }
    ],
    "description":"Individual bento box lunch delivery",
    "displayName":"Bento",
    "isLocationOnline": true,
    "smsNotificationsEnabled": true,
    "languageTag": "en-US",
    "isHiddenFromCustomers":false,
    "notes":"Home-cooked special",
    "postBuffer":"PT10M",
    "preBuffer":"PT5M",
    "schedulingPolicy":{
        "@odata.type":"#microsoft.graph.bookingSchedulingPolicy",
        "allowStaffSelection":true,
        "maximumAdvance":"P10D",
        "minimumLeadTime":"PT10H",
        "sendConfirmationsToOwner":true,
        "timeSlotInterval":"PT1H"
    },
    "staffMemberIds@odata.type":"#Collection(String)",
    "staffMemberIds":[
        "d90d1e8c-5cfe-48cf-a2d5-966267375b6a",
        "2f5f8794-0b29-45b5-b56a-2eb5ff7aa880"
    ],
    "isAnonymousJoinEnabled": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingService = new BookingService
{
	DefaultDuration = new Duration("PT1H30M"),
	DefaultLocation = new Location
	{
		Address = new PhysicalAddress
		{
			City = "Buffalo",
			CountryOrRegion = "USA",
			PostalCode = "98052",
			PostOfficeBox = null,
			State = "NY",
			Street = "4567 First Street",
			Type = null,
			AdditionalData = new Dictionary<string, object>()
			{
				{"type@odata.type", "#microsoft.graph.physicalAddressType"}
			}
		},
		Coordinates = null,
		DisplayName = "Contoso Lunch Delivery",
		LocationEmailAddress = null,
		LocationType = null,
		LocationUri = null,
		UniqueId = null,
		UniqueIdType = null,
		AdditionalData = new Dictionary<string, object>()
		{
			{"locationType@odata.type", "#microsoft.graph.locationType"},
			{"uniqueIdType@odata.type", "#microsoft.graph.locationUniqueIdType"}
		}
	},
	DefaultPrice = 10,
	DefaultPriceType = BookingPriceType.FixedPrice,
	DefaultReminders = new List<BookingReminder>()
	{
		new BookingReminder
		{
			Message = "Please be reminded that this service is tomorrow.",
			Offset = new Duration("P1D"),
			Recipients = BookingReminderRecipients.AllAttendees,
			AdditionalData = new Dictionary<string, object>()
			{
				{"recipients@odata.type", "#microsoft.graph.bookingReminderRecipients"}
			}
		}
	},
	Description = "Individual bento box lunch delivery",
	DisplayName = "Bento",
	IsLocationOnline = true,
	SmsNotificationsEnabled = true,
	LanguageTag = "en-US",
	IsHiddenFromCustomers = false,
	Notes = "Home-cooked special",
	PostBuffer = new Duration("PT10M"),
	PreBuffer = new Duration("PT5M"),
	SchedulingPolicy = new BookingSchedulingPolicy
	{
		AllowStaffSelection = true,
		MaximumAdvance = new Duration("P10D"),
		MinimumLeadTime = new Duration("PT10H"),
		SendConfirmationsToOwner = true,
		TimeSlotInterval = new Duration("PT1H")
	},
	StaffMemberIds = new List<String>()
	{
		"d90d1e8c-5cfe-48cf-a2d5-966267375b6a",
		"2f5f8794-0b29-45b5-b56a-2eb5ff7aa880"
	},
	IsAnonymousJoinEnabled = false,
	AdditionalData = new Dictionary<string, object>()
	{
		{"defaultPriceType@odata.type", "#microsoft.graph.bookingPriceType"},
		{"defaultReminders@odata.type", "#Collection(microsoft.graph.bookingReminder)"},
		{"staffMemberIds@odata.type", "#Collection(String)"}
	}
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"].Services
	.Request()
	.AddAsync(bookingService);

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
  "@odata.type": "microsoft.graph.bookingService"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#bookingBusinesses('Contosolunchdelivery%40contoso.onmicrosoft.com')/services/$entity",
    "id": "57da6774-a087-4d69-b0e6-6fb82c339976",
    "displayName": "Bento",
    "defaultDuration": "PT1H30M",
    "defaultPrice": 10.0,
    "defaultPriceType": "fixedPrice",
    "description": "Individual bento box lunch delivery",
    "isHiddenFromCustomers": false,
    "notes": "Home-cooked special",
    "preBuffer": "PT5M",
    "postBuffer": "PT10M",
    "staffMemberIds": [],
    "isLocationOnline": true,
    "smsNotificationsEnabled": true,
    "webUrl": "https://outlook.office365.com/owa/calendar/Contosolunchdelivery@contoso.onmicrosoft.com/bookings/s/gkcGIq92Z0u5h4FWB9Qgcg2",
    "defaultLocation": {
        "displayName": "Contoso Lunch Delivery",
        "locationEmailAddress": null,
        "locationUri": "",
        "locationType": null,
        "uniqueId": null,
        "uniqueIdType": null,
        "address": {
            "type": "home",
            "postOfficeBox": "",
            "street": "4567 First Street",
            "city": "Buffalo",
            "state": "NY",
            "countryOrRegion": "USA",
            "postalCode": "98052"
        },
        "coordinates": {
            "altitude": null,
            "latitude": null,
            "longitude": null,
            "accuracy": null,
            "altitudeAccuracy": null
        }
    },
    "defaultReminders": [
        {
            "offset": "P1D",
            "recipients": "allAttendees",
            "message": "Please be reminded that this service is tomorrow."
        }
    ],
    "schedulingPolicy": {
        "timeSlotInterval": "PT1H",
        "minimumLeadTime": "PT10H",
        "maximumAdvance": "P10D",
        "sendConfirmationsToOwner": true,
        "allowStaffSelection": true
    }
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create bookingService",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


