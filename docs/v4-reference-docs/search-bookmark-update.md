---
title: "Update bookmark"
description: "Update the properties of a bookmark object."
author: "jakeost-msft"
ms.localizationpriority: medium
ms.prod: "search"
doc_type: apiPageType
---

# Update bookmark
Namespace: microsoft.graph.search

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [bookmark](../resources/search-bookmark.md) object.

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
PATCH /search/bookmarks/{bookmarksId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

>**Note:** Updates to collection properties will update the entire collection. Any updates to a collection, such as keywords or categories, will replace the collection entirely.

|Property|Type|Description|
|:---|:---|:---|
|availabilityEndDateTime|DateTimeOffset|Timestamp of when the bookmark will stop to appear as a search result. Set as `null` for always available.|
|availabilityStartDateTime|DateTimeOffset|Timestamp of when the bookmark will start to appear as a search result. Set as `null` for always available.|
|categories|String collection|Categories commonly used to describe this bookmark. For example, IT and HR.|
|description|String|Bookmark description shown on search results page. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|
|displayName|String|Bookmark name displayed in search results. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|
|groupIds|String collection|List of security groups able to view this bookmark.|
|keywords|[microsoft.graph.search.answerKeyword](../resources/search-answerKeyword.md)|Keywords that trigger this bookmark to appear in search results.|
|languageTags|String collection|List of countries or regions able to view this bookmark.|
|platforms|microsoft.graph.devicePlatformType collection|List of devices and operating systems able to view this bookmark. Possible values are: `unknown`, `android`, `androidForWork`, `ios`, `macOS`, `windowsPhone81`, `windowsPhone81AndLater`, `windows10AndLater`, `androidWorkProfile`, `androidASOP`.|
|powerAppIds|String collection|List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks, such as to enter vacation time or to report expenses on the search results page.|
|state|microsoft.graph.search.answerState|State of the bookmark. Possible values are: `published`, `draft`, `excluded`, or `unknownFutureValue`.|
|targetedVariations|[microsoft.graph.search.answerVariant](../resources/search-answerVariant.md) collection|Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.|
|webUrl|String|Bookmark URL link. When users click this bookmark in search results, they will go to this URL. Inherited from [searchAnswer](../resources/search-searchAnswer.md).|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_bookmark"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/search/bookmarks/{bookmarksId}
Content-Type: application/json

{
  "description": "Book a fancy vacation in Tuscany or browse museums in Florence."
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var bookmark = new Microsoft.Graph.Search.Bookmark
{
	Description = "Book a fancy vacation in Tuscany or browse museums in Florence."
};

await graphClient.Search.Bookmarks["{search.bookmark-id}"]
	.Request()
	.UpdateAsync(bookmark);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

