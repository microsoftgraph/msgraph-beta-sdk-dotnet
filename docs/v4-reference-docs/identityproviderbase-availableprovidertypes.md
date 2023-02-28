---
title: "List availableProviderTypes"
description: "Retrieve all supported identity providers in the directory."
ms.localizationpriority: medium
doc_type: apiPageType
author: "namkedia"
ms.prod: "identity-and-sign-in"
---

# List availableProviderTypes

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get all identity providers supported in a directory.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityProvider.Read.All, IdentityProvider.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application|IdentityProvider.Read.All, IdentityProvider.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global Administrator
* External Identity Provider Administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /identity/identityProviders/availableProviderTypes
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a string collection in the response body. The string collection contains the names of the identity providers supported in the tenant.

## Example

### Example 1: List all **identityProvider** available in an Azure AD directory

#### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "identityprovider_availableprovidertypes_inAzure_ad_directory"
}
-->

``` http
GET https://graph.microsoft.com/beta/identity/identityProviders/availableProviderTypes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var availableProviderTypes = await graphClient.Identity.IdentityProviders
	.AvailableProviderTypes()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(Edm.String)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(Edm.String)",
    "value": [
        "MicrosoftAccount",
        "EmailOTP",
        "Facebook",
        "Google"
    ]
}
```

### Example 2: List all **identityProvider** available in an Azure AD B2C directory

#### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "identityprovider_availableprovidertypes_b2c"
}
-->

``` http
GET https://graph.microsoft.com/beta/identity/identityProviders/availableProviderTypes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var availableProviderTypes = await graphClient.Identity.IdentityProviders
	.AvailableProviderTypes()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(Edm.String)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
 "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(Edm.String)",
  "value": [
        "Microsoft",
        "Google",
        "Facebook",
        "Amazon",
        "LinkedIn",
        "Weibo",
        "QQ",
        "WeChat",
        "Twitter",
        "GitHub",
        "AppleManaged",
        "OpenIdConnect"
  ]
}
```
