---
title: "Create reviewSet"
description: "Create an eDiscovery review set."
ms.localizationpriority: medium
author: "mahage-msft"
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# Create reviewSet

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [reviewSet](../resources/ediscovery-reviewset.md) object. The request body contains the display name of the review set, which is the only writable property.

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
POST /compliance/ediscovery/cases/{id}/reviewSets
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of the [reviewSet](../resources/ediscovery-reviewset.md).  The following table lists the required properties.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| displayName  | string      | The name of the review set. |

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.ediscovery.reviewSet](../resources/ediscovery-reviewset.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_reviewset"
}-->

```http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/6f65a8e4-c6a0-4cff-8a81-c9ab5df7290d/reviewSets
Content-type: application/json

{
  "displayName": "My Reviewset 3",
}
```
# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reviewSet = new Microsoft.Graph.Ediscovery.ReviewSet
{
	DisplayName = "My Reviewset 3"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].ReviewSets
	.Request()
	.AddAsync(reviewSet);

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
  "@odata.type": "microsoft.graph.ediscovery.reviewSet"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/compliance/ediscovery/$metadata#cases('6f65a8e4-c6a0-4cff-8a81-c9ab5df7290d')/reviewSets/$entity",
    "id": "0157910c-57ce-4e48-bd4b-90f3c88ca32e",
    "displayName": "My Reviewset 3",
    "createdBy": {
        "user": {
            "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
            "displayName": "eDiscovery admin"
        }
    },
    "createdDateTime": "2020-03-11T08:40:14.9486058Z"
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update reviewset",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


