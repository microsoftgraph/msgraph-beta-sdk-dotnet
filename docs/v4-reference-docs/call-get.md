---
title: "Get call"
description: "Retrieve the properties and relationships of a call object."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Get call

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a call object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged)                  |
| :-------------- | :----------------------------------------------------------- |
| Delegated (work or school account)     | Not Supported.                         |
| Delegated (personal Microsoft account) | Not Supported.                         |
| Application                            | Calls.Initiate.All, Calls.AccessMedia.All |

> **Note:** Permissions are checked when the call is created; no additional permission check is made when calling this API. Calls.AccessMedia.All is only necessary for calls that use app-hosted media.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /app/calls/{id}
GET /communications/calls/{id}
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and a [call](../resources/call.md) object in the response body.

## Examples

### Example 1: Getting a Peer-to-Peer call

##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get-call-1"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/communications/calls/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var call = await graphClient.Communications.Calls["{call-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get-call-2"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/communications/calls/2f1a1100-b174-40a0-aba7-0b405e01ed92
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var call = await graphClient.Communications.Calls["{call-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

