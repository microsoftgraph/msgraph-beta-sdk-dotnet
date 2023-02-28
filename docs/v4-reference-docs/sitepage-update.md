---
title: "Update sitePage"
description: "Update the properties of a sitePage object."
author: sangle7
ms.localizationpriority: medium
ms.prod: sharepoint
doc_type: apiPageType
---

# Update sitePage

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [sitePage](../resources/sitepage.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Sites.ReadWrite.All                         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Sites.ReadWrite.All                         |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

```http
PATCH /sites/{sitesId}/pages/{sitePageId}
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

These fields and be used in update requests.

| Property             | Type                                         | Description                                                                                                                                                                                                        |
| :------------------- | :------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| description                | String                                       | Description of the site page. Optional.                                                                                                                                                                                  |
| thumbnailWebUrl                | String                                       | Url of the site page's thumbnail image. Optional.                                                                                                                                                                                  |
| title                | String                                       | Title of the site page. Optional.                                                                                                                                                                                  |
| showComments         | Boolean                                      | Boolean to determine whether or not to show comments at the bottom of the page. Optional.                                                                                                                          |
| showRecommendedPages | Boolean                                      | Boolean to determine whether or not to show recommended pages at the bottom of the page. Optional.                                                                                                                 |
| promotionKind            | [PagePromotionType](../resources/sitepage.md#pagepromotiontype-values)      | Promotion kind of the SharePoint page. Optional. Only support promote a page (e.g from `page` to `newsPost`). Demote is not supported.                                                                                                                                                                      |
| titleArea            | [titleArea](../resources/titlearea.md)       | Title area on the site page. Optional.                                                                                                                                                                       |
| canvasLayout         | [canvasLayout](../resources/canvaslayout.md) | The layout of the content in a page, including horizontal sections and vertical section. A content of the entire page layout needs to be provided, the update function does not support partial updates. Optional. |

## Response

If successful, this method returns a `200 OK` response code and an updated [sitePage](../resources/sitepage.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_sitepage"
}
-->

```http
PATCH https://graph.microsoft.com/beta/sites/{sitesId}/pages/{sitePageId}
Content-Type: application/json
Content-length: 650

{
  "@odata.type": "#microsoft.graph.sitePage",
  "title": "sample",
  "showComments": true,
  "showRecommendedPages": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var sitePage = new SitePage
{
	Title = "sample",
	ShowComments = true,
	ShowRecommendedPages = false
};

await graphClient.Sites["{site-id}"].Pages["{sitePage-id}"]
	.Request()
	.UpdateAsync(sitePage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.sitePage",
  "truncated": true
}
-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.sitePage",
  "id": "0dd6ddd6-45bd-4acd-b683-de0e6e7231b7",
  "name": "sample.aspx",
  "webUrl": "SitePages/sample.aspx",
  "title": "sample",
  "pageLayout": "article",
  "showComments": true,
  "showRecommendedPages": false,
  "createdBy": {
    "user": {
      "displayName": "Rahul Mittal",
      "email": "rahmit@contoso.com"
    }
  },
  "lastModifiedBy": {
    "user": {
      "displayName": "Rahul Mittal",
      "email": "rahmit@contoso.com"
    }
  },
  "publishingState": {
    "level": "checkout",
    "versionId": "0.1",
    "checkedOutBy": {
      "user": {
        "displayName": "Rahul Mittal",
        "email": "rahmit@contoso.com"
      }
    }
  },
  "titleArea": {
    "enableGradientEffect": true,
    "imageWebUrl": "/_LAYOUTS/IMAGES/VISUALTEMPLATETITLEIMAGE.JPG",
    "layout": "colorBlock",
    "showAuthor": true,
    "showPublishedDate": false,
    "showTextBlockAboveTitle": false,
    "textAboveTitle": "TEXT ABOVE TITLE",
    "textAlignment": "left",
    "title": "sample",
    "imageSourceType": 2
  }
}
```
