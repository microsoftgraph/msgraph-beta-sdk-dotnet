---
title: "Delete baseTask"
description: "Delete a baseTask object."
author: "devindrajit"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Delete baseTask (deprecated)
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
Delete a [baseTask](../resources/basetask.md) object.

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
DELETE /me/tasks/lists/{baseTaskListId}/tasks/{baseTaskId}
DELETE /users/{userId|userPrincipalName}/tasks/lists/{baseTaskListId}/tasks/{baseTaskId}

DELETE /me/tasks/alltasks/{baseTaskId}
DELETE /users/{userId|userPrincipalName}/tasks/alltasks/{baseTaskId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_basetask",
  "sampleKeys": ["AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAu", "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT"]
}
-->
``` http
DELETE /me/tasks/lists/AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAu/tasks/AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Tasks.Lists["{baseTaskList-id}"].Tasks["{baseTask-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

