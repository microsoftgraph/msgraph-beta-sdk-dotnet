---
title: "Delete namedItem"
description: Delete a workbookNamedItem object
author: isvargasmsft
ms.localizationpriority: medium
ms.prod: workbooks-and-charts
doc_type: apiPageType
---

# Delete namedItem

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [workbookNamedItem](../resources/workbooknameditem.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Files.ReadWrite.Selected, Files.ReadWrite.AppFolder, Files.ReadWrite, Files.ReadWrite.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All    |
|Delegated (personal Microsoft account) | Files.ReadWrite, Files.ReadWrite.All    |
|Application | Files.ReadWrite.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All   |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /me/drive/items/{id}/workbook/names/{name}
DELETE /me/drive/root:/{item-path}:/workbook/names/{name}
DELETE /me/drive/items/{id}/workbook/worksheets/{id|name}/names/{name}
DELETE /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/names/{name}
```

## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Workbook-Session-ID  | Workbook session ID that determines if changes are persisted or not. Optional.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content`. It does not return anything in the response body.


## Example
### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_nameditem"
}-->

```http
DELETE https://graph.microsoft.com/beta/me/drive/items/{itemID}/workbook/names/{name}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Names["{workbookNamedItem-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
Here is an example of the response. 
<!-- {
  "blockType": "response",
  "isEmpty": true
} -->
```http
HTTP/1.1 204 No Content
```
