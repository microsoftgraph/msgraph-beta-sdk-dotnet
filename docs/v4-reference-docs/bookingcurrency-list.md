---
title: "List bookingCurrencies"
description: "Get a list of bookingCurrency objects available to a Microsoft Bookings business."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# List bookingCurrencies

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Get a list of [bookingCurrency](../resources/bookingcurrency.md) objects available to a Microsoft Bookings business.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Bookings.Read.All, BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /bookingCurrencies
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response, including $count, $filter, $select, $skip, and $top.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {code}|

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and collection of [bookingCurrency](../resources/bookingcurrency.md) objects in the response body.
## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_bookingcurrencies"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/bookingCurrencies
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingCurrencies = await graphClient.BookingCurrencies
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

