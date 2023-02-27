---
title: "groupLifecyclePolicy: renewGroup"
description: "Renew a group's expiration. When a group is renewed, the group expiration is extended by the number of days defined in the policy."
ms.localizationpriority: medium
author: "psaffaie"
ms.prod: "groups"
doc_type: apiPageType
---

# groupLifecyclePolicy: renewGroup

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Renew a group's expiration. When a group is renewed, the group expiration is extended by the number of days defined in the policy.

> **Note:** When calling the v1.0 endpoint, use the [Renew group](/graph/api/group-renew?view=graph-rest-1.0&preserve-view=true) method.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)    |
| :------------------------------------- | :--------------------------------------------- |
| Delegated (work or school account)     | Group.ReadWrite.All or Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported                                  |
| Application                            | Group.ReadWrite.All or Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groupLifecyclePolicies/renewGroup

```

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json          |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter | Type | Description                   |
| :-------- | :--- | :---------------------------- |
| groupId   | Guid | The id of the group to renew. |

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example

##### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "grouplifecyclepolicy_renewgroup"
}-->

```http
POST https://graph.microsoft.com/beta/groupLifecyclePolicies/renewGroup
Content-type: application/json

{
  "groupId": "ffffffff-ffff-ffff-ffff-ffffffffffff"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var groupId = "ffffffff-ffff-ffff-ffff-ffffffffffff";

await graphClient.GroupLifecyclePolicies
	.RenewGroup(groupId)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

