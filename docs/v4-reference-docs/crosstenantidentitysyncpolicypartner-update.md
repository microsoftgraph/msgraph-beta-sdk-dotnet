---
title: "Update crossTenantIdentitySyncPolicyPartner"
description: "Update the user synchronization policy of a partner-specific configuration."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update crossTenantIdentitySyncPolicyPartner
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the user synchronization policy of a partner-specific configuration.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.CrossTenantAccess|
|Delegated (personal Microsoft account)|Not applicable|
|Application|Policy.ReadWrite.CrossTenantAccess|

The signed-in user must also be assigned the following minimum [directory role](/azure/active-directory/roles/permissions-reference):

+ Hybrid Identity Administrator

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /policies/crossTenantAccessPolicy/partners/{id}/identitySynchronization
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Display name for the cross-tenant user synchronization policy. Generally, this should be the tenant name of the partner Azure AD organization. Optional.|
|userSyncInbound|[crossTenantUserSyncInbound](../resources/crosstenantusersyncinbound.md)|Determines whether users can be synchronized from the partner tenant. If set to `false`, any current user synchronization from the source tenant to the target tenant will stop. There is no impact to existing users that have already been synchronized.|



## Response

If successful, this method returns a `204 No Content` response code.

## Examples


### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_crosstenantidentitysyncpolicypartner"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/partners/90e29127-71ad-49c7-9ce8-db3f41ea06f1/identitySynchronization
Content-Type: application/json

{
  "userSyncInbound": 
  {
    "isSyncAllowed": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var crossTenantIdentitySyncPolicyPartner = new CrossTenantIdentitySyncPolicyPartner
{
	UserSyncInbound = new CrossTenantUserSyncInbound
	{
		IsSyncAllowed = true
	}
};

await graphClient.Policies.CrossTenantAccessPolicy.Partners["{crossTenantAccessPolicyConfigurationPartner-id}"].IdentitySynchronization
	.Request()
	.UpdateAsync(crossTenantIdentitySyncPolicyPartner);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

