---
title: "Update deployment"
description: "Update the properties of a deployment object."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# Update deployment
Namespace: microsoft.graph.windowsUpdates

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [deployment](../resources/windowsupdates-deployment.md) object.

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
PATCH /admin/windows/updates/deployments/{deploymentId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

The following table shows the properties that can be set when you update a [deployment](../resources/windowsupdates-deployment.md).

|Property|Type|Description|
|:---|:---|:---|
|state|[microsoft.graph.windowsUpdates.deploymentState](../resources/windowsupdates-deploymentstate.md)|Execution status of the deployment.|
|settings|[microsoft.graph.windowsUpdates.deploymentSettings](../resources/windowsupdates-deploymentsettings.md)|Settings specified on the specific deployment governing how to deploy deployment `content`.|

## Response

If successful, this method returns a `202 Accepted` response code and an updated [deployment](../resources/windowsupdates-deployment.md) object in the response body.

## Examples

### Example 1: Pause a deployment

In this example, the deployment is paused by updating the **requestedValue** of the deployment **state**.

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_deployment_1",
  "@odata.type": "microsoft.graph.windowsUpdates.deployment"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/admin/windows/updates/deployments/b5171742-1742-b517-4217-17b5421717b5
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
  "state": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentState",
    "requestedValue": "paused"
  },
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var deployment = new Microsoft.Graph.WindowsUpdates.Deployment
{
	State = new DeploymentState
	{
		RequestedValue = Microsoft.Graph.WindowsUpdates.RequestedDeploymentStateValue.Paused
	}
};

await graphClient.Admin.Windows.Updates.Deployments["{windowsUpdates.deployment-id}"]
	.Request()
	.UpdateAsync(deployment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.windowsUpdates.deployment"
}
-->
``` http
HTTP/1.1 202 Accepted
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
  "id": "b5171742-1742-b517-4217-17b5421717b5",
  "state": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentState",
    "reasons": [
      {
        "@odata.type": "microsoft.graph.windowsUpdates.deploymentStateReason",
        "value": "pausedByRequest"
      }
    ],
    "requestedValue": "paused",
    "effectiveValue": "paused"
  },
  "content": {
    "@odata.type": "#microsoft.graph.windowsUpdates.catalogContent",
    "catalogEntry": {
      "@odata.id": "catalog/entries/1"
    }
  },
  "settings": null,
  "createdDateTime": "String (timestamp)",
  "lastModifiedDateTime": "String (timestamp)"
}
```

### Example 2: Update deployment settings to add a monitoring rule

In this example, the **settings** property of the deployment is updated to add a monitoring rule.

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_deployment_2",
  "@odata.type": "microsoft.graph.windowsUpdates.deployment"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/admin/windows/updates/deployments/b5171742-1742-b517-4217-17b5421717b5
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
  "settings": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentSettings",
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
	Settings = new WindowsDeploymentSettings
	{
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

await graphClient.Admin.Windows.Updates.Deployments["{windowsUpdates.deployment-id}"]
	.Request()
	.UpdateAsync(deployment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.windowsUpdates.deployment"
}
-->
``` http
HTTP/1.1 202 Accepted
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.deployment",
  "id": "b5171742-1742-b517-4217-17b5421717b5",
  "state": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentState",
    "reasons": [
      {
        "@odata.type": "microsoft.graph.windowsUpdates.deploymentStateReason",
        "value": "offeringByRequest"
      }
    ],
    "requestedValue": "none",
    "effectiveValue": "offering"
  },
  "content": {
    "@odata.type": "#microsoft.graph.windowsUpdates.catalogContent",
    "catalogEntry": {
      "@odata.id": "catalog/entries/1"
    }
  },
  "settings": {
    "@odata.type": "microsoft.graph.windowsUpdates.deploymentSettings",
    "monitoring": {
      "monitoringRules": [
        {
          "signal": "rollback",
          "threshold": 5,
          "action": "pauseDeployment"
        }
      ]
    }
  },
  "createdDateTime": "String (timestamp)",
  "lastModifiedDateTime": "String (timestamp)"
}
```

