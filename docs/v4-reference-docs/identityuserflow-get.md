---
title: "Get userFlow (deprecated)"
description: "Retrieve the properties and relationships of userflow object."
ms.localizationpriority: medium
author: "Nickgmicrosoft"
ms.prod: "identity-and-sign-in"
doc_type: "apiPageType"
---

# Get userFlow

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The user flow API is deprecated and will stop returning data in January 2022. Please use the [B2C user flow](/graph/api/resources/b2cidentityuserflow) or [Self-service sign up user flow](/graph/api/resources/b2xidentityuserflow) API, depending on your external identity needs.

Retrieve the properties and associations for an [userFlow](../resources/identityuserflow.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | IdentityUserFlow.Read.All, IdentityUserFlow.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | IdentityUserFlow.Read.All, IdentityUserFlow.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /identity/userFlows/{id}
```

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and the requested [userFlow](../resources/identityuserflow.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_identityuserflow",
  "sampleKeys": ["B2C_1_Pol1"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/identity/userFlows/B2C_1_Pol1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityUserFlow = await graphClient.Identity.UserFlows["{identityUserFlow-id}"]
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
  "@odata.type": "microsoft.graph.UserFlow"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "id": "B2C_1_Pol1",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 1
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get UserFlow",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
   "suppressions": [
    "Error: get_identityuserflow/userFlowTypeVersion:\r\n      Expected type Single but actual was Int64. Property: userFlowTypeVersion, actual value: '1'"
  ]
}-->


