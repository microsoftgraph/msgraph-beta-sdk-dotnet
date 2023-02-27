---
title: "Create deployment"
description: "Create a new deployment object."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# Create deployment
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [deployment](../resources/windowsupdates-deployment.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|WindowsUpdates.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|WindowsUpdates.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /admin/windows/updates/deployments
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [deployment](../resources/windowsupdates-deployment.md) object.

The following table shows the properties that are required when you create the [deployment](../resources/windowsupdates-deployment.md).

|Property|Type|Description|
|:---|:---|:---|
|audience|[microsoft.graph.windowsUpdates.deploymentAudience](../resources/windowsupdates-deploymentaudience.md)|Specifies the audience to target.|
|content|[microsoft.graph.windowsUpdates.deployableContent](../resources/windowsupdates-deployablecontent.md)|Specifies what content to deploy. Deployable content should be provided as one of the following derived types: [catalogContent](../resources/windowsupdates-catalogcontent.md).|

## Response

If successful, this method returns a `201 Created` response code and a [deployment](../resources/windowsupdates-deployment.md) object in the response body.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_deployment_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/windows/updates/deployments
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
    "content": {
        "@odata.type": "#microsoft.graph.windowsUpdates.catalogContent",
        "catalogEntry": {
            "@odata.type": "#microsoft.graph.windowsUpdates.featureUpdateCatalogEntry",
            "id": "f341705b-0b15-4ce3-aaf2-6a1681d78606"
        }
    },
    "settings": {
        "@odata.type": "microsoft.graph.windowsUpdates.deploymentSettings",
        "schedule": {
            "gradualRollout": {
                "@odata.type": "#microsoft.graph.windowsUpdates.rateDrivenRolloutSettings",
                "durationBetweenOffers": "P7D",
                "devicePerOffer": 100
            }
        },
        "monitoring": {
            "monitoringRules": [
                {
                    "signal": "rollback",
                    "threshold": 5,
                    "action": "pauseDeployment"
                }
            ]
        }
    }
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var deployment = new Microsoft.Graph.WindowsUpdates.Deployment
{
	Content = new FeatureUpdateReference
	{
		Version = "20H2"
	},
	Settings = new WindowsDeploymentSettings
	{
		Rollout = new Microsoft.Graph.WindowsUpdates.RolloutSettings
		{
			DevicesPerOffer = 100
		},
		Monitoring = new Microsoft.Graph.WindowsUpdates.MonitoringSettings
		{
			MonitoringRules = new List<Microsoft.Graph.WindowsUpdates.MonitoringRule>()
			{
				new Microsoft.Graph.WindowsUpdates.MonitoringRule
				{
					Signal = Microsoft.Graph.WindowsUpdates.MonitoringSignal.Rollback,
					Threshold = 5,
					Action = Microsoft.Graph.WindowsUpdates.MonitoringAction.PauseDeployment
				}
			}
		}
	}
};

await graphClient.Admin.Windows.Updates.Deployments
	.Request()
	.AddAsync(deployment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.windowsUpdates.deployment"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
  "id": "b5171742-1742-b517-4217-17b5421717b5",
  "createdDateTime": "2023-01-26T05:08:38.118213Z",
  "lastModifiedDateTime": "2023-01-26T05:08:38Z",
  "state": {
    "value": "offering",
    "reasons": [],
    "requestedValue": "none",
  },
  "content": {
    "@odata.type": "microsoft.graph.windowsUpdates.catalogContent",
  },
  "settings": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentSettings",
    "schedule": {
      "gradualRollout": {
        "@odata.type": "#microsoft.graph.windowsUpdates.rateDrivenRolloutSettings",
        "durationBetweenOffers": "P1D",
        "devicePerOffer": 1000
      }
    },
    "monitoring": {
      "monitoringRules": [
        {
          "@odata.type": "#microsoft.graph.windowsUpdates.monitoringRule",
          "signal": "rollback",
          "threshold": 5,
          "action": "pauseDeployment"
        }
      ]
    },
    "userExperience": null,
    "safeguard": null
  },
}
```
