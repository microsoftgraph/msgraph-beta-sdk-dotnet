---
title: "presence: setStatusMessage"
description: "Set a presence status message for a user."
author: "afedorov"
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "cloud-communications"
---

# presence: setStatusMessage

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Set a presence status message for a user. An optional expiration date and time can be supplied.

## Permissions
The following permission is required to call the API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Presence.ReadWrite                          |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | Not supported.                              |

## HTTP Request
<!-- { "blockType": "ignored" } -->
```http
POST /users/{userId}/presence/setStatusMessage
```

## Request headers
| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter       | Type            |  Description                                 |
| --------------- | --------------- |------------------------------------------- |
| `statusMessage` | [microsoft.graph.presenceStatusMessage](../resources/presencestatusmessage.md) |It can be set to display the presence status message of a user. |

## Response
If successful, this method returns a `200 OK` response code.

## Examples

### Example 1: Set status message with expiry date

The following request sets the presence status message as "Hey I'm currently in a meeting." for user `fa8bf3dc-eca7-46b7-bad1-db199b62afc3`, with the expiration on `2022-10-18 at 17:05:33.2079781 Pacific Standard Time`.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "setstatusmessage"
}-->

```http
POST https://graph.microsoft.com/beta/users/fa8bf3dc-eca7-46b7-bad1-db199b62afc3/presence/setStatusMessage
Content-Type: application/json

{
  "statusMessage": {
    "message": {
        "content": "Hey I'm currently in a meeting.",
        "contentType": "text"
    },
    "expiryDateTime": {
        "dateTime": "2022-10-18T17:05:33.2079781",
        "timeZone": "Pacific Standard Time"
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var statusMessage = new PresenceStatusMessage
{
	Message = new ItemBody
	{
		Content = "Hey I'm currently in a meeting.",
		ContentType = BodyType.Text
	},
	ExpiryDateTime = new DateTimeTimeZone
	{
		DateTime = "2022-10-18T17:05:33.2079781",
		TimeZone = "Pacific Standard Time"
	}
};

await graphClient.Users["{user-id}"].Presence
	.SetStatusMessage(statusMessage)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "name": "setstatusmessage",
  "truncated": true
} -->
```http
HTTP/1.1 200 OK
```

### Example 2: Get status message of another user

The following request sets the presence status message as "Hey I'm currently in a meeting." for user `fa8bf3dc-eca7-46b7-bad1-db199b62afc3`. Then presence for user `fa8bf3dc-eca7-46b7-bad1-db199b62afc3` is obtained on behalf of other user via a [getPresence](presence-get.md) request.

#### Set status message: request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "setstatusmessage-another-user"
}-->
```http
POST https://graph.microsoft.com/beta/users/fa8bf3dc-eca7-46b7-bad1-db199b62afc3/presence/setStatusMessage
Content-Type: application/json

{
  "statusMessage": {
    "message": {
      "content": "Hey I am available now",
      "contentType": "text"
    }
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var statusMessage = new PresenceStatusMessage
{
	Message = new ItemBody
	{
		Content = "Hey I am available now",
		ContentType = BodyType.Text
	}
};

await graphClient.Users["{user-id}"].Presence
	.SetStatusMessage(statusMessage)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "setstatusmessage-another-user-get-presence"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/users/fa8bf3dc-eca7-46b7-bad1-db199b62afc3/presence
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var presence = await graphClient.Users["{user-id}"].Presence
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

