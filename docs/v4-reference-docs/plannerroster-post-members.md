---
title: "Create plannerRosterMember"
description: "Create a new plannerRosterMember object."
author: "tarkansevilmis"
ms.localizationpriority: medium
ms.prod: "planner"
doc_type: apiPageType
---

# Create plannerRosterMember
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a member to the [plannerRoster](../resources/plannerrostermember.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Tasks.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /planner/rosters/{plannerRosterId}/members
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [plannerRosterMember](../resources/plannerrostermember.md) object.

The following table shows the properties that are required when you create the [plannerRosterMember](../resources/plannerrostermember.md).

|Property|Type|Description|
|:---|:---|:---|
|userId|String|Identifier of the user.|
|tenantId|String|Identifier of the tenant the user belongs to. Optional. Currently roster members cannot be from different tenants.|
|roles|String collection|Additional roles assigned to the user. Optional. Currently there are no additional roles available for users.|



## Response

If successful, this method returns a `201 Created` response code and a [plannerRosterMember](../resources/plannerrostermember.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_plannerrostermember_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/planner/rosters/6519868f-868f-6519-8f86-19658f861965/members
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerRosterMember",
  "userId": "String"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerRosterMember = new PlannerRosterMember
{
	UserId = "String"
};

await graphClient.Planner.Rosters["{plannerRoster-id}"].Members
	.Request()
	.AddAsync(plannerRosterMember);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.plannerRosterMember"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerRosterMember",
  "id": "670095cd-95cd-6700-cd95-0067cd950067",
  "userId": "5ba84f7a-aa11-4a51-a298-9f2c7ec6bb38",
  "roles": [
  ]
}
```

