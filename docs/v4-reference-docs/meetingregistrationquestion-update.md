---
title: "Update meetingRegistrationQuestion"
description: "Update a custom meeting registration question associated with a meetingRegistration object."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Update meetingRegistrationQuestion

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update a [custom registration question](../resources/meetingregistrationquestion.md) associated with a [meetingRegistration](../resources/meetingregistration.md) object on behalf of the organizer.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
| Delegated (work or school account) | OnlineMeetings.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/onlineMeetings/{meetingId}/registration/customQuestions/{id}
```

## Request headers

| Name            | Description               |
| :-------------- | :------------------------ |
| Authorization   | Bearer {token}. Required. |

## Request body

In the request body, supply only the properties that need to be updated in a JSON representation of a [meetingRegistrationQuestion](../resources/meetingregistrationquestion.md) object.

## Response

If successful, this method returns a `200 OK` response code and an updated [meetingRegistrationQuestion](../resources/meetingregistrationquestion.md) object in the response body.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update-custom-question",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ", "MSNhYjc5NWI4MC119zX3gwMDIwX3lvdXJfeDAwMjBfam8="]
}-->

```http
PATCH https://graph.microsoft.com/beta/me/onlineMeetings/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ/registration/customQuestions/MSNhYjc5NWI4MC119zX3gwMDIwX3lvdXJfeDAwMjBfam8=
Content-Type: application/json

{
  "answerInputType": "radioButton",
  "answerOptions": [
    "Software Engineer",
    "Software Development Manager",
    "Product Manager",
    "Data scientist",
    "Other"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var meetingRegistrationQuestion = new MeetingRegistrationQuestion
{
	AnswerInputType = AnswerInputType.RadioButton,
	AnswerOptions = new List<String>()
	{
		"Software Engineer",
		"Software Development Manager",
		"Product Manager",
		"Data scientist",
		"Other"
	}
};

await graphClient.Me.OnlineMeetings["{onlineMeeting-id}"].Registration.CustomQuestions["{meetingRegistrationQuestion-id}"]
	.Request()
	.UpdateAsync(meetingRegistrationQuestion);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

> **Note**: The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "name": "update-custom-question",
  "@odata.type": "microsoft.graph.meetingRegistrationQuestion"
}-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('16664f75-11dc-4870-bec6-38c1aaa81431')/onlineMeetings('MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZ')/registration/customQuestions/$entity",
  "id": "MSNhYjc5NWI4MC119zX3gwMDIwX3lvdXJfeDAwMjBfam8=",
  "displayName": "What's your job position?",
  "isRequired": false,
  "answerInputType": "radioButton",
  "answerOptions": [
      "Software Engineer",
      "Software Development Manager",
      "Product Manager",
      "Data scientist",
      "Other"
  ]
}
```
