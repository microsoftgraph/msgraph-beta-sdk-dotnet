---
title: "Create identityProvider"
description: "Create a new identityProvider object."
ms.localizationpriority: medium
doc_type: apiPageType
author: "namkedia"
ms.prod: "identity-and-sign-in"
---

# Create identityProvider (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
> [!CAUTION]
> This identity provider API is deprecated and will stop returning data after March, 2023. Please use the new [identity provider API](/graph/api/resources/identityproviderbase).

Create a new [identityProvider](../resources/identityprovider.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityProvider.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application|IdentityProvider.ReadWrite.All|

The work or school account needs to belong to one of the following roles:
* Global Administrator
* External Identity Provider Administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identityProviders
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON representation of [identityProvider](../resources/identityprovider.md) or [openIdConnectProvider](../resources/openidconnectprovider.md) (only for Azure AD B2C) object. All the properties listed in the following table are required.

### identityProvider object

|Property|Type|Description|
|:---------------|:--------|:----------|
|clientId|String|The client ID for the application. This is the client ID obtained when registering the application with the identity provider.|
|clientSecret|String|The client secret for the application. This is the client secret obtained when registering the application with the identity provider.|
|name|String|The display name of the identity provider.|
|type|String|The identity provider type. <ul>For B2B scenario:<li/>Google<li/>Facebook</ul><ul>For B2C scenario:<li/>Microsoft<li/>Google<li/>Amazon<li/>LinkedIn<li/>Facebook<li/>GitHub<li/>Twitter<li/>Weibo<li/>QQ<li/>WeChat<li/>OpenIDConnect</ul>|

### openIdConnectProvider object

|Property|Type|Description|
|:---------------|:--------|:----------|
|clientId|String|The client ID for the application. This is the client ID obtained when registering the application with the identity provider.|
|clientSecret|String|The client secret for the application. This is the client secret obtained when registering the application with the identity provider.|
|name|String|The display name of the identity provider.|
|type|String|The identity provider type. The value must be `OpenIdConnect`.|
|claimsMapping|[claimsMapping](../resources/claimsmapping.md)|The `userId` and `displayname` properties are required in the claimsMapping object.|
|metadataUrl|String|The URL for the metadata document of the Open Id Connect identity provider.|
|responseMode|String|Defines the method that should be used to send the data back from the custom identity provider to Azure AD B2C. The following response modes can be used: <ul><li/>`form_post` : This response mode is recommended for best security. The response is transmitted via the HTTP POST method, with the code or token being encoded in the body using the application/x-www-form-urlencoded format.<li/>`query` : The code or token is returned as a query parameter.</ul>|
|responseType|String|Describes what kind of information is sent back in the initial call to the authorization_endpoint of the custom identity provider. The following response types can be used:<ul><li/> `code` : As per the authorization code flow, a code will be returned back to Azure AD B2C. Azure AD B2C proceeds to call the token_endpoint to exchange the code for the token.<li/> `id_token` : An ID token is returned back to Azure AD B2C from the custom identity provider. <li/>`token` : An access token is returned back to Azure AD B2C from the custom identity provider. (This value is not supported by Azure AD B2C at the moment)</ul>|
|scope|String|Scope defines the information and permissions you are looking to gather from your custom identity provider.|

## Response

If successful, this method returns a `201 Created` response code and [identityProvider](../resources/identityprovider.md) or [openIdConnectProvider](../resources/openidconnectprovider.md) (only for Azure AD B2C) object in the response body. If unsuccessful, a `4xx` error will be returned with specific details.

## Examples

### Example 1: Create a specific **identityProvider**

#### Request

The following is an example of the request.

<!-- {
  "blockType": "request",
  "name": "create_identityprovider_from_identityproviders"
}
-->

``` http
POST https://graph.microsoft.com/beta/identityProviders
Content-type: application/json

{
  "@odata.type": "microsoft.graph.identityProvider",
  "name": "Login with Amazon",
  "type": "Amazon",
  "clientId": "56433757-cadd-4135-8431-2c9e3fd68ae8",
  "clientSecret": "000000000000"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityProvider = new IdentityProvider
{
	Name = "Login with Amazon",
	Type = "Amazon",
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8",
	ClientSecret = "000000000000"
};

await graphClient.IdentityProviders
	.Request()
	.AddAsync(identityProvider);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityProvider"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
   "@odata.type": "microsoft.graph.identityProvider",
    "id": "Amazon-OAUTH",
    "name": "Login with Amazon",
    "type": "Amazon",
    "clientId": "56433757-cadd-4135-8431-2c9e3fd68ae8",
    "clientSecret": "*****"
}
```

### Example 2: Create a specific **openIDConnectProvider** (only for Azure AD B2C)

#### Request

The following is an example of the request.

<!-- {
  "blockType": "request",
  "name": "create_openidconnectprovider_from_identityproviders"
}
-->

``` http
POST https://graph.microsoft.com/beta/identityProviders
Content-type: application/json

{
  "@odata.type": "microsoft.graph.openIdConnectProvider",
    "name": "Login with the Contoso identity provider",
    "type": "OpenIDConnect",
    "clientId": "56433757-cadd-4135-8431-2c9e3fd68ae8",
    "clientSecret": "12345",
    "claimsMapping": {
        "userId": "myUserId",
        "givenName": "myGivenName",
        "surname": "mySurname",
        "email": "myEmail",
        "displayName": "myDisplayName"
    },
    "domainHint": "mycustomoidc",
    "metadataUrl": "https://mycustomoidc.com/.well-known/openid-configuration",
    "responseMode": "form_post",
    "responseType": "code",
    "scope": "openid"
}

```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityProvider = new OpenIdConnectProvider
{
	Name = "Login with the Contoso identity provider",
	Type = "OpenIDConnect",
	ClientId = "56433757-cadd-4135-8431-2c9e3fd68ae8",
	ClientSecret = "12345",
	ClaimsMapping = new ClaimsMapping
	{
		UserId = "myUserId",
		GivenName = "myGivenName",
		Surname = "mySurname",
		Email = "myEmail",
		DisplayName = "myDisplayName"
	},
	DomainHint = "mycustomoidc",
	MetadataUrl = "https://mycustomoidc.com/.well-known/openid-configuration",
	ResponseMode = OpenIdConnectResponseMode.Form_post,
	ResponseType = OpenIdConnectResponseTypes.Code,
	Scope = "openid"
};

await graphClient.IdentityProviders
	.Request()
	.AddAsync(identityProvider);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.openIdConnectProvider"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "@odata.type": "microsoft.graph.openIdConnectProvider",
  "id": "OIDC-V1-MyTest-085a8a0c-58cb-4b6d-8e07-1328ea404e1a",
  "name": "Login with the Contoso identity provider",
  "type": "OpenIDConnect",
  "clientId": "56433757-cadd-4135-8431-2c9e3fd68ae8",
  "clientSecret": "12345",
  "claimsMapping": {
      "userId": "myUserId",
      "givenName": "myGivenName",
      "surname": "mySurname",
      "email": "myEmail",
      "displayName": "myDisplayName"
  },
  "domainHint": "mycustomoidc",
  "metadataUrl": "https://mycustomoidc.com/.well-known/openid-configuration",
  "responseMode": "form_post",
  "responseType": "code",
  "scope": "openid"
}
```
