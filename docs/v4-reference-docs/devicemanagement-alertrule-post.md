---
title: "Create alertRule"
description: "Create an alertRule object."
author: "zhishending"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Create alertRule

Namespace: microsoft.graph.deviceManagement

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create an [alertRule](../resources/devicemanagement-alertrule.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
```http
POST /deviceManagement/monitoring/alertRules
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
|alertRuleTemplate|alertRuleTemplate|The rule template of the alert event. The possible values are: `cloudPcProvisionScenario`, `cloudPcImageUploadScenario`, `cloudPcOnPremiseNetworkConnectionCheckScenario`, `unknownFutureValue`.|
|description|String|The rule description.|
|displayName|String|The display name of the rule.|
|enabled|Boolean|The status of the rule that indicates whether the rule is enabled or disabled. If `true`, the rule is enabled; otherwise, the rule is disabled.|
|isSystemRule|Boolean|Indicates whether the rule is a system rule. If `true`, the rule is a system rule; otherwise, the rule is a custom defined rule and can be edited. System rules are built-in and only a few properties can be edited.|
|notificationChannels|[microsoft.graph.deviceManagement.notificationChannel](../resources/devicemanagement-notificationchannel.md) collection|The notification channels of the rule selected by the user.|
|severity|ruleSeverityType|The severity of the rule. The possible values are: `unknown`, `informational`, `warning`, `critical`, `unknownFutureValue`.|
|threshold|[microsoft.graph.deviceManagement.ruleThreshold](../resources/devicemanagement-rulethreshold.md)|The threshold of the rule.|

## Response

If successful, this method returns a `201 Created` response code and an [microsoft.graph.deviceManagement.alertRule](../resources/devicemanagement-alertrule.md) object in the response body.

## Example

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_alertrule"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/monitoring/alertRules
Content-Type: application/json

{
  "id": "215c55cc-b1c9-4d36-a870-be5778101714",
  "displayName": "Azure network connection failure impacting Cloud PCs",
  "severity": "informational",
  "isSystemRule": true,
  "description": "Azure network connection checks have failed and is potentially impacting existing Cloud PCs and blocking the provisioning of new Cloud PCs",
  "enabled": true,
  "alertRuleTemplate": "cloudPcOnPremiseNetworkConnectionCheckScenario",
  "threshold": {
      "aggregation": "count",
      "operator": "greaterOrEqual",
      "target": 90
  },
  "notificationChannels": [
      {
        "notificationChannelType": "portal",
        "receivers": [
            ""
        ],
        "notificationReceivers": []
      },
      {
        "notificationChannelType": "email",
        "receivers": [
            "serena.davis@contoso.com"
        ],
        "notificationReceivers": [
            {
                "locale": "en-us",
                "contactInformation": "serena.davis@contoso.com"
            }
        ]
      }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var alertRule = new Microsoft.Graph.DeviceManagement.AlertRule
{
	Id = "215c55cc-b1c9-4d36-a870-be5778101714",
	DisplayName = "Azure network connection failure impacting Cloud PCs",
	Severity = Microsoft.Graph.DeviceManagement.RuleSeverityType.Informational,
	IsSystemRule = true,
	Description = "Azure network connection checks have failed and is potentially impacting existing Cloud PCs and blocking the provisioning of new Cloud PCs",
	Enabled = true,
	AlertRuleTemplate = Microsoft.Graph.DeviceManagement.AlertRuleTemplate.CloudPcOnPremiseNetworkConnectionCheckScenario,
	Threshold = new Microsoft.Graph.DeviceManagement.RuleThreshold
	{
		Aggregation = Microsoft.Graph.DeviceManagement.AggregationType.Count,
		Operator = Microsoft.Graph.DeviceManagement.OperatorType.GreaterOrEqual,
		Target = 90
	},
	NotificationChannels = new List<Microsoft.Graph.DeviceManagement.NotificationChannel>()
	{
		new Microsoft.Graph.DeviceManagement.NotificationChannel
		{
			NotificationChannelType = Microsoft.Graph.DeviceManagement.NotificationChannelType.Portal,
			Receivers = new List<String>()
			{
				""
			},
			NotificationReceivers = new List<Microsoft.Graph.DeviceManagement.NotificationReceiver>()
			{
			}
		},
		new Microsoft.Graph.DeviceManagement.NotificationChannel
		{
			NotificationChannelType = Microsoft.Graph.DeviceManagement.NotificationChannelType.Email,
			Receivers = new List<String>()
			{
				"serena.davis@contoso.com"
			},
			NotificationReceivers = new List<Microsoft.Graph.DeviceManagement.NotificationReceiver>()
			{
				new Microsoft.Graph.DeviceManagement.NotificationReceiver
				{
					Locale = "en-us",
					ContactInformation = "serena.davis@contoso.com"
				}
			}
		}
	}
};

await graphClient.DeviceManagement.Monitoring.AlertRules
	.Request()
	.AddAsync(alertRule);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.deviceManagement.alertRule"
}
-->
``` http
HTTP/1.1 201 CREATED
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#deviceManagement/monitoring/alertRules/$entity",
  "id": "215c55cc-b1c9-4d36-a870-be5778101714",
  "displayName": "Azure network connection failure impacting Cloud PCs",
  "severity": "informational",
  "isSystemRule": true,
  "description": "Azure network connection checks have failed and is potentially impacting existing Cloud PCs and blocking the provisioning of new Cloud PCs",
  "enabled": true,
  "alertRuleTemplate": "cloudPcOnPremiseNetworkConnectionCheckScenario",
  "threshold": {
      "aggregation": "count",
      "operator": "greaterOrEqual",
      "target": 90
  },
  "notificationChannels": [
      {
        "notificationChannelType": "portal",
        "receivers": [
            ""
        ],
        "notificationReceivers": []
      },
      {
        "notificationChannelType": "email",
        "receivers": [
            "serena.davis@contoso.com"
        ],
        "notificationReceivers": [
            {
                "locale": "en-us",
                "contactInformation": "serena.davis@contoso.com"
            }
        ]
      }
  ]
}
```
