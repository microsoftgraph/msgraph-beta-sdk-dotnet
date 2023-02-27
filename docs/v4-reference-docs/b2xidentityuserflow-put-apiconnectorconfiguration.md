---
title: "Configure an API connector in a user flow"
description: "Enable or disable an API connector to a specific step in a user flow by updating the apiConnectorConfiguration property."
author: "nickgmicrosoft"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Configure userFlowApiConnectorConfiguration

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the [apiConnectorConfiguration](../resources/userflowapiconnectorconfiguration.md) property in a [b2xIdentityUserFlow](../resources/b2xidentityuserflow.md) to enable or disable an API connector in a user flow. Each relationship of the [apiConnectorConfiguration](../resources/userflowapiconnectorconfiguration.md) corresponds to a specific step in the user flow that can be configured to call an API connector. You configure an API connector for a particular step one at a time as shown below.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External Identity User Flow administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PUT /identity/b2xUserFlows/{b2xUserFlowId}/apiConnectorConfiguration/{step}/$ref
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON representation of the `id` of the [identityApiConnector](../resources/identityapiconnector.md) you want to use the particular step. To disable an API connector, the value can be {}.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Enable API connector for Post IDP Federation on sign up

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "put_b2xuserflows-apiconnectorconfiguration_postFederationSignup",
  "sampleKeys": ["B2X_1_testuserflow", "postFederationSignup"]
}
-->

``` http
PUT https://graph.microsoft.com/beta/identity/b2xUserFlows/B2X_1_testuserflow/apiConnectorConfiguration/postFederationSignup/$ref
Content-Type: application/json

{
    "@odata.id": "https://graph.microsoft.com/beta/identity/apiConnectors/{id}"   
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Identity.B2xUserFlows["{b2xIdentityUserFlow-id}"].PostFederationSignup.Reference
	.Request()
	.PutAsync("{id}");

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

### Example 2: Enable API connector for Post Attribute Collection on sign up

#### Request 

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "put_b2xuserflows-apiconnectorconfiguration_postAttributeCollection",
  "sampleKeys": ["B2X_1_testuserflow", "postAttributeCollection"]
}
-->

``` http
PUT https://graph.microsoft.com/beta/identity/b2xUserFlows/B2X_1_testuserflow/apiConnectorConfiguration/postAttributeCollection/$ref
Content-Type: application/json

{
    "@odata.id": "https://graph.microsoft.com/beta/identity/apiConnectors/{id}"   
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Identity.B2xUserFlows["{b2xIdentityUserFlow-id}"].PostAttributeCollection.Reference
	.Request()
	.PutAsync("{id}");

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

### Example 3: Disable an API connector for Post Attribute Collection on sign up

#### Request 

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "put_b2xuserflows-apiconnectorconfiguration_disable-postAttributeCollection",
  "sampleKeys": ["B2X_1_testuserflow", "postAttributeCollection"]
}
-->

``` http
PUT https://graph.microsoft.com/beta/identity/b2xUserFlows/B2X_1_testuserflow/apiConnectorConfiguration/postAttributeCollection/$ref
Content-Type: application/json

{ }
```

# [C#](#tab/csharp)
```
Snippet not available
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
