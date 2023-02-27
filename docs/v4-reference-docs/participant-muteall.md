---
title: "participant: muteAll"
description: "Mute all participants in the call."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# participant: muteAll

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Mute all participants in the call.

> **Note:** This API is deprecated and will be removed by March 15th, 2020. To mute a single participant, see [participant: mute](participant-mute.md).


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not Supported                               |
| Delegated (personal Microsoft account) | Not Supported                               |
| Application                            | Calls.JoinGroupCallsasGuest.All or Calls.JoinGroupCalls.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/participants/muteAll
POST /communications/calls/{id}/participants/muteAll
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
|participants|String collection|The participants to be muted.|
|clientContext|String|The client context.|

## Response
If successful, this method returns a `200 OK` response code and a [commsOperation](../resources/commsoperation.md) object in the response body.

## Example
The following example shows how to call this API.

##### Request
The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "participant-muteAll"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/{id}/participants/muteAll
Content-Type: application/json
Content-Length: 81

{
  "participants": [
    ""
  ],
  "clientContext": "clientContext-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var participants = new List<String>()
{
	""
};

var clientContext = "clientContext-value";

await graphClient.Communications.Calls["{call-id}"].Participants
	.MuteAll(participants,clientContext)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

