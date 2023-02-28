---
title: "message: send"
description: "Send an existing draft message."
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# message: send

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Send an existing draft message. 

The draft message can be a new message [draft](../api/user-post-messages.md), [reply draft](../api/message-createreply.md), [reply-all draft](../api/message-createreplyall.md), or a [forward draft](../api/message-createforward.md). 

This method saves the message in the **Sent Items** folder.

Alternatively, [send a new message](../api/user-sendmail.md) in a single operation.

## Permissions
One of the following permissions are required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.Send    |
|Delegated (personal Microsoft account) | Mail.Send    |
|Application | Mail.Send |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /me/messages/{id}/send
POST /users/{id | userPrincipalName}/messages/{id}/send
```

## Request headers

| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Length | number | 0. Required. |

## Request body
Since this method sends an already existing draft message, specifying a request body is not necessary.

## Response

If successful, this method returns `202 Accepted` response code. It does not return anything in the response body.

## Examples
### Example 1: Send an existing draft message

Here is an example of how to call this API.

##### Request

Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "message_send"
}-->

```http
POST https://graph.microsoft.com/beta/me/messages/{id}/send
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Messages["{message-id}"]
	.Send()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

