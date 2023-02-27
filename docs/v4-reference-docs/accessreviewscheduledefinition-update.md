---
title: "Update accessReviewScheduleDefinition"
description: "Update an existing accessReviewScheduleDefinition object to change one or more of its properties."
ms.localizationpriority: medium
author: "jyothig123"
ms.prod: "governance"
doc_type: apiPageType
---

# Update accessReviewScheduleDefinition

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update an existing [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object to change one or more of its properties.

>[!NOTE]
>Any updates made to an accessReviewScheduleDefinition only apply to future instances. Currently running instances cannot be updated.
>Additionally, this API is not intended to update properties, including decisions, on the accessReviewInstance level. See [accessReviewInstance](../resources/accessreviewinstance.md) for more information on instances.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PUT /identityGovernance/accessReviews/definitions/{review-id}
```
## Request headers
| Name         | Description |
|:-------------|:------------|
|Authorization|Bearer {token}. Required.|
| Content-type | application/json. Required. |

## Request body
In the request body, supply a JSON representation of an [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.

The following table shows the properties accepted to update an accessReviewScheduleDefinition.

| Property | Type | Description |
|:-------------|:------------|:------------|
| descriptionForAdmins | String | Context of the review provided to admins. |
| descriptionForReviewers | String | Context of the review provided to reviewers. |
| displayName | String | Name of access review series. |
| fallbackReviewers|[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|A collection of reviewer scopes used to define the list of fallback reviewers who are notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.|
| reviewers | [accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|  Defines who the reviewers are. If none are specified, the review is a self-review (users review their own access). The **reviewers** property is only updatable if individual users are assigned as reviewers. See [accessReviewReviewerScope](../resources/accessreviewreviewerscope.md). |
|stageSettings|[accessReviewStageSettings](../resources/accessreviewstagesettings.md) collection| Defines how many stages each instance of an access review series will have. Stages will be created sequentially based on the **dependsOn** property. Each stage can have different set of reviewer, fallback reviewers and settings. Only reviewers and fallback reviewers are updatable. See [accessReviewStageSettings](../resources/accessreviewstagesettings.md). Optional.|
| settings | [accessReviewScheduleSettings](../resources/accessreviewschedulesettings.md) | The settings for an access review series. See [accessReviewScheduleSettings](../resources/accessreviewschedulesettings.md). |
| backupReviewers (deprecated)|[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection| This property has been replaced by **fallbackReviewers**. However, specifying either **backupReviewers** or **fallbackReviewers** automatically populates the same values to the other property. |

A **PUT** request expects the full object to be passed in, which includes all writable properties, not just the properties being updated.

## Response
If successful, this method returns a `204 No Content` response code and no response body.

## Examples

This is an example of updating the displayName of an existing access review series.

### Request
In the request body, supply a JSON representation of the new properties of the [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_accessReviewScheduleDefinition"
}-->
```http
PUT https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/60860cdd-fb4d-4054-91ba-f75e04444aa6
Content-type: application/json

{
  "id": "60860cdd-fb4d-4054-91ba-f75e04444aa6",
  "displayName": "Test world UPDATED NAME!",
  "descriptionForAdmins": "Test world",
  "descriptionForReviewers": "Test world",
  "scope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/b7a059cb-038a-4802-8fc9-b9d1ed0cf11f/transitiveMembers",
    "queryType": "MicrosoftGraph"
  },
  "instanceEnumerationScope": {
    "@odata.type": "#microsoft.graph.accessReviewQueryScope",
    "query": "/groups/b7a059cb-038a-4802-8fc9-b9d1ed0cf11f",
    "queryType": "MicrosoftGraph"
  },
  "reviewers": [],
  "settings": {
    "mailNotificationsEnabled": true,
    "reminderNotificationsEnabled": true,
    "justificationRequiredOnApproval": true,
    "defaultDecisionEnabled": false,
    "defaultDecision": "None",
    "instanceDurationInDays": 3,
    "autoApplyDecisionsEnabled": false,
    "recommendationsEnabled": true,
    "recurrence": {
      "pattern": {
        "type": "weekly",
        "interval": 1
      },
      "range": {
        "type": "noEnd",
        "startDate": "2020-09-15"
      }
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewScheduleDefinition = new AccessReviewScheduleDefinition
{
	Id = "60860cdd-fb4d-4054-91ba-f75e04444aa6",
	DisplayName = "Test world UPDATED NAME!",
	DescriptionForAdmins = "Test world",
	DescriptionForReviewers = "Test world",
	Scope = new AccessReviewQueryScope
	{
		Query = "/groups/b7a059cb-038a-4802-8fc9-b9d1ed0cf11f/transitiveMembers",
		QueryType = "MicrosoftGraph"
	},
	InstanceEnumerationScope = new AccessReviewQueryScope
	{
		Query = "/groups/b7a059cb-038a-4802-8fc9-b9d1ed0cf11f",
		QueryType = "MicrosoftGraph"
	},
	Reviewers = new List<AccessReviewReviewerScope>()
	{
	},
	Settings = new AccessReviewScheduleSettings
	{
		MailNotificationsEnabled = true,
		ReminderNotificationsEnabled = true,
		JustificationRequiredOnApproval = true,
		DefaultDecisionEnabled = false,
		DefaultDecision = "None",
		InstanceDurationInDays = 3,
		AutoApplyDecisionsEnabled = false,
		RecommendationsEnabled = true,
		Recurrence = new PatternedRecurrence
		{
			Pattern = new RecurrencePattern
			{
				Type = RecurrencePatternType.Weekly,
				Interval = 1
			},
			Range = new RecurrenceRange
			{
				Type = RecurrenceRangeType.NoEnd,
				StartDate = new Date(2020,9,15)
			}
		}
	}
};

await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"]
	.Request()
	.PutAsync(accessReviewScheduleDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 204 No Content
```

<!--
{
  "type": "#page.annotation",
  "description": "Update accessReviewScheduleDefinition",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
