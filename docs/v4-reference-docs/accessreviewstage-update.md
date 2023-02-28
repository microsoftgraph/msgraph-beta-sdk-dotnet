---
title: "Update accessReviewStage"
description: "Update the properties of an accessReviewStage object."
author: "jyothig123"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update accessReviewStage
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [accessReviewStage](../resources/accessreviewstage.md) object. Only the **reviewers** and **fallbackReviewers** properties can be updated. You can only add reviewers to the **fallbackReviewers** property but can't remove existing **fallbackReviewers**.

To update an **accessReviewStage**, its **status** must be `NotStarted`, `Initializing`, or `InProgress`.

> [!NOTE]
> 
> Updating an **accessReviewStage** will update only that stage. The parent **accessReviewInstance** and any future **accessReviewStage** objects won't change. To make updates that apply to all future instances and stages, update the parent [accessReviewScheduleDefinition](../resources/accessreviewscheduledefinition.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | AccessReview.ReadWrite.All |
|Delegated (personal Microsoft account)|Not supported.|
|Application                            | AccessReview.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinitionId}/instances/{accessReviewInstanceId}/stages/{accessReviewStageId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|reviewers|[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|This collection of access review scopes is used to define who the reviewers are. For examples of options for assigning reviewers, see [Assign reviewers to your access review definition using the Microsoft Graph API](/graph/accessreviews-scope-concept). Optional. Updatable.|
|fallbackReviewers|[accessReviewReviewerScope](../resources/accessreviewreviewerscope.md) collection|This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Optional. Updatable.|



## Response

If successful, this method returns a `200 OK` response code and an updated [accessReviewStage](../resources/accessreviewstage.md) object in the response body.

Attempting to remove existing **fallbackReviewers** returns a `409 Conflict` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_accessreviewstage"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/identityGovernance/accessReviews/definitions/5dcfcc88-da88-4252-8629-a0807b4b076d/instances/720b8ee0-cee4-42ac-b164-894c48703acc/stages/7d244ab1-4ab1-7d24-b14a-247db14a247d
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.accessReviewStage",
  "reviewers": [
      {
          "query": "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
          "queryType": "MicrosoftGraph"
      }
  ],
  "fallbackReviewers": [
      {
          "query": "/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e",
          "queryType": "MicrosoftGraph"
      },
      {
          "query": "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
          "queryType": "MicrosoftGraph"
      }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewStage = new AccessReviewStage
{
	Reviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
			QueryType = "MicrosoftGraph"
		}
	},
	FallbackReviewers = new List<AccessReviewReviewerScope>()
	{
		new AccessReviewReviewerScope
		{
			Query = "/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e",
			QueryType = "MicrosoftGraph"
		},
		new AccessReviewReviewerScope
		{
			Query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
			QueryType = "MicrosoftGraph"
		}
	}
};

await graphClient.IdentityGovernance.AccessReviews.Definitions["{accessReviewScheduleDefinition-id}"].Instances["{accessReviewInstance-id}"].Stages["{accessReviewStage-id}"]
	.Request()
	.UpdateAsync(accessReviewStage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewStage"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.accessReviewStage",
  "id": "7d244ab1-4ab1-7d24-b14a-247db14a247d",
  "startDateTime": "2021-12-14T11:15:43.207Z",
  "endDateTime": "2021-12-15T11:15:43.207Z",
  "status": "InProgress",
  "reviewers": [
      {
          "query": "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
          "queryType": "MicrosoftGraph"
      }
  ],
  "fallbackReviewers": [
      {
          "query": "/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e",
          "queryType": "MicrosoftGraph"
      },
      {
          "query": "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5",
          "queryType": "MicrosoftGraph"
      }
  ]
}
```

