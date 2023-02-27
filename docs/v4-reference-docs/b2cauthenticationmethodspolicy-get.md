---
title: "Get b2cAuthenticationMethodsPolicy"
description: "Read the properties of a b2cAuthenticationMethodsPolicy object."
ms.localizationpriority: high
author: "namkedia"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Get b2cAuthenticationMethodsPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties of a [b2cAuthenticationMethodsPolicy](../resources/b2cauthenticationmethodspolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions|
|:---------------------------------------|:---------------|
| Delegated (work or school account)     | Policy.Read.All|
| Delegated (personal Microsoft account) | Policy.Read.All|
| Application                            | Policy.Read.All|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /policies/b2cAuthenticationMethodsPolicy
```

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and the requested [b2cAuthenticationMethodsPolicy](../resources/b2cauthenticationmethodspolicy.md) object in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_b2cauthenticationmethodspolicy"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/b2cAuthenticationMethodsPolicy
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cAuthenticationMethodsPolicy = await graphClient.Policies.B2cAuthenticationMethodsPolicy
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.b2cAuthenticationMethodsPolicy"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#b2cAuthenticationMethodsPolicy",
    "id": "b2CAuthenticationMethodsPolicy",
    "isEmailPasswordAuthenticationEnabled": true,
    "isUserNameAuthenticationEnabled": false,
    "isPhoneOneTimePasswordAuthenticationEnabled": true
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get b2cAuthenticationMethodsPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
