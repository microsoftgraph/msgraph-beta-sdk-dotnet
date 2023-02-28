---
title: "workbookWorksheetProtection: protect"
description: "Protect a worksheet. It throws if the worksheet has been protected."
author: "lumine2008"
ms.localizationpriority: medium
ms.prod: "excel"
doc_type: apiPageType
---

# workbookWorksheetProtection: protect

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Protect a worksheet. It throws if the worksheet has been protected.
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
POST /me/drive/items/{id}/workbook/worksheets/{id|name}/protection/protect
POST /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/protection/protect

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Workbook-Session-Id  | Workbook session Id that determines if changes are persisted or not. Optional.|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|options|[workbookWorksheetProtectionOptions](../resources/workbookworksheetprotectionoptions.md)|Optional. sheet protection options.|

## Response

If successful, this method returns `200 OK` response code. It does not return anything in the response body.

## Example
Here is an example of how to call this API.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "workbookworksheetprotection_protect"
}-->
```http
POST https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/worksheets/{id|name}/protection/protect
Content-type: application/json

{
  "options": {
    "allowFormatCells": true,
    "allowFormatColumns": true,
    "allowFormatRows": true,
    "allowInsertColumns": true,
    "allowInsertRows": true,
    "allowInsertHyperlinks": true,
    "allowDeleteColumns": true,
    "allowDeleteRows": true,
    "allowSort": true,
    "allowAutoFilter": true,
    "allowPivotTables": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var options = new WorkbookWorksheetProtectionOptions
{
	AllowFormatCells = true,
	AllowFormatColumns = true,
	AllowFormatRows = true,
	AllowInsertColumns = true,
	AllowInsertRows = true,
	AllowInsertHyperlinks = true,
	AllowDeleteColumns = true,
	AllowDeleteRows = true,
	AllowSort = true,
	AllowAutoFilter = true,
	AllowPivotTables = true
};

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Worksheets["{workbookWorksheet-id}"].Protection
	.Protect(options)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

