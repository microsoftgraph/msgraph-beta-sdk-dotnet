---
title: "Get crossTenantAccessPolicyConfigurationDefault"
description: "Read the default configuration of a cross-tenant access policy."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get crossTenantAccessPolicyConfigurationDefault

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the [default configuration](../resources/crosstenantaccesspolicyconfigurationdefault.md) of a cross-tenant access policy. This default configuration may be the service default assigned by Azure AD (**isServiceDefault** is `true`) or may be customized in your tenant (**isServiceDefault** is `false`).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.CrossTenantAccess|
|Delegated (personal Microsoft account)|Not applicable|
|Application|Policy.Read.All, Policy.ReadWrite.CrossTenantAccess|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /policies/crossTenantAccessPolicy/default
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [crossTenantAccessPolicyConfigurationDefault](../resources/crosstenantaccesspolicyconfigurationdefault.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_crosstenantaccesspolicyconfigurationdefault"
}
-->

``` http
GET https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/default
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var crossTenantAccessPolicyConfigurationDefault = await graphClient.Policies.CrossTenantAccessPolicy.Default
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following response object shows a default cross-tenant policy inherited from Azure AD, as identified by **isServiceDefault** set to `true`.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.crossTenantAccessPolicyConfigurationDefault"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "isServiceDefault": true,
  "inboundTrust":
  {
    "isMfaAccepted": false,
    "isCompliantDeviceAccepted": false,
    "isHybridAzureADJoinedDeviceAccepted": false,
  },
  "automaticUserConsentSettings":
  {
    "inboundAllowed": false,
    "outboundAllowed": false
  },
  "b2bCollaborationOutbound":
  {
    "usersAndGroups":
    {
      "accessType": "allowed",
      "targets": [
        {
          "target": "AllUsers",
          "targetType": "user"
        }
      ]
    },
    "applications":
    {
      "accessType": "allowed",
      "targets": [
        {
          "target": "AllApplications",
          "targetType": "application"
        }
      ]
    }
  },
  "b2bCollaborationInbound":
  {
    "usersAndGroups":
    {
      "accessType": "allowed",
      "targets": [
        {
          "target": "AllUsers",
          "targetType": "user"
        }
      ]
    },
    "applications":
    {
      "accessType": "allowed",
      "targets": [
        {
          "target": "AllApplications",
          "targetType": "application"
        }
      ]
    }
  },
  "b2bDirectConnectOutbound":
  {
    "usersAndGroups":
    {
      "accessType": "blocked",
      "targets": [
        {
          "target": "AllUsers",
          "targetType": "user"
        }
      ]
    },
    "applications":
    {
      "accessType": "blocked",
      "targets": [
        {
          "target": "AllApplications",
          "targetType": "application"
        }
      ]
    }
  },
  "b2bDirectConnectInbound":
  {
    "usersAndGroups":
    {
      "accessType": "blocked",
      "targets": [
        {
          "target": "AllUsers",
          "targetType": "user"
        }
      ]
    },
    "applications":
    {
      "accessType": "blocked",
      "targets": [
        {
          "target": "AllApplications",
          "targetType": "application"
        }
      ]
    }
  }
}
```
