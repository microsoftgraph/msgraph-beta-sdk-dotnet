---
title: "filter: apply"
description: "Apply the given filter criteria on the given column."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ruoyingl"
ms.prod: workbooks-and-charts
---

# filter: apply

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Apply the given filter criteria on the given column.
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
POST /me/drive/items/{id}/workbook/tables/{id|name}/columns/{id|name}/filter/apply
POST /me/drive/root:/{item-path}:/workbook/tables/{id|name}/columns/{id|name}/filter/apply
POST /me/drive/items/{id}/workbook/worksheets/{id|name}/tables/{id|name}/columns/{id|name}/filter/apply
POST /me/drive/root:/{item-path}:/workbook/worksheets/{id|name}/tables/{id|name}/columns/{id|name}/filter/apply

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|criteria|workbookFilterCriteria|The criteria to apply.|

## Response

If successful, this method returns `200 OK` response code. It does not return anything in the response body.

## Example

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "filter_apply"
}-->
```http
POST https://graph.microsoft.com/beta/me/drive/items/{id}/workbook/tables/{id|name}/columns/{id|name}/filter/apply
Content-type: application/json

{
  "criteria": {
    "criterion1": "criterion1-value",
    "criterion2": "criterion2-value",
    "color": "color-value",
    "operator": {
    },
    "icon": {
      "set": "set-value",
      "index": 99
    },
    "dynamicCriteria": "dynamicCriteria-value",
    "values": {
    },
    "filterOn": "filterOn-value"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var criteria = new WorkbookFilterCriteria
{
	Criterion1 = "criterion1-value",
	Criterion2 = "criterion2-value",
	Color = "color-value",
	Operator = "",
	Icon = new WorkbookIcon
	{
		Set = "set-value",
		Index = 99
	},
	DynamicCriteria = "dynamicCriteria-value",
	Values = JsonDocument.Parse("{}"),
	FilterOn = "filterOn-value"
};

await graphClient.Me.Drive.Items["{driveItem-id}"].Workbook.Tables["{workbookTable-id}"].Columns["{workbookTableColumn-id}"].Filter
	.Apply(criteria)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 200 OK
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Filter: apply",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


