---
title: "Create todoTask"
description: "Create a new task object in a specified todoTaskList."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create todoTask
Namespace: microsoft.graph
> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new task object in a specified [todoTaskList](../resources/todotasklist.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.ReadWrite|
|Application|Tasks.ReadWrite.All  |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /me/todo/lists/{todoTaskListId}/tasks
POST /users/{id|userPrincipalName}/todo/lists/{todoTaskListId}/tasks
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [todoTask](../resources/todotask.md) object.

The following table shows the properties that are required when you create the [todoTask](../resources/todotask.md).

|Property|Type|Description|
|:---|:---|:---|
|id|String|Unique identifier for the task. By default, this value changes when the item is moved from one list to another.|
|body|[itemBody](../resources/itembody.md)|The task body that typically contains information about the task.|
|categories|String collection|The categories associated with the task. Each category corresponds to the **displayName** property of an [outlookCategory](../resources/outlookcategory.md) that the user has defined.|
|completedDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone that the task was finished.|
|dueDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone that the task is to be finished.|
|importance|importance|The importance of the task. Possible values are: `low`, `normal`, `high`.|
|isReminderOn|Boolean|Set to true if an alert is set to remind the user of the task.|
|recurrence|[patternedRecurrence](../resources/patternedrecurrence.md)|The recurrence pattern for the task.|
|reminderDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date and time for a reminder alert of the task to occur.|
|startDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone at which the task is scheduled to start.|
|status|taskStatus|Indicates the state or progress of the task. Possible values are: `notStarted`, `inProgress`, `completed`, `waitingOnOthers`, `deferred`.|
|title|String|A brief description of the task.|
|createdDateTime|DateTimeOffset|The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.|
|lastModifiedDateTime|DateTimeOffset|The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.|
|bodyLastModifiedDateTime|DateTimeOffset|The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.|



## Response

If successful, this method returns a `201 Created` response code and a [todoTask](../resources/todotask.md) object in the response body.

## Examples

### Request
The following example creates a **todoTask** in the specified task list, and includes a [linkedResource](../resources/linkedresource.md).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["AQMkADAwATM0MDAAMS0yMDkyLWVjMzYtM"],
  "name": "create_todotask_from_tasks"
}
-->
``` http
POST https://graph.microsoft.com/beta/me/todo/lists/AQMkADAwATM0MDAAMS0yMDkyLWVjMzYtM/tasks
Content-Type: application/json

{
   "title":"A new task",
   "categories": ["Important"],
   "linkedResources":[
      {
         "webUrl":"http://microsoft.com",
         "applicationName":"Microsoft",
         "displayName":"Microsoft"
      }
   ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var todoTask = new TodoTask
{
	Title = "A new task",
	Categories = new List<String>()
	{
		"Important"
	},
	LinkedResources = new TodoTaskLinkedResourcesCollectionPage()
	{
		new LinkedResource
		{
			WebUrl = "http://microsoft.com",
			ApplicationName = "Microsoft",
			DisplayName = "Microsoft"
		}
	}
};

await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks
	.Request()
	.AddAsync(todoTask);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.todoTask"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
   "@odata.etag":"W/\"xzyPKP0BiUGgld+lMKXwbQAAnBoTIw==\"",
   "importance":"low",
   "isReminderOn":false,
   "status":"notStarted",
   "title":"A new task",
   "createdDateTime":"2020-08-18T09:03:05.8339192Z",
   "lastModifiedDateTime":"2020-08-18T09:03:06.0827766Z",
   "categories": ["Important"],
   "id":"AlMKXwbQAAAJws6wcAAAA=",
   "body":{
      "content":"",
      "contentType":"text"
   },
   "linkedResources":[
      {
         "id":"f9cddce2-dce2-f9cd-e2dc-cdf9e2dccdf9",
         "webUrl":"http://microsoft.com",
         "applicationName":"Microsoft",
         "displayName":"Microsoft"
      }
   ]
}
```



