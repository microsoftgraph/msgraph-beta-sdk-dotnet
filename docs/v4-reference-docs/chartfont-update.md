---
title: "Update workbookChartFont"
description: "Update the properties of workbookChartFont object."
author: "lumine2008"
ms.localizationpriority: medium
ms.prod: "excel"
doc_type: apiPageType
---

# Update chartfont

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of chartfont object.
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
PATCH /me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/axes/valueaxis/format/font
PATCH /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/charts/{name}/axes/valueaxis/format/font
PATCH /me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/axes/seriesaxis/format/font
PATCH /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/charts/{name}/axes/seriesaxis/format/font
PATCH /me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/axes/categoryaxis/format/font
PATCH /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/charts/{name}/axes/categoryaxis/format/font
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
|bold|boolean|Represents the bold status of font.|
|color|string|HTML color code representation of the text color. E.g. #FF0000 represents Red.|
|italic|boolean|Represents the italic status of the font.|
|name|string|Font name (e.g. "Calibri")|
|size|double|Size of the font (e.g. 11)|
|underline|string|Type of underline applied to the font. Possible values are: `None`, `Single`.|

## Response

If successful, this method returns a `200 OK` response code and updated [workbookChartFont](../resources/workbookchartfont.md) object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_chartfont"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/worksheets/{id|name}/charts/{name}/axes/valueaxis/format/font
Content-type: application/json

{
  "bold": true,
  "color": "color-value",
  "italic": true,
  "name": "name-value",
  "size": 99,
  "underline": "underline-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var workbookChartFont = new WorkbookChartFont
{
	Bold = true,
	Color = "color-value",
	Italic = true,
	Name = "name-value",
	Size = 99,
	Underline = "underline-value"
};

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Worksheets["{workbookWorksheet-id}"].Charts["{workbookChart-id}"].Axes.ValueAxis.Format.Font
	.Request()
	.UpdateAsync(workbookChartFont);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

