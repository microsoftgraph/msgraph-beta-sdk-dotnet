---
title: "accessReviewScheduleDefinition: filterByCurrentUser"
description: "Returns accessReviewScheduleDefinition objects where the calling user is the reviewer."
author: "jyothig123"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# accessReviewScheduleDefinition: filterByCurrentUser
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Returns [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) objects where the calling user is a reviewer on one or more [accessReviewInstance](../resources/accessreviewinstance.md) objects.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|AccessReview.Read.All, AccessReview.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|AccessReview.Read.All, AccessReview.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identityGovernance/accessReviews/definitions/filterByCurrentUser(on='reviewer')
```

## Optional query parameters
This method supports `$select`, `$filter`, `$orderBy`, `$skip`, and `$top` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

The default page size for this API is 100 **accessReviewScheduleDefinition** objects. To improve efficiency and avoid timeouts due to large result sets, apply pagination using the `$skip` and `$top` query parameters. For more information, see [Paging Microsoft Graph data in your app](/graph/paging).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) collection in the response body.

## Examples
Returns all review definitions where the calling user is a reviewer.

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "accessreviewscheduledefinition_filterbycurrentuser"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/filterByCurrentUser(on='reviewer')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var filterByCurrentUser = await graphClient.IdentityGovernance.AccessReviews.Definitions
	.FilterByCurrentUser(AccessReviewScheduleDefinitionFilterByCurrentUserOptions.Reviewer)
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
  "@odata.type": "Collection(microsoft.graph.accessReviewScheduleDefinition)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(accessReviewScheduleDefinition)",
    "@odata.count": 1,
    "value": [
        {
            "@odata.type": "#microsoft.graph.accessReviewScheduleDefinition",
            "id": "ad0ec492-c1b6-49f0-9025-ea15ca471ea9",
            "displayName": "Test",
            "createdDateTime": "2021-04-29T20:01:18.1084432Z",
            "lastModifiedDateTime": "2021-04-29T20:01:52.3233462Z",
            "status": "Completed",
            "descriptionForAdmins": "Test",
            "descriptionForReviewers": "Test",
            "createdBy": {
                "id": "36c4c56e-fce3-4e2d-b28e-4ac0c7d2fa10",
                "displayName": "MOD Administrator",
                "userPrincipalName": "admin@contoso.com"
            },
            "scope": {
                "@odata.type": "#microsoft.graph.accessReviewInactiveUsersQueryScope",
                "query": "./members/microsoft.graph.user/?$count=true&$filter=(userType eq 'Guest')",
                "queryType": "MicrosoftGraph",
                "queryRoot": null,
                "inactiveDuration": "P30D"
            },
            "instanceEnumerationScope": {
                "@odata.type": "#microsoft.graph.accessReviewQueryScope",
                "query": "/v1.0/groups?$filter=(groupTypes/any(c:c+eq+'Unified'))&$count=true",
                "queryType": "MicrosoftGraph",
                "queryRoot": null
            },
            "reviewers": [
                {
                    "query": "./owners",
                    "queryType": "MicrosoftGraph",
                    "queryRoot": null
                }
            ],
            "backupReviewers": [],
            "fallbackReviewers": [],
            "settings": {
                "mailNotificationsEnabled": true,
                "reminderNotificationsEnabled": true,
                "justificationRequiredOnApproval": true,
                "defaultDecisionEnabled": true,
                "defaultDecision": "Approve",
                "instanceDurationInDays": 3,
                "autoApplyDecisionsEnabled": true,
                "recommendationsEnabled": true,
                "recurrence": {
                    "pattern": {
                        "type": "weekly",
                        "interval": 1,
                        "month": 0,
                        "dayOfMonth": 0,
                        "daysOfWeek": [],
                        "firstDayOfWeek": "sunday",
                        "index": "first"
                    },
                    "range": {
                        "type": "numbered",
                        "numberOfOccurrences": 0,
                        "recurrenceTimeZone": null,
                        "startDate": "2021-04-30",
                        "endDate": "2021-04-30"
                    }
                },
                "applyActions": [
                    {
                        "@odata.type": "#microsoft.graph.removeAccessApplyAction"
                    }
                ]
            },
            "instances": []
        }
    ]
}
```
