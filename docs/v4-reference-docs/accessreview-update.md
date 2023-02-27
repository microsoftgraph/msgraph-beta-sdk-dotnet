---
title: "Update accessReview (deprecated)"
description: "In the Azure AD access reviews feature, update an existing accessReview object to change one or more of its properties."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Update accessReview (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, update an existing [accessReview](../resources/accessreview.md) object to change one or more of its properties.

This API is not intended to change the reviewers or decisions of a review.  To change the reviewers, use the [addReviewer](accessreview-addreviewer.md) or [removeReviewer](accessreview-removereviewer.md) APIs.  To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the [stop](accessreview-stop.md) API. To apply the decisions to the target group or app access rights, use the [apply](accessreview-apply.md) API. 


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
PATCH /accessReviews/{reviewId}
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply a JSON representation of the parameters of an [accessReview](../resources/accessreview.md) object.

The following table shows the properties that can be supplied when you update an accessReview.

| Property      | Type           | Description                                                                                                |
|:--------------|:---------------|:-----------------------------------------------------------------------------------------------------------|
| displayName   | String         | The access review name.                                                                                    |
| startDateTime | DateTimeOffset | The DateTime when the review is scheduled to be start.  This must be a date in the future.                 |
| endDateTime   | DateTimeOffset | The DateTime when the review is scheduled to end. This must be at least one day later than the start date. |
| description   | String         | The description, to show to the reviewers.                                                                 |



## Response
If successful, this method returns a `204 Accepted` response code and an [accessReview](../resources/accessreview.md) object in the response body.

## Example

This is an example of updating a one-time (not reoccurring) access review.

##### Request
In the request body, supply a JSON representation of the new properties of the [accessReview](../resources/accessreview.md) object.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_accessReview"
}-->
```http
PATCH https://graph.microsoft.com/beta/accessReviews/006111db-0810-4494-a6df-904d368bd81b
Content-type: application/json

{
    "displayName":"TestReview new name"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReview = new AccessReview
{
	DisplayName = "TestReview new name"
};

await graphClient.AccessReviews["{accessReview-id}"]
	.Request()
	.UpdateAsync(accessReview);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

