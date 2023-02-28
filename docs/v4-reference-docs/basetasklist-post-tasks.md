---
title: "Create baseTask"
description: "Create a new baseTask object in a specific baseTaskList."
author: "devindrajit"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create baseTask (deprecated)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

---
author: "angelgolfer-ms"
ms.localizationpriority: high
ms.prod: "outlook"
ms.topic: include
---

<!-- markdownlint-disable MD041-->
>[!CAUTION]
>The to-do API set built on [baseTask](/graph/api/resources/basetask?view=graph-rest-beta&preserve-view=true) is deprecated as of May 31, 2022, and will stop returning data on August 31, 2022. Please use the API set built on [todoTask](/graph/api/resources/todotask?view=graph-rest-beta&preserve-view=true). 
Create a new [baseTask](../resources/basetask.md) object in a specific [baseTaskList](../resources/basetasklist.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.ReadWrite|
|Application|Not supported|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /me/tasks/lists/{baseTaskListId}/tasks
POST /users/{userId|userPrincipalName}/tasks/lists/{baseTaskListId}/tasks
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [baseTask](../resources/basetask.md) object.

You can specify the following properties when creating a **baseTask**.

|Property|Type|Description|
|:---|:---|:---|
|textBody|String|The task body in text format that typically contains information about the task.|
|createdDateTime|DateTimeOffset|The date in the specified time zone that the task was finished.|
|lastModifiedDateTime|DateTimeOffset|The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.|
|bodyLastModifiedDateTime|DateTimeOffset|The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: '2020-01-01T00:00:00Z'.|
|completedDateTime|DateTimeOffset|The date in the specified time zone that the task was finished.|
|dueDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone that the task is to be finished.|
|startDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone when the task is to begin.|
|importance|importance|The importance of the task. The possible values are: `low`, `normal`, `high`.|
|recurrence|[patternedRecurrence](../resources/patternedrecurrence.md)|The recurrence pattern for the task.|
|displayName|String|A brief description of the task.|
|status|taskStatus_v2|Indicates the state or progress of the task. The possible values are: `notStarted`, `inProgress`, `completed`, `unknownFutureValue`. Required.|
|viewpoint|[taskViewpoint](../resources/taskviewpoint.md)|Properties that are personal to a user such as reminderDateTime.|



## Response

If successful, this method returns a `201 Created` response code and a [baseTask](../resources/basetask.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_basetask_from_",
  "sampleKeys": ["AQMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNi"]
}
-->
``` http
POST https://graph.microsoft.com/beta/me/tasks/lists/AQMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNi/tasks
Content-Type: application/json
Content-length: 634

{
  "@odata.type": "#microsoft.graph.task",
  "textBody":  "String",
  "bodyLastModifiedDateTime": "String (timestamp)",
  "completedDateTime": "String (timestamp)",
  "dueDateTime": {
    "@odata.type": "microsoft.graph.dateTimeTimeZone"
  },
  "startDateTime": {
    "@odata.type": "microsoft.graph.dateTimeTimeZone"
  },
  "importance": "String",
  "recurrence": {
    "@odata.type": "microsoft.graph.patternedRecurrence"
  },
  "displayName": "String",
  "status": "String",
  "viewpoint": {
    "@odata.type": "microsoft.graph.taskViewpoint"
  }
}
```

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.task"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.task",
    "@odata.etag": "W/\"kOO4xOT//0qFRAqk3TNe0QAABCE1Xg==\"",
    "importance": "normal",
    "status": "notStarted",
    "displayName": "Buy medicine",
    "createdDateTime": "2021-11-17T10:11:18.0229364Z",
    "lastModifiedDateTime": "2021-11-17T10:11:18.19789Z",
    "id": "AAkALgAAAAAAHYQDEapmEc2byACqAC",
    "textBody":  "",
    "parentList": {
        "id": "AQMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNi"
    }
}
```

