---
title: "Get accessReview (deprecated)"
description: "In the Azure AD access reviews feature, retrieve an accessReview object."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Get accessReview (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, retrieve an [accessReview](../resources/accessreview.md) object.  

To retrieve the reviewers of the access review, use the [list accessReview reviewers](accessreview-listreviewers.md) API. To retrieve the decisions of the access review, use the [list accessReview decisions](accessreview-listdecisions.md) API, or the [list my accessReview decisions](accessreview-listmydecisions.md) API.

If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the `instances` relationship of that series to retrieve an [accessReview](../resources/accessreview.md) collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.Read.All, AccessReview.ReadWrite.Membership, AccessReview.ReadWrite.All  |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | AccessReview.Read.All, AccessReview.ReadWrite.Membership  |

In order to call this API, the signed in user must also be in a directory role that permits them to read an access review, or the user can be assigned as a reviewer on the access review.  For more details, see the role and permission requirements for [access reviews](../resources/accessreviews-root.md).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /accessReviews/{reviewId}
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and an [accessReview](../resources/accessreview.md) object in the response body.

## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessReview"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/accessReviews/2b83cc42-09db-46f6-8c6e-16fec466a82d
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReview = await graphClient.AccessReviews["{accessReview-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

