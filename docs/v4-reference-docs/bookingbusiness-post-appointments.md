---
title: "Create bookingAppointment"
description: "Create a new bookingAppointment for the specified bookingBusiness."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Create bookingAppointment

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Create a new [bookingAppointment](../resources/bookingappointment.md) for the specified [bookingBusiness](../resources/bookingbusiness.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | BookingsAppointment.ReadWrite.All, Bookings.Read.All  |

> [!NOTE]
> If you create a custom app using application permissions, you must follow the [Business rules validation](/graph/bookingsbusiness-business-rules).

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /bookingBusinesses/{id}/appointments

```

## Request headers

| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}. Required.|

## Request body

In the request body, supply a JSON representation of [bookingAppointment](../resources/bookingappointment.md) object.

If the maximum number of customers (**maximumAttedeesCount**) allowed in the [service](../resources/bookingservice.md) is greater than 1:

- Make sure that the customers exist in the Booking Calendar. If they don’t, create using the [Create bookingCustomer](bookingbusiness-post-customers.md) operation.
- Pass valid customer IDs when you create or update the appointment. If the customer ID is not valid, that customer won't be included in the appointment object.

## Response

If successful, this method returns a `201 Created` response code and a [bookingAppointment](../resources/bookingappointment.md) object in the response body.

## Example

### Request

The following is an example of the request. This appointment does not involve booking specific staff members.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_bookingappointment_from_bookingbusiness",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com"]
}-->
```http
POST https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/appointments
Content-type: application/json

{   
    "@odata.type":"#microsoft.graph.bookingAppointment",
    "customerEmailAddress":"jordanm@contoso.com",
    "customerLocation":{
        "@odata.type":"#microsoft.graph.location",
        "address":{
            "@odata.type":"#microsoft.graph.physicalAddress",
            "city":"Buffalo",
            "countryOrRegion":"USA",
            "postalCode":"98052",
            "postOfficeBox":null,
            "state":"NY",
            "street":"123 First Avenue",
            "type@odata.type":"#microsoft.graph.physicalAddressType",
            "type":null
        },
        "coordinates":null,
        "displayName":"Customer",
        "locationEmailAddress":null,
        "locationType@odata.type":"#microsoft.graph.locationType",
        "locationType":null,
        "locationUri":null,
        "uniqueId":null,
        "uniqueIdType@odata.type":"#microsoft.graph.locationUniqueIdType",
        "uniqueIdType":null
    },
    "customerName":"Jordan Miller",
    "customerNotes":"Please be on time.",
    "customerPhone":"213-555-0199",
    "customerTimeZone":"America/Chicago",
    "smsNotificationsEnabled":true,
    "end":{
        "@odata.type":"#microsoft.graph.dateTimeTimeZone",
        "dateTime":"2018-05-01T12:30:00.0000000+00:00",
        "timeZone":"UTC"
    },
    "invoiceAmount":10.0,
    "invoiceDate":{
        "@odata.type":"#microsoft.graph.dateTimeTimeZone",
        "dateTime":"2018-05-01T12:30:00.0000000+00:00",
        "timeZone":"UTC"
    },
    "invoiceId":"1001",
    "invoiceStatus@odata.type":"#microsoft.graph.bookingInvoiceStatus",
    "invoiceStatus":"open",
    "invoiceUrl":"theInvoiceUrl",
    "isLocationOnline": true,
    "optOutOfCustomerEmail": false,
    "anonymousJoinWebUrl": null,
    "postBuffer": "PT10M",
    "preBuffer": "PT5M",
    "price": 10.0,
    "priceType@odata.type": "#microsoft.graph.bookingPriceType",
    "priceType": "fixedPrice",
    "reminders@odata.type": "#Collection(microsoft.graph.bookingReminder)",
    "reminders": [
        {
            "@odata.type": "#microsoft.graph.bookingReminder",
            "message": "This service is tomorrow",
            "offset": "P1D",
            "recipients@odata.type": "#microsoft.graph.bookingReminderRecipients",
            "recipients": "allAttendees"
        },
        {
            "@odata.type": "#microsoft.graph.bookingReminder",
            "message": "Please be available to enjoy your lunch service.",
            "offset": "PT1H",
            "recipients@odata.type": "#microsoft.graph.bookingReminderRecipients",
            "recipients": "customer"
        },
        {
            "@odata.type": "#microsoft.graph.bookingReminder",
            "message": "Please check traffic for next cater.",
            "offset": "PT2H",
            "recipients@odata.type": "#microsoft.graph.bookingReminderRecipients",
            "recipients": "staff"
        }
    ],
    "serviceId": "57da6774-a087-4d69-b0e6-6fb82c339976",
    "serviceLocation": {
        "@odata.type": "#microsoft.graph.location",
        "address": {
            "@odata.type": "#microsoft.graph.physicalAddress",
            "city": "Buffalo",
            "countryOrRegion": "USA",
            "postalCode": "98052",
            "postOfficeBox": null,
            "state": "NY",
            "street": "123 First Avenue",
            "type@odata.type": "#microsoft.graph.physicalAddressType",
            "type": null
        },
        "coordinates": null,
        "displayName": "Customer location",
        "locationEmailAddress": null,
        "locationType@odata.type": "#microsoft.graph.locationType",
        "locationType": null,
        "locationUri": null,
        "uniqueId": null,
        "uniqueIdType@odata.type": "#microsoft.graph.locationUniqueIdType",
        "uniqueIdType": null
    },
    "serviceName": "Catered bento",
    "serviceNotes": "Customer requires punctual service.",
    "start": {
        "@odata.type": "#microsoft.graph.dateTimeTimeZone",
        "dateTime": "2018-05-01T12:00:00.0000000+00:00",
        "timeZone": "UTC"
    },
    "maximumAttendeesCount": 5,
    "filledAttendeesCount": 1,
    "customers": [
        {
            "@odata.type": "#microsoft.graph.bookingCustomerInformation",
            "customerId": "7ed53fa5-9ef2-4f2f-975b-27447440bc09",
            "name": "Jordan Miller",
            "emailAddress": "jordanm@contoso.com",
            "phone": "213-555-0199",
            "notes": null,
            "location": {
                "@odata.type": "#microsoft.graph.location",
                "displayName": "Customer",
                "locationEmailAddress": null,
                "locationUri": "",
                "locationType": null,
                "uniqueId": null,
                "uniqueIdType": null,
                "address": {
                    "@odata.type": "#microsoft.graph.physicalAddress",
                    "type": "home",
                    "postOfficeBox": "",
                    "street": "",
                    "city": "",
                    "state": "",
                    "countryOrRegion": "",
                    "postalCode": ""
                },
                "coordinates": {
                    "altitude": null,
                    "latitude": null,
                    "longitude": null,
                    "accuracy": null,
                    "altitudeAccuracy": null
                }
            },
            "timeZone":"America/Chicago",
            "customQuestionAnswers": [
                {
                    "questionId": "3bc6fde0-4ad3-445d-ab17-0fc15dba0774",
                    "question": "What is your age",
                    "answerInputType": "text",
                    "answerOptions": [],
                    "isRequired": true,
                    "answer": "25",
                    "selectedOptions": []
                }
            ]
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingAppointment = new BookingAppointment
{
	CustomerEmailAddress = "jordanm@contoso.com",
	CustomerLocation = new Location
	{
		Address = new PhysicalAddress
		{
			City = "Buffalo",
			CountryOrRegion = "USA",
			PostalCode = "98052",
			PostOfficeBox = null,
			State = "NY",
			Street = "123 First Avenue",
			Type = null,
			AdditionalData = new Dictionary<string, object>()
			{
				{"type@odata.type", "#microsoft.graph.physicalAddressType"}
			}
		},
		Coordinates = null,
		DisplayName = "Customer",
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
	CustomerName = "Jordan Miller",
	CustomerNotes = "Please be on time.",
	CustomerPhone = "213-555-0199",
	CustomerTimeZone = "America/Chicago",
	SmsNotificationsEnabled = true,
	End = new DateTimeTimeZone
	{
		DateTime = "2018-05-01T12:30:00+00:00",
		TimeZone = "UTC"
	},
	InvoiceAmount = 10,
	InvoiceDate = new DateTimeTimeZone
	{
		DateTime = "2018-05-01T12:30:00+00:00",
		TimeZone = "UTC"
	},
	InvoiceId = "1001",
	InvoiceStatus = BookingInvoiceStatus.Open,
	InvoiceUrl = "theInvoiceUrl",
	IsLocationOnline = true,
	OptOutOfCustomerEmail = false,
	AnonymousJoinWebUrl = null,
	PostBuffer = new Duration("PT10M"),
	PreBuffer = new Duration("PT5M"),
	Price = 10,
	PriceType = BookingPriceType.FixedPrice,
	Reminders = new List<BookingReminder>()
	{
		new BookingReminder
		{
			Message = "This service is tomorrow",
			Offset = new Duration("P1D"),
			Recipients = BookingReminderRecipients.AllAttendees,
			AdditionalData = new Dictionary<string, object>()
			{
				{"recipients@odata.type", "#microsoft.graph.bookingReminderRecipients"}
			}
		},
		new BookingReminder
		{
			Message = "Please be available to enjoy your lunch service.",
			Offset = new Duration("PT1H"),
			Recipients = BookingReminderRecipients.Customer,
			AdditionalData = new Dictionary<string, object>()
			{
				{"recipients@odata.type", "#microsoft.graph.bookingReminderRecipients"}
			}
		},
		new BookingReminder
		{
			Message = "Please check traffic for next cater.",
			Offset = new Duration("PT2H"),
			Recipients = BookingReminderRecipients.Staff,
			AdditionalData = new Dictionary<string, object>()
			{
				{"recipients@odata.type", "#microsoft.graph.bookingReminderRecipients"}
			}
		}
	},
	ServiceId = "57da6774-a087-4d69-b0e6-6fb82c339976",
	ServiceLocation = new Location
	{
		Address = new PhysicalAddress
		{
			City = "Buffalo",
			CountryOrRegion = "USA",
			PostalCode = "98052",
			PostOfficeBox = null,
			State = "NY",
			Street = "123 First Avenue",
			Type = null,
			AdditionalData = new Dictionary<string, object>()
			{
				{"type@odata.type", "#microsoft.graph.physicalAddressType"}
			}
		},
		Coordinates = null,
		DisplayName = "Customer location",
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
	ServiceName = "Catered bento",
	ServiceNotes = "Customer requires punctual service.",
	Start = new DateTimeTimeZone
	{
		DateTime = "2018-05-01T12:00:00+00:00",
		TimeZone = "UTC"
	},
	MaximumAttendeesCount = 5,
	FilledAttendeesCount = 1,
	Customers = new List<BookingCustomerInformationBase>()
	{
		new BookingCustomerInformation
		{
			CustomerId = "7ed53fa5-9ef2-4f2f-975b-27447440bc09",
			Name = "Jordan Miller",
			EmailAddress = "jordanm@contoso.com",
			Phone = "213-555-0199",
			Notes = null,
			Location = new Location
			{
				DisplayName = "Customer",
				LocationEmailAddress = null,
				LocationUri = "",
				LocationType = null,
				UniqueId = null,
				UniqueIdType = null,
				Address = new PhysicalAddress
				{
					Type = PhysicalAddressType.Home,
					PostOfficeBox = "",
					Street = "",
					City = "",
					State = "",
					CountryOrRegion = "",
					PostalCode = ""
				},
				Coordinates = new OutlookGeoCoordinates
				{
					Altitude = null,
					Latitude = null,
					Longitude = null,
					Accuracy = null,
					AltitudeAccuracy = null
				}
			},
			TimeZone = "America/Chicago",
			CustomQuestionAnswers = new List<BookingQuestionAnswer>()
			{
				new BookingQuestionAnswer
				{
					QuestionId = "3bc6fde0-4ad3-445d-ab17-0fc15dba0774",
					Question = "What is your age",
					AnswerInputType = AnswerInputType.Text,
					AnswerOptions = new List<String>()
					{
					},
					IsRequired = true,
					Answer = "25",
					SelectedOptions = new List<String>()
					{
					}
				}
			}
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"invoiceStatus@odata.type", "#microsoft.graph.bookingInvoiceStatus"},
		{"priceType@odata.type", "#microsoft.graph.bookingPriceType"},
		{"reminders@odata.type", "#Collection(microsoft.graph.bookingReminder)"}
	}
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"].Appointments
	.Request()
	.AddAsync(bookingAppointment);

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
  "@odata.type": "microsoft.graph.bookingAppointment"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#bookingBusinesses('Contosolunchdelivery%40contoso.onmicrosoft.com')/appointments/$entity",
    "id": "AAMkADc7zF4J0AAA8v_KnAAA=",
    "selfServiceAppointmentId": "00000000-0000-0000-0000-000000000000",
    "isLocationOnline": true,
    "joinWebUrl": "https://teams.microsoft.com/l/meetup-join/19%3ameeting_MTlhZTE3MDUtODk0Yy00MGZkLTlhNzktN2FmYTk3MDUxNmE2%40thread.v2/0?context=%7b%22Tid%22%3a%22995fa18c-b557-4694-8d07-b89779d6dc77%22%2c%22Oid%22%3a%22d4d260ab-989d-490e-b121-e2066391807a%22%7d",
    "smsNotificationsEnabled": true,
    "customerId": "7ed53fa5-9ef2-4f2f-975b-27447440bc09",
    "customerName": "Jordan Miller",
    "customerEmailAddress": "jordanm@contoso.com",
    "customerPhone": "213-555-0199",
    "customerTimeZone":"America/Chicago",
    "customerNotes": null,
    "serviceId": "57da6774-a087-4d69-b0e6-6fb82c339976",
    "serviceName": "Catered bento",
    "duration": "PT30M",
    "preBuffer": "PT5M",
    "postBuffer": "PT10M",
    "priceType": "fixedPrice",
    "price": 10.0,
    "serviceNotes": "Customer requires punctual service.",
    "optOutOfCustomerEmail": false,
    "anonymousJoinWebUrl": null,
    "staffMemberIds": [],
    "invoiceAmount": 10.0,
    "invoiceId": "1001",
    "invoiceStatus": "open",
    "invoiceUrl": "theInvoiceUrl",
    "customerLocation": {
        "displayName": "Customer",
        "locationEmailAddress": null,
        "locationUri": "",
        "locationType": null,
        "uniqueId": null,
        "uniqueIdType": null,
        "address": {
            "type": "home",
            "postOfficeBox": "",
            "street": "",
            "city": "",
            "state": "",
            "countryOrRegion": "",
            "postalCode": ""
        },
        "coordinates": {
            "altitude": null,
            "latitude": null,
            "longitude": null,
            "accuracy": null,
            "altitudeAccuracy": null
        }
    },
    "start": {
        "dateTime": "2018-05-01T12:00:00.0000000Z",
        "timeZone": "UTC"
    },
    "end": {
        "dateTime": "2018-05-01T12:30:00.0000000Z",
        "timeZone": "UTC"
    },
    "serviceLocation": {
        "displayName": "Customer location (123 First Avenue, Buffalo, NY 98052, USA)",
        "locationEmailAddress": null,
        "locationUri": "",
        "locationType": null,
        "uniqueId": null,
        "uniqueIdType": null,
        "address": {
            "type": "home",
            "postOfficeBox": "",
            "street": "",
            "city": "",
            "state": "",
            "countryOrRegion": "",
            "postalCode": ""
        },
        "coordinates": {
            "altitude": null,
            "latitude": null,
            "longitude": null,
            "accuracy": null,
            "altitudeAccuracy": null
        }
    },
    "reminders": [
        {
            "offset": "P1D",
            "recipients": "allAttendees",
            "message": "This service is tomorrow"
        },
        {
            "offset": "PT1H",
            "recipients": "customer",
            "message": "Please be available to enjoy your lunch service."
        },
        {
            "offset": "PT2H",
            "recipients": "staff",
            "message": "Please check traffic for next cater."
        }
    ],
    "invoiceDate": {
        "dateTime": "2018-05-01T12:30:00.0000000Z",
        "timeZone": "UTC"
    },
    "maximumAttendeesCount": 5,
    "filledAttendeesCount": 1,
    "customers": [
        {
            "@odata.type": "#microsoft.graph.bookingCustomerInformation",
            "customerId": "7ed53fa5-9ef2-4f2f-975b-27447440bc09",
            "name": "Jordan Miller",
            "emailAddress": "jordanm@contoso.com",
            "phone": "213-555-0199",
            "notes": null,
            "location": {
                "@odata.type": "#microsoft.graph.location",
                "displayName": "Customer",
                "locationEmailAddress": null,
                "locationUri": "",
                "locationType": null,
                "uniqueId": null,
                "uniqueIdType": null,
                "address": {
                    "@odata.type": "#microsoft.graph.physicalAddress",
                    "type": "home",
                    "postOfficeBox": "",
                    "street": "",
                    "city": "",
                    "state": "",
                    "countryOrRegion": "",
                    "postalCode": ""
                },
                "coordinates": {
                    "altitude": null,
                    "latitude": null,
                    "longitude": null,
                    "accuracy": null,
                    "altitudeAccuracy": null
                }
            },
            "timeZone": "America/Chicago",
            "customQuestionAnswers": [
                {
                    "questionId": "3bc6fde0-4ad3-445d-ab17-0fc15dba0774",
                    "question": "What is your age",
                    "answerInputType": "text",
                    "answerOptions": [],
                    "isRequired": true,
                    "answer": "25",
                    "selectedOptions": []
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
  "description": "Create bookingAppointment",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


