---
title: "List accessReviews (deprecated)"
description: "Retrieve accessReview objects for a businessFlowTemplate."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# List accessReviews (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
Retrieve the [accessReview](../resources/accessreview.md) objects for a particular [businessFlowTemplate](../resources/businessflowtemplate.md). A list of zero or more **accessReview** objects are returned, for each one-time and recurring access review that was created with that business flow template.  Note that business flow template IDs are case sensitive.

>[!NOTE]
> If any of the access reviews that match the filter is a recurring access review, one **accessReview** object will be returned to represent each recurring series as a whole, in addition to any current, past and the next upcoming instance. For example, if there is a monthly recurring access review of guest members of group A, a quarterly recurring access review of guest members of group B, and a one-time access review of guest members of group C, each of these recurrences have just started, and the caller queries for access reviews with a business flow template of reviews of guest members of groups, three objects will be returned representing the three series, as well as three objects for the current access review instances, and potentially three objects for the next upcoming instances. To retrieve the instances of a recurring access review, or the access review instance scheduled for a particular month or quarter, the caller can subsequently navigate the **instance** relationship of the recurring **accessReview** object. The **instance** relationship links to the **accessReview** objects for a current or the past instances of the recurring access review.

If many access reviews match the filter, to improve efficiency and avoid timeouts, retrieve the result set in pages, by including both the `$top` query parameter with a page size, for example 100, and the `$skip=0` query parameter in the request. These parameters can be included even when you do not anticipate that the request will span multiple pages. When a result set spans multiple pages, Microsoft Graph returns that page with an `@odata.nextLink` property in the response that contains a URL to the next page of results. If that property is present, continue making additional requests with the `@odata.nextLink` URL in each response, until all the results are returned, as described in [paging Microsoft Graph data in your app](/graph/paging).

The **accessReview** objects returned by this API will not include nested structure properties such as **settings**, or relationships.  To retrieve an access review settings or relationships, use the [get accessReview](accessreview-get.md) API.


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
GET /accessReviews?$filter=businessFlowTemplateId eq {businessFlowTemplate-id}&$top={pagesize}&$skip=0
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
Do not supply a request body.

## Response
If successful, this method returns a `200 OK` response code and an array of [accessReview](../resources/accessreview.md) objects in the response body.

## Examples
##### Request
The following example shows a request to retrieve all the one-time and recurring access reviews for a business flow template '6e4f3d20-c5c3-407f-9695-8460952bcc68'.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessReviews"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/accessReviews?$filter=businessFlowTemplateId+eq+'6e4f3d20-c5c3-407f-9695-8460952bcc68'&$top=100&$skip=0
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviews = await graphClient.AccessReviews
	.Request()
	.Filter("businessFlowTemplateId eq '6e4f3d20-c5c3-407f-9695-8460952bcc68'")
	.Skip(0)
	.Top(100)
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

