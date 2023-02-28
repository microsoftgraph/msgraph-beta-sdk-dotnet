---
title: "Update set"
description: "Update the properties of a set object."
author: mohitpcad
ms.localizationpriority: medium
ms.prod: sites-and-lists
doc_type: apiPageType
---

# Update set
Namespace: microsoft.graph.termStore

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [set](../resources/termstore-set.md) object.

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
}
-->

``` http
PATCH /termStore/sets/{setId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [set](../resources/termstore-set.md) object.

The following table shows the properties that can be edited for the [set](../resources/termstore-set.md).

|Property|Type|Description|
|:---|:---|:---|
|localizedNames|[microsoft.graph.termStore.localizedName](../resources/termstore-localizedname.md) collection|Name of the set|
|description|String|Description of the set|
|properties|[microsoft.graph.keyValue](../resources/keyvalue.md) collection|properties of a set|



## Response

If successful, this method returns a `200 OK` response code and an updated [set](../resources/termstore-set.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_set"
} -->

``` http
PATCH https://graph.microsoft.com/beta/termStore/sets/{setId}
Content-Type: application/json

{
  "description": "mySet"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var set = new Microsoft.Graph.TermStore.Set
{
	Description = "mySet"
};

await graphClient.TermStore.Sets["{termStore.set-id}"]
	.Request()
	.UpdateAsync(set);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.termStore.set"
}-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "3607e9f9-e9f9-3607-f9e9-0736f9e90736",
  "description": "mySet",    
  "localizedNames" : [
    {
      "languageTag" : "en-US",
      "name" : "Department"
    }
  ]
}
```

<!--
{
  "type": "#page.annotation",
  "description": "Get termSet entity in termStore",
  "keywords": "term,termStore",
  "section": "documentation",
  "tocPath": "termStore/Update termSet",
  "suppressions": [
  ]
}
-->


