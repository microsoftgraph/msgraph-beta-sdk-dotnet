---
title: "List rosterPlans"
description: "Get the plannerPlan resources from the rosterPlans navigation property."
author: "tarkansevilmis"
ms.localizationpriority: medium
ms.prod: "planner"
doc_type: apiPageType
---

# List rosterPlans
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the list of [plannerPlans](../resources/plannerplan.md) that are contained by the [plannerRosters](../resources/plannerroster.md) of which the user is a member.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.Read, Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Tasks.Read.All, Tasks.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /users/{usersId}/planner/rosterPlans
```

## Optional query parameters
This method only supports following OData query parameters:

- $select

For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [plannerPlan](../resources/plannerplan.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_plannerplan_2"
}
-->
``` http
GET https://graph.microsoft.com/beta/users/{usersId}/planner/rosterPlans
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var rosterPlans = await graphClient.Users["{user-id}"].Planner.RosterPlans
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.plannerPlan)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.plannerPlan",
      "id": "c6442b38-2b38-c644-382b-44c6382b44c6",
      "createdBy": {
        "@odata.type": "microsoft.graph.identitySet"
      },
      "title": "Test plan",
      "container": {
        "@odata.type": "microsoft.graph.plannerPlanContainer",
        "url": "https://graph.microsoft.com/beta/planner/rosters/5ba84f7a-aa11-4a51-a298-9f2c7ec6bb38",
        "containerId": "5ba84f7a-aa11-4a51-a298-9f2c7ec6bb38",
        "type": "roster"
      }
    }
  ]
}
```

