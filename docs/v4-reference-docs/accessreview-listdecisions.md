---
title: "List accessReview decisions (deprecated)"
description: "In the Azure AD access reviews feature, retrieve the decisions of an accessReview object."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# List accessReview decisions (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, retrieve the decisions of an [accessReview](../resources/accessreview.md) object.

Note that a recurring access review will not have a **decisions** relationship.  Instead, the caller must navigate the **instance** relationship to find an [accessReview](../resources/accessreview.md) object for a current or past instance of the access review.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.Read.All, AccessReview.ReadWrite.Membership, AccessReview.ReadWrite.All  |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | AccessReview.Read.All, AccessReview.ReadWrite.Membership |

 The signed in user must also be in a directory role that permits them to read an access review.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /accessReviews/{reviewId}/decisions
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
No request body should be supplied.

## Response
If successful, this method returns a `200 OK` response code and an array of [accessReviewDecision](../resources/accessreviewdecision.md) objects in the response body.

## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessReview_decisions_1"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/accessReviews/2b83cc42-09db-46f6-8c6e-16fec466a82d/decisions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var decisions = await graphClient.AccessReviews["{accessReview-id}"].Decisions
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

