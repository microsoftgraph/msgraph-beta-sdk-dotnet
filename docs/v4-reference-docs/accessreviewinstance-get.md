---
title: "Get accessReviewInstance"
description: "Retrieve an accessReviewInstance object."
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# Get accessReviewInstance

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve an [accessReviewInstance](../resources/accessreviewinstance.md) object using the identifier of an accessReviewInstance and its parent [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md). This returns all properties of the instance except for the associated [accessReviewInstanceDecisionItems](../resources/accessreviewinstancedecisionitem.md).

To retrieve the decisions on the instance, use [List accessReviewInstanceDecisionItem](accessreviewinstance-list-decisions.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.Read.All, AccessReview.ReadWrite.All  |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.Read.All, AccessReview.ReadWrite.All |

In order to call this API, the signed in user must also be in a directory role that permits them to read an access review, or the user can be assigned as a reviewer on the access review.  For more details, see the role and permission requirements for [access reviews](../resources/accessreviewsv2-overview.md).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /identityGovernance/accessReviews/definitions/{definition-id}/instances/{instance-id}
```

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
None.

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and an [accessReviewInstance](../resources/accessreviewinstance.md) object in the response body.

## Examples
### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accessReviewInstance"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/6af553ce-104d-4842-ab5f-67d7b556e9dd/instances/9ea56d3c-8746-4cdf-9ccc-c7fe1a267c24
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewInstance = await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewInstance",
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/accessReviews/definitions('6af553ce-104d-4842-ab5f-67d7b556e9dd')/instances/$entity",
    "id": "9ea56d3c-8746-4cdf-9ccc-c7fe1a267c24",
    "startDateTime": "2021-03-11T16:44:59.337Z",
    "endDateTime": "2021-06-09T16:44:59.337Z",
    "status": "InProgress",
    "scope": {
        "@odata.type": "#microsoft.graph.accessReviewQueryScope",
        "query": "/v1.0/groups/97eebd44-61fd-4d42-8b2a-a4de41b6c572/transitiveMembers",
        "queryType": "MicrosoftGraph",
        "queryRoot": null
    }
}
```

## See also

- [Get accessReviewScheduleDefinition](accessreviewscheduledefinition-get.md)
- [List accessReviewInstance](accessreviewscheduledefinition-list-instances.md)


<!--
{
  "type": "#page.annotation",
  "description": "Get accessReviewInstance",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
