---
title: "Update emailAuthenticationMethod"
description: "Update the properties of an emailAuthenticationMethod object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update emailAuthenticationMethod
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update a user's email address associated with an [email Authentication Method](../resources/emailauthenticationmethod.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Permissions acting on self

|Permission type      | Permissions (from least to most privileged)              |
|:---------------------------------------|:-------------------------|
| Delegated (work or school account)     | UserAuthenticationMethod.ReadWrite |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

### Permissions acting on other users

|Permission type      | Permissions (from least to most privileged)              |
|:---------------------------------------|:-------------------------|
| Delegated (work or school account)     | UserAuthenticationMethod.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | UserAuthenticationMethod.ReadWrite.All |

For delegated scenarios where an admin is acting on another user, the admin needs one of the following [roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

* Global administrator
* Privileged authentication administrator
* Authentication administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /users/{id | userPrincipalName}/authentication/emailMethods/{id}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [emailAuthenticationMethod](../resources/emailauthenticationmethod.md) object with the updated email address.

The following table shows the properties that are required when you update the [emailAuthenticationMethod](../resources/emailauthenticationmethod.md).

|Property|Type|Description|
|:---|:---|:---|
|emailAddress|String|Updated email address|



## Response

If successful, this method returns a `200 OK` response code and an updated [emailAuthenticationMethod](../resources/emailauthenticationmethod.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_emailauthenticationmethod",
  "sampleKeys": ["kim@contoso.com", "3ddfcfc8-9383-446f-83cc-3ab9be4be18f"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/users/kim@contoso.com/authentication/emailMethods/3ddfcfc8-9383-446f-83cc-3ab9be4be18f
Content-Type: application/json

{
  "emailAddress": "kim@contoso.com"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var emailAuthenticationMethod = new EmailAuthenticationMethod
{
	EmailAddress = "kim@contoso.com"
};

await graphClient.Users["{user-id}"].Authentication.EmailMethods["{emailAuthenticationMethod-id}"]
	.Request()
	.UpdateAsync(emailAuthenticationMethod);

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
  "@odata.type": "microsoft.graph.emailAuthenticationMethod"
} -->

``` http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "3ddfcfc8-9383-446f-83cc-3ab9be4be18f",
  "emailAddress": "kim@contoso.com"
}
```
