---
title: "List a userflowidentityproviders"
description: "List all identity providers in a b2cIdentityUserFlow."
ms.localizationpriority: medium
doc_type: apiPageType
author: "namkedia"
ms.prod: "identity-and-sign-in"
---

# List a userflowidentityproviders

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the identity providers in a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application| IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External ID user flow administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /identity/b2cUserFlows/{userflow-id}/userflowIdentityProviders
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a JSON representation of the [identityProviders](../resources/identityproviderbase.md) in the response body.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_b2cUserFlow_list_userflowidentityProviders",
  "sampleKeys": ["B2C_test_signin_signup"]
}
-->

``` http
GET https://graph.microsoft.com/beta/identity/b2cUserFlows/B2C_test_signin_signup/userflowIdentityProviders
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userFlowIdentityProviders = await graphClient.Identity.B2cUserFlows["{b2cIdentityUserFlow-id}"].UserFlowIdentityProviders
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityProviderBase"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.identityProviderBase)",
    "value": [
        {
            "@odata.type": "#microsoft.graph.openIdConnectIdentityProvider",
            "id": "OIDC-V1-AD_Test-3e393390-ed2d-4794-97f6-5c1a1ccc61f7",
            "displayName": "OIDC AD Test",
            "clientId": "fe1b1576-adca-4bef-b321-076fde19950b",
            "clientSecret": "******",
            "scope": "openid",
            "metadataUrl": "https://login.microsoftonline.com/contoso.com/.well-known/openid-configuration",
            "domainHint": "",
            "responseType": "code",
            "responseMode": "form_post",
            "claimsMapping": {
                "userId": "oid",
                "displayName": "samuel",
                "givenName": "samuel",
                "surname": "emmense",
                "email": "sam.e@contoso.com"
            }
        },
        {
            "@odata.type": "#microsoft.graph.socialIdentityProvider",
            "id": "Apple-Managed-OIDC",
            "displayName": "Sign in with Apple",
            "identityProviderType": "AppleManaged",
            "clientId": "com.contoso.client",
            "clientSecret": "******"
        },
        {
            "@odata.type": "#microsoft.graph.socialIdentityProvider",
            "id": "MSA-OIDC",
            "displayName": "Microsoft Account",
            "identityProviderType": "Microsoft",
            "clientId": "1e02ac8a-0c37-4046-abe4-35098a840090",
            "clientSecret": "******"
        },
        {
            "@odata.type": "#microsoft.graph.socialIdentityProvider",
            "id": "Facebook-OAUTH",
            "displayName": "Facebook",
            "identityProviderType": "Facebook",
            "clientId": "576628889930009",
            "clientSecret": "******"
        }
    ]
}
```
