---
title: "Update plannerPlanConfiguration"
description: "Update the properties of a plannerPlanConfiguration object for a businessScenario."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Update plannerPlanConfiguration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [plannerPlanConfiguration](../resources/plannerplanconfiguration.md) object for a [businessScenario](../resources/businessscenario.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioConfig.ReadWrite.OwnedBy, BusinessScenarioConfig.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BusinessScenarioConfig.ReadWrite.OwnedBy|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

For the plan configuration based on a business scenario ID:

``` http
PATCH /solutions/businessScenarios/{businessScenarioId}/planner/planConfiguration
```

For the plan configuration based on the unique name of a business scenario:

``` http
PATCH /solutions/businessScenarios(uniqueName='{uniqueName}')/planner/planConfiguration
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
|defaultLanguage|String|The language that should be used for creating plans when no language has been specified. Required.|
|buckets|[plannerPlanConfigurationBucketDefinition](../resources/plannerplanconfigurationbucketdefinition.md) collection|Buckets that will be available in the plan. Required.|

## Response

If successful, this method returns a `200 OK` response code and an updated [plannerPlanConfiguration](../resources/plannerplanconfiguration.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_plannerplanconfiguration",
  "sampleKeys": ["c5d514e6c6864911ac46c720affb6e4d"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/solutions/businessScenarios/c5d514e6c6864911ac46c720affb6e4d/planner/planConfiguration
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerPlanConfiguration",
  "defaultLanguage": "en-us",
  "buckets": [
    {
      "externalBucketId": "deliveryBucket"
    },
    {
      "externalBucketId": "storePickupBucket"
    },
    {
      "externalBucketId": "specialOrdersBucket"
    },
    {
      "externalBucketId": "returnProcessingBucket"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerPlanConfiguration = new PlannerPlanConfiguration
{
	DefaultLanguage = "en-us",
	Buckets = new List<PlannerPlanConfigurationBucketDefinition>()
	{
		new PlannerPlanConfigurationBucketDefinition
		{
			ExternalBucketId = "deliveryBucket"
		},
		new PlannerPlanConfigurationBucketDefinition
		{
			ExternalBucketId = "storePickupBucket"
		},
		new PlannerPlanConfigurationBucketDefinition
		{
			ExternalBucketId = "specialOrdersBucket"
		},
		new PlannerPlanConfigurationBucketDefinition
		{
			ExternalBucketId = "returnProcessingBucket"
		}
	}
};

await graphClient.Solutions.BusinessScenarios["{businessScenario-id}"].Planner.PlanConfiguration
	.Request()
	.UpdateAsync(plannerPlanConfiguration);

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
  "@odata.type": "microsoft.graph.plannerPlanConfiguration"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerPlanConfiguration",
  "id": "afdd911ee3db44b69cc28373a6192e94",
  "defaultLanguage": "en-us",
  "buckets": [
    {
      "externalBucketId": "deliveryBucket"
    },
    {
      "externalBucketId": "storePickupBucket"
    },
    {
      "externalBucketId": "specialOrdersBucket"
    },
    {
      "externalBucketId": "returnProcessingBucket"
    }
  ]
}
```
