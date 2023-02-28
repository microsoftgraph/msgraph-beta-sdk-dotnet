---
title: "Update bookingcustomer"
description: "Update the properties of a bookingCustomer object."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Update bookingcustomer

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Update the properties of a [bookingCustomer](../resources/bookingcustomer.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | BookingsAppointment.ReadWrite.All, Bookings.Read.All  |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
PATCH /bookingBusinesses/{id}/customers/{id}
```

## Optional request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|displayName|String|The name of the customer.|
|emailAddress|String|The SMTP address of the customer.|
|addresses|[physicalAddress](../resources/physicaladdress.md) collection|Addresses associated with the customer, including home, business and other addresses.|
|phones|[phone](../resources/phone.md) collection|Phone numbers associated with the customer, including home, business and mobile numbers.|

## Response
If successful, this method returns a `200 OK` response code and updated [bookingCustomer](../resources/bookingcustomer.md) object in the response body.
## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_bookingcustomer",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com", "8bb19078-0f45-4efb-b2c5-da78b860f73a"]
}-->
```http
PATCH https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/customers/8bb19078-0f45-4efb-b2c5-da78b860f73a
Content-type: application/json

{
    "displayName": "Adele",
    "emailAddress": "adele@relecloud.com"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingCustomer = new BookingCustomer
{
	DisplayName = "Adele",
	EmailAddress = "adele@relecloud.com"
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"].Customers["{bookingCustomer-id}"]
	.Request()
	.UpdateAsync(bookingCustomer);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

