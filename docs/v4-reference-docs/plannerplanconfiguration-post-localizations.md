---
title: "Create plannerPlanConfigurationLocalization"
description: "Create a new plannerPlanConfigurationLocalization object."
author: "TarkanSevilmis"
ms.localizationpriority: medium
ms.prod: "business-scenarios"
doc_type: apiPageType
---

# Create plannerPlanConfigurationLocalization

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [plannerPlanConfigurationLocalization](../resources/plannerplanconfigurationlocalization.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BusinessScenarioConfig.ReadWrite.OwnedBy, BusinessScenarioConfig.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application| BusinessScenarioConfig.ReadWrite.OwnedBy |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

For a specific localization based on a business scenario ID:

``` http
POST /solutions/businessScenarios/{businessScenarioId}/planner/planConfiguration/localizations
```

For a specific localization based on the unique name of a business scenario:

``` http
POST /solutions/businessScenarios(uniqueName='{uniqueName}')/planner/planConfiguration/localizations
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [plannerPlanConfigurationLocalization](../resources/plannerplanconfigurationlocalization.md) object.

You can specify the following properties when you create a **plannerPlanConfigurationLocalization**.

|Property|Type|Description|
|:---|:---|:---|
|buckets|[plannerPlanConfigurationBucketLocalization](../resources/plannerplanconfigurationbucketlocalization.md) collection|Localizations for buckets specified in the [plannerPlanConfiguration](../resources/plannerplanconfiguration.md). Required.|
|languageTag|String|The code for the language the localized data is intended for. Required.|
|planTitle|String|Localized title of the plan. Required.|

## Response

If successful, this method returns a `201 Created` response code and a [plannerPlanConfigurationLocalization](../resources/plannerplanconfigurationlocalization.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_plannerplanconfigurationlocalization_from_",
  "sampleKeys": ["c5d514e6c6864911ac46c720affb6e4d"]
}
-->
``` http
POST https://graph.microsoft.com/beta/solutions/businessScenarios/c5d514e6c6864911ac46c720affb6e4d/planner/planConfiguration/localizations
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerPlanConfigurationLocalization",
  "languageTag": "en-us",
  "planTitle": "Order Tracking",
  "buckets": [
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "deliveryBucket",
        "name": "Deliveries"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "storePickupBucket",
        "name": "Pickup"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "specialOrdersBucket",
        "name": "Special Orders"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "returnProcessingBucket",
        "name": "Customer Returns"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerPlanConfigurationLocalization = new PlannerPlanConfigurationLocalization
{
	LanguageTag = "en-us",
	PlanTitle = "Order Tracking",
	Buckets = new List<PlannerPlanConfigurationBucketLocalization>()
	{
		new PlannerPlanConfigurationBucketLocalization
		{
			ExternalBucketId = "deliveryBucket",
			Name = "Deliveries"
		},
		new PlannerPlanConfigurationBucketLocalization
		{
			ExternalBucketId = "storePickupBucket",
			Name = "Pickup"
		},
		new PlannerPlanConfigurationBucketLocalization
		{
			ExternalBucketId = "specialOrdersBucket",
			Name = "Special Orders"
		},
		new PlannerPlanConfigurationBucketLocalization
		{
			ExternalBucketId = "returnProcessingBucket",
			Name = "Customer Returns"
		}
	}
};

await graphClient.Solutions.BusinessScenarios["{businessScenario-id}"].Planner.PlanConfiguration.Localizations
	.Request()
	.AddAsync(plannerPlanConfigurationLocalization);

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
  "@odata.type": "microsoft.graph.plannerPlanConfigurationLocalization"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.plannerPlanConfigurationLocalization",
  "id": "en-us",
  "languageTag": "en-us",
  "planTitle": "Order Tracking",
  "buckets": [
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "deliveryBucket",
        "name": "Deliveries"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "storePickupBucket",
        "name": "Pickup"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "specialOrdersBucket",
        "name": "Special Orders"
    },
    {
        "@odata.type": "microsoft.graph.plannerPlanConfigurationBucketLocalization",
        "externalBucketId": "returnProcessingBucket",
        "name": "Customer Returns"
    }
  ]
}
```
