---
title: "call: cancelMediaProcessing"
description: "Cancels media processing for any in-progress playPrompt or recordResponse operations."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# call: cancelMediaProcessing

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Cancels processing for any in-progress media operations.

Media operations refer to the IVR operations [playPrompt](./call-playprompt.md) and [recordResponse](./call-record.md), which are by default queued to process in order. The **cancelMediaProcessing** method cancels any operation that is in-process as well as operations that are queued. For example, this API can be used to clean up the IVR operation queue for a new media operation. However, it will not cancel a **ubscribeToTone** operation because it operates independent of any operation queue.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not Supported.                              |
| Delegated (personal Microsoft account) | Not Supported.                              |
| Application                            | Calls.Initiate.All, Calls.AccessMedia.All |

> **Note:** Permissions are checked when the call is created; no additional permission check is made when calling this API. Calls.AccessMedia.All is only necessary for calls that use app-hosted media.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/cancelMediaProcessing
POST /communications/calls/{id}/cancelMediaProcessing
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter      | Type    | Description                                                    |
|:---------------|:--------|:---------------------------------------------------------------|
| clientContext  | String  | The client context.                                            |

## Response
If successful, this method returns a `200 OK` HTTP response code and a Location header with a URI to the [commsOperation](../resources/commsoperation.md) created for this request.

## Example
The following example shows how to call this API.

##### Request
The following example shows the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "call-cancelMediaProcessing"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/{id}/cancelMediaProcessing
Content-Type: application/json
Content-Length: 62

{
  "clientContext": "clientContext-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var clientContext = "clientContext-value";

await graphClient.Communications.Calls["{call-id}"]
	.CancelMediaProcessing(clientContext)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

