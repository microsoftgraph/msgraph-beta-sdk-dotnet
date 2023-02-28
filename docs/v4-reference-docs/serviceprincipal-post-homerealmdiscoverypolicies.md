---
title: "Assign homeRealmDiscoveryPolicy"
description: "Assign a homeRealmDiscoveryPolicy to a service principal."
ms.localizationpriority: medium
author: "sureshja"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Assign homeRealmDiscoveryPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Assign a [homeRealmDiscoveryPolicy](../resources/homerealmdiscoverypolicy.md) to a [servicePrincipal](../resources/servicePrincipal.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.Read.All and Application.ReadWrite.All, Policy.ReadWrite.ApplicationConfiguration and Application.ReadWrite.All  |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Policy.Read.All and Application.ReadWrite.OwnedBy, Policy.ReadWrite.ApplicationConfiguration and Application.ReadWrite.OwnedBy, Policy.Read.All and Application.ReadWrite.All, Policy.ReadWrite.ApplicationConfiguration and Application.ReadWrite.All |

## HTTP request

You can address the service principal using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->

```http
POST /servicePrincipals/{id}/homeRealmDiscoveryPolicies/$ref
POST /servicePrincipals(appId='{appId}')/homeRealmDiscoveryPolicies/$ref
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token} |
| Content-Type | application/json |

## Request body

In the request body, supply the identifier of the [homeRealmDiscoveryPolicy](../resources/homerealmdiscoverypolicy.md) object (using an `@odata.id` property) that should be assigned to the service principal.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_homerealmdiscoverypolicy_from_serviceprincipal"
}-->

```http
POST https://graph.microsoft.com/beta/servicePrincipals/19c308f2-e088-464d-8ccb-7137b7bab660/homeRealmDiscoveryPolicies/$ref
Content-Type: application/json

{
    "@odata.id": "https://graph.microsoft.com/beta/policies/homeRealmDiscoveryPolicies/6c6f154f-cb39-4ff9-bf5b-62d5ad585cde"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var homeRealmDiscoveryPolicy = new HomeRealmDiscoveryPolicy
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.id", "https://graph.microsoft.com/beta/policies/homeRealmDiscoveryPolicies/6c6f154f-cb39-4ff9-bf5b-62d5ad585cde"}
	}
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].HomeRealmDiscoveryPolicies.References
	.Request()
	.AddAsync(homeRealmDiscoveryPolicy);

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
  "description": "Assign homeRealmDiscoveryPolicy",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



