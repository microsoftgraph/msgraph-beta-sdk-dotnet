---
title: "List Todo tasks"
description: "Get the todoTask resources from the tasks navigation property of a specified todoTaskList."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# List tasks
Namespace: microsoft.graph
> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the **todoTask** resources from the **tasks** navigation property of a specified [todoTaskList](../resources/todotasklist.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.ReadWrite|
|Application|Tasks.Read.All, Tasks.ReadWrite.All  |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/todo/lists/{todoTaskListId}/tasks
GET /users/{id|userPrincipalName}/todo/lists/{todoTaskListId}/tasks
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

If successful, this method returns a `200 OK` response code and a collection of [todoTask](../resources/todotask.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["35e2-35e2-721a-e235-1a72e2351a7"],
  "name": "get_todotask_2"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/todo/lists/35e2-35e2-721a-e235-1a72e2351a7/tasks
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tasks = await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "collection(microsoft.graph.todoTask)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
   "value":[
      {
         "@odata.etag":"W/\"xzyPKP0BiUGgld+lMKXwbQAAgdhkVw==\"",
         "importance":"low",
         "isReminderOn":false,
         "status":"notStarted",
         "title":"Linked entity new task 1",
         "createdDateTime":"2020-07-08T11:15:19.9359889Z",
         "lastModifiedDateTime":"2020-07-08T11:15:20.0614375Z",
          "categories": [
               "Important",
               "Urgent"
            ],
         "id":"AQMkADAwATM0MDAAMS0yMDkyLWVjMzYtMDACLTAwCgBGAAAD",
         "body":{
            "content":"",
            "contentType":"text"
         },
         "linkedResources":[
            {
               "applicationName":"Partner App Name",
               "displayName":"Partner App Name",
               "externalId":"teset1243434",
               "id":"30911960-7321-4cba-9ba0-cdb68e2984c7"
            }
         ]
      }
   ]
}
```



