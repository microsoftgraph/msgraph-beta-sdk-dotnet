---
title: "Get connectionOperation"
description: "Retrieve the properties of a connectionOperation."
ms.localizationpriority: medium
author: "snlraju-msft"
ms.prod: "search"
doc_type: "apiPageType"
---

# Get connectionOperation

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties of a [connectionOperation](../resources/externalconnectors-connectionoperation.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ExternalConnection.ReadWrite.OwnedBy, ExternalConnection.Read.All, ExternalConnection.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ExternalConnection.ReadWrite.OwnedBy, ExternalConnection.Read.All, ExternalConnection.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /external/connections/{connection-id}/operations/{operation-id}
```

## Request headers

| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and the requested [connectionOperation](../resources/externalconnectors-connectionoperation.md) object in the response body.

## Examples

### Request

The following is an example of the request.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_connectionoperation",
  "sampleKeys": ["contosohr", "3ed1595a-4bae-43c2-acda-ef973e581323"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/external/connections/contosohr/operations/3ed1595a-4bae-43c2-acda-ef973e581323
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var connectionOperation = await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Operations["{externalConnectors.connectionOperation-id}"]
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
  "expectError": true,
  "@odata.type": "microsoft.graph.externalConnectors.connectionOperation"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "3ed1595a-4bae-43c2-acda-ef973e581323",
  "status": "failed",
  "error": {
    "message": "Server error, something went wrong"
  }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get connectionOperation",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
