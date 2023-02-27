---
title: "Update trustFrameworkKeySet"
description: "Update the properties of a **trustFrameworkKeySet** object."
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update trustFrameworkKeySet

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [trustFrameworkKeyset](../resources/trustframeworkkeyset.md). This operation will replace the content of an existing keyset. Specifying the ID in the request payload is optional.

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
PUT /trustFramework/keySets/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body


| Property     | Type        | Description |
|:-------------|:------------|:------------|
|keys|[trustFrameworkKey](../resources/trustframeworkkey.md) collection| updates a collection of Trustframeworkkeys|

## Response

If successful, this method returns a `200 OK` response code and an updated [trustFrameworkKeySet](../resources/trustframeworkkeyset.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_trustframeworkkeyset"
}-->

```http
PUT https://graph.microsoft.com/beta/trustFramework/keySets/{id}
Content-type: application/json

{
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

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var trustFrameworkKeySet = new TrustFrameworkKeySet
{
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

await graphClient.TrustFramework.KeySets["{trustFrameworkKeySet-id}"]
	.Request()
	.PutAsync(trustFrameworkKeySet);

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
  "@odata.type": "microsoft.graph.trustFrameworkKeySet"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "id-value",
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
  "description": "Update trustframeworkkeyset",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


