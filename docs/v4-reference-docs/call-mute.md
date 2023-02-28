---
title: "call: mute"
description: "Allows the application to mute itself."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# call: mute

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Allows the application to mute itself.

This is a server mute, meaning that the server will drop all audio packets for this participant, even if the participant continues to stream audio.

For more details about how to handle mute operations, see [muteParticipantOperation](../resources/muteparticipantoperation.md)

> **Note:** This method is only supported for group calls.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not Supported.                               |
| Delegated (personal Microsoft account) | Not Supported.                               |
| Application     | Calls.Initiate.All, Calls.AccessMedia.All  |

> **Note:** Permissions are checked when the call is created; no additional permission check is made when calling this API. Calls.AccessMedia.All is only necessary for calls that use app-hosted media.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/mute
POST /communications/calls/{id}/mute
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter      | Type    |Description|
|:---------------|:--------|:----------|
|clientContext|String|The client context.|

## Response
If successful, this method returns a `200 OK` response code and a [muteParticipantOperation](../resources/muteParticipantoperation.md) object in the response body.

> **Note:** After this operation returns a successful response, all participants will receive a roster update

## Example
The following example shows how to call this API.

##### Request
The following example shows the request.


# [HTTP](#tab/http)
<!-- { 
  "blockType": "request", 
  "name": "call-mute" 
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/57dab8b1-894c-409a-b240-bd8beae78896/mute
Content-Type: application/json

{
  "clientContext": "clientContext-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var clientContext = "clientContext-value";

await graphClient.Communications.Calls["{call-id}"]
	.Mute(clientContext)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

