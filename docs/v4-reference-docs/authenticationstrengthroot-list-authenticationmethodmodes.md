---
title: "List authenticationMethodModes"
description: "Get a list of all supported authentication methods, or all supported authentication method combinations."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List authenticationMethodModes

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of all supported authentication methods, or all supported authentication method combinations as a list of **authenticationMethodModes** objects and their properties.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|

## HTTP request

Retrieve the collection of **authenticationMethodModes** objects and their descriptions.

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identity/conditionalAccess/authenticationStrengths/authenticationMethodModes
```

Retrieve the flat collection of authenticationCombinations objects, representing all the allowed combinations (allowedCombinations) in an authenticationStrengthPolicy object.
<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identity/conditionalAccess/authenticationStrengths/authenticationCombinations
```

## Optional query parameters
This method does not support OData query parameters.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [authenticationMethodModeDetail](../resources/authenticationmethodmodedetail.md) objects in the response body.

## Examples

### Example 1: Retrieve authenticationMethodModes objects and their descriptions

#### Request
The following is an example of a request to retrieve the collection of **authenticationMethodModes** objects and their descriptions.
.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_authenticationmethodmodedetail"
}
-->
``` http
GET https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationStrengths/authenticationMethodModes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationMethodModes = await graphClient.Identity.ConditionalAccess.AuthenticationStrengths.AuthenticationMethodModes
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.authenticationMethodModeDetail)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#authenticationMethodModeDetail",
  "value": [
    {
        "id" : "password",
        "displayName" : "Password",
        "authenticationMethod" : "password"
    },
    {
        "id" : "voice",
        "displayName" : "Voice",
        "authenticationMethod" : "voice"
    },
    {
        "id" : "softwareOath",
        "displayName" : "Software OATH tokens",
        "authenticationMethod" : "softwareOath"
    },
    {
        "id" : "sms",
        "displayName" : "SMS",
        "authenticationMethod" : "sms"
    },
    {
        "id" : "fido2",
        "displayName" : "FIDO2 Security Key",
        "authenticationMethod" : "fido2"
    },
    {
        "id" : "windowsHelloForBusiness",
        "displayName" : "Windows Hello for Business",
        "authenticationMethod" : "windowsHelloForBusiness"
    },
    {
        "id" : "microsoftAuthenticatorPush",
        "displayName" : "Microsoft Authenticator (push notification)",
        "authenticationMethod" : "microsoftAuthenticator"
    },
    {
        "id" : "deviceBasedPush",
        "displayName" : "Microsoft Authenticator (Passwordless)",
        "authenticationMethod" : "microsoftAuthenticator"
    },
    {
        "id" : "temporaryAccessPassOneTime",
        "displayName" : "Temporary Access Pass (one-time use)",
        "authenticationMethod" : "temporaryAccessPass"
    },
    {
        "id" : "temporaryAccessPassMultiUse",
        "displayName" : "Temporary Access Pass (multi-use)",
        "authenticationMethod" : "temporaryAccessPass"
    },
    {
        "id" : "email",
        "displayName" : "Email one-time passcode",
        "authenticationMethod" : "email"
    },
    {
        "id" : "x509CertificateSingleFactor",
        "displayName" : "Certificate-based authentication (single-factor)",
        "authenticationMethod" : "x509Certificate"
    },
    {
        "id" : "federatedMultiFactor",
        "displayName" : "Federation (multi-factor)",
        "authenticationMethod" : "federation"
    },
    {
        "id" : "federatedSingleFactor",
        "displayName" : "Federation (single-factor)",
        "authenticationMethod" : "federation"
    },
    {
        "id": "x509CertificateMultiFactor",
        "displayName" : "Certificate-based authentication (multi-factor)",
        "authenticationMethod" : "x509Certificate"
    }
  ]
}
```

### Example 2: Retrieve the allowed authentication combinations

#### Request
The following is an example of a request to retrieve the flat collection of authenticationCombinations objects, representing all the possible allowed combinations (allowedCombinations) that may be used in an authenticationStrengthPolicy object.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_authenticationcombinations"
}
-->
``` http
GET https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationStrengths/authenticationCombinations
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationStrengths = await graphClient.Identity.ConditionalAccess.AuthenticationStrengths
	.Request()
	.Select("AuthenticationCombinations")
	.GetAsync();

var authenticationCombinations = authenticationStrengths.AuthenticationCombinations;

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "isCollection": true,
  "@odata.type": "Collection(microsoft.graph.authenticationMethodModes)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/conditionalAccess/authenticationStrengths/authenticationCombinations",
    "value": [
        "windowsHelloForBusiness",
        "fido2",
        "x509CertificateMultiFactor",
        "deviceBasedPush",
        "temporaryAccessPassOneTime",
        "temporaryAccessPassMultiUse",
        "password,microsoftAuthenticatorPush",
        "password,softwareOath",
        "password,hardwareOath",
        "password,sms",
        "password,voice",
        "federatedMultiFactor",
        "microsoftAuthenticatorPush,federatedSingleFactor",
        "softwareOath,federatedSingleFactor",
        "hardwareOath,federatedSingleFactor",
        "sms,federatedSingleFactor",
        "voice,federatedSingleFactor",
        "x509CertificateSingleFactor",
        "sms",
        "password",
        "federatedSingleFactor",
        "email"
    ]
}
```

<!-- {
  "type": "#page.annotation",
  "section": "documentation",
  "suppressions": [
    "Error: list_authenticationcombinations:
      Unable to locate a definition for resource type: microsoft.graph.authenticationMethodModes"
  ]
} -->
