---
title: "Update b2cIdentityUserFlow"
description: "Update the properties of a b2cIdentityUserFlow object."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update b2cIdentityUserFlow

Namespace: microsoft.graph

Update the properties of a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
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
PATCH /identity/b2cUserFlows/{id}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object.

The following table shows the properties that are able to be updated after you create a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md).

|Property|Type|Description|
|:---|:---|:---|
|isLanguageCustomizationEnabled|Boolean|The property that determines whether language customization is enabled within the B2C user flow. Language customization is not enabled by default for B2C user flows.|
|defaultLanguageTag|String|Indicates the default language of the b2cIdentityUserFlow that is used when no `ui_locale` tag is specified in the request. This field is [RFC 5646](https://tools.ietf.org/html/rfc5646) compliant.|

## Response

If successful, this method returns a `200 OK` response code and an updated [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_b2cidentityuserflow",
  "sampleKeys": ["B2C_1_CustomerSignUp"]
}
-->

``` http
PATCH https://graph.microsoft.com/beta/identity/b2cUserFlows/B2C_1_CustomerSignUp
Content-Type: application/json

{
  "isLanguageCustomizationEnabled": true,
  "defaultLanguageTag": "en",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cIdentityUserFlow = new B2cIdentityUserFlow
{
	IsLanguageCustomizationEnabled = true,
	DefaultLanguageTag = "en"
};

await graphClient.Identity.B2cUserFlows["{b2cIdentityUserFlow-id}"]
	.Request()
	.UpdateAsync(b2cIdentityUserFlow);

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
}
-->

``` http
HTTP/1.1 204 No Content
```

<!-- {
  "type": "#page.annotation",
  "description": "Create b2CUserFlow",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->
