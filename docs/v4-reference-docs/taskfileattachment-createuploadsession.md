---
title: "taskFileAttachment: createUploadSession"
description: "Create an upload session to iteratively upload ranges of a file as an attachment to a Microsoft To Do task."
author: "avijityadav"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# taskFileAttachment: createUploadSession
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create an upload session to iteratively upload ranges of a file as an attachment to a [todoTask](../resources/todotask.md).

As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries. The request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded. This allows the transfer to be resumed, in case the network connection is dropped during the upload.

The following are the steps to attach a file to a Microsoft To Do task using an upload session:

1. Create an upload session.
2. Within that upload session, iteratively upload ranges of bytes (up to 4 MB each time) until all the bytes of the file have been uploaded, and the file is attached to the **todoTask**.
3. Optional: Delete the upload session.

>**Note:** Use this approach to attach a file of any supported size between 0 MB to 25 MB.

For an example that describes the end-to-end attachment process, see [attach files to a To Do task](/graph/todo-attachments).

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
POST /me/todo/lists/{id}/tasks/{id}/attachments/createUploadSession
POST /users/{id}/todo/lists/{id}/tasks/{id}/attachments/createUploadSession
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the parameters.

The following table shows the parameter that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|attachmentInfo|[attachmentInfo](../resources/attachmentinfo.md)|Represents attributes of the item to be uploaded and attached. At minimum, specify the attachment type (`file`), a name, and the size of the file.|


## Response

If successful, this action returns a `200 OK` response code and a new [uploadSession](../resources/uploadsession.md) in the response body.

## Examples

### Request
The following is an example of a request to create an upload session.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "attachmentbasethis.createuploadsession",
  "sampleKeys": ["AAMDiFkfh=", "AAMkADliMm="]
}
-->
``` http
POST https://graph.microsoft.com/beta/me/todo/lists/AAMDiFkfh=/tasks/AAMkADliMm=/attachments/createUploadSession
Content-Type: application/json

{
  "attachmentInfo": {
    "attachmentType": "file",
    "name": "flower",
    "size": 3483322
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachmentInfo = new AttachmentInfo
{
	AttachmentType = AttachmentType.File,
	Name = "flower",
	Size = 3483322
};

await graphClient.Me.Todo.Lists["{todoTaskList-id}"].Tasks["{todoTask-id}"].Attachments
	.CreateUploadSession(attachmentInfo)
	.Request()
	.PostAsync();

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
  "@odata.type": "microsoft.graph.uploadSession"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.uploadSession",
    "uploadUrl": "https://graph.microsoft.com/beta/users/6f9a2a92-8527-4d64-837e-b5312852f36d/todo/lists/AAMDiFkfh=/tasks/AAMkADliMm=/attachmentSessions/AAMkADliMm=",
    "expirationDateTime": "2022-06-09T10:45:27.4324526Z",
    "nextExpectedRanges": [
        "0-"
    ]
}
```
