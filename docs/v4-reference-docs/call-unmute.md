---
title: "call: unmute"
description: "Allow the application to unmute itself."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# call: unmute

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Allow the application to unmute itself.

This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again.

For more information about how to handle unmute operations, see [unmuteParticipantOperation](../resources/unmuteParticipantoperation.md).

> **Note:** This method is only supported for group calls.

## Permissions

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not supported.                               |
| Delegated (personal Microsoft account) | Not supported.                               |
| Application                            | Calls.Initiate.All, Calls.AccessMedia.All |

> **Note:** Permissions are checked when the call is created; no additional permission check is made when calling this API. Calls.AccessMedia.All is only necessary for calls that use app-hosted media.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/unmute
POST /communications/calls/{id}/unmute
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required.|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter      | Type    |Description|
|:---------------|:--------|:----------|
|clientContext|String|The client context.|

## Response
If successful, this method returns a `200 OK` response code and a [unmuteParticipantOperation](../resources/unmuteParticipantoperation.md) object in the response body.

>**Note:** When this API returns a successful response, all participants will receive a roster update.

## Example

##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "call-unmute"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/57dab8b1-894c-409a-b240-bd8beae78896/unmute
Content-Type: application/json
Content-Length: 46

{
  "clientContext": "clientContext-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var clientContext = "clientContext-value";

await graphClient.Communications.Calls["{call-id}"]
	.Unmute(clientContext)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

