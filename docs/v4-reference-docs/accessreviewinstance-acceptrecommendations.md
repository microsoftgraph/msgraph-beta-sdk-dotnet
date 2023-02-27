---
title: "accessReviewInstance: acceptRecommendations"
description: "Allows the acceptance of recommendations on all decisions that have not been reviewed for an access review instance for which the calling user is a reviewer. "
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# accessReviewInstance: acceptRecommendations

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Allows the acceptance of recommendations on all [accessReviewInstanceDecisionItem](../resources/accessreviewinstancedecisionitem.md) objects that have not been reviewed for an [accessReviewInstance](../resources/accessreviewinstance.md) object for which the calling user is a reviewer. Recommendations are generated if **recommendationsEnabled** is `true` on the [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object. If there is not a recommendation on an [accessReviewInstanceDecisionItem](../resources/accessreviewinstancedecisionitem.md) object no decision will be recorded.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All |
| Delegated (personal Microsoft account)| Not supported. |

The signed-in user must also be a reviewer on the accessReviewInstance.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/pendingAccessReviewInstances/{instance-id}/acceptRecommendations
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
  "name": "acceptrecommendations_accessReviewInstance"
}-->
```http
POST https://graph.microsoft.com/beta/me/pendingAccessReviewInstances/70a68410-67f3-4d4c-b946-6989e050be19/acceptRecommendations
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.PendingAccessReviewInstances["{accessReviewInstance-id}"]
	.AcceptRecommendations()
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

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2017-06-25 00:00:01 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Accept recommendations accessReviewInstance",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
