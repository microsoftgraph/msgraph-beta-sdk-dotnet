---
title: "List tasks"
description: "Get all the Outlook tasks in the specified folder."
author: "mashriv"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# List tasks (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Outlook tasks API is deprecated and will stop returning data on August 20, 2022. Please use the new [To Do API](/graph/api/resources/todo-overview). For more information, see [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/).


Get all the Outlook tasks in the specified folder.

By default, this operation (and the POST, PATCH, and [complete](../api/outlooktask-complete.md) task operations) returns
date-related properties in UTC.  You can use a `Prefer: outlook.timezone` request header to have all the date-related properties in the response represented in a time zone
different than UTC. See an [example](outlooktask-get.md#example-2-get-outlook-task-with-date-time-properties-in-pacific-standard-time) for getting a single task. You can apply the header similarly to get multiple tasks.

If there is more than one task group, and you want to get all the tasks in a specific task group, first
[get all the task folders in that task group](outlooktaskgroup-list-taskfolders.md),
and then get the tasks in each of these task folders.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Tasks.Read    |
|Delegated (personal Microsoft account) | Tasks.Read    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/outlook/taskFolders/{id}/tasks
GET /me/outlook/taskGroups/{id}/taskFolders/{id}/tasks
GET /users/{id|userPrincipalName}/outlook/taskFolders/{id}/tasks
GET /users/{id|userPrincipalName}/outlook/taskGroups/{id}/taskFolders/{id}/tasks
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |
| Prefer: outlook.timezone | Specifies the time zone for time properties in the response, which would be in UTC if this header is not specified. Optional.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [outlookTask](../resources/outlooktask.md) objects in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "outlooktaskfolder_get_tasks",
  "sampleKeys": ["AAMkADIyAAAhrbPWAAA="]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/outlook/taskFolders/AAMkADIyAAAhrbPWAAA=/tasks
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tasks = await graphClient.Me.Outlook.TaskFolders["{outlookTaskFolder-id}"].Tasks
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

