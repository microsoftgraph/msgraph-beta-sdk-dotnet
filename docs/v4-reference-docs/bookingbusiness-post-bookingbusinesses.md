---
title: "Create bookingBusiness"
description: "Create a new Microsoft Bookings business in a tenant."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# Create bookingBusiness

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Create a new Microsoft Bookings business in a tenant.

This is the first step in setting up a Bookings business where you must specify the business display name. You can include other information such as business address, web site address, and scheduling policy, or set that information later by [updating](bookingbusiness-update.md) the **bookingBusiness**.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  Bookings.Manage.All  |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /bookingBusinesses

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, supply a JSON representation of [bookingBusiness](../resources/bookingbusiness.md) object.


## Response
If successful, this method returns `201, Created` response code and [bookingBusiness](../resources/bookingbusiness.md) object in the response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_bookingbusiness_from_bookingbusinesses"
}-->
```http
POST https://graph.microsoft.com/beta/bookingBusinesses
Content-type: application/json

{
    "displayName":"Fourth Coffee",
    "address":{
        "postOfficeBox":"P.O. Box 123",
        "street":"4567 Main Street",
        "city":"Buffalo",
        "state":"NY",
        "countryOrRegion":"USA",
        "postalCode":"98052"
    },
    "phone":"206-555-0100",
    "email":"manager@fourthcoffee.com",
    "webSiteUrl":"https://www.fourthcoffee.com",
    "defaultCurrencyIso":"USD"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingBusiness = new BookingBusiness
{
	DisplayName = "Fourth Coffee",
	Address = new PhysicalAddress
	{
		PostOfficeBox = "P.O. Box 123",
		Street = "4567 Main Street",
		City = "Buffalo",
		State = "NY",
		CountryOrRegion = "USA",
		PostalCode = "98052"
	},
	Phone = "206-555-0100",
	Email = "manager@fourthcoffee.com",
	WebSiteUrl = "https://www.fourthcoffee.com",
	DefaultCurrencyIso = "USD"
};

await graphClient.BookingBusinesses
	.Request()
	.AddAsync(bookingBusiness);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

