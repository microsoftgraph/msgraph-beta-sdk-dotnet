---
title: "Update reviewSetQuery"
description: "Update the properties of a reviewSetQuery object."
ms.localizationpriority: medium
author: "mahage-msft"
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# Update reviewSetQuery

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an eDiscovery [reviewSetQuery](../resources/ediscovery-reviewsetquery.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /compliance/ediscovery/cases/{id}/reviewSets/{id}/queries/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| displayName | String | Display name for they review set query. |
| query | String | The query string in KQL (Keyword Query Language) query. For details, see [Document metadata fields](/microsoft-365/compliance/document-metadata-fields-in-advanced-ediscovery). |

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_reviewsetquery"
}-->

```http
PATCH https://graph.microsoft.com/beta/compliance/ediscovery/cases/2eef613a-ca2d-42f4-89fe-84d5198ddedf/reviewSets/b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8/queries/6b5358b0-2ce2-4369-b9cf-65392fe56807
Content-type: application/json

{
  "displayName": "My Query 1 - Renamed"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reviewSetQuery = new Microsoft.Graph.Ediscovery.ReviewSetQuery
{
	DisplayName = "My Query 1 - Renamed"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].ReviewSets["{ediscovery.reviewSet-id}"].Queries["{ediscovery.reviewSetQuery-id}"]
	.Request()
	.UpdateAsync(reviewSetQuery);

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
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update reviewsetquery",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
