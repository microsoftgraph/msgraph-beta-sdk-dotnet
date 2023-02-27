---
title: "List instances"
description: "Retrieve accessReviewInstance objects."
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# List instances

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the [accessReviewInstance](../resources/accessreviewinstance.md) objects for a specific [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md). A list of zero or more **accessReviewInstance** objects are returned, including all of their nested properties. Returned objects do not include associated accessReviewInstanceDecisionItems. To retrieve the decisions on the instance, use [List accessReviewInstanceDecisionItem](accessreviewinstance-list-decisions.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.Read.All, AccessReview.ReadWrite.All  |
|Application                            | AccessReview.Read.All, AccessReview.ReadWrite.All |

The signed-in user must also be in a directory role that permits them to read an access review. To view just the instances that the signed-in user is assigned the reviewer on, see [List pending access review instances](accessreviewinstance-pendingaccessreviewinstances.md)

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /identityGovernance/accessReviews/definitions/{definition-id}/instances
```

## Optional query parameters
This method supports `$select`, `$filter`, `$orderBy`, `$skip`, and `$top` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

The default page size for this API is 100 **accessReviewInstance** objects. To improve efficiency and avoid timeouts due to large result sets, apply pagination using the `$skip` and `$top` query parameters. For more information, see [Paging Microsoft Graph data in your app](/graph/paging).

## Request headers
None.

## Request body
Do not supply a request body.

## Response
If successful, this method returns a `200 OK` response code and an array of [accessReviewInstance](../resources/accessreviewinstance.md) objects in the response body.

## Examples
### Request
The following example shows a request to retrieve all the access review instances for a definition.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_accessReviewInstance"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/8564a649-4f67-4e09-88e7-55def6530e88/instances?$top=100&$skip=0
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var instances = await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances
	.Request()
	.Skip(0)
	.Top(100)
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
  "isCollection": "true"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/accessReviews/definitions('8564a649-4f67-4e09-88e7-55def6530e88')/instances",
    "@odata.count": 2,
    "value": [
        {
            "id": "7bc18cf4-3d70-4009-bc8e-a7c5adb30849",
            "startDateTime": "2021-03-09T23:10:28.83Z",
            "endDateTime": "2021-03-09T23:10:28.83Z",
            "status": "Applied",
            "scope": {
                "@odata.type": "#microsoft.graph.accessReviewQueryScope",
                "query": "/v1.0/groups/f661fdd0-f0f7-42c0-8281-e89c6527ac63/members/microsoft.graph.user/?$count=true&$filter=(userType eq 'Guest')",
                "queryType": "MicrosoftGraph",
                "queryRoot": null
            }
        },
        {
            "id": "f1f35945-3f42-4941-9f7b-465e545f6f99",
            "startDateTime": "2021-03-09T23:10:28.83Z",
            "endDateTime": "2021-03-09T23:10:28.83Z",
            "status": "Applied",
            "scope": {
                "@odata.type": "#microsoft.graph.accessReviewQueryScope",
                "query": "/v1.0/groups/f4ac55b3-3b3c-417e-85bd-183bbda3ccf2/members/microsoft.graph.user/?$count=true&$filter=(userType eq 'Guest')",
                "queryType": "MicrosoftGraph",
                "queryRoot": null
            }
        }
    ]
}
```

## See also

- [List accessReviewScheduleDefinition](accessreviewset-list-definitions.md)
- [Get accessReviewInstance](accessreviewinstance-get.md)


<!--
{
  "type": "#page.annotation",
  "description": "List accessReviewInstance",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
