---
title: "Create bookmark"
description: "Create a new bookmark object."
author: "jakeost-msft"
ms.localizationpriority: medium
ms.prod: "search"
doc_type: apiPageType
---

# Create bookmark
Namespace: microsoft.graph.search

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [bookmark](../resources/search-bookmark.md) object.

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
}-->
```http
POST /search/bookmarks
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [bookmark](../resources/search-bookmark.md) object.

The following table shows the properties that are available when you create a [bookmark](../resources/search-bookmark.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Bookmark name displayed in search results. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|
|description|String|Bookmark description shown on search results page. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|
|webUrl|String|Bookmark URL link. When users click this bookmark in search results, they will go to this URL. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|
|categories|String collection|Categories commonly used to describe this bookmark. For example, IT and HR.|
|availabilityStartDateTime|DateTimeOffset|Timestamp of when the bookmark will start to appear as a search result. Set as `null` for always available.|
|availabilityEndDateTime|DateTimeOffset|Timestamp of when the bookmark will stop to appear as a search result. Set as `null` for always available.|
|languageTags|String collection|List of countries or regions able to view this bookmark.|
|platforms|microsoft.graph.devicePlatformType collection|List of devices and operating systems able to view this bookmark. Possible values are: `unknown`, `android`, `androidForWork`, `ios`, `macOS`, `windowsPhone81`, `windowsPhone81AndLater`, `windows10AndLater`, `androidWorkProfile`, `androidASOP`.|
|targetedVariations|[microsoft.graph.search.answerVariant](../resources/search-answerVariant.md) collection|Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.|
|powerAppIds|String collection|List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks, such as to enter vacation time or to report expenses on the search results page.|
|keywords|[microsoft.graph.search.answerKeyword](../resources/search-answerKeyword.md)|Keywords that trigger this bookmark to appear in search results.|
|state|microsoft.graph.search.answerState|State of the bookmark. Possible values are: `published`, `draft`, `excluded`, or `unknownFutureValue`.|
|groupIds|String collection|List of security groups able to view this bookmark.|



## Response

If successful, this method returns a `201 Created` response code with the ID of the bookmark created.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_bookmark_from_bookmarks"
}-->
```http
POST https://graph.microsoft.com/beta/search/bookmarks
Content-Type: application/json

{
  "displayName": "Contoso Install Site",
  "webUrl": "http://www.contoso.com/",
  "description": "Try or buy Contoso for Home or Business and view product information",
  "keywords":  {
    "keywords": ["Contoso", "install"],
    "reservedKeywords": ["Contoso"],
    "matchSimilarKeywords": true
  },
  "availabilityStartDateTime": null,
  "availabilityEndDateTime": null,
  "platforms": ["windows"],
  "targetedVariations": [
    {
      "languageTag": "es-es",
      "displayName": "Sitio de instalaciÃ³n Contoso",
      "description": "Pruebe o compre Contoso hogar o negocios y vea la informaciÃ³n del producto"
    }
  ],
  "state": "published"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookmark = new Microsoft.Graph.Search.Bookmark
{
	DisplayName = "Contoso Install Site",
	WebUrl = "http://www.contoso.com/",
	Description = "Try or buy Contoso for Home or Business and view product information",
	Keywords = new Microsoft.Graph.Search.AnswerKeyword
	{
		Keywords = new List<String>()
		{
			"Contoso",
			"install"
		},
		ReservedKeywords = new List<String>()
		{
			"Contoso"
		},
		MatchSimilarKeywords = true
	},
	AvailabilityStartDateTime = null,
	AvailabilityEndDateTime = null,
	Platforms = new List<DevicePlatformType>()
	{
		DevicePlatformType.Android
	},
	TargetedVariations = new List<Microsoft.Graph.Search.AnswerVariant>()
	{
		new Microsoft.Graph.Search.AnswerVariant
		{
			LanguageTag = "es-es",
			DisplayName = "Sitio de instalación Contoso",
			Description = "Pruebe o compre Contoso hogar o negocios y vea la información del producto"
		}
	},
	State = Microsoft.Graph.Search.AnswerState.Published
};

await graphClient.Search.Bookmarks
	.Request()
	.AddAsync(bookmark);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
Here is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.search.bookmark"
}-->
```http
HTTP/1.1 201 CREATED
Location: /733b26d5-af76-4eea-ac69-1a0ce8716897
Content-Type: application/json

{
  "id": "733b26d5-af76-4eea-ac69-1a0ce8716897"
}
```

