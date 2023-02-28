---
title: "Get externalItem"
description: "Get an externalItem."
ms.localizationpriority: medium
author: "snlraju-msft"
ms.prod: "search"
doc_type: "apiPageType"
---

# Get externalItem

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the properties and relationships of an [externalitem](../resources/externalconnectors-externalitem.md) object.

This API is provided for diagnostic purposes only. It is not intended to be used for any other purpose. Repeated requests to this API might result in `429` HTTP errors.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ExternalItem.ReadWrite.OwnedBy, ExternalItem.Read.All, ExternalItem.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ExternalItem.ReadWrite.OwnedBy, ExternalItem.Read.All, ExternalItem.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /external/connections/{connection-id}/items/{item-id}
```

## Path parameters

| Parameter     | Type   | Description                                         |
|:--------------|:-------|:----------------------------------------------------|
| connection-id | string | The `id` property of the containing [externalConnection](../resources/externalconnectors-externalconnection.md) |
| item-id       | string | The developer-provided `id` property of the [externalItem](../resources/externalconnectors-externalitem.md). |

## Optional query parameters

This method does not support optional query parameters to customize the response.

## Request headers

| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [externalItem](../resources/externalconnectors-externalitem.md) object in the response body.

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_externalitem",
  "sampleKeys": ["contosohr", "TSP228082938"]
}
-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/external/connections/contosohr/items/TSP228082938
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalItem = await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Items["{externalConnectors.externalItem-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- markdownlint-enable MD024 -->

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.externalConnectors.externalItem"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "acl": [
    {
      "type": "user",
      "value": "e811976d-83df-4cbd-8b9b-5215b18aa874",
      "accessType": "grant",
    },
    {
      "type": "externalGroup",
      "value": "14m1b9c38qe647f6a",
      "accessType": "deny",
    }
  ],
  "properties": {
    "title": "Error in the payment gateway",
    "priority": 1,
    "assignee": "john@contoso.com"
  },
  "content": {
    "value": "Error in payment gateway...",
    "type": "text"
  }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get externalItem",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
