---
title: "Update authenticationMethodsPolicy"
description: "Update the properties of an authenticationMethodsPolicy object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update authenticationMethodsPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [authenticationMethodsPolicy](../resources/authenticationmethodspolicy.md) object.

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
PATCH /policies/authenticationMethodsPolicy
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [registrationEnforcement](../resources/registrationenforcement.md) object to prompt users to set up targeted authentication methods. 

|Property|Type|Description|
|:---|:---|:---|
|registrationEnforcement|[registrationEnforcement](../resources/registrationenforcement.md)|Enforce registration at sign-in time. This property can be used to prompt users to set up targeted authentication methods.|

## Response
If successful, this method returns a `200 OK` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authenticationmethodspolicy"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/authenticationMethodsPolicy
Content-Type: application/json

{
  "registrationEnforcement": {
    "authenticationMethodsRegistrationCampaign": {
        "snoozeDurationInDays": 1,
        "state": "enabled",
        "excludeTargets": [],
        "includeTargets": [
            {
                "id": "3ee3a9de-0a86-4e12-a287-9769accf1ba2",
                "targetType": "group",
                "targetedAuthenticationMethod": "microsoftAuthenticator"
            }
        ]
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationMethodsPolicy = new AuthenticationMethodsPolicy
{
	RegistrationEnforcement = new RegistrationEnforcement
	{
		AuthenticationMethodsRegistrationCampaign = new AuthenticationMethodsRegistrationCampaign
		{
			SnoozeDurationInDays = 1,
			State = AdvancedConfigState.Enabled,
			ExcludeTargets = new List<ExcludeTarget>()
			{
			},
			IncludeTargets = new List<AuthenticationMethodsRegistrationCampaignIncludeTarget>()
			{
				new AuthenticationMethodsRegistrationCampaignIncludeTarget
				{
					Id = "3ee3a9de-0a86-4e12-a287-9769accf1ba2",
					TargetType = AuthenticationMethodTargetType.Group,
					TargetedAuthenticationMethod = "microsoftAuthenticator"
				}
			}
		}
	}
};

await graphClient.Policies.AuthenticationMethodsPolicy
	.Request()
	.UpdateAsync(authenticationMethodsPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.authenticationMethodsPolicy"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#authenticationMethodsPolicy",
  "id": "authenticationMethodsPolicy",
  "displayName": "Authentication Methods Policy",
  "description": "The tenant-wide policy that controls which authentication methods are allowed in the tenant, authentication method registration requirements, and self-service password reset settings",
  "lastModifiedDateTime": "2021-05-25T01:08:08.6712279Z",
  "policyVersion": "1.4",
  "registrationEnforcement": {
    "authenticationMethodsRegistrationCampaign": {
        "snoozeDurationInDays": 1,
        "state": "enabled",
        "excludeTargets": [],
        "includeTargets": [
            {
                "id": "3ee3a9de-0a86-4e12-a287-9769accf1ba2",
                "targetType": "group",
                "targetedAuthenticationMethod": "microsoftAuthenticator"
            }
        ]
    }
  }
}
```
