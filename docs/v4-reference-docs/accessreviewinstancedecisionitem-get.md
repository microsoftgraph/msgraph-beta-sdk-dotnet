---
title: "Get accessReviewInstanceDecisionItem"
description: "Read the properties and relationships of an accessReviewInstanceDecisionItem object."
author: "jyothig123"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Get accessReviewInstanceDecisionItem
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [accessReviewInstanceDecisionItem](../resources/accessreviewinstancedecisionitem.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|AccessReview.Read.All, AccessReview.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|AccessReview.Read.All, AccessReview.ReadWrite.All|

## HTTP request

To retrieve a decision on an accessReviewInstance:
<!-- {
  "blockType": "ignored"
}
-->
```http
GET /identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinitionId}/instances/{accessReviewInstanceId}/decisions/{accessReviewInstanceDecisionItemId}
```

To retrieve a decision from a stage of an accessReviewInstance:

<!-- {
  "blockType": "ignored"
}
-->
```http
GET /identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinitionId}/instances/{accessReviewInstanceId}/stages/{accessReviewStageId}/decisions/{accessReviewInstanceDecisionItemId}
```

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [accessReviewInstanceDecisionItem](../resources/accessreviewinstancedecisionitem.md) object in the response body.

## Examples

### Example 1: Retrieve a decision on an accessReviewInstance

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessreviewinstancedecisionitem"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/5eac5a70-7cd7-4f20-92b0-f9dba70dd7f0/instances/6444d4fd-ab55-4608-8cf9-c6702d172bcc/decisions/e6cafba0-cbf0-4748-8868-0810c7f4cc06
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewInstanceDecisionItem = await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"].Decisions["{accessReviewInstanceDecisionItem-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewInstanceDecisionItem"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/accessReviews/definitions('5eac5a70-7cd7-4f20-92b0-f9dba70dd7f0')/instances('6444d4fd-ab55-4608-8cf9-c6702d172bcc')/decisions/$entity",
    "id": "e6cafba0-cbf0-4748-8868-0810c7f4cc06",
    "accessReviewId": "6444d4fd-ab55-4608-8cf9-c6702d172bcc",
    "reviewedDateTime": null,
    "decision": "NotReviewed",
    "justification": "",
    "appliedDateTime": null,
    "applyResult": "New",
    "recommendation": "Approve",
    "principalLink": "https://graph.microsoft.com/v1.0/users/04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
    "resourceLink": null,
    "resource": null,
    "reviewedBy": {
        "id": "00000000-0000-0000-0000-000000000000",
        "displayName": "",
        "userPrincipalName": ""
    },
    "appliedBy": {
        "id": "00000000-0000-0000-0000-000000000000",
        "displayName": "",
        "userPrincipalName": ""
    },
    "target": {
        "@odata.type": "#microsoft.graph.accessReviewInstanceDecisionItemUserTarget",
        "userId": "04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
        "userDisplayName": "Diego Siciliani",
        "userPrincipalName": "DiegoS@contoso.com"
    },
    "principal": {
        "@odata.type": "#microsoft.graph.userIdentity",
        "id": "04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
        "displayName": "Diego Siciliani",
        "userPrincipalName": "DiegoS@contoso.com"
    }
}
```

### Example 2: Retrieve a decision from a stage of a multi-stage access review

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessreviewstage_accessreviewinstancedecisionitem"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/5eac5a70-7cd7-4f20-92b0-f9dba70dd7f0/instances/6444d4fd-ab55-4608-8cf9-c6702d172bcc/stages/9458f255-dff2-4d86-9a05-69438f49d7f8/decisions/e6cafba0-cbf0-4748-8868-0810c7f4cc06
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewInstanceDecisionItem = await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"].Stages["{accessReviewStage-id}"].Decisions["{accessReviewInstanceDecisionItem-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewInstanceDecisionItem"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/5eac5a70-7cd7-4f20-92b0-f9dba70dd7f0/instances/6444d4fd-ab55-4608-8cf9-c6702d172bcc/stages/9458f255-dff2-4d86-9a05-69438f49d7f8/decisions/$entity",
    "id": "e6cafba0-cbf0-4748-8868-0810c7f4cc06",
    "accessReviewId": "6444d4fd-ab55-4608-8cf9-c6702d172bcc",
    "reviewedDateTime": null,
    "decision": "NotReviewed",
    "justification": "",
    "appliedDateTime": null,
    "applyResult": "New",
    "recommendation": "Approve",
    "principalLink": "https://graph.microsoft.com/v1.0/users/04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
    "resourceLink": null,
    "resource": null,
    "reviewedBy": {
        "id": "00000000-0000-0000-0000-000000000000",
        "displayName": "",
        "userPrincipalName": ""
    },
    "appliedBy": {
        "id": "00000000-0000-0000-0000-000000000000",
        "displayName": "",
        "userPrincipalName": ""
    },
    "target": {
        "@odata.type": "#microsoft.graph.accessReviewInstanceDecisionItemUserTarget",
        "userId": "04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
        "userDisplayName": "Diego Siciliani",
        "userPrincipalName": "DiegoS@contoso.com"
    },
    "principal": {
        "@odata.type": "#microsoft.graph.userIdentity",
        "id": "04777c4b-4d43-4d32-a2e7-1eba5d03f8cf",
        "displayName": "Diego Siciliani",
        "userPrincipalName": "DiegoS@contoso.com"
    }
}
```
