---
title: "Range: LastRow"
description: "."
author: "lumine2008"
ms.localizationpriority: medium
ms.prod: "excel"
doc_type: apiPageType
---

# Range: LastRow

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Gets the last row within the range. For example, the last row of "B2:D5" is "B5:D5".
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
GET /me/drive/items/{id}/workbook/names/{name}/range/LastRow
GET /me/drive/root:/{item-path}:/workbook/names/{name}/range/LastRow
GET /me/drive/items/{id}/workbook/worksheets/{id|name}/range(address='<address>')/LastRow
GET /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/range(address='<address>')/LastRow
GET /me/drive/items/{id}/workbook/tables/{id|name}/columns/{id|name}/range/LastRow
GET /me/drive/root:/{item-path}:/workbook/tables/{id|name}/columns/{id|name}/range/LastRow

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Workbook-Session-Id  | Workbook session Id that determines if changes are persisted or not. Optional.|

## Request body

## Response

If successful, this method returns `200 OK` response code and [workbookRange](../resources/workbookrange.md) object in the response body.

## Example
Here is an example of how to call this API.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "range_lastrow"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/names/{name}/range/LastRow
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var workbookRange = await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Names["{workbookNamedItem-id}"]
	.Range()
	.LastRow()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

