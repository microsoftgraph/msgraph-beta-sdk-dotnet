---
title: "presence: clearPresence"
description: "Clear the presence information for a user's application presence session."
author: "mkhribech"
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "cloud-communications"
---

# presence: clearPresence

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Clear a [presence session](presence-setpresence.md#presence-sessions) of an application for a user. If it is the user's only presence session, a successful **clearPresence** changes the user's presence to `Offline/Offline`.

Read more about [presence sessions](presence-setpresence.md#presence-sessions) and their [time-out and expiration](presence-setpresence.md#timeout-expiration-and-keep-alive). 

## Permissions
The following permission is required to call the API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Presence.ReadWrite                          |
| Delegated (personal Microsoft account) | Not Supported.                              |
| Application                            | Presence.ReadWrite.All                      |

## HTTP Request
<!-- { "blockType": "ignored" } -->
```http
POST /users/{userId}/presence/clearPresence
```

## Request headers
| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter | Type   | Description                                   |
| :-------- | :----- | :-------------------------------------------- |
| sessionId | string | The ID of the application's presence session. |


> [!IMPORTANT]
> 
> Provide the ID of the application as `sessionId` in the request.

## Response
If successful, this method returns a `200 OK` response code.

If the presence session doesn't exist, this method returns a `404 NotFound` response code.

## Examples
The following request shows the application with ID `22553876-f5ab-4529-bffb-cfe50aa89f87` that clears its presence session for user `fa8bf3dc-eca7-46b7-bad1-db199b62afc3`.

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "clear--presence"
}-->

```msgraph-interactive
POST https://graph.microsoft.com/beta/users/fa8bf3dc-eca7-46b7-bad1-db199b62afc3/presence/clearPresence
Content-Type: application/json

{
  "sessionId": "22553876-f5ab-4529-bffb-cfe50aa89f87"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var sessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87";

await graphClient.Users["{user-id}"].Presence
	.ClearPresence(sessionId)
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
} -->
```http
HTTP/1.1 200 OK
```
