---
title: "Get businessScenarioTask"
description: "Read the properties and relationships of a businessScenarioTask object."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Get businessScenarioTask

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [businessScenarioTask](../resources/businessscenariotask.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioData.Read.OwnedBy, BusinessScenarioData.ReadWrite.OwnedBy|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BusinessScenarioData.Read.OwnedBy, BusinessScenarioData.ReadWrite.OwnedBy|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /solutions/businessScenarios/{businessScenarioId}/planner/tasks/{businessScenarioTaskId}
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [businessScenarioTask](../resources/businessscenariotask.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_businessscenariotask",
  "sampleKeys": ["c5d514e6c6864911ac46c720affb6e4d", "pmc1rS1Io0C3rXQhyXIsNmUAOeIi"]
}
-->
``` http
GET https://graph.microsoft.com/beta/solutions/businessScenarios/c5d514e6c6864911ac46c720affb6e4d/planner/tasks/pmc1rS1Io0C3rXQhyXIsNmUAOeIi
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var businessScenarioTask = await graphClient.Solutions.BusinessScenarios["{businessScenario-id}"].Planner.Tasks["{businessScenarioTask-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.businessScenarioTask"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "title": "Customer order #12010",
    "percentComplete": 0,
    "priority": 5,
    "id": "pmc1rS1Io0C3rXQhyXIsNmUAOeIi",
    "target": {
        "@odata.type": "microsoft.graph.businessScenarioGroupTarget",
        "taskTargetKind": "group",
        "groupId": "7a339254-4b2b-4410-b295-c890a16776ee"
    },
    "businessScenarioProperties": {
        "externalObjectId": "Order#12010",
        "externalContextId": "Warehouse-CA-36",
        "externalObjectVersion": "000001",
        "webUrl": "https://ordertracking.contoso.com/view?id=12010",
        "externalBucketId": "deliveryBucket"
    }
}
```
