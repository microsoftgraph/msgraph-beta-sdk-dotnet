---
title: "Create outlookTask"
description: "Create an Outlook task in the default task group (`My Tasks`) and default task folder (`Tasks`) in the user's mailbox."
ms.localizationpriority: medium
author: "mashriv"
ms.prod: "outlook"
doc_type: apiPageType
---

# Create outlookTask (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Outlook tasks API is deprecated and will stop returning data on August 20, 2022. Please use the new [To Do API](/graph/api/resources/todo-overview). For more information, see [To Do APIs in public preview](https://developer.microsoft.com/graph/blogs/the-new-improved-microsoft-graph-to-do-apis-are-now-in-public-preview/).


Create an Outlook task in the default task group (`My Tasks`) and default task folder (`Tasks`) in the user's mailbox.

The POST method always ignores the time portion of **startDateTime** and **dueDateTime** in the request body, and assumes the time 
to be always midnight in the specified time zone.

By default, this operation (and the GET, PATCH, and [complete](../api/outlooktask-complete.md) task operations) returns date-related properties in UTC. 
You can use the `Prefer: outlook.timezone` header to have all the date-related properties in the response represented in a time zone 
different than UTC.

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
POST /me/outlook/tasks
POST /users/{id|userPrincipalName}/outlook/tasks
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Prefer: outlook.timezone | Specifies the time zone for time properties in the response, which would be in UTC if this header is not specified. Optional.|

## Request body
In the request body, supply a JSON representation of [outlookTask](../resources/outlooktask.md) object.

## Response

If successful, this method returns `201 Created` response code and [outlookTask](../resources/outlooktask.md) object in the response body.

## Example
##### Request
The following example shows the use of the `Prefer: outlook.timezone` header. It creates a task, expresses **startDateTime** and **dueDateTime** in Eastern Standard Time (EST), and includes a `Prefer` header of Pacific Standard Time (PST).
<!-- {
  "blockType": "request",
  "name": "create_outlooktask_from_outlookuser"
}-->
```http
POST https://graph.microsoft.com/beta/me/outlook/tasks
Prefer: outlook.timezone="Pacific Standard Time"
Content-type: application/json

{
  "subject": "Shop for children's weekend",
  "startDateTime": {
      "dateTime": "2016-05-03T09:00:00",
      "timeZone": "Eastern Standard Time"
  },
  "dueDateTime":  {
      "dateTime": "2016-05-05T16:00:00",
      "timeZone": "Eastern Standard Time"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var outlookTask = new OutlookTask
{
	Subject = "Shop for children's weekend",
	StartDateTime = new DateTimeTimeZone
	{
		DateTime = "2016-05-03T09:00:00",
		TimeZone = "Eastern Standard Time"
	},
	DueDateTime = new DateTimeTimeZone
	{
		DateTime = "2016-05-05T16:00:00",
		TimeZone = "Eastern Standard Time"
	}
};

await graphClient.Me.Outlook.Tasks
	.Request()
	.Header("Prefer","outlook.timezone=\"Pacific Standard Time\"")
	.AddAsync(outlookTask);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

