---
title: "Delete checklistItem"
description: "Delete a checklistItem object."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Delete checklistItem
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
>Existing apps that use this feature with [baseTask](/graph/api/resources/basetask?view=graph-rest-beta&preserve-view=true) or [baseTaskList](/graph/api/resources/basetasklist?view=graph-rest-beta&preserve-view=true) should be updated, as the to-do API set built on these resources is deprecated as of May 31, 2022. That API set will stop returning data on August 31, 2022. Please use the API set built on [todoTask](/graph/api/resources/todotask?view=graph-rest-beta&preserve-view=true). 

Delete a [checklistItem](../resources/checklistitem.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.ReadWrite|
|Application|Tasks.ReadWrite.All|

## HTTP request

This section lists the syntax for each of the two `PATCH` scenarios described above.

### Delete a checklistItem associated to a specified todoTask

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /me/todo/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems/{checklistItemId}
DELETE /users/{id | userPrincipalName}/todo/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems/{checklistItemId}
```
### Delete a checklistItem associated to a specified baseTask (deprecated)

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /me/tasks/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems/{checklistItemId}
DELETE /users/{id | userPrincipalName}/tasks/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems/{checklistItemId}
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

### Request 1

Here is an example to delete a **checklistItem** associated to a **todoTask**.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_checklistitem_1",
  "sampleKeys": ["AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=", "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA", "e3a26c2e-7c6f-4317-9d71-c27267008202"]
}
-->
``` http
DELETE https://graph.microsoft.com/beta/me/todo/lists/AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=/tasks/AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA/checklistitems/e3a26c2e-7c6f-4317-9d71-c27267008202
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks["{todoTask-id}"].ChecklistItems["{checklistItem-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

### Request 2

Here is an example to delete a **checklistItem** associated to a **baseTask** (deprecated).

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_checklistitem_2",
  "sampleKeys": ["AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=", "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA", "e3a26c2e-7c6f-4317-9d71-c27267008202"]
}
-->
``` http
DELETE https://graph.microsoft.com/beta/me/tasks/lists/AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=/tasks/AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA/checklistitems/e3a26c2e-7c6f-4317-9d71-c27267008202
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Tasks.Lists.AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=.Tasks.AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA.Checklistitems.E3a26c2e-7c6f-4317-9d71-c27267008202
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```
