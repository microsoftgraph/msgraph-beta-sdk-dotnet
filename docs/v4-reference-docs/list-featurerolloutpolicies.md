---
title: "List featureRolloutPolicies"
description: "Retrieve a list of featureRolloutPolicy objects."
ms.localizationpriority: medium
author: "madhavpatel6"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# List featureRolloutPolicies

Namespace: microsoft.graph

> [!CAUTION]
> The featureRolloutPolicy API moved from /directory/featureRolloutPolicies to **/policies/featureRolloutPolicies** on March 5, 2021. The previous /directory/featureRolloutPolicies endpoint stopped returning returning data after June 30, 2021.

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [featureRolloutPolicy](../resources/featurerolloutpolicy.md) objects.

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
GET /policies/featureRolloutPolicies
```

## Optional query parameters

This method supports the following OData query parameters to help customize the response: `$count`, `$expand`, `$filter`, `$orderby`, `$select`, `$skip`, `$top`. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token}. Required |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [featureRolloutPolicy](../resources/featurerolloutpolicy.md) objects in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_featurerolloutpolicies_policies"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/featureRolloutPolicies
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var featureRolloutPolicies = await graphClient.Policies.FeatureRolloutPolicies
	.Request()
	.GetAsync();

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
  "@odata.type": "microsoft.graph.featureRolloutPolicy",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "e3c2f23a-edd2-43a8-849f-154e70794ac5",
      "displayName": "PassthroughAuthentication rollout policy",
      "description": "PassthroughAuthentication rollout policy",
      "feature": "passthroughAuthentication",
      "isEnabled": true,
      "isAppliedToOrganization": false
    },
    {
      "id": "df85e4d9-e8c4-4033-a41c-73419a95c29c",
      "displayName": "SeamlessSso rollout policy",
      "description": "SeamlessSso rollout policy",
      "feature": "seamlessSso",
      "isEnabled": true,
      "isAppliedToOrganization": false
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List featureRolloutPolicies",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


