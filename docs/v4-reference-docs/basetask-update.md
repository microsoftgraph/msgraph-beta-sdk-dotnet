---
title: "Update baseTask"
description: "Update the properties of a baseTask object."
author: "devindrajit"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Update baseTask (deprecated)
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
Update the properties of a [baseTask](../resources/basetask.md) object.

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
PATCH /me/tasks/lists/{baseTaskListId}/tasks/{baseTaskId}
PATCH /users/{userId|userPrincipalName}/tasks/lists/{baseTaskListId}/tasks/{baseTaskId}

PATCH /me/tasks/alltasks/{baseTaskId}
PATCH /users/{userId|userPrincipalName}/tasks/alltasks/{baseTaskId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|textBody|String|The task body in text format that typically contains information about the task.|
|createdDateTime|DateTimeOffset|The date in the specified time zone that the task was finished.|
|lastModifiedDateTime|DateTimeOffset|The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header.|
|bodyLastModifiedDateTime|DateTimeOffset|The date and time when the task body was last modified. By default, it is in UTC. You can provide a custom time zone in the request header.|
|completedDateTime|DateTimeOffset|The date in the specified time zone that the task was finished.|
|dueDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone that the task is to be finished.|
|startDateTime|[dateTimeTimeZone](../resources/datetimetimezone.md)|The date in the specified time zone when the task is to begin.|
|importance|importance|The importance of the event. The possible values are: `low`, `normal`, `high`.|
|recurrence|[patternedRecurrence](../resources/patternedrecurrence.md)|The recurrence pattern for the task.|
|displayName|String|A brief description of the task.|
|status|taskStatus_v2|Indicates state or progress of the task. The possible values are: `notStarted`, `inProgress`, `completed`, `unknownFutureValue`.|
|viewpoint|[taskViewpoint](../resources/taskviewpoint.md)|Properties that are personal to a user such as reminderDateTime.|



## Response

If successful, this method returns a `200 OK` response code and an updated [baseTask](../resources/basetask.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_basetask",
  "sampleKeys": ["AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt", "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/me/tasks/lists/AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt/tasks/AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT
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
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.task",
    "@odata.etag": "W/\"kOO4xOT//0qFRAqk3TNe0QAAA1uzSQ==\"",
    "importance": "normal",
    "status": "notStarted",
    "displayName": "T-2",
    "createdDateTime": "2021-11-15T14:38:25.6868632Z",
    "lastModifiedDateTime": "2021-11-15T15:51:13.3606631Z",
    "id": "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT",
    "textBody":  "",
    "parentList": {
        "id": "AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt"
    }
}
```

