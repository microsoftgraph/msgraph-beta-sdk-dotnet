---
title: "Get teamsAsyncOperation"
description: "Get the details of a teamsAsyncOperation."
author: "jecha"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Get teamsAsyncOperation
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the specified [Teams async operation](../resources/teamsasyncoperation.md) that ran or is running on a specific resource.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

The following permissions are for getting the operation on a chat:

| Permission type                        | Permissions (from least to most privileged)|
| :------------------------------------- | :--------------------------------------------------- |
| Delegated (work or school account)     | Chat.ReadBasic, Chat.Read, Chat.ReadWrite|
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ChatSettings.Read.Chat*, ChatSettings.ReadWrite.Chat*, Chat.Manage.Chat*, Chat.ReadBasic.All, Chat.Read.All, Chat.ReadWrite.All |

> **Note**: Permissions marked with * use [resource-specific consent](/microsoftteams/platform/graph-api/rsc/resource-specific-consent).

## HTTP request
<!-- { 
    "blockType": "ignored" 
} 
-->
``` http
GET /chats/{chat-id}/operations/{operation-id}
```

## Optional query parameters

This method supports the `$select` [OData query parameter](/graph/query-parameters) to help customize the response.

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this returns a `200 OK` response code and a [teamsAsyncOperation](../resources/teamsasyncoperation.md) object in the response body.

## Example: Get operation on chat

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_chat_operation",
  "sampleKeys": ["19:c253a29b5f694b55a6baad8e83510af7@thread.v2", "2432b57b-0abd-43db-aa7b-16eadd115d34-e88ae9aa-887e-4972-ac3e-bd578e38232e-cf58835e-43f0-4fc1-825e-5de55630e7e4"]
}
-->
``` http
GET https://graph.microsoft.com/beta/chats/19:c253a29b5f694b55a6baad8e83510af7@thread.v2/operations/2432b57b-0abd-43db-aa7b-16eadd115d34-e88ae9aa-887e-4972-ac3e-bd578e38232e-cf58835e-43f0-4fc1-825e-5de55630e7e4
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAsyncOperation = await graphClient.Chats["{chat-id}"].Operations["{teamsAsyncOperation-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.teamsAsyncOperation"
}
-->
``` http
HTTP/1.1 202 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#chats('19%3Ac253a29b5f694b55a6baad8e83510af7%40thread.v2')/operations/$entity",
    "id": "2432b57b-0abd-43db-aa7b-16eadd115d34-e88ae9aa-887e-4972-ac3e-bd578e38232e-cf58835e-43f0-4fc1-825e-5de55630e7e4",
    "operationType": "createChat",
    "createdDateTime": "2021-05-27T21:23:41.9085453Z",
    "status": "succeeded",
    "lastActionDateTime": "2021-05-27T21:23:45.1899277Z",
    "attemptsCount": 1,
    "targetResourceId": "19:c253a29b5f694b55a6baad8e83510af7@thread.v2",
    "targetResourceLocation": "/chats('19:c253a29b5f694b55a6baad8e83510af7@thread.v2')",
    "values": "{\"appIds\":[\"1542629c-01b3-4a6d-8f76-1938b779e48d\"]}",
    "error": null
}
```
