---
title: "organization: activateService"
description: "Activates a service for an organization."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# organization: activateService (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The **activateService** API is deprecated and will stop returning data on June 30, 2022.

Activate a service for an organization.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

In order to activate a service for an organization the requestor needs to have the _Company Administrator_ role with the following permissions.

|Permission type|Permissions (from least to most privileged)|
| :--- | :--- |
| Delegated (work or school account) | Directory.ReadWrite.All|
| Delegated (personal Microsoft account) | Not Supported. |
| Application | Directory.ReadWrite.All|


## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /organization/{organizationId}/activateService
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [activateService](../resources/activateService.md) object.
You must define **service** or (**servicePlanId** _and_ **skuId**) for this action to be valid.

| Property         | Type         | Description                           |
| ----------------- | ------------ | ------------------------------------- |
| service| String | The name of the service to activate. |
| servicePlanId | Guid | The plan identifier of the service plan to activate. |
| skuId | Guid | The SKU identifier of the service plan. |

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "organization_activateservice"
}
-->
``` http
POST https://graph.microsoft.com/beta/organization/{:organizationId}/activateService
Content-Type: application/json

{
    "skuId": "6fd2c87f-b296-42f0-b197-1e91e994b900",
    "servicePlanId": "a23b959c-7ce8-4e57-9140-b90eb88a9e97"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var skuId = Guid.Parse("6fd2c87f-b296-42f0-b197-1e91e994b900");

var servicePlanId = Guid.Parse("a23b959c-7ce8-4e57-9140-b90eb88a9e97");

await graphClient.Organization["{organization-id}"]
	.ActivateService(null,servicePlanId,skuId)
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
