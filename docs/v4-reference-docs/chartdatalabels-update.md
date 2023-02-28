---
title: "Update workbookChartDataLabels"
description: "Update the properties of workbookchartdatalabels object."
author: "lumine2008"
ms.localizationpriority: medium
ms.prod: "excel"
doc_type: apiPageType
---

# Update workbookChartDataLabels

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of chartdatalabels object.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Files.ReadWrite    |
|Delegated (personal Microsoft account) | Files.ReadWrite    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/datalabels
PATCH /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/charts/{name}/datalabels
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}. Required. |
| Workbook-Session-Id  | Workbook session Id that determines if changes are persisted or not. Optional.|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|position|string|DataLabelPosition value that represents the position of the data label. Possible values are: `None`, `Center`, `InsideEnd`, `InsideBase`, `OutsideEnd`, `Left`, `Right`, `Top`, `Bottom`, `BestFit`, `Callout`.|
|separator|string|String representing the separator used for the data labels on a chart.|
|showBubbleSize|boolean|Boolean value representing if the data label bubble size is visible or not.|
|showCategoryName|boolean|Boolean value representing if the data label category name is visible or not.|
|showLegendKey|boolean|Boolean value representing if the data label legend key is visible or not.|
|showPercentage|boolean|Boolean value representing if the data label percentage is visible or not.|
|showSeriesName|boolean|Boolean value representing if the data label series name is visible or not.|
|showValue|boolean|Boolean value representing if the data label value is visible or not.|

## Response

If successful, this method returns a `200 OK` response code and updated [workbookChartDataLabels](../resources/workbookchartdatalabels.md) object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_chartdatalabels"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/datalabels
Content-type: application/json

{
  "position": "position-value",
  "showValue": true,
  "showSeriesName": true,
  "showCategoryName": true,
  "showLegendKey": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var workbookChartDataLabels = new WorkbookChartDataLabels
{
	Position = "position-value",
	ShowValue = true,
	ShowSeriesName = true,
	ShowCategoryName = true,
	ShowLegendKey = true
};

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Worksheets["{workbookWorksheet-id}"].Charts["{workbookChart-id}"].DataLabels
	.Request()
	.UpdateAsync(workbookChartDataLabels);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

