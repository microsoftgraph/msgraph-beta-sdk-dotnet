---
title: "message: unsubscribe"
description: "Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list. Uses the information in the `List-Unsubscribe` header."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# message: unsubscribe

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list. Uses the information in the `List-Unsubscribe` header.

Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out. They can do so by specifying the `List-Unsubscribe` header in each message following [RFC-2369](http://www.faqs.org/rfcs/rfc2369.html).

**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.

Setting that header would also set the **unsubscribeEnabled** property of the [message](../resources/message.md) instance to `true`, and the **unsubscribeData** property to the header data.

If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.

A successful **unsubscribe** action moves the message to the **Deleted Items** folder. The actual exclusion of the user from future mail distribution is managed by the sender.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Mail.Send    |
|Delegated (personal Microsoft account) | Mail.Send    |
|Application | Mail.Send |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /users/{id | userPrincipalName}/messages/{id}/unsubscribe
```
## Request headers
| Name       | Type | Description|
|:---------------|:--------|:----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `202 Accepted` response code. It does not return anything in the response body.

## Example
Here is an example of how to call this API.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "message_unsubscribe"
}-->
```http
POST https://graph.microsoft.com/beta/me/messages/{id}/unsubscribe
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Messages["{message-id}"]
	.Unsubscribe()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

