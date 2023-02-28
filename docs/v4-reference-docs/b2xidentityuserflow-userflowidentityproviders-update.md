---
title: "Update a userFlowIdentityProvider"
description: "Update an identityProvider in a b2xIdentityUserFlow."
ms.localizationpriority: medium
doc_type: apiPageType
author: "namkedia"
ms.prod: "identity-and-sign-in"
---

# Update a userFlowIdentityProvider

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update an identity providers in a [b2xIdentityUserFlow](../resources/b2xidentityuserflow.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application| IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External ID user flow administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /identity/b2xUserFlows/{userflow-id}/userflowIdentityProviders/$ref
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON representation with the `id` of the [identityProvider](../resources/identityproviderbase.md) you want to add. For self-service sign up user flows, the values can be `Google-OAUTH` or `Facebook-OAUTH`.

## Response

If successful, this method returns a `204 No Content` response code. If unsuccessful, a `4xx` error is returned with the specific error details.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_b2xuserflows_userflowidentityprovider",
  "sampleKeys": ["B2X_1_Test"]
}
-->

``` http
PATCH https://graph.microsoft.com/beta/identity/b2xUserFlows/B2X_1_Test/userflowIdentityProviders/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/identity/identityProviders/B2X_1_Test",
  "@odata.type": "#microsoft.graph.identityProvider"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userFlowIdentityProviders = new IdentityProvider
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.id", "https://graph.microsoft.com/beta/identity/identityProviders/B2X_1_Test"}
	}
};

await graphClient.Identity.B2xUserFlows["{b2xIdentityUserFlow-id}"].UserFlowIdentityProviders.References
	.Request()
	.UpdateAsync(userFlowIdentityProviders);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```
