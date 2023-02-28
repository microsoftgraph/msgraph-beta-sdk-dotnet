---
title: "Create table"
description: "Use this API to create a new Table."
author: "lumine2008"
ms.localizationpriority: medium
ms.prod: "excel"
doc_type: apiPageType
---

# Create table

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Use this API to create a new Table.
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
POST /me/drive/items/{id}/workbook/worksheets/{id|name}/tables/add
POST /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/tables/add

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Workbook-Session-Id  | Workbook session Id that determines if changes are persisted or not. Optional.|

## Request body
In the request body, provide a JSON object with the following parameters. 

| Parameter       | Type|Description|
|:---------------|:----------|:----------|
| Address  | string| Range address. If you are calling this API off of `worksheets/{id|name}/tables/add` path, there is no need to support the sheet name prefix in the address. However, if you are calling this off of `workbook/tables/add` path, then supply the sheet name on which the table needs to be created (example: `sheet1!A1:D4`)|
| hasHeaders  | boolean|Boolean value that indicates whether the range has column labels. If the source does not contain headers (i.e,. when this property set to false), Excel will automatically generate header shifting the data down by one row.|

## Response

If successful, this method returns `201 Created` response code and [workbookTable](../resources/workbooktable.md) object in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_table_from_worksheet"
}-->
```http
POST https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/worksheets/{id|name}/tables/$/add
Content-type: application/json

{
  "address": "",
  "hasHeaders": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var address = "";

var hasHeaders = false;

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Worksheets["{workbookWorksheet-id}"].Tables
	.Add(hasHeaders,address)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

