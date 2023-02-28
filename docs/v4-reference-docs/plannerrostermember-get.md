---
title: "Get plannerRosterMember"
description: "Read the properties and relationships of a plannerRosterMember object."
author: "tarkansevilmis"
ms.localizationpriority: medium
ms.prod: "planner"
doc_type: apiPageType
---

# Get plannerRosterMember
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [plannerRosterMember](../resources/plannerrostermember.md) object.

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
GET /planner/rosters/{plannerRosterId}/members/{plannerRosterMemberId}
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

If successful, this method returns a `200 OK` response code and a [plannerRosterMember](../resources/plannerrostermember.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_plannerrostermember"
}
-->
``` http
GET https://graph.microsoft.com/beta/planner/rosters/523a9d5a-f9d5-45c1-929f-b8525393515c/members/5ba84f7a-aa11-4a51-a298-9f2c7ec6bb38
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerRosterMember = await graphClient.Planner.Rosters["{plannerRoster-id}"].Members["{plannerRosterMember-id}"]
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
  "@odata.type": "microsoft.graph.plannerRosterMember"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerRosterMember",
  "id": "670095cd-95cd-6700-cd95-0067cd950067",
  "userId": "5ba84f7a-aa11-4a51-a298-9f2c7ec6bb38",
  "tenantId": "7084c257-c1b7-4286-98b0-20ea7b5c1319",
  "roles": [
  ]
}
```

