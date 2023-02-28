---
title: "Delete a historyItem"
description: "Delete an existing history item for an existing user activity."
ms.localizationpriority: medium
ms.prod: "project-rome"
doc_type: apiPageType
author: "ailae"
---

# Delete a historyItem

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an existing history item for an existing user activity.

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
DELETE /me/activities/{id}/historyItems/{id}
```

## Request headers

|Name | Type | Description|
|:----|:-----|:-----------|
|Authorization | string | Bearer {token}. Required.|

## Request body

No request body.

## Response

If successful, this method returns the `204 No Content` response code if the history item was deleted.

## Example

##### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_historyItem",
  "sampleKeys": ["13881113971988980728", "390e06e2-7e5b-4133-8014-fac7ac5991af"]
}-->

```http
PUT https://graph.microsoft.com/beta/me/activities/13881113971988980728/historyItems/390e06e2-7e5b-4133-8014-fac7ac5991af
```

