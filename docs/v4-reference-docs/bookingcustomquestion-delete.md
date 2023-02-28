---
title: "Delete bookingCustomQuestion"
description: "Delete a bookingCustomQuestion object."
author: "razortbone"
ms.localizationpriority: medium
ms.prod: "bookings"
doc_type: apiPageType
---

# Delete bookingCustomQuestion

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete the specified [bookingCustomQuestion](../resources/bookingcustomquestion.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                    |
| :------------------------------------- | :----------------------------------------------------------------------------- |
| Delegated (work or school account)     | BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All |
| Delegated (personal Microsoft account) | Not supported.                                                                 |
| Application                            | Not supported.                                                                 |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /bookingBusinesses/{bookingBusinessesId}/customQuestions/{bookingCustomQuestionId}
```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_bookingcustomQuestions",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com", "80b5ddda-1e3b-4c9d-abe2-d606cc075e2e"]
}
-->

```http
DELETE https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/customQuestions/80b5ddda-1e3b-4c9d-abe2-d606cc075e2e
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.BookingBusinesses["{bookingBusiness-id}"].CustomQuestions["{bookingCustomQuestion-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

```http
HTTP/1.1 204 No Content
```
