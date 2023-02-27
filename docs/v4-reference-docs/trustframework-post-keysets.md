---
title: "Create trustFrameworkKeySet"
description: "Create a new **trustFrameworkKeySet** object."
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Create trustFrameworkKeySet

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [trustFrameworkKeySet](../resources/trustframeworkkeyset.md). The ID of the **trustFrameworkKeySet** is expected in the create request; however, it can be modified by the service. The modified ID will be available in the response and in the location header.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | TrustFrameworkKeySet.ReadWrite.All	|
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | TrustFrameworkKeySet.ReadWrite.All	 |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /trustFramework/keySets
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
|Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of a [trustFrameworkKeySet](../resources/trustframeworkkeyset.md) object.

## Response

If successful, this method returns a `201 Created` response code, a location header for the newly created object, and a new [trustFrameworkKeySet](../resources/trustframeworkkeyset.md) object in the response body.

## Examples

### Example 1: Create an empty keyset
This is one of the most useful operations. First, you create an empty keyset. Then, in the new keyset, you can generate a key, upload a manual secret, and upload a certificate or a PKCS12 key. 

#### Request

The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_trustframeworkkeyset_from_trustframework1"
}-->

```http
POST https://graph.microsoft.com/beta/trustFramework/keySets
Content-type: application/json

{
  "id": "keyset1"  
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var trustFrameworkKeySet = new TrustFrameworkKeySet
{
	Id = "keyset1",
	Keys = new List<TrustFrameworkKey>()
	{
		new TrustFrameworkKey
		{
			K = "k-value",
			X5c = new List<String>()
			{
				"x5c-value"
			},
			X5t = "x5t-value",
			Kty = "kty-value",
			Use = "use-value",
			Exp = 99,
			Nbf = 99,
			Kid = "kid-value",
			E = "e-value",
			N = "n-value",
			D = "d-value",
			P = "p-value",
			Q = "q-value",
			Dp = "dp-value",
			Dq = "dq-value",
			Qi = "qi-value"
		}
	}
};

await graphClient.TrustFramework.KeySets
	.Request()
	.AddAsync(trustFrameworkKeySet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.trustFrameworkKeySet"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json
Location: /trustFramework/keySets('B2C_1A_keyset1')

{
  "id": "B2C_1A_keyset1",
  "keys": []
}
```

### Example 2: Create a keyset with a key

This is an advanced scenario where you need to know the [RFC 7517](https://tools.ietf.org/html/rfc7517#section-5) compliant JSON Web Key format of the key.

#### Request

The following example shows the request.
<!-- {
  "blockType": "request",
  "name": "create_trustframeworkkeyset_from_trustframework"
}-->

```http
POST https://graph.microsoft.com/beta/trustFramework/keySets
Content-type: application/json

{
  "id": "keyset1",
  "keys": [
    {
      "k": "k-value",
      "x5c": [
        "x5c-value"
      ],
      "x5t": "x5t-value",
      "kty": "kty-value",
      "use": "use-value",
      "exp": 99,
      "nbf": 99,
      "kid": "kid-value",
      "e": "e-value",
      "n": "n-value",
      "d": "d-value",
      "p": "p-value",
      "q": "q-value",
      "dp": "dp-value",
      "dq": "dq-value",
      "qi": "qi-value"
    }
  ]
}
```

#### Response

The following example shows the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.trustFrameworkKeySet"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json
Location: /trustFramework/keySets('B2C_1A_keyset1')

{
  "id": "B2C_1A_keyset1",
  "keys": [
    {
      "k": "k-value",
      "x5c": [
        "x5c-value"
      ],
      "x5t": "x5t-value",
      "kty": "kty-value",
      "use": "use-value",
      "exp": 99,
      "nbf": 99,
      "kid": "kid-value",
      "e": "e-value",
      "n": "n-value",
      "d": "d-value",
      "p": "p-value",
      "q": "q-value",
      "dp": "dp-value",
      "dq": "dq-value",
      "qi": "qi-value"
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create trustFrameworkKeySet",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


