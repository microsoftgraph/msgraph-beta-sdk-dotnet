---
title: "passwordAuthenticationMethod: resetPassword"
description: "Reset a user's password"
ms.localizationpriority: medium
author: "mmcla"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# passwordAuthenticationMethod: resetPassword

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Initiate a reset for the password associated with a [password authentication method](../resources/passwordauthenticationmethod.md) object. This can only be done by an administrator with appropriate permissions and cannot be performed on a user's own account.

This flow writes the new password to Azure Active Directory and pushes it to on-premises Active Directory if configured using password writeback. The admin can either provide a new password or have the system generate one. The user is prompted to change their password on their next sign in.

This reset is a long-running operation and will return a **Location** header with a link where the caller can periodically check for the status of the reset operation.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

> [!IMPORTANT]
> The operation cannot be performed on a user's own account. Only an administrator with the appropriate permissions can perform this operation.

|Permission type      | Permissions (from least to most privileged)              |
|:---------------------------------------|:-------------------------|
| Delegated (work or school account)     | UserAuthenticationMethod.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

For delegated scenarios where an admin is acting on another user, the admin needs one of the following [Azure AD roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles):

* Global administrator
* Privileged authentication administrator
* Authentication administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /users/{id | userPrincipalName}/authentication/passwordMethods/{id}/resetPassword
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter    | Type        | Description |
|:-------------|:------------|:------------|
|newPassword|String|The new password. Required for tenants with hybrid password scenarios. If omitted for a cloud-only password, the system returns a system-generated password. This is a unicode string with no other encoding. It is validated against the tenant's banned password system before acceptance, and must adhere to the tenant's cloud and/or on-premises password requirements.|

## Response

If successful, this method returns a `202 Accepted` response code and a **Location** header with a URL to check the status of the reset operation.

If the caller did not submit a password, a Microsoft-generated password is provided in a JSON object in the response body.

### Response headers

| Name        | Description     |
|:------------|:----------------|
|Location     | URL to call to check the status of the operation. Required.|
|Retry-after  | Duration in seconds. Optional.|

## Examples

### Example 1: User-submitted password

The following example shows how to call this API when the caller submits a password.

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "passwordauthenticationmethod_resetpassword_adminprovided"
}-->

```http
POST https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0/authentication/passwordMethods/28c10230-6103-485e-b985-444c60001490/resetPassword
Content-type: application/json

{
    "newPassword": "Cuyo5459"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var newPassword = "Cuyo5459";

await graphClient.Users["{user-id}"].Authentication.PasswordMethods["{passwordAuthenticationMethod-id}"]
	.ResetPassword(newPassword)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.entity"
} -->

```http
HTTP/1.1 202 Accepted
Content-type: application/json
Location: https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0/authentication/operations/88e7560c-9ebf-435c-8089-c3998ac1ec51?aadgdc=DUB02P&aadgsu=ssprprod-a

{}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "passwordAuthenticationMethod: resetPassword",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->

### Example 2: System-generated password

The following example shows how to call this API when the caller does not submit a password.

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "passwordauthenticationmethod_resetpassword_systemgenerated"
}-->

```http
POST https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0/authentication/passwordMethods/28c10230-6103-485e-b985-444c60001490/resetPassword
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Users["{user-id}"].Authentication.PasswordMethods["{passwordAuthenticationMethod-id}"]
	.ResetPassword(null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.entity"
} -->

```http
HTTP/1.1 202 ACCEPTED
Location: https://graph.microsoft.com/beta/users/6ea91a8d-e32e-41a1-b7bd-d2d185eed0e0/authentication/operations/77bafe36-3ac0-4f89-96e4-a4a5a48da851?aadgdc=DUB02P&aadgsu=ssprprod-a
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.passwordResetResponse",
    "newPassword": "Cuyo5459"
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "passwordAuthenticationMethod: resetPassword",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
