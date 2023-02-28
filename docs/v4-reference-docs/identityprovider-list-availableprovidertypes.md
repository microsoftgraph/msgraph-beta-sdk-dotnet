---
title: "List availableProviderTypes"
description: "Retrieve all available identity provider types in the directory."
ms.localizationpriority: medium
doc_type: apiPageType
author: "namkedia"
ms.prod: "identity-and-sign-in"
---

# List availableProviderTypes (deprecated)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
> [!CAUTION]
> This identity provider API is deprecated and will stop returning data after March, 2023. Please use the new [identity provider API](/graph/api/resources/identityproviderbase).

Retrieves all identity provider types available in a directory.

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
GET /identityProviders/availableProviderTypes
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a String collection in the response body.

## Example

### Request
The following is an example of the request.

<!-- {
  "blockType": "request",
  "name": "identityprovider_availableprovidertypes_in_directory"
}
-->

``` http
GET https://graph.microsoft.com/beta/identityProviders/availableProviderTypes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var availableProviderTypes = await graphClient.IdentityProviders
	.AvailableProviderTypes()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

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
  "value": [
      "Amazon",
      "OpenIDConnect",
      "Facebook",
      "GitHub",
      "Google",
      "LinkedIn",
      "Microsoft",
      "QQ",
      "Twitter",
      "WeChat",
      "Weibo"
  ]
}
```
