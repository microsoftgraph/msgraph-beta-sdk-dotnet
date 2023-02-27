---
title: "Get participant"
description: "Retrieve the properties and relationships of a **participant** object."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Get participant

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a **participant** object.

## Permissions

| Permission type | Permissions (from least to most privileged) |
| :-------------- | :------------------------------------------ |
| Delegated (work or school account)     | Not Supported        |
| Delegated (personal Microsoft account) | Not Supported        |
| Application     | Calls.JoinGroupCallsasGuest.All or Calls.JoinGroupCalls.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /app/calls/{id}/participants/{id}
GET /communications/calls/{id}/participants/{id}
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and a [participant](../resources/participant.md) object in the response body.

## Example

##### Request
The following example shows the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get-participant"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/communications/calls/7531d31f-d10d-44de-802f-c569dbca451c/participants/7e1b4346-85a6-4bdd-abe3-d11c5d420efe
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var participant = await graphClient.Communications.Calls["{call-id}"].Participants["{participant-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

