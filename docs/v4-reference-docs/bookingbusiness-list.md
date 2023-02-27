---
title: "List bookingBusinesses"
description: "Get a collection of bookingBusiness objects that has been created for the tenant."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# List bookingBusinesses

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Get a collection of [bookingBusiness](../resources/bookingbusiness.md) objects that has been created for the tenant.

This operation returns only the **id** and **displayName** of each Microsoft Bookings business in the collection. For performance considerations, it does not return other properties. You can get the other properties of a Bookings business by specifying its **id** in a [GET](bookingbusiness-get.md) operation.

You can also query for Bookings businesses by specifying a string in a `query` parameter to do substring matching among the businesses of a tenant. See an [example](#request-2) below.

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
GET /bookingBusinesses
```

## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

This method also supports the `query` parameter which accepts a string value. This parameter limits the GET results to businesses that match the specified string. You can see an [example](#request-2) below.


## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {code}|

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and collection of [bookingBusiness](../resources/bookingbusiness.md) objects in the response body.
## Example
##### Request 1
The following example gets the Bookings businesses in a tenant.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_bookingbusinesses"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/bookingBusinesses
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingBusinesses = await graphClient.BookingBusinesses
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "query_bookingbusinesses"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/bookingBusinesses?query=Adventure
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("query", "Adventure")
};

var bookingBusinesses = await graphClient.BookingBusinesses
	.Request( queryOptions )
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

