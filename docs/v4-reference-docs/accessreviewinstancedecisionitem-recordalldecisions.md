---
title: "accessReviewInstanceDecisionItem: recordAllDecisions"
description: "Record the decisions for an accessReviewInstanceDecisionItem object."
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# accessReviewInstanceDecisionItem: recordAllDecisions
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

As a reviewer of an access review, record a decision for an [accessReviewInstanceDecisionItem](../resources/accessReviewInstanceDecisionItem.md) that is assigned to you and that matches the principal or resource IDs specified. If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.Read.All, AccessReview.ReadWrite.All  |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.Read.All, AccessReview.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /identityGovernance/accessReviews/decisions/filterByCurrentUser(on='reviewer')/recordAllDecisions
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|decision|String| The decision to provide. The possible values are `Approve`, `Deny`, `DontKnow`. |
|justification|String|Justification to provide for the decision.|
|principalId|String|If provided, all decision items matching the principalId will have this decision recorded.|
|resourceId|String|If provided, all decision items matching the resourceId will have this decision recorded.|



## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "accessreviewinstancedecisionitem-recordalldecisions"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/accessReviews/decisions/filterByCurrentUser(on='reviewer')/recordAllDecisions
Content-Type: application/json

{
  "decision": "Deny",
  "justification": "Alice switched teams and no longer works with this group",
  "principalId": "2043848d-e422-473c-8607-88a3319ff491",
  "resourceId": "733ef921-89e1-4d7e-aeff-83612223c37e"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var decision = "Deny";

var justification = "Alice switched teams and no longer works with this group";

var principalId = "2043848d-e422-473c-8607-88a3319ff491";

var resourceId = "733ef921-89e1-4d7e-aeff-83612223c37e";

await graphClient.IdentityGovernance.AccessReviews.Decisions
	.FilterByCurrentUser(null)
	.RecordAllDecisions(decision,justification,principalId,resourceId)
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
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

