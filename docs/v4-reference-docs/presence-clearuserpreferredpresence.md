---
title: "presence: clearUserPreferredPresence"
description: "Clear the preferred availability and activity status for a user."
author: "mkhribech"
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "cloud-communications"
---

# presence: clearUserPreferredPresence

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Clear the preferred availability and activity status for a user.

## Permissions
The following permission is required to call the API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Presence.ReadWrite                          |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Presence.ReadWrite.All                      |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /users/{userId}/presence/clearUserPreferredPresence
```

## Request headers
| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply an empty JSON object `{}` for this method.

## Response
If successful, this method returns a `200 OK` response code.

## Examples

### Request

The following is an example of a request that clears the preferred availability and activity status for a user.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "clearUserPreferredPresence"
}-->

```msgraph-interactive
POST https://graph.microsoft.com/beta/users/fa8bf3dc-eca7-46b7-bad1-db199b62afc3/presence/clearUserPreferredPresence
Content-Type: application/json

{
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Users["{user-id}"].Presence
	.ClearUserPreferredPresence()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 200 OK
```
