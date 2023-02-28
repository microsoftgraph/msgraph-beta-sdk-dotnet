---
title: "Delete simulation"
description: "Delete an attack simulation campaign for a tenant."
author: stuartcl
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Delete simulation

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an attack simulation campaign for a tenant.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | AttackSimulation.ReadWrite.All              |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | AttackSimulation.ReadWrite.All              |

## HTTP request
<!-- {
  "blockType": "ignored"
}
-->
```http
DELETE /security/attackSimulation/simulations/{simulationId}
```

## Request headers

|Header         |Value                    |
|---------------|-------------------------|
|Authorization  |Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code in the response.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_simulation",
  "sampleKeys": ["2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc"]
}
-->
```http
DELETE https://graph.microsoft.com/beta/security/attackSimulation/simulations/2f5548d1-0dd8-4cc8-9de0-e0d6ec7ea3dc
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Security.AttackSimulation.Simulations["{simulation-id}"]
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
}
-->
``` http
HTTP/1.1 204 No Content
```
