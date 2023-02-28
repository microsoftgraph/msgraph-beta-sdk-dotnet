---
title: "Get plannerRoster"
description: "Read the properties and relationships of a plannerRoster object."
author: "tarkansevilmis"
ms.localizationpriority: medium
ms.prod: "planner"
doc_type: apiPageType
---

# Get plannerRoster
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [plannerRoster](../resources/plannerroster.md) object.

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
GET /planner/rosters/{plannerRosterId}
```

## Optional query parameters
This method only supports following OData query parameters:

- $expand

For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [plannerRoster](../resources/plannerroster.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_plannerroster"
}
-->
``` http
GET https://graph.microsoft.com/beta/planner/rosters/6519868f-868f-6519-8f86-19658f861965
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerRoster = await graphClient.Planner.Rosters["{plannerRoster-id}"]
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
  "@odata.type": "microsoft.graph.plannerRoster"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.plannerRoster",
    "id": "6519868f-868f-6519-8f86-19658f861965"
  }
}
```

