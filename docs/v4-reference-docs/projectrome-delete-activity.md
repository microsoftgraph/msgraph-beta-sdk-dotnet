---
title: "Delete an activity"
description: "Delete an existing user activity for your app."
ms.localizationpriority: medium
ms.prod: "project-rome"
doc_type: apiPageType
author: "ailae"
---

# Delete an activity

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an existing user activity for your app.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | UserActivity.ReadWrite.CreatedByApp    |
|Delegated (personal Microsoft account) | UserActivity.ReadWrite.CreatedByApp    |
|Application | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /me/activities/{id}
```

## Request headers

|Name | Type | Description|
|:----|:-----|:-----------|
|Authorization | string | Bearer {token}. Required.|

## Request body

No request body.

## Response

If successful, this method returns the `204 No Content` response code if the activity was deleted.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_activity",
  "sampleKeys": ["13881113971988980728"]
}-->

```http
DELETE https://graph.microsoft.com/beta/me/activities/13881113971988980728
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.Activities["{userActivity-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2017-06-07 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete activity",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


