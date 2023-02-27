---
title: "outlookTask: complete"
description: "Complete an Outlook task which sets the **completedDateTime** property to the current date, "
ms.localizationpriority: medium
author: "mashriv"
ms.prod: "outlook"
doc_type: apiPageType
---

# outlookTask: complete (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Outlook tasks API is deprecated and will stop returning data on August 20, 2022. Please use the new [To Do API](/graph/api/resources/todo-overview). For more information, see [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/).


Complete an Outlook task which sets the **completedDateTime** property to the current date, and the **status** property to `completed`.

If you are completing a task in a recurring series, in the response, the task collection will contain the completed task in the series, and the next task in the series.

The **completedDateTime** property represents the date when the task is finished. The time portion of **completedDateTime** is set to midnight UTC by default.

By default, this operation (and the POST, GET, and PATCH task operations) returns date-related properties in UTC. You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone different than UTC.

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
POST /me/outlook/tasks/{id}/complete
POST /users/{id|userPrincipalName}/outlook/tasks/{id}/complete
```

## Request headers

| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Prefer: outlook.timezone | Specifies the time zone for time properties in the response, which would be in UTC if this header is not specified. Optional.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns `200 OK` response code and the [outlookTask](../resources/outlooktask.md) object in the response body.

## Example

The following example marks the specified task as complete. It specifies Pacific Standard Time (PST) in the `Prefer: outlook.timezone` header.

### Request

Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "outlooktask_complete",
  "sampleKeys": ["AAMkADA1MT15rfAAA="]
}-->

```http
POST https://graph.microsoft.com/beta/me/outlook/tasks('AAMkADA1MT15rfAAA=')/complete
Prefer: outlook.timezone="Pacific Standard Time"
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Outlook.Tasks["{outlookTask-id}"]
	.Complete()
	.Request()
	.Header("Prefer","outlook.timezone=\"Pacific Standard Time\"")
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Here is an example of the response. The **completedDateTime** and other date-related properties in the response are expressed in PST.

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.outlookTask",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "AAMkADA1MT15rfAAA=",
      "createdDateTime": "2016-04-21T22:44:01.2012012-07:00",
      "lastModifiedDateTime": "2016-04-22T19:28:38.5300447-07:00",
      "changeKey": "1/KC9Vmu40G3DwB6Lgs7MAAAIW9XYQ==",
      "categories": [
      ],
      "assignedTo": null,
      "body": {
          "contentType": "text",
          "content": ""
      },
      "completedDateTime": {
          "dateTime": "2016-04-22T00:00:00.0000000",
          "timeZone": "Pacific Standard Time"
      },
      "dueDateTime": {
          "dateTime": "2016-04-25T00:00:00.0000000",
          "timeZone": "Pacific Standard Time"
      },
      "hasAttachments":false,
      "importance": "normal",
      "isReminderOn": false,
      "owner": "Administrator",
      "parentFolderId": "AQMkADA1MTIBEgAAAA==",
      "recurrence": null,
      "reminderDateTime": null,
      "sensitivity": "normal",
      "startDateTime": {
          "dateTime": "2016-04-21T00:00:00.0000000",
          "timeZone": "Pacific Standard Time"
      },
      "status": "completed",
      "subject": "Shop for dinner"
    }
  ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "outlookTask: complete",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


