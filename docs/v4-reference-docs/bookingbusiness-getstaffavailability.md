---
title: "bookingsBusiness: getStaffAvailability"
description: "Get the availability information of staff members of a Microsoft Bookings calendar."
ms.localizationpriority: medium
author: kwekua
ms.prod: "bookings"
doc_type: apiPageType
---

# bookingsBusiness: getStaffAvailability

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the availability information of [staff members](../resources/bookingstaffmember.md) of a [Microsoft Bookings calendar](../resources/bookingappointment.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Not supported.   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Calendar.Read, Calendar.ReadWrite, Bookings.Read.All, Calendars.ReadWrite  |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /bookingBusinesses/{id}/getStaffAvailability
```

## Request header

|Name |Description |
|:--------------|:------------|
|Authorization |Bearer {code}. Required. |
|Content-Type| application/json. Required.|

## Request body

In the request body, pass the list of staff IDs along with two other parameters of [dateTimeTimeZone resource type](/graph/resources/datetimetimezone) called **startDateTime** and **endDateTime**. These correspond to the two timestamps between which the staff availability will be returned.

## Response

If successful, this method returns a `200 OK` response code and a [staffAvailabilityItem](../resources/staffavailabilityitem.md) collection in the response body.

## Example

### Request
The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "bookingbusiness_getstaffavailability",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com"]
}-->

```msgraph-interactive
POST https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/getStaffAvailability 
Content-Type: application/json 

{
    "staffIds": [
        "311a5454-08b2-4560-ba1c-f715e938cb79"
    ],
    "startDateTime": {
        "dateTime": "2022-01-25T00:00:00",
        "timeZone": "India Standard Time"
    },
    "endDateTime": {
        "dateTime": "2022-01-26T17:00:00",
        "timeZone": "Pacific Standard Time"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var staffIds = new List<String>()
{
	"311a5454-08b2-4560-ba1c-f715e938cb79"
};

var startDateTime = new DateTimeTimeZone
{
	DateTime = "2022-01-25T00:00:00",
	TimeZone = "India Standard Time"
};

var endDateTime = new DateTimeTimeZone
{
	DateTime = "2022-01-26T17:00:00",
	TimeZone = "Pacific Standard Time"
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"]
	.GetStaffAvailability(staffIds,startDateTime,endDateTime)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following example shows the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.staffAvailabilityItem",
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{ 
    "staffAvailabilityItem": [ 
        { 
            "staffId": "311a5454-08b2-4560-ba1c-f715e938cb79", 
            "availabilityItems": [ 
                { 
                    "status": "Available", 
                    "startDateTime": { 
                        "dateTime": "2022-01-24T08:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "endDateTime": { 
                        "dateTime": "2022-01-24T15:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "serviceId": "" 
                }, 
                { 
                    "status": "Busy", 
                    "startDateTime": { 
                        "dateTime": "2022-01-24T15:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "endDateTime": { 
                        "dateTime": "2022-01-24T16:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "serviceId": "57da6774-a087-4d69-b0e6-6fb82c339976" 
                }, 
                { 
                    "status": "Available", 
                    "startDateTime": { 
                        "dateTime": "2022-01-24T16:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "endDateTime": { 
                        "dateTime": "2022-01-24T17:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "serviceId": "" 
                }, 
                { 
                    "status": "Available", 
                    "startDateTime": { 
                        "dateTime": "2022-01-25T08:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "endDateTime": { 
                        "dateTime": "2022-01-25T17:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "serviceId": "" 
                }, 
                { 
                    "status": "Available", 
                    "startDateTime": { 
                        "dateTime": "2022-01-26T08:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "endDateTime": { 
                        "dateTime": "2022-01-26T17:00:00", 
                        "timeZone": "(UTC-08:00) Pacific Time (US & Canada)" 
                    }, 
                    "serviceId": "" 
                } 
            ] 
        } 
    ] 
}
```
<!-- 
In the response body, for each staff member, their available windows are returned. The types of status of the windows are explained below.

|Type      | Explanation              |
|:--------------------|:---------------------------------------------------------|
|Available | The staff member is available in the given window.   |
|slotAvailable | The staff member has an appointment in the given window. The appointment is for a service which has **maxAttendeecount** more than 1. The customer can join this appointment as there are empty slots available.   |
|Busy | The staff member has an appointment in the given window. Either the staff member has an appointment for a service which has **maxAttendeecount** equal to 1 or the staff has an appointment for a service with **maxAttendeecount** more than 1 but without any available slots.  |


-->
