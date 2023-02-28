---
title: "List customers"
description: "Get a list of bookingCustomer objects."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# List customers

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Get a list of [bookingCustomer](../resources/bookingcustomer.md) objects.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  Bookings.Read.All, BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /bookingBusinesses/{id}/customers
```
## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {code}|

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and collection of [bookingCustomer](../resources/bookingcustomer.md) objects in the response body.
## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_customers",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/customers
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customers = await graphClient.BookingBusinesses["{bookingBusiness-id}"].Customers
	.Request()
	.GetAsync();

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
  "@odata.type": "microsoft.graph.bookingCustomer",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#bookingBusinesses('Contosolunchdelivery%40contoso.onmicrosoft.com')/customers",
    "value": [
        {
            "id": "80b5ddda-1e3b-4c9d-abe2-d606cc075e2e",
            "displayName": "Adele Vance",
            "emailAddress": "adelev@proseware.com",
            "addresses": [],
            "phones": []
        },
        {
            "id": "8bb19078-0f45-4efb-b2c5-da78b860f73a",
            "displayName": "Adele Vance",
            "emailAddress": "adelev@proseware.com",
            "addresses": [
                {
                    "postOfficeBox":"",
                    "street":"4567 Main Street",
                    "city":"Buffalo",
                    "state":"NY",
                    "countryOrRegion":"USA",
                    "postalCode":"98052",
                    "type":"home"
                },
                {
                    "postOfficeBox":"",
                    "street":"4570 Main Street",
                    "city":"Buffalo",
                    "state":"NY",
                    "countryOrRegion":"USA",
                    "postalCode":"98054",
                    "type":"business"
                }
            ],
            "phones": [
                {
                    "number": "206-555-0100",
                    "type": "home"
                },
                {
                    "number": "206-555-0200",
                    "type": "business"
                }
            ]
        },
        {
            "id": "829e3cb5-3d4d-4319-a8de-1953aedaa166",
            "displayName": "Bob Kelly",
            "emailAddress": "bobk@tailspintoys.com",
            "addresses": [],
            "phones": []
        },
        {
            "id": "7ed53fa5-9ef2-4f2f-975b-27447440bc09",
            "displayName": "Jordan Miller",
            "emailAddress": "jordanm@contoso.com",
            "addresses": [],
            "phones": []
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List customers",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
