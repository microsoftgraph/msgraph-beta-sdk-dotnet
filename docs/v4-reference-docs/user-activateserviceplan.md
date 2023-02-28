---
title: "user: activateServicePlan"
description: "Activate a service plan with a given `servicePlanId` and `skuId` for a given user."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# user: activateServicePlan (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The **activateServicePlan** API is deprecated and will stop returning data on June 30, 2022.

Activate a service plan with a given `servicePlanId` and `skuId` for a given user.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from most to least privileged)|
| :--- | :--- |
| Delegated (work or school account) | Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not Supported. |
| Application | Directory.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /users/{id | userPrincipalName}/activateServicePlan
```

## Request headers

| Name | Description |
| :--- | :--- |
| Authorization | Bearer {token}. Required. |
| Content-Type | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameter:

| Parameter | Type | Description |
| :--- | :--- | :--- |
| servicePlanId | Guid | PlanId of the ServicePlan to activate. |
| skuId | Guid | SkuId of SKU the service plan is on. |

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_activateserviceplan"
}
-->

``` http
POST https://graph.microsoft.com/beta/me/activateServicePlan
Content-type: application/json

{
  "servicePlanId": "28f42d6f-8034-4a0f-9d8a-a218a63b3299",
  "skuId": "465a2a90-5e59-456d-a7b8-127b9fb2e484"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var servicePlanId = Guid.Parse("28f42d6f-8034-4a0f-9d8a-a218a63b3299");

var skuId = Guid.Parse("465a2a90-5e59-456d-a7b8-127b9fb2e484");

await graphClient.Me
	.ActivateServicePlan(servicePlanId,skuId)
	.Request()
	.PostAsync();

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
