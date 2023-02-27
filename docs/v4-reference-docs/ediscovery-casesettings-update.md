---
title: "Update caseSettings"
description: "Update the properties of an eDiscovery caseSettings object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Update caseSettings

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a an eDiscovery [caseSettings](../resources/ediscovery-caseSettings.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PATCH /compliance/ediscovery/cases/{caseId}/settings
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [caseSettings](../resources/ediscovery-caseSettings.md) object.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_settings_for _caseID"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/compliance/ediscovery/cases/{caseId}/settings
Content-Type: application/json

{
    "redundancyDetection": {
        "isEnabled": false,
        "similarityThreshold": 70,
        "minWords": 12,
        "maxWords": 400000
    },
    "topicModeling": {
        "isEnabled": false,
        "ignoreNumbers": false,
        "topicCount": 50,
        "dynamicallyAdjustTopicCount": false
    },
    "ocr": {
        "isEnabled": true,
        "maxImageSize": 12000
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var caseSettings = new Microsoft.Graph.Ediscovery.CaseSettings
{
	RedundancyDetection = new Microsoft.Graph.Ediscovery.RedundancyDetectionSettings
	{
		IsEnabled = false,
		SimilarityThreshold = 70,
		MinWords = 12,
		MaxWords = 400000
	},
	TopicModeling = new Microsoft.Graph.Ediscovery.TopicModelingSettings
	{
		IsEnabled = false,
		IgnoreNumbers = false,
		TopicCount = 50,
		DynamicallyAdjustTopicCount = false
	},
	Ocr = new Microsoft.Graph.Ediscovery.OcrSettings
	{
		IsEnabled = true,
		MaxImageSize = 12000
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].Settings
	.Request()
	.UpdateAsync(caseSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
cache-control: no-cache
client-request-id: e9fc7554-ca5e-0928-fc09-9c5825820c88
content-length: 0
request-id: 1f53bd55-f099-46cb-91df-8f5d466aba3a
```
