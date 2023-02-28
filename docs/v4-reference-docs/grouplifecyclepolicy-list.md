---
title: "List groupLifecyclePolicies"
description: "List all the groupLifecyclePolicies."
author: "psaffaie"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# List groupLifecyclePolicies

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List all the [groupLifecyclePolicies](../resources/grouplifecyclepolicy.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)   |
| :------------------------------------- | :-------------------------------------------- |
| Delegated (work or school account)     | Directory.Read.All or Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported                                 |
| Application                            | Directory.Read.All or Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /groupLifecyclePolicies
```

## Optional query parameters

This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [groupLifecyclePolicy](../resources/grouplifecyclepolicy.md) objects in the response body.

## Example

##### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "get_grouplifecyclepolicy_2"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/groupLifecyclePolicies
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var groupLifecyclePolicies = await graphClient.GroupLifecyclePolicies
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

