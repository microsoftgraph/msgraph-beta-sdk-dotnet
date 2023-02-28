---
title: "bookingBusiness: unpublish"
description: "Make the scheduling page of this business not available to external customers."
ms.localizationpriority: medium
author: "arvindmicrosoft"
ms.prod: "bookings"
doc_type: apiPageType
---

# bookingBusiness: unpublish

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Make the scheduling page of this business not available to external customers.

Set the **isPublished** property to false, and **publicUrl** property to null.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  Bookings.Manage.All   |
|Delegated (personal Microsoft account) | Not supported.   |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /bookingBusinesses/{id}/unpublish

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body

## Response
If successful, this method returns `204 No content` response code. It does not return anything in the response body.

## Example
The following is an example of how to call this API.
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "bookingbusiness_unpublish",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com"]
}-->
```http
POST https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/unpublish
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.BookingBusinesses["{bookingBusiness-id}"]
	.Unpublish()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

