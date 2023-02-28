---
title: "Update authorizationpolicy"
description: "Update the properties of authorizationPolicy object."
ms.localizationpriority: medium
author: "DougKirschner"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update authorizationPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [authorizationPolicy](../resources/authorizationpolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.ReadWrite.Authorization|
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Policy.ReadWrite.Authorization|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /policies/authorizationPolicy/authorizationPolicy
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token} |
| Content-type | application/json |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|allowedToSignUpEmailBasedSubscriptions|Boolean| Indicates whether users can sign up for email based subscriptions. |
|allowedToUseSSPR|Boolean| Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant. |
|allowEmailVerifiedUsersToJoinOrganization|Boolean| Indicates whether a user can join the tenant by email validation. |
|allowUserConsentForRiskyApps|Boolean| Indicates whether [user consent for risky apps](/azure/active-directory/manage-apps/configure-risk-based-step-up-consent) is allowed. It is recommended to keep this as `false`. |
|blockMsolPowerShell|Boolean| To disable the use of MSOL PowerShell, set this property to `true`. This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell. This does not affect Azure AD Connect or Microsoft Graph. |
|defaultUserRolePermissions|[defaultUserRolePermissions](../resources/defaultUserRolePermissions.md)| Specifies certain customizable permissions for default user role. |
|description|String| Description of this policy. |
|displayName|String| Display name for this policy. |
|enabledPreviewFeatures|Collection(string)| List of features enabled for private preview on the tenant. |
|guestUserRoleId|Guid| Represents role templateId for the role that should be granted to guest user. Refer to [List unifiedRoleDefinitions](./rbacapplication-list-roledefinitions.md) to find the list of available role templates. Only supported roles today are User (`a0b1b346-4d3e-4e8b-98f8-753987be4970`), Guest User (`10dae51f-b6af-4016-8d66-8c2a99b929b3`), and Restricted Guest User (`2af84b1e-32c8-42b7-82bc-daa82404023b`). |
|permissionGrantPolicyIdsAssignedToDefaultUserRole | String collection | Indicates whether user consent to apps is allowed, and if it is, which [app consent policy](/azure/active-directory/manage-apps/manage-app-consent-policies) governs the permission for users to grant consent. Values should be in the format `managePermissionGrantsForSelf.{id}`, where `{id}` is the **id** of a built-in or custom [app consent policy](/azure/active-directory/manage-apps/manage-app-consent-policies). An empty list indicates user consent to apps is disabled. |

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Example 1: Update or set Guest user access level for the tenant

#### Request

The following is an example of the request. In this example, guest access level is modified to Restricted Guest User.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_guestUserLevel"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "guestUserRole":"2af84b1e-32c8-42b7-82bc-daa82404023b"
}
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
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 2: Enable new feature for preview on tenant

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_preview"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "enabledPreviewFeatures":[
      "assignGroupsToRoles"
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	EnabledPreviewFeatures = new List<String>()
	{
		"assignGroupsToRoles"
	}
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 3: Block MSOL PowerShell in tenant

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_blockMSOLPowerShell"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "blockMsolPowerShell":true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	BlockMsolPowerShell = true
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 4: Disable default user role's permission to create applications

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_applications"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "defaultUserRolePermissions":{
      "allowedToCreateApps":false
   }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	DefaultUserRolePermissions = new DefaultUserRolePermissions
	{
		AllowedToCreateApps = false
	}
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 5: Enable default user role to use Self-Serve Password Reset feature

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_SSPR"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "allowedToUseSSPR":true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	AllowedToUseSSPR = true
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 6: Disable user consent to apps for default user role

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_disableUserConsent"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "permissionGrantPolicyIdsAssignedToDefaultUserRole":[
   
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	PermissionGrantPolicyIdsAssignedToDefaultUserRole = new List<String>()
	{
	}
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 7: Enable user consent to apps, subject to app consent policy 

#### Request

The following is an example of the request that allows user consent to apps, subject to the built-in [app consent policy](/azure/active-directory/manage-apps/manage-app-consent-policies) `microsoft-user-default-low`, which allows delegated permissions classified "low", for client apps from verified publishers or registered in the same tenant.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authZPolicy_enableUserConsentLow"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/authorizationPolicy/authorizationPolicy

{
   "permissionGrantPolicyIdsAssignedToDefaultUserRole":[
      "managePermissionGrantsForSelf.microsoft-user-default-low"
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authorizationPolicy = new AuthorizationPolicy
{
	PermissionGrantPolicyIdsAssignedToDefaultUserRole = new List<String>()
	{
		"managePermissionGrantsForSelf.microsoft-user-default-low"
	}
};

await graphClient.Policies.AuthorizationPolicy["{authorizationPolicy-id}"]
	.Request()
	.UpdateAsync(authorizationPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```
