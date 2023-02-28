---
title: "Update store"
description: "Update the properties of a store object."
author: mohitpcad
ms.localizationpriority: medium
ms.prod: sites-and-lists
doc_type: apiPageType
---

# Update store
Namespace: microsoft.graph.termStore

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [store](../resources/termstore-store.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) |TermStore.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}-->

``` http
PATCH /termStore
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [store](../resources/termstore-store.md) object.

The following table shows the properties that can be edited for the [store](../resources/termstore-store.md).

|Property|Type|Description|
|:---|:---|:---|
|defaultLanguageTag|String|Default language of the [microsoft.graph.termstore.store](../resources/termstore-store.md)|
|languageTags|String collection|Available languages in the [microsoft.graph.termstore.store](../resources/termstore-store.md)|



## Response

If successful, this method returns a `200 OK` response code and an updated [store](../resources/termstore-store.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_store"
} -->

``` http
PATCH https://graph.microsoft.com/beta/termStore
Content-Type: application/json

{
  "defaultLanguageTag": "en-US"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var store = new Microsoft.Graph.TermStore.Store
{
	DefaultLanguageTag = "en-US"
};

await graphClient.TermStore
	.Request()
	.UpdateAsync(store);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.termStore.store"
} -->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "dad13b4b-3b4b-dad1-4b3b-d1da4b3bd1da",
  "defaultLanguageTag": "en-US",
  "languageTags": [
    "en-US", 
    "fr-FR"
  ]
}
```

<!--
{
  "type": "#page.annotation",
  "description": "Get term entity in termStore",
  "keywords": "term,termStore",
  "section": "documentation",
  "tocPath": "termStore/Update termstore",
  "suppressions": [
  ]
}
-->



