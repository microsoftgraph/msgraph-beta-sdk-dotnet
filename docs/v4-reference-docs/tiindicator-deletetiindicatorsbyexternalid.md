---
title: "tiIndicator: deleteTiIndicatorsByExternalId"
description: "Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests, and the request contains external IDs instead of IDs."
ms.localizationpriority: medium
author: "preetikr"
ms.prod: "security"
doc_type: apiPageType
---

# tiIndicator: deleteTiIndicatorsByExternalId

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests, when the request contains external IDs instead of IDs.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type  | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ThreatIndicators.ReadWrite.OwnedBy |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ThreatIndicators.ReadWrite.OwnedBy |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /security/tiIndicators/deleteTiIndicatorsByExternalId
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {code} |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
|value|String collection| Collection of `externalIds` of the **tiIndicator** objects to be deleted. |

## Response

If successful, this method returns `200, OK` response code and a [resultInfo](../resources/resultinfo.md) collection object in the response body. If there is an error, this method returns a `206 Partial Content` response code.  See [Errors](../resources/security-error-codes.md#threat-indicator-bulk-action-errors) for more information.

## Examples

The following example shows how to call this API.

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "tiindicator_deletetiindicatorsbyexternalid",
  "isCollection":"true"
}-->

```http
POST https://graph.microsoft.com/beta/security/tiIndicators/deleteTiIndicatorsByExternalId
Content-type: application/json

{
  "value": [
    "externalId-value1",
    "externalId-value2"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var value = new List<String>()
{
	"externalId-value1",
	"externalId-value2"
};

await graphClient.Security.TiIndicators
	.DeleteTiIndicatorsByExternalId(value)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> [!NOTE]
> The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.resultInfo",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "code": 0,
      "message": "message-value",
      "subCode": "subCode-value"
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "tiIndicator: deleteTiIndicatorsByExternalId",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->


