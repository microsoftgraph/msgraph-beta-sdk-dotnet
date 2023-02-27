---
title: "Update outlooktaskgroup"
description: "Update the writable properties of an Outlook task group."
author: "mashriv"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Update outlooktaskgroup (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Outlook tasks API is deprecated and will stop returning data on August 20, 2022. Please use the new [To Do API](/graph/api/resources/todo-overview). For more information, see [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/).


Update the writable properties of an Outlook task group.

Note that you cannot modify the name of the default task group, "My Tasks".
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Tasks.ReadWrite    |
|Delegated (personal Microsoft account) | Tasks.ReadWrite    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/outlook/taskGroups/{id}
PATCH /users/{id|userPrincipalName}/outlook/taskGroups/{id}
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|name|String|The name of the task group.|

## Response

If successful, this method returns a `200 OK` response code and updated [outlookTaskGroup](../resources/outlooktaskgroup.md) object in the response body.
## Example
##### Request
The following example changes the name of a task group to "Personal Tasks". 

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_outlooktaskgroup",
  "sampleKeys": ["AAMkADIyAAAhrbe-AAA="]
}-->
```http
PATCH https://graph.microsoft.com/beta/me/outlook/taskgroups/AAMkADIyAAAhrbe-AAA=
Content-type: application/json

{
  "name": "Personal Tasks",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var outlookTaskGroup = new OutlookTaskGroup
{
	Name = "Personal Tasks"
};

await graphClient.Me.Outlook.TaskGroups["{outlookTaskGroup-id}"]
	.Request()
	.UpdateAsync(outlookTaskGroup);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

