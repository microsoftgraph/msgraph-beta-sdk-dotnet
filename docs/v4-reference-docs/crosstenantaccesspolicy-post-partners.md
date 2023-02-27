---
title: "Create crossTenantAccessPolicyConfigurationPartner"
description: "Create a new partner configuration in a cross-tenant access policy."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Create crossTenantAccessPolicyConfigurationPartner

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new partner configuration in a cross-tenant access policy.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.CrossTenantAccess|
|Delegated (personal Microsoft account)|Not applicable|
|Application|Policy.ReadWrite.CrossTenantAccess|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /policies/crossTenantAccessPolicy/partners
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [crossTenantAccessPolicyConfigurationPartner](../resources/crosstenantaccesspolicyconfigurationpartner.md) object.

The following table shows the properties that are required when you create the [crossTenantAccessPolicyConfigurationPartner](../resources/crosstenantaccesspolicyconfigurationpartner.md).

|Property|Type|Description|
|:---|:---|:---|
| automaticUserConsentSettings | [inboundOutboundPolicyConfiguration](../resources/inboundoutboundpolicyconfiguration.md) | Determines the partner-specific configuration for automatic user consent settings. Unless specifically configured, the `inboundAllowed` and `outboundAllowed` properties will be **null** and inherit from the default settings, which is always `false`. |
| b2bCollaborationInbound | [crossTenantAccessPolicyB2BSetting](../resources/crosstenantaccesspolicyb2bsetting.md) | Defines your partner-specific configuration for users from other organizations accessing your resources via Azure AD B2B collaboration. |
| b2bCollaborationOutbound | [crossTenantAccessPolicyB2BSetting](../resources/crosstenantaccesspolicyb2bsetting.md) | Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B collaboration. |
| b2bDirectConnectInbound | [crossTenantAccessPolicyB2BSetting](../resources/crosstenantaccesspolicyb2bsetting.md) | Defines your partner-specific configuration for users from other organizations accessing your resources via Azure B2B direct connect. |
| b2bDirectConnectOutbound | [crossTenantAccessPolicyB2BSetting](../resources/crosstenantaccesspolicyb2bsetting.md) | Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B direct connect. |
| inboundTrust | [crossTenantAccessPolicyInboundTrust](../resources/crosstenantaccesspolicyinboundtrust.md) | Determines the partner-specific configuration for trusting other Conditional Access claims from external Azure AD organizations. |
| isServiceProvider | Boolean | Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization. |
| tenantId | String | The tenant identifier for the partner Azure AD organization. Read-only. Key.|

## Response

If successful, this method returns a `201 Created` response code and a [crossTenantAccessPolicyConfigurationPartner](../resources/crosstenantaccesspolicyconfigurationpartner.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_crosstenantaccesspolicyconfigurationpartner_from_"
}
-->

``` http
POST https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/partners
Content-Type: application/json

{
  "tenantId": "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a",
  "b2bDirectConnectOutbound": 
  {
    "usersAndGroups": 
    {
      "accessType": "blocked",
      "targets": [
        {
            "target": "6f546279-4da5-4b53-a095-09ea0cef9971",
            "targetType": "group"
        }
      ]
    }
  },
  "b2bDirectConnectInbound": 
  {
    "applications":
    {
      "accessType": "allowed",
      "targets": [
        {
            "target": "Office365",
            "targetType": "application"
        }
      ]
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var crossTenantAccessPolicyConfigurationPartner = new CrossTenantAccessPolicyConfigurationPartner
{
	TenantId = "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a",
	B2bDirectConnectOutbound = new CrossTenantAccessPolicyB2BSetting
	{
		UsersAndGroups = new CrossTenantAccessPolicyTargetConfiguration
		{
			AccessType = CrossTenantAccessPolicyTargetConfigurationAccessType.Blocked,
			Targets = new List<CrossTenantAccessPolicyTarget>()
			{
				new CrossTenantAccessPolicyTarget
				{
					Target = "6f546279-4da5-4b53-a095-09ea0cef9971",
					TargetType = CrossTenantAccessPolicyTargetType.Group
				}
			}
		}
	},
	B2bDirectConnectInbound = new CrossTenantAccessPolicyB2BSetting
	{
		Applications = new CrossTenantAccessPolicyTargetConfiguration
		{
			AccessType = CrossTenantAccessPolicyTargetConfigurationAccessType.Allowed,
			Targets = new List<CrossTenantAccessPolicyTarget>()
			{
				new CrossTenantAccessPolicyTarget
				{
					Target = "Office365",
					TargetType = CrossTenantAccessPolicyTargetType.Application
				}
			}
		}
	}
};

await graphClient.Policies.CrossTenantAccessPolicy.Partners
	.Request()
	.AddAsync(crossTenantAccessPolicyConfigurationPartner);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.crossTenantAccessPolicyConfigurationPartner"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "tenantId": "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a",
  "inboundTrust": null,
  "b2bCollaborationInbound": null,
  "b2bCollaborationOutbound": null,
  "b2bDirectConnectOutbound": 
  {
    "usersAndGroups":
    {
      "accessType": "blocked",
      "targets": [
        {
          "target": "6f546279-4da5-4b53-a095-09ea0cef9971",
          "targetType": "group"
        }
      ]
    }
  },
  "b2bDirectConnectInbound":
  {
    "applications":
    {
      "accessType": "allowed",
      "targets": [
        {
          "target": "Office365",
          "targetType": "application"
        }
      ]
    }
  }
}
```
