---
title: "Update bookingbusiness"
description: "Update the properties of a bookingBusiness object."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Update bookingbusiness

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Update the properties of a [bookingBusiness](../resources/bookingbusiness.md) object.
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
PATCH /bookingBusinesses/{id}
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|address|[physicalAddress](../resources/physicaladdress.md)|The street address of the business.|
|businessHours|[bookingWorkHours](../resources/bookingworkhours.md) collection|The hours of operation for the business.|
|businessType|String|The type of business.|
|defaultCurrencyIso|String|The code for the currency that the business operates in on Microsoft Bookings.|
|displayName|String|A name for the business that interfaces with customers.|
|email|String|The email address for the business.|
|languageTag|String|The language of the self service booking page.
|phone|String|The telephone number for the business.|
|schedulingPolicy|[bookingSchedulingPolicy](../resources/bookingschedulingpolicy.md)|Specifies how bookings can be created for this business.|
|webSiteUrl|String|The URL of the business web site.|

## Response
If successful, this method returns a `204, No Content` response code. It does not return anything in the response body.
## Example
##### Request
The following example updates the business email address and scheduling policy, to change the business default booking time slot to an hour, and advance booking up to 30 days.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_bookingbusiness",
  "sampleKeys": ["fabrikam@contoso.onmicrosoft.com"]
}-->
```http
PATCH https://graph.microsoft.com/beta/bookingBusinesses/fabrikam@contoso.onmicrosoft.com
Content-type: application/json

{
  "email": "admin@fabrikam.com",
  "schedulingPolicy": {
      "timeSlotInterval": "PT60M",
      "minimumLeadTime": "P1D",
      "maximumAdvance": "P30D",
      "sendConfirmationsToOwner": true,
      "allowStaffSelection": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingBusiness = new BookingBusiness
{
	Email = "admin@fabrikam.com",
	SchedulingPolicy = new BookingSchedulingPolicy
	{
		TimeSlotInterval = new Duration("PT60M"),
		MinimumLeadTime = new Duration("P1D"),
		MaximumAdvance = new Duration("P30D"),
		SendConfirmationsToOwner = true,
		AllowStaffSelection = true
	}
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"]
	.Request()
	.UpdateAsync(bookingBusiness);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

