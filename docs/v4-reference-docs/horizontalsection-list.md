---
title: "List horizontalSections"
description: "Get a list of the horizontalSection objects and their properties."
author: sangle7
ms.localizationpriority: medium
ms.prod: sharepoint
doc_type: apiPageType
---

# List horizontalSections

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [horizontalSection](../resources/horizontalsection.md) objects and their properties. Sort by `id` in ascending order.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Sites.Read.All, Sites.ReadWrite.All         |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Sites.Read.All, Sites.ReadWrite.All         |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

```http
GET /sites/{sitesId}/pages/{sitePageId}/canvasLayout/horizontalSections
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [horizontalSection](../resources/horizontalsection.md) objects in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_horizontalsection"
}
-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/sites/{sitesId}/pages/{sitePageId}/canvasLayout/horizontalSections
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var horizontalSections = await graphClient.Sites["{site-id}"].Pages["{sitePage-id}"].CanvasLayout.HorizontalSections
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.horizontalSection)"
}
-->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.horizontalSection",
      "layout": "twoColumns",
      "id": "1",
      "emphasis": "soft"
    },
    {
      "@odata.type": "#microsoft.graph.horizontalSection",
      "layout": "oneThirdRightColumn",
      "id": "2",
      "emphasis": "none"
    }
  ]
}
```
