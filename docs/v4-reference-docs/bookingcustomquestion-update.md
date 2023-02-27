---
title: "Update bookingCustomQuestion"
description: "Update the properties of a bookingCustomQuestion object."
author: "razortbone"
ms.localizationpriority: medium
ms.prod: "bookings"
doc_type: apiPageType
---

# Update bookingCustomQuestion

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [bookingCustomQuestion](../resources/bookingcustomquestion.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                    |
| :------------------------------------- | :----------------------------------------------------------------------------- |
| Delegated (work or school account)     | BookingsAppointment.ReadWrite.All, Bookings.ReadWrite.All, Bookings.Manage.All |
| Delegated (personal Microsoft account) | Not supported.                                                                 |
| Application                            | Not supported.                                                                 |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

```http
PATCH /bookingBusinesses/{bookingBusinessesId}/customQuestions/{bookingCustomQuestionId}
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

| Property        | Type              | Description                                                                                                         |
| :-------------- | :---------------- | :------------------------------------------------------------------------------------------------------------------ |
| answerInputType | answerInputType   | The expected answer type. The possible values are: `text`, `radioButton`, `unknownFutureValue`. Optional.    |
| answerOptions   | String collection | List of possible answer values. Optional.                                                                   |
| displayName     | String            | The question. Inherited from [bookingNamedEntity](../resources/bookingnamedentity.md). Required. |

## Response

If successful, this method returns a `200 OK` response code and an updated [bookingCustomQuestion](../resources/bookingcustomquestion.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_bookingcustomquestion",
  "sampleKeys": ["contosolunchdelivery@contoso.onmicrosoft.com", "3bc6fde0-4ad3-445d-ab17-0fc15dba0774"]
}
-->

```http
PATCH https://graph.microsoft.com/beta/bookingBusinesses/contosolunchdelivery@contoso.onmicrosoft.com/customQuestions/3bc6fde0-4ad3-445d-ab17-0fc15dba0774
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.bookingCustomQuestion",
  "displayName": "What is your age?",
  "answerInputType": "text",
  "answerOptions": []
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookingCustomQuestion = new BookingCustomQuestion
{
	DisplayName = "What is your age?",
	AnswerInputType = AnswerInputType.Text,
	AnswerOptions = new List<String>()
	{
	}
};

await graphClient.BookingBusinesses["{bookingBusiness-id}"].CustomQuestions["{bookingCustomQuestion-id}"]
	.Request()
	.UpdateAsync(bookingCustomQuestion);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.bookingCustomQuestion"
}
-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.bookingCustomQuestion",
  "id": "3bc6fde0-4ad3-445d-ab17-0fc15dba0774",
  "displayName": "What is your age?",
  "answerInputType": "text",
  "answerOptions": []
}
```
