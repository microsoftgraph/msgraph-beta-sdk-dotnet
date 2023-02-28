---
title: "accessReviewInstance: sendReminder"
description: "Sends a reminder to the reviewers of a currently active accessReviewInstance."
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# accessReviewInstance: sendReminder

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Send a reminder to the reviewers of a currently active [accessReviewInstance](../resources/accessreviewinstance.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /identityGovernance/accessReviews/definitions/{definitionId}/instances/{instanceId}/sendReminder
```
## Request headers
None.

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `204, No Content` response code. It does not return anything in the response body.

## Examples
### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "sendReminder_accessReview_2"
}-->
```http
POST https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/04e5c3b2-9db2-40d3-a204-128f4956ae8e/instances/70463350-742e-4909-bfa5-bc23447bd002/sendReminder
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"]
	.SendReminder()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": false
} -->
```http
HTTP/1.1 204 No Content
```

<!--
{
  "type": "#page.annotation",
  "description": "SendReminder accessReviewInstance",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
