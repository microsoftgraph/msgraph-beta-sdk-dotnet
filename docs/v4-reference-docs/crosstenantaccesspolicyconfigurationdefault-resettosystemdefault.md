---
title: "crossTenantAccessPolicyConfigurationDefault: resetToSystemDefault"
description: "Reset any changes made to the default configuration in a cross-tenant access policy back to the system default."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# crossTenantAccessPolicyConfigurationDefault: resetToSystemDefault

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Reset any changes made to the default configuration in a cross-tenant access policy back to the system default.

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
POST /policies/crossTenantAccessPolicy/default/resetToSystemDefault
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this action returns a `204 No Content` response code. To confirm that the default configuration has been restored to the system defaults, run [Get crossTenantAccessPolicyConfigurationDefault](../api/crosstenantaccesspolicyconfigurationdefault-get.md) and confirm that **isSystemDefault** is set to `true`.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "crosstenantaccesspolicyconfigurationdefault_resettosystemdefault"
}
-->

``` http
POST https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/default/resetToSystemDefault
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Policies.CrossTenantAccessPolicy.Default
	.ResetToSystemDefault()
	.Request()
	.PostAsync();

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
