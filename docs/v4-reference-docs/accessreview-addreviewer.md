---
title: "Add accessReview reviewer (deprecated)"
description: "In the Azure AD access reviews feature, update an existing accessReview object to add another user as a reviewer.  This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified. This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers. "
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Add accessReview reviewer (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, update an existing [accessReview](../resources/accessreview.md) object to add another user as a reviewer.  This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified. This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers. 


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.Membership, AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | AccessReview.ReadWrite.Membership |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /accessReviews/{reviewId}/reviewers
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply a JSON representation of the ID of a user who will be a reviewer.

The following table shows the properties that can be supplied when you update an accessReview.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| id        | String   | The user ID.|


## Response
If successful, this method returns a `201 Created` response code .

## Example

This is an example of updating a one-time (not reoccurring) access review with an additional reviewer.

##### Request
In the request body, supply a JSON representation of the id of the user object.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "add_accessReview_reviewer"
}-->
```http
POST https://graph.microsoft.com/beta/accessReviews/2b83cc42-09db-46f6-8c6e-16fec466a82d/reviewers
Content-Type: application/json

{
    "id":"006111db-0810-4494-a6df-904d368bd81b"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewReviewer = new AccessReviewReviewer
{
	Id = "006111db-0810-4494-a6df-904d368bd81b"
};

await graphClient.AccessReviews["{accessReview-id}"].Reviewers
	.Request()
	.AddAsync(accessReviewReviewer);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

