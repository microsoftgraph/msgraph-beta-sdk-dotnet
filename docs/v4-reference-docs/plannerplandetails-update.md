---
title: "Update plannerplandetails"
description: "Update the properties of **plannerplandetails** object."
ms.localizationpriority: medium
author: "TarkanSevilmis"
ms.prod: "planner"
doc_type: apiPageType
---

# Update plannerplandetails

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of **plannerplandetails** object.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Tasks.ReadWrite, Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Tasks.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /planner/plans/{id}/details
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}. Required. |
| If-Match  | Last known ETag value for the plannerPlanDetails to be updated. Required.|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|categoryDescriptions|[plannerCategoryDescriptions](../resources/plannercategorydescriptions.md)|An object that specifies the descriptions of the six categories that can be associated with tasks in the plan|
|sharedWith|[plannerUserIds](../resources/planneruserids.md)|Set of user ids that this plan is shared with. If you are leveraging Microsoft 365 groups, use the Groups API to manage group membership to share the [group's](../resources/group.md) plan. You can also add existing members of the group to this collection though it is not required for them to access the plan owned by the group.|

## Response

If successful, this method returns `204 No Content` response and empty content. If the request specifies `Prefer` header with `return=representation` preference, then this method returns a `200 OK` response code and updated [plannerPlanDetails](../resources/plannerplandetails.md) object in the response body.

This method can return any of the [HTTP status codes](/graph/errors). The most common errors that apps should handle for this method are the 400, 403, 404, 409, and 412 responses. For more information about these errors, see [Common Planner error conditions](../resources/planner-overview.md#common-planner-error-conditions).

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_plannerplandetails",
  "sampleKeys": ["xqQg5FS2LkCp935s-FIFm2QAFkHM"]
}-->
```http
PATCH https://graph.microsoft.com/beta/planner/plans/xqQg5FS2LkCp935s-FIFm2QAFkHM/details
Content-type: application/json
Prefer: return=representation
If-Match: W/"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="

{
  "sharedWith": {
    "6463a5ce-2119-4198-9f2a-628761df4a62" : true,
    "d95e6152-f683-4d78-9ff5-67ad180fea4a" : false,
  },
  "categoryDescriptions": {
    "category1": "Indoors",
    "category3": null,
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerPlanDetails = new PlannerPlanDetails
{
	SharedWith = new PlannerUserIds
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"6463a5ce-2119-4198-9f2a-628761df4a62", "true"},
			{"d95e6152-f683-4d78-9ff5-67ad180fea4a", "false"}
		}
	},
	CategoryDescriptions = new PlannerCategoryDescriptions
	{
		Category1 = "Indoors",
		Category3 = null
	}
};

await graphClient.Planner.Plans["{plannerPlan-id}"].Details
	.Request()
	.Header("Prefer","return=representation")
	.Header("If-Match","W/\"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc=\"")
	.UpdateAsync(plannerPlanDetails);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

