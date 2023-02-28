---
title: "Delete outlookTaskFolder"
description: "Delete the specified Outlook task folder."
author: "mashriv"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Delete outlookTaskFolder (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Outlook tasks API is deprecated and will stop returning data on August 20, 2022. Please use the new [To Do API](/graph/api/resources/todo-overview). For more information, see [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/).


Delete the specified Outlook task folder.
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
DELETE /me/outlook/taskFolders/{id}
DELETE /me/outlook/taskGroups/{id}/taskFolders/{id}
DELETE /users/{id|userPrincipalName}/outlook/taskFolders/{id}
DELETE /users/{id|userPrincipalName}/outlook/taskGroups/{id}/taskFolders/{id}
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_outlooktaskfolder",
  "sampleKeys": ["AAMkADIyAAAhrbPXAAA="]
}-->
```http
DELETE https://graph.microsoft.com/beta/me/outlook/taskFolders/AAMkADIyAAAhrbPXAAA=
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Outlook.TaskFolders["{outlookTaskFolder-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

