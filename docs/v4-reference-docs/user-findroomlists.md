---
title: "user: findRoomLists"
description: "Get the room lists defined in a tenant."
author: "vrod9429"
ms.localizationpriority: high
ms.prod: "outlook"
doc_type: apiPageType
---

# user: findRoomLists

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the room lists defined in a tenant, as represented by their [emailAddress](../resources/emailaddress.md) objects.

Tenants can organize meeting rooms into room lists. In this API, each meeting room and room list is represented by an [emailAddress](../resources/emailaddress.md) instance.
You can get all the room lists in the tenant, [get all the rooms](user-findrooms.md) in the tenant, or [get all the rooms](user-findrooms.md) in a specific room list.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.ReadBasic.All, User.Read.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | User.Read.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/findRoomLists
GET /users/{id}/findRoomLists

```

## Request headers
| Name       | Type | Description |
|:---------------|:----------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type  | string  | application/json. Required. |


## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [emailAddress](../resources/emailaddress.md) objects in the response body.

If no lists are defined in the tenant, then an empty array is returned.

## Example
##### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_get_room_lists"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/findRoomLists
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var findRoomLists = await graphClient.Me
	.FindRoomLists()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

