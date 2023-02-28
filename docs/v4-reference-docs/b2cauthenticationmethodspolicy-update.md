---
title: "Update b2cAuthenticationMethodsPolicy"
description: "Update properties of a b2cAuthenticationMethodsPolicy object."
ms.localizationpriority: high
author: "namkedia"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update b2cAuthenticationMethodsPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [b2cAuthenticationMethodsPolicy](../resources/b2cauthenticationmethodspolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions|
|:---------------------------------------|:---------------|
| Delegated (work or school account)     | Policy.ReadWrite.AuthenticationMethod|
| Delegated (personal Microsoft account) | Policy.ReadWrite.AuthenticationMethod|
| Application                            | Policy.ReadWrite.AuthenticationMethod|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /policies/b2cAuthenticationMethodsPolicy
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [b2cAuthenticationMethodsPolicy](../resources/b2cauthenticationmethodspolicy.md) object.

The following table shows the properties that are required when you update the [b2cAuthenticationMethodsPolicy](../resources/b2cauthenticationmethodspolicy.md).

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|isEmailPasswordAuthenticationEnabled|Boolean|The tenant admin can configure local accounts using email if the email and password authentication method is enabled.|
|isUserNameAuthenticationEnabled|Boolean|The tenant admin can configure local accounts using username if the username and password authentication method is enabled.|
|isPhoneOneTimePasswordAuthenticationEnabled|Boolean|The tenant admin can configure local accounts using phone number if the phone number and one-time password authentication method is enabled.|

## Response

If successful, this method returns a `204 No Content` response code and an empty response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "patch_b2cauthenticationmethodspolicy"
}-->

```msgraph-interactive
PATCH https://graph.microsoft.com/beta/policies/b2cAuthenticationMethodsPolicy

{
    "isEmailPasswordAuthenticationEnabled": false,
    "isUserNameAuthenticationEnabled": true,
    "isPhoneOneTimePasswordAuthenticationEnabled": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cAuthenticationMethodsPolicy = new B2cAuthenticationMethodsPolicy
{
	IsEmailPasswordAuthenticationEnabled = false,
	IsUserNameAuthenticationEnabled = true,
	IsPhoneOneTimePasswordAuthenticationEnabled = true
};

await graphClient.Policies.B2cAuthenticationMethodsPolicy
	.Request()
	.UpdateAsync(b2cAuthenticationMethodsPolicy);

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
HTTP/1.1 204 NO CONTENT
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update b2cauthenticationmethodspolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
