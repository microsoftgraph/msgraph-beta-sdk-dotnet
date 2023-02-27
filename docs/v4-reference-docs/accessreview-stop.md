---
title: "Stop accessReview (deprecated)"
description: "In the Azure AD access reviews feature, stop a currently active accessReview.  The target object can be either a one-time access review, or an instance of a recurring access review.  (To prevent a recurring access review from starting future instances, update it to change its scheduled end date).  After the access review stops, reviewers can no longer give input, and the access review decisions can be applied."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Stop accessReview (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, stop a currently active [accessReview](../resources/accessreview.md).  The target object can be either a one-time access review, or an instance of a recurring access review.  (To prevent a recurring access review from starting future instances, [update it](accessreview-update.md) to change its scheduled end date).  After the access review stops, reviewers can no longer give input, and the access review decisions can be applied.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.Membership, AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | AccessReview.ReadWrite.Membership  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /accessReviews/{reviewId}/stop
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
Do not supply a request body for this method.


## Response
If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "stop_accessReview"
}-->
```http
POST https://graph.microsoft.com/beta/accessReviews/2975E9B5-44CE-4E71-93D3-30F03B5AA992/stop
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.AccessReviews["{accessReview-id}"]
	.Stop()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

