---
title: "baseTaskList: delta"
description: "Get a set of baseTaskList resources that have been added, deleted, or removed in Microsoft To Do."
author: "devindrajit"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# baseTaskList: delta (deprecated)
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
>The to-do API set built on [baseTask](/graph/api/resources/basetask?view=graph-rest-beta&preserve-view=true) is deprecated as of May 31, 2022, and will stop returning data on August 31, 2022. Please use the API set built on [todoTask](/graph/api/resources/todotask?view=graph-rest-beta&preserve-view=true). 
Get a set of [baseTaskList](../resources/basetasklist.md) resources that have been added, deleted, or removed in Microsoft To Do.

A **delta** function call for **baseTaskList** is similar to a GET request, except that by appropriately applying [state tokens](/graph/delta-query-overview) in one or more of these calls, 
you can query for incremental changes in the **baseTaskList**. This allows you to maintain and synchronize a local store of a user's **baseTaskList** without having to fetch all the **baseTaskList** from the server every time.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Tasks.Read, Tasks.ReadWrite|
|Delegated (personal Microsoft account)|Tasks.Read, Tasks.ReadWrite|
|Application|Not supported|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/tasks/lists/delta
GET /users/{userId|userPrincipalName}/tasks/lists/delta
```

## Query parameters

Tracking changes in **baseTaskList** resources incurs a round of one or more **delta** function calls. If you use any query parameter 
(other than `$deltatoken` and `$skiptoken`), you must specify 
it in the initial **delta** request. Microsoft Graph automatically encodes any specified parameters 
into the token portion of the `@odata.nextLink` or `@odata.deltaLink` URL provided in the response. 
You only need to specify any desired query parameters once upfront. 
In subsequent requests, simply copy and apply the `@odata.nextLink` or `@odata.deltaLink` URL from the previous response, as that URL already 
includes the encoded, desired parameters.

| Query parameter    | Type |Description|
|:---------------|:--------|:----------|
| $deltatoken | string | A [state token](/graph/delta-query-overview) returned in the `@odata.deltaLink` URL of the previous **delta** function call for the same **baseTaskList** collection, indicating the completion of that round of change tracking. Save and apply the entire `@odata.deltaLink` URL including this token in the first request of the next round of change tracking for that collection.|
| $skiptoken | string | A [state token](/graph/delta-query-overview) returned in the `@odata.nextLink` URL of the previous **delta** function call, indicating there are further changes to be tracked in the same **baseTaskList** collection. |

### OData query parameters

- Delta query support `$filter` `$top`, and `$expand` query parameters for **baseTaskList**. 
- There is no support for `$search`. 

## Request headers
| Name       | Type | Description |
|:---------------|:----------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Prefer | string  | odata.maxpagesize={x}. Optional. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [baseTaskList](../resources/basetasklist.md) collection in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "basetasklist_delta"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/tasks/lists/delta
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delta = await graphClient.Me.Tasks.Lists.Delta
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.baseTaskList)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(baseTaskList)",
    "@odata.nextLink": "https://graph.microsoft.com/beta/me/tasks/lists/delta?$skiptoken=AVCnFFj2r7PtnjtkD-g_6Y5Ntek1m4V",
    "value": [
        {
            "@odata.type": "#microsoft.graph.wellKnownTaskList",
            "@odata.etag": "W/\"kOO4xOT//0qFRAqk3TNe0QAAAAAAkw==\"",
            "wellKnownListName": "defaultList",
            "displayName": "Tasks",
            "id": "AQMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNm"
        }
    ]
}
```

