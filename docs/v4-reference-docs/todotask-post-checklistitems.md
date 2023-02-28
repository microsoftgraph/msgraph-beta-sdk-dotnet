---
title: "Create checklistItem"
description: "Create a new checklistItem object."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create checklistItem
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [checklistItem](../resources/checklistitem.md) object as a subtask in a bigger [todoTask](../resources/todotask.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.ReadWrite|
|Application|Tasks.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /me/todo/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems
POST /users/{id | userPrincipalName}/todo/lists/{todoTaskListId}/tasks/{todoTaskId}/checklistItems
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [checklistItem](../resources/checklistitem.md) object.

You can specify the following properties when creating a **checklistItem**.

|Property|Type|Description|
|:---|:---|:---|
|checkedDateTime|DateTimeOffset|The date and time when the **checklistItem** was finished.|
|createdDateTime|DateTimeOffset|The date and time when the **checklistItem** was created.|
|displayName|String|Field indicating the title of **checklistItem**.|
|isChecked|Boolean|State indicating whether the item is checked off or not.|


## Response

If successful, this method returns a `201 Created` response code and a [checklistItem](../resources/checklistitem.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_checklistitem_as_substask",
  "sampleKeys": ["AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=", "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA"]
}
-->
``` http
POST https://graph.microsoft.com/beta/me/todo/lists/AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA=/tasks/AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA/checklistitems/
Content-Type: application/json

{
    "displayName": "Final sign-off from the team"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var checklistItem = new ChecklistItem
{
	DisplayName = "Final sign-off from the team"
};

await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks["{todoTask-id}"].ChecklistItems
	.Request()
	.AddAsync(checklistItem);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.checklistItem"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('6f9a2a92-8527-4d64-937e-b5312852f35d')/todo/lists('AAMkADliMmU5YjJlLTVmMmQtNGQzNS1iYjA0LTdmZTA2NTI0MTE5YwAuAAAAAADdOMUbUmCfTKa7OC-fqjkdAQBnu3olF7NfToRyJ2f__TNcAAAAAAESAAA%3D')/tasks('AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AZ7t6JRezX06Ecidn-vkzXAABPDii4gAA')/checklistItems/$entity",
    "displayName": "Final sign-off from the team",
    "createdDateTime": "2021-11-17T05:35:03.9736453Z",
    "isChecked": false,
    "id": "e3a26c2e-7c6f-4317-9d71-c27267008202"
}
```

