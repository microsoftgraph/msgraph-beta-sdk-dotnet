---
title: "trustFrameworkKeySet: generateKey"
description: "Generate a key and a secret automatically in the keyset."
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# trustFrameworkKeySet: generateKey

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Generate a [trustFrameworkKey](../resources/trustFrameworkKey.md) and a secret automatically in the [trustFrameworkKeyset](../resources/trustframeworkkeyset.md). The caller doesn't have to provide a secret.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | TrustFrameworkKeySet.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | TrustFrameworkKeySet.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /trustFramework/keySets/{id}/generateKey
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
| use | string | Similar to the **use** property of **trustFrameworkKey**. |
| kty | string | Similar to **kty** property of **trustFrameworkKey**. |
| nbf | int | Similar to **nbf** property of **trustFrameworkKey**. |
| exp | int | Similar to **exp** property of **trustFrameworkKey**. |

## Response

If successful, this method returns a `200 OK` response code and a new [trustFrameworkKey](../resources/trustframeworkkey.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "trustframeworkkeyset_generatekey"
}-->

```http
POST https://graph.microsoft.com/beta/trustFramework/keySets/{id}/generateKey
Content-type: application/json

{
  "use": "sig",
  "kty": "RSA",
  "nbf": 1508969811,
  "exp": 1508969811
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var use = "sig";

var kty = "RSA";

var nbf = 1508969811;

var exp = 1508969811;

await graphClient.TrustFramework.KeySets["{trustFrameworkKeySet-id}"]
	.GenerateKey(use,kty,nbf,exp)
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
  "@odata.type": "microsoft.graph.trustFrameworkKey"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.trustFrameworkKey",
    "k": null,
    "x5c": [],
    "kty": "RSA",
    "use": "sig",
    "exp": 1908969811,
    "nbf": 1908969811,
    "kid": "Gaid7K8sO8RavMX9fzHir_Wg0femGhbY9b-B4rVIxbE",
    "e": "AQAB",
    "n": "rd54s6",
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "trustFrameworkKeySet: generateKey",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


