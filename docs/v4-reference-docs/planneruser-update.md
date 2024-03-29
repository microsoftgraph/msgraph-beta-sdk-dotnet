---
title: "Update plannerUser"
description: "Update the properties of a plannerUser object. You can use this operation to add or remove plans from a user's favorite plans list, and to indicate which plans the user has recently viewed."
ms.localizationpriority: medium
author: "TarkanSevilmis"
ms.prod: "planner"
doc_type: apiPageType
---

# Update plannerUser

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [plannerUser](../resources/planneruser.md) object. You can use this operation to add or remove plans from a user's favorite plans list, and to indicate which plans the user has recently viewed.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Tasks.ReadWrite, Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/planner
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {code}. Required.|
| If-Match  | Last known ETag value for the **plannerUser** to be updated. Required.|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|favoritePlanReferences|[plannerFavoritePlanReferenceCollection](../resources/plannerfavoriteplanreferencecollection.md)|Changes to the collection containing the references to the plans that the user has marked as a favorite.|
|recentPlanReferences|[plannerRecentPlanReferenceCollection](../resources/plannerrecentplanreferencecollection.md)|Changes to the collection containing the references to the plans that the user has recently viewed.|

## Response
If successful, this method returns `204 No Content` response and empty content. If the request specifies `Prefer` header with `return=representation` preference, then this method returns a `200 OK` response code and an updated [plannerUser](../resources/planneruser.md) object in the response body.

This method can return any of the [HTTP status codes](/graph/errors). The most common errors that apps should handle for this method are the 400, 403, 404, 409, and 412 responses. For more information about these errors, see [Common Planner error conditions](../resources/planner-overview.md#common-planner-error-conditions).
## Example
##### Request
The following is an example of the request. This request adds the plan "Next Release Discussion" with ID "jd8S5gOaFk2S8aWCIAJz42QAAxtD" as a favorite for the user, and removes plan with ID "7oTB5aMIAE2rVo-1N-L7RmQAGX2q" from the favorite plans list.
It also updates the last view time of the plan "jd8S5gOaFk2S8aWCIAJz42QAAxtD".

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_planneruser"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/planner
Content-type: application/json
Prefer: return=representation
If-Match: W/"JzEtVXNlckRldGFpbHMgQEBAQEBAQEBAQEBAQEBIWCc="

{
  "favoritePlanReferences": {
    "jd8S5gOaFk2S8aWCIAJz42QAAxtD": {
      "@odata.type": "#microsoft.graph.plannerFavoritePlanReference",
      "orderHint": " !",
      "planTitle": "Next Release Discussion"
    },
    "7oTB5aMIAE2rVo-1N-L7RmQAGX2q": null
  },
  "recentPlanReferences": {
    "jd8S5gOaFk2S8aWCIAJz42QAAxtD": {
      "@odata.type": "#microsoft.graph.plannerRecentPlanReference",
      "lastAccessedDateTime": "2018-01-02T22:49:46.155Z",
      "planTitle": "Next Release Discussion"
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerUser = new PlannerUser
{
	FavoritePlanReferences = new PlannerFavoritePlanReferenceCollection
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"jd8S5gOaFk2S8aWCIAJz42QAAxtD", "{\"@odata.type\":\"#microsoft.graph.plannerFavoritePlanReference\",\"orderHint\":\" !\",\"planTitle\":\"Next Release Discussion\"}"},
			{"7oTB5aMIAE2rVo-1N-L7RmQAGX2q", "null"}
		}
	},
	RecentPlanReferences = new PlannerRecentPlanReferenceCollection
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"jd8S5gOaFk2S8aWCIAJz42QAAxtD", "{\"@odata.type\":\"#microsoft.graph.plannerRecentPlanReference\",\"lastAccessedDateTime\":\"2018-01-02T22:49:46.155Z\",\"planTitle\":\"Next Release Discussion\"}"}
		}
	}
};

await graphClient.Me.Planner
	.Request()
	.Header("Prefer","return=representation")
	.Header("If-Match","W/\"JzEtVXNlckRldGFpbHMgQEBAQEBAQEBAQEBAQEBIWCc=\"")
	.UpdateAsync(plannerUser);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

