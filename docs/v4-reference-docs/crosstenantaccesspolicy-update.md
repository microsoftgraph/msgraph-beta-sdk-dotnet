---
title: "Update crossTenantAccessPolicy"
description: "Update the properties of a cross-tenant access policy."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update crossTenantAccessPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [cross-tenant access policy](../resources/crosstenantaccesspolicy.md).

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
PATCH /policies/crossTenantAccessPolicy
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
|displayName|String|The display name of the cross-tenant access policy.|

## Response

If successful, this method returns a `204 No Content` response code.

The [crossTenantAccessPolicy](../resources/crosstenantaccesspolicy.md) object size is currently limited to 25KB. This method will return a `400 Bad Request` error code if the size of the policy will exceed 25KB.

## Examples

### Request

<!-- {
  "blockType": "request",
  "name": "update_crosstenantaccesspolicy"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy
Content-Type: application/json

{
  "allowedCloudEndpoints": ["microsoftonline.us", "partner.microsoftonline.cn"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var crossTenantAccessPolicy = new CrossTenantAccessPolicy
{
	AllowedCloudEndpoints = new List<String>()
	{
		"microsoftonline.us",
		"partner.microsoftonline.cn"
	}
};

await graphClient.Policies.CrossTenantAccessPolicy
	.Request()
	.UpdateAsync(crossTenantAccessPolicy);

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
