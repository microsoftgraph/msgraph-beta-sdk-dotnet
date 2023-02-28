---
title: "Update term"
description: "Update the properties of a term object."
author: mohitpcad
ms.localizationpriority: medium
ms.prod: sites-and-lists
doc_type: apiPageType
---

# Update term
Namespace: microsoft.graph.termStore

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [term](../resources/termstore-term.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account) | TermStore.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |


## HTTP request

<!-- {
  "blockType": "ignored"
}-->

``` http
PATCH /termStore/sets/{setId}/terms/{termId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [term](../resources/termstore-term.md) object.

The following table shows the properties that can be updated for a [term](../resources/termstore-term.md).

|Property|Type|Description|
|:---|:---|:---|
|labels|[microsoft.graph.termStore.localizedLabel](../resources/termstore-localizedlabel.md) collection|Labels of a term.|
|descriptions|[microsoft.graph.termStore.localizedDescription](../resources/termstore-localizeddescription.md) collection|Description about the term.|
|properties|[microsoft.graph.keyValue](../resources/keyvalue.md) collection|Properties associated with the term.|



## Response

If successful, this method returns a `200 OK` response code and an updated [term](../resources/termstore-term.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_term"
} -->

``` http
PATCH https://graph.microsoft.com/beta/termStore/sets/{setId}/terms/{termId}
Content-Type: application/json

{
  "labels" : [
      {
          "name" : "changedLabel",
          "languageTag" : "en-US",
          "isDefault" : true
      }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var term = new Microsoft.Graph.TermStore.Term
{
	Labels = new List<Microsoft.Graph.TermStore.LocalizedLabel>()
	{
		new Microsoft.Graph.TermStore.LocalizedLabel
		{
			Name = "changedLabel",
			LanguageTag = "en-US",
			IsDefault = true
		}
	}
};

await graphClient.TermStore.Sets["{termStore.set-id}"].Terms["{termStore.term-id}"]
	.Request()
	.UpdateAsync(term);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.termStore.term"
}-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "81be9856-9856-81be-5698-be815698be81",
  "labels" : [
      {
          "name" : "changedLabel",
          "languageTag" : "en-US",
          "isDefault" : true
      }
  ]
}
```

[microsoft.graph.termStore.term]: ../resources/termstore-term.md

<!--
{
  "type": "#page.annotation",
  "description": "Get term entity in termStore",
  "keywords": "term,termStore",
  "section": "documentation",
  "tocPath": "termStore/Update term",
  "suppressions": [
  ]
}
-->


