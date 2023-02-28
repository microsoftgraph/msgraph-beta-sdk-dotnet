---
title: "Update accessReviewPolicy"
description: "Update the properties of an accessReviewPolicy object."
author: "kafen"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Update accessReviewPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [accessReviewPolicy](../resources/accessreviewpolicy.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.AccessReview|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.ReadWrite.AccessReview|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /policies/accessReviewPolicy
PATCH /identityGovernance/accessReviews/policy
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [accessReviewPolicy](../resources/accessreviewpolicy.md) object.

The following table shows the properties that are required when you update the [accessReviewPolicy](../resources/accessreviewpolicy.md).

|Property|Type|Description|
|:---|:---|:---|
|isGroupOwnerManagementEnabled|Boolean|If `true`, group owners can create and manage access reviews on groups they own.|



## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_accessreviewpolicy"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/accessReviewPolicy
Content-Type: application/json

{
  "isGroupOwnerManagementEnabled": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewPolicy = new AccessReviewPolicy
{
	IsGroupOwnerManagementEnabled = true
};

await graphClient.Policies.AccessReviewPolicy
	.Request()
	.UpdateAsync(accessReviewPolicy);

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

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_accessreviewpolicy_2"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/identityGovernance/accessReviews/policy
Content-Type: application/json

{
  "isGroupOwnerManagementEnabled": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewPolicy = new AccessReviewPolicy
{
	IsGroupOwnerManagementEnabled = true
};

await graphClient.IdentityGovernance.AccessReviews.Policy
	.Request()
	.UpdateAsync(accessReviewPolicy);

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
