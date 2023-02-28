---
title: "Create permissionGrantPolicy"
description: "Creates a permissionGrantPolicy object that describes the conditions under which permissions may be granted."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# Create permissionGrantPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Creates a [permissionGrantPolicy](../resources/permissiongrantpolicy.md). A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).

After creating the permission grant policy, you can [add include condition sets](permissiongrantpolicy-post-includes.md) to add matching rules, and [add exclude condition sets](permissiongrantpolicy-post-excludes.md) to add exclusion rules.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Policy.ReadWrite.PermissionGrant |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Policy.ReadWrite.PermissionGrant |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /policies/permissionGrantPolicies
```

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization | Bearer {token}. Required.  |
| Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [permissionGrantPolicy](../resources/permissiongrantpolicy.md) object.

## Response

If successful, this method returns a `201 Created` response code and a [permissionGrantPolicy](../resources/permissiongrantpolicy.md) object in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "truncated": true,
  "name": "create_permissiongrantpolicy"
}-->

```http
POST https://graph.microsoft.com/beta/policies/permissionGrantPolicies
Content-Type: application/json

{
  "id": "my-custom-consent-policy",
  "displayName": "Custom application consent policy",
  "description": "A custom permission grant policy to customize conditions for granting consent."
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var permissionGrantPolicy = new PermissionGrantPolicy
{
	Id = "my-custom-consent-policy",
	DisplayName = "Custom application consent policy",
	Description = "A custom permission grant policy to customize conditions for granting consent."
};

await graphClient.Policies.PermissionGrantPolicies
	.Request()
	.AddAsync(permissionGrantPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.permissionGrantPolicy"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "my-custom-consent-policy",
  "displayName": "Custom application consent policy",
  "description": "A custom permission grant policy to customize conditions for granting consent."
}
```
