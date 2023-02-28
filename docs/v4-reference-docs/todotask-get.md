---
title: "Get todoTask"
description: "Read the properties and relationships of a todoTask object."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Get todoTask
Namespace: microsoft.graph
> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [todoTask](../resources/todotask.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.Read, Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.Read, Tasks.ReadWrite|
|Application|Tasks.Read.All, Tasks.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/todo/lists/{todoTaskListId}/tasks/{taskId}
GET /users/{id|userPrincipalName}/todo/lists/{todoTaskListId}/tasks/{taskId}
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [todoTask](../resources/todotask.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["AAMkADA1MTHgwAAA=", "721a35e2-35e2-721a-e235-1a72e2351a72"],
  "name": "get_todotask_1"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/todo/lists/AAMkADA1MTHgwAAA=/tasks/721a35e2-35e2-721a-e235-1a72e2351a72
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var todoTask = await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks["{todoTask-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.todoTask"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#tasks/$entity",
    "@odata.etag": "W/\"s8/ERWT3WEeFpBGD0bDgAA+TWq9g==\"",
    "importance": "low",
    "isReminderOn": false,
    "status": "notStarted",
    "title": "Shop for dinner",
    "createdDateTime": "2020-07-22T10:39:03.7937971Z",
    "lastModifiedDateTime": "2020-07-22T12:02:10.8835421Z",
    "categories": [
        "Important",
        "Urgent"
    ],
    "id": "721a35e2-35e2-721a-e235-1a72e2351a72",
    "body": {
        "content": "",
        "contentType": "text"
    },
    "dueDateTime": {
        "dateTime": "2020-08-25T04:00:00.0000000",
        "timeZone": "UTC"
    },
    "startDateTime": {
        "dateTime": "2020-06-23T04:00:00.0000000",
        "timeZone": "UTC"
    }
}
```



