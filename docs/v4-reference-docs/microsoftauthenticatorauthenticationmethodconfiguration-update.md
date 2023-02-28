---
title: "Update microsoftAuthenticatorAuthenticationMethodConfiguration"
description: "Update the properties of a microsoftAuthenticatorAuthenticationMethodConfiguration object."
author: "jpettere"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update microsoftAuthenticatorAuthenticationMethodConfiguration
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [microsoftAuthenticatorAuthenticationMethodConfiguration](../resources/microsoftauthenticatorauthenticationmethodconfiguration.md) object, which represents the Microsoft Authenticator authentication method policy for the Azure AD tenant.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.AuthenticationMethod|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.ReadWrite.AuthenticationMethod|

For delegated scenarios, the administrator needs one of the following [Azure AD roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

* Authentication Policy Administrator
* Global Administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /policies/authenticationMethodsPolicy/authenticationMethodConfigurations/microsoftAuthenticator
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [microsoftAuthenticatorAuthenticationMethodConfiguration](../resources/microsoftauthenticatorauthenticationmethodconfiguration.md) object with the values of fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

For the list of properties, see [microsoftAuthenticatorAuthenticationMethodConfiguration](../resources/microsoftauthenticatorauthenticationmethodconfiguration.md).

>**Note:** The `@odata.type` property with a value of `#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration` must be included in the body.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_microsoftauthenticatorauthenticationmethodconfiguration"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/authenticationMethodsPolicy/authenticationMethodConfigurations/microsoftAuthenticator
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration",
    "state": "enabled"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationMethodConfiguration = new MicrosoftAuthenticatorAuthenticationMethodConfiguration
{
	State = AuthenticationMethodState.Enabled
};

await graphClient.Policies.AuthenticationMethodsPolicy.AuthenticationMethodConfigurations["{authenticationMethodConfiguration-id}"]
	.Request()
	.UpdateAsync(authenticationMethodConfiguration);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

