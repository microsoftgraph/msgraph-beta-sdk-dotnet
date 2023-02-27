---
title: "Update identityApiConnector"
description: "Update the properties of an identityApiConnector object."
author: "nickgmicrosoft"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update identityApiConnector

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [identityApiConnector](../resources/identityapiconnector.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | APIConnectors.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.  |
| Application                            | APIConnectors.ReadWrite.All |

The work or school account needs to belong to one of the following roles:

* Global administrator
* External Identity User Flow administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PATCH /identity/apiConnectors/{identityApiConnectorId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [identityApiConnector](../resources/identityapiconnector.md) object.

The following table shows the properties of the [identityApiConnector](../resources/identityapiconnector.md) that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|displayName|String| The name of the API connector. |
|targetUrl|String| The URL of the API endpoint to call. |
|authenticationConfiguration|[apiAuthenticationConfigurationBase](../resources/apiauthenticationconfigurationbase.md)|The object which describes the authentication configuration details for calling the API. Only [Basic authentication](../resources/basicauthentication.md) and [PKCS 12 client certificate](../resources/pkcs12certificate.md) are supported.|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Changing display name, targetUrl, and username & password used for basic authentication

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_identityapiconnector_forandID"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/identity/apiConnectors/{identityApiConnectorId}
Content-Type: application/json

{
  "displayName": "New Test API",
  "targetUrl": "https://otherapi.com/api/endpoint",
  "authenticationConfiguration": {
    "@odata.type": "microsoft.graph.basicAuthentication",
    "username":"<NEW_USERNAME>", 
    "password":"<NEW_PASSWORD>"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityApiConnector = new IdentityApiConnector
{
	DisplayName = "New Test API",
	TargetUrl = "https://otherapi.com/api/endpoint",
	AuthenticationConfiguration = new BasicAuthentication
	{
		Username = "<NEW_USERNAME>",
		Password = "<NEW_PASSWORD>"
	}
};

await graphClient.Identity.ApiConnectors["{identityApiConnector-id}"]
	.Request()
	.UpdateAsync(identityApiConnector);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
}
-->

``` http
HTTP/1.1 204 No Content
```

### Example 2: Changing API connector to use client certificate authentication

> **Note:** This will overwrite any previous authenticationConfiguration settings. To change from Basic authentication to certificate authentication, use this. To add additional certificates to list of certificates, use the [Upload client certificate](../api/identityapiconnector-uploadclientcertificate.md) method. When using this method, consequent "Get" or "List" operations of API connectors, `authenticationConfiguration` will be of type [microsoft.graph.clientCertificateAuthentication](../resources/clientcertificateauthentication.md).

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_identityapiconnector_forspecific_ID"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/identity/apiConnectors/{identityApiConnectorId}
Content-Type: application/json

{
  "authenticationConfiguration": {
    "@odata.type": "#microsoft.graph.pkcs12Certificate",
    "pkcs12Value": "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA",
    "password": "secret"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityApiConnector = new IdentityApiConnector
{
	AuthenticationConfiguration = new Pkcs12Certificate
	{
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA",
		Password = "secret"
	}
};

await graphClient.Identity.ApiConnectors["{identityApiConnector-id}"]
	.Request()
	.UpdateAsync(identityApiConnector);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
}
-->

``` http
HTTP/1.1 204 No Content
```
