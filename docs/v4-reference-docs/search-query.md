---
title: "searchEntity: query"
description: "Run a specified search query. Search results are provided in the response."
ms.localizationpriority: medium
author: "njerigrevious"
ms.prod: "search"
doc_type: "apiPageType"
---

# searchEntity: query

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Run a specified search query. Search results are provided in the response.


> [!CAUTION]
> Resources used in a Microsoft Search API request and response have had properties renamed or removed, or are being deprecated. Find [more details](/graph/api/resources/search-api-overview?view=graph-rest-beta&preserve-view=true#schema-change-deprecation-warning) about the deprecation. Update search API queries in any earlier apps accordingly.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference). 

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Mail.Read, Calendars.Read, Files.Read.All, Sites.Read.All, ExternalItem.Read.All, Acronym.Read.All, Bookmark.Read.All, ChannelMessage.Read.All, Chat.Read, QnA.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Files.Read.All, Sites.Read.All |

## HTTP request

```HTTP
POST /search/query
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
|requests|[searchRequest](../resources/searchrequest.md) collection|A collection of one or more search requests each formatted in a JSON blob. Each JSON blob contains the types of resources expected in the response, the underlying sources, paging parameters, requested fields, and actual search query. Be aware of [known limitations](../resources/search-api-overview.md#known-limitations) on searching specific combinations of entity types, and sorting or aggregating search results. |

## Response

If successful, this method returns an `HTTP 200 OK` response code and a collection of [searchResponse](../resources/searchresponse.md) objects in the response body.
 

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "search_query"
}-->

```HTTP
POST https://graph.microsoft.com/beta/search/query
Content-type: application/json

{
  "requests": [
    {
      "entityTypes": [
        "externalItem"
      ],
      "contentSources": [
        "/external/connections/connectionfriendlyname"
      ],
      "query": {
        "queryString": "contoso product"
      },
      "from": 0,
      "size": 25,
      "fields": [
        "title",
        "description"
      ]
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var requests = new List<SearchRequestObject>()
{
	new SearchRequestObject
	{
		EntityTypes = new List<EntityType>()
		{
			EntityType.ExternalItem
		},
		ContentSources = new List<String>()
		{
			"/external/connections/connectionfriendlyname"
		},
		Query = new SearchQuery
		{
			QueryString = "contoso product"
		},
		From = 0,
		Size = 25,
		Fields = new List<String>()
		{
			"title",
			"description"
		}
	}
};

await graphClient.Search
	.Query(requests)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.searchResponse",
  "isCollection": true
} -->

```HTTP
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "searchTerms": [
        "searchTerms-value"
      ],
      "hitsContainers": [
        {
          "hits": [
            {
              "hitId": "1",
              "rank": 1,
              "summary": "_summary-value",
              "resource": "The source field will contain the underlying graph entity part of the response"
            }
          ],
          "total": 47,
          "moreResultsAvailable": true
        }
      ]
    }
  ]
}
```

## See also

- Search [mail messages](/graph/search-concept-messages)
- Search [calendar events](/graph/search-concept-events)
- Search [person](/graph/search-concept-person)
- Search content in SharePoint and OneDrive ([files, lists and sites](/graph/search-concept-files))
- Search [custom types (Graph Connectors)](/graph/search-concept-custom-types) data
- [Sort](/graph/search-concept-sort) search results
- Use [aggregations](/graph/search-concept-aggregations) to refine search results
- Enable [spell corrections](/graph/search-concept-speller) in search results

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "search: query",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
