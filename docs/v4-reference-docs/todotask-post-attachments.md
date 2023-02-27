---
title: "Create taskFileAttachment"
description: "Add a new taskFileAttachment object to a todoTask."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Create taskFileAttachment
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a new [taskFileAttachment](../resources/taskfileattachment.md) object to a [todoTask](../resources/todotask.md).

This operation limits the size of the attachment you can add to under 3 MB. If the size of the file attachments is more than 3 MB, [create an upload session](../api/taskfileattachment-createuploadsession.md) to upload the attachments.


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
POST /me/todo/lists/{id}/tasks/{id}/attachments
POST /users/{id}/todo/lists/{id}/tasks/{id}/attachments
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [taskFileAttachment](../resources/taskfileattachment.md) object.

When you create a file attachment, include `"@odata.type": "#microsoft.graph.taskFileAttachment"` and the required properties.

|Property|Type|Description|
|:---|:---|:---|
|contentBytes|Binary|The base64-encoded contents of the file. Required.|
|contentType|String|The content type of the attachment. |
|name|String|The name of the text displayed under the icon that represents the embedded attachment. This does not need to be the actual file name. Required. |
|size|Int32|The size in bytes of the attachment. |

## Response

If successful, this method returns a `201 Created` response code and a [taskFileAttachment](../resources/taskfileattachment.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_taskFileAttachment_from_",
  "sampleKeys": ["AAMkpsDRVK=", "AAKdfjhgsjhgJ="]
}
-->
``` http
POST https://graph.microsoft.com/beta/me/todo/lists/AAMkpsDRVK=/tasks/AAKdfjhgsjhgJ=/attachments
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.taskFileAttachment",
  "name": "smile",
  "contentBytes": "a0b1c76de9f7=",
  "contentType": "image/gif"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachmentBase = new TaskFileAttachment
{
	Name = "smile",
	ContentBytes = Convert.FromBase64String("a0b1c76de9f7="),
	ContentType = "image/gif"
};

await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks["{todoTask-id}"].Attachments
	.Request()
	.AddAsync(attachmentBase);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.taskFileAttachment"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.taskFileAttachment",
  "id": "AAMkADNkN2R",
  "lastModifiedDateTime": "2017-01-26T08:48:28Z",
  "name": "smile",
  "contentType": "image/gif",
  "size": 1008
}
```

