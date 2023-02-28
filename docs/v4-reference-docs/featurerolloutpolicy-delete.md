---
title: "Delete featureRolloutPolicy"
description: "Delete a featureRolloutPolicy object."
ms.localizationpriority: medium
author: "madhavpatel6"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Delete featureRolloutPolicy

Namespace: microsoft.graph

> [!CAUTION]
> The featureRolloutPolicy API moved from /directory/featureRolloutPolicies to **/policies/featureRolloutPolicies** on March 5, 2021. The previous /directory/featureRolloutPolicies endpoint stopped returning returning data after June 30, 2021.

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [featureRolloutPolicy](../resources/featurerolloutpolicy.md) object.

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
DELETE /policies/featureRolloutPolicies/{id}
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_featurerolloutpolicy_policies"
}-->

```http
DELETE https://graph.microsoft.com/beta/policies/featureRolloutPolicies/df85e4d9-e8c4-4033-a41c-73419a95c29c
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Policies.FeatureRolloutPolicies["{featureRolloutPolicy-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Delete featureRolloutPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


