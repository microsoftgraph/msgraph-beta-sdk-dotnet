---
title: "Create inferenceClassificationOverride"
description: "Create a Focused Inbox override for a sender identified by an SMTP address. Future messages from that SMTP address will be consistently classified "
ms.localizationpriority: medium
doc_type: apiPageType
author: "abheek-das"
ms.prod: mail
---

# Create inferenceClassificationOverride

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a [focused Inbox](../resources/manage-focused-inbox.md) override for a sender identified by an SMTP address. Future messages from that SMTP address will be consistently classified
as specified in the override.

>[!NOTE]
>- If an override already exists with the same SMTP address, then the **classifyAs** and **name** fields of that override are updated with the provided values.
>- The maximum number of overrides supported for a mailbox is 1000, based on unique sender SMTP addresses.
>- The POST operation supports creating only one override at a time.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.ReadWrite    |
|Delegated (personal Microsoft account) | Mail.ReadWrite    |
|Application | Mail.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/inferenceClassification/overrides
POST /users/{id}/inferenceClassification/overrides
```
## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type | string  | Nature of the data in the body of an entity. Required. |

## Request body
In the request body, supply a JSON representation of [inferenceClassificationOverride](../resources/inferenceclassificationoverride.md) object.

## Response

If successful, this method returns `201 Created` response code and an [inferenceClassificationOverride](../resources/inferenceclassificationoverride.md) object in the response body.

## Example
### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_inferenceclassificationoverride_from_inferenceclassification"
}-->
```http
POST https://graph.microsoft.com/beta/me/inferenceClassification/overrides
Content-type: application/json

{
  "classifyAs": "focused",
  "senderEmailAddress": {
    "name": "Samantha Booth",
    "address": "samanthab@adatum.onmicrosoft.com"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var inferenceClassificationOverride = new InferenceClassificationOverride
{
	ClassifyAs = InferenceClassificationType.Focused,
	SenderEmailAddress = new EmailAddress
	{
		Name = "Samantha Booth",
		Address = "samanthab@adatum.onmicrosoft.com"
	}
};

await graphClient.Me.InferenceClassification.Overrides
	.Request()
	.AddAsync(inferenceClassificationOverride);

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
  "@odata.type": "microsoft.graph.inferenceClassificationOverride"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "classifyAs": "focused",
  "senderEmailAddress": {
    "name": "Samantha Booth",
    "address": "samanthab@adatum.onmicrosoft.com"
  },
  "id": "98f5bdef-576a-404d-a2ea-07a3cf11a9b9"
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create inferenceClassificationOverride",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


