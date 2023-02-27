---
title: "Delete crossTenantAccessPolicyConfigurationPartner"
description: "Delete a partner-specific configuration in a cross-tenant access policy."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Delete crossTenantAccessPolicyConfigurationPartner

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [partner-specific configuration](../resources/crosstenantaccesspolicyconfigurationpartner.md) in a cross-tenant access policy. If a configuration includes a [user synchronization policy](../resources/crosstenantidentitysyncpolicypartner.md), you must first [delete the user synchronization policy](./crosstenantidentitysyncpolicypartner-delete.md) before you can delete the partner-specific configuration.

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
DELETE /policies/crossTenantAccessPolicy/partners/{id}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

If a configuration includes a [user synchronization policy](../resources/crosstenantidentitysyncpolicypartner.md), you must first [delete the user synchronization policy](./crosstenantidentitysyncpolicypartner-delete.md) before you can delete the partner-specific configuration.

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_crosstenantaccesspolicyconfigurationpartner"
}
-->

``` http
DELETE https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/partners/9c5d131d-b1c3-4fc4-9e3f-c6557947d551
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Policies.CrossTenantAccessPolicy.Partners["{crossTenantAccessPolicyConfigurationPartner-id}"]
	.Request()
	.DeleteAsync();

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
