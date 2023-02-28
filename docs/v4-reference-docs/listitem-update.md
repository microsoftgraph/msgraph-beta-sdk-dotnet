---
author: JeremyKelley
description: "Update the properties on a listItem."
ms.date: 09/11/2017
title: Update a record in a SharePoint list
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Update an item in a list

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties on a **[listItem][]**.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Sites.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /sites/{site-id}/lists/{list-id}/items/{item-id}/fields
```

## Optional request headers

| Name       | Value | Description
|:-----------|:------|:--------------------------------------------------------
| _if-match_ | etag  | If this request header is included and the eTag provided does not match the current eTag on the item, a `412 Precondition Failed` response is returned and the item will not be updated.


## Request body

In the request body, supply a JSON representation of a [fieldValueSet][] specifying the fields to update.

## Example

Here is an example that updates the Color and Quantity fields of the list item with new values.
All other values on the listItem are left alone. 


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "create-listitem-2", "scopes": "sites.readwrite.all" } -->

```http
PATCH https://graph.microsoft.com/beta/sites/{site-id}/lists/{list-id}/items/{item-id}/fields
Content-Type: application/json

{
    "Color": "Fuchsia",
    "Quantity": 934
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var fieldValueSet = new FieldValueSet
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"Color", "Fuchsia"},
		{"Quantity", "934"}
	}
};

await graphClient.Sites["{site-id}"].Lists["{list-id}"].Items["{listItem-id}"].Fields
	.Request()
	.UpdateAsync(fieldValueSet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

