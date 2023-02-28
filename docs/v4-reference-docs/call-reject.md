---
title: "call: reject"
description: "Enable a bot to reject an incoming call."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# call: reject

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Enable a bot to reject an incoming call. The incoming call request can be an invite from a participant in a group call or a peer-to-peer call. If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.

The bot is expected to answer or reject the call before the call times out. The current timeout value is 15 seconds.

This API does not end existing calls that have already been answered. Use [delete call](../api/call-delete.md) to end a call.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged)                |
| :-------------- | :--------------------------------------------------------- |
| Delegated (work or school account)     | Not Supported                       |
| Delegated (personal Microsoft account) | Not Supported                       |
| Application     | None                                                       |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/reject
POST /communications/calls/{id}/reject
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter      | Type    |Description|
|:---------------|:--------|:----------|
|reason|String|The rejection reason. Possible values are `None`, `Busy` and `Forbidden` |
|callbackUri|String|This allows bots to provide a specific callback URI for the current call to receive later notifications. If this property has not been set, the bot's global callback URI will be used instead. This must be `https`.|

## Response
If successful, this method returns a `202 Accepted` response code. It does not return anything in the response body.

## Examples
The following examples show how to call this API.

### Example 1: Reject an incoming call with 'Busy' reason
#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "call-reject"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/57dab8b1-894c-409a-b240-bd8beae78896/reject
Content-Type: application/json
Content-Length: 24

{
  "reason": "busy"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reason = RejectReason.Busy;

await graphClient.Communications.Calls["{call-id}"]
	.Reject(reason,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "call-reject-none-reason"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/57dab8b1-894c-409a-b240-bd8beae78896/reject
Content-Type: application/json
Content-Length: 24

{
  "reason": "none"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reason = RejectReason.None;

await graphClient.Communications.Calls["{call-id}"]
	.Reject(reason,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

