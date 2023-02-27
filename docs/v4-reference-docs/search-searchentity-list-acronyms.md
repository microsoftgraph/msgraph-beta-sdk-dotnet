---
title: "List acronyms"
description: "Get a list of the acronym objects and their properties."
author: "jakeost-msft"
ms.localizationpriority: medium
ms.prod: "search"
doc_type: apiPageType
---

# List acronyms
Namespace: microsoft.graph.search

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [acronym](../resources/search-acronym.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)| SearchConfiguration.Read.All, SearchConfiguration.ReadWrite.All |
|Delegated (personal Microsoft account)| Not supported. |
|Application| SearchConfiguration.Read.All, SearchConfiguration.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /search/acronyms
```

## Optional query parameters
This method supports the `select`, `expand`, `filter`, `orderBy`, `maxTop`, and `count` [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [acronym](../resources/search-acronym.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_acronym"
}
-->
``` http
GET https://graph.microsoft.com/beta/search/acronyms
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var acronyms = await graphClient.Search.Acronyms
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.search.acronym",
  "isCollection": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

[
  {
    "id": "733b26d5-af76-4eea-ac69-1a0ce8716897",
    "displayName": "DNN",
    "standsFor": ["Deep Neural Network"],
    "description": "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers.",
    "webUrl": "http://microsoft.com/deep-neural-network",
    "state": "published",
    "lastModifiedDateTime": "2016-03-21T20:01:37Z",
    "lastModifiedBy": {
      "user": {
          "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
          "displayName": "Amalie Larsen"
      }
    }
  }
]
```

