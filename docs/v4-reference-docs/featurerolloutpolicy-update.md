---
title: "Update featureRolloutPolicy"
description: "Update the properties of featurerolloutpolicy object."
ms.localizationpriority: medium
author: "madhavpatel6"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Update featurerolloutpolicy

Namespace: microsoft.graph

> [!CAUTION]
> The featureRolloutPolicy API moved from /directory/featureRolloutPolicies to **/policies/featureRolloutPolicies** on March 5, 2021. The previous /directory/featureRolloutPolicies endpoint stopped returning returning data after June 30, 2021.

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of [featureRolloutPolicy](../resources/featurerolloutpolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /policies/featureRolloutPolicies/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required |

## Request body

In the request body, supply the values for relevant properties that should be updated. Existing properties that are not included in the request body maintain their previous values or are recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|description|String|A description for this policy.|
|displayName|String|The display name for this policy.|
|isAppliedToOrganization|Boolean|Indicates whether this feature rollout policy should be applied to the entire organization.|
|isEnabled|Boolean|Indicates whether the feature rollout is enabled.|

## Response

If successful, this method returns a `204 No content` response code.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_featurerolloutpolicy_policies"
}-->

```http
PATCH https://graph.microsoft.com/beta/policies/featureRolloutPolicies/d7ab4886-d7f0-441b-a5e6-e62d7328d18a
Content-type: application/json

{
  "displayName": "PasswordHashSync Rollout Policy",
  "description": "PasswordHashSync Rollout Policy",
  "isEnabled": true,
  "isAppliedToOrganization": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var featureRolloutPolicy = new FeatureRolloutPolicy
{
	DisplayName = "PasswordHashSync Rollout Policy",
	Description = "PasswordHashSync Rollout Policy",
	IsEnabled = true,
	IsAppliedToOrganization = false
};

await graphClient.Policies.FeatureRolloutPolicies["{featureRolloutPolicy-id}"]
	.Request()
	.UpdateAsync(featureRolloutPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update featurerolloutpolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


