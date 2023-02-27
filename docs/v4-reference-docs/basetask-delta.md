---
title: "baseTask: delta"
description: "Get a set of baseTask resources that have been added, deleted, or updated in a specific baseTaskList."
author: "devindrajit"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# baseTask: delta (deprecated)
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
Get a set of [baseTask](../resources/basetask.md) resources that have been added, deleted, or updated in a specific [baseTaskList](../resources/basetasklist.md).

A **delta** function call for **baseTask** resources in a **baseTaskList** is similar to a GET request, except that by appropriately applying [state tokens](/graph/delta-query-overview) in one or more of these calls, you can query for incremental changes in the **baseTask** in that **baseTaskList**. This allows you to maintain and synchronize a local store of a user's **baseTask** resources without having to fetch the entire set from the server every time.

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
GET /me/tasks/lists/{baseTaskListId}/tasks/delta
GET /users/{userId|userPrincipalName}/tasks/lists/{baseTaskListId}/tasks/delta
```

## Query parameters

Tracking changes in a **baseTask** collection incurs a round of one or more **delta** function calls. If you use any query parameter 
(other than `$deltatoken` and `$skiptoken`), you must specify 
it in the initial **delta** request. Microsoft Graph automatically encodes any specified parameters 
into the token portion of the `@odata.nextLink` or `@odata.deltaLink` URL provided in the response. 
You only need to specify any desired query parameters once upfront. 
In subsequent requests, simply copy and apply the `@odata.nextLink` or `@odata.deltaLink` URL from the previous response, as that URL already 
includes the encoded, desired parameters.

| Query parameter    | Type |Description|
|:---------------|:--------|:----------|
| $deltatoken | string | A [state token](/graph/delta-query-overview) returned in the `@odata.deltaLink` URL of the previous **delta** function call for the same baseTask collection, indicating the completion of that round of change tracking. Save and apply the entire `@odata.deltaLink` URL including this token in the first request of the next round of change tracking for that collection.|
| $skiptoken | string | A [state token](/graph/delta-query-overview) returned in the `@odata.nextLink` URL of the previous **delta** function call, indicating there are further changes to be tracked in the same baseTask collection. |

### OData query parameters

- Delta query support `$filter` `$top`, and `$expand` query parameters for **baseTask**. 
- There is no support for `$search`.

## Request headers
| Name       | Type | Description |
|:---------------|:----------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Prefer | string  | odata.maxpagesize={x}. Optional. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [baseTask](../resources/basetask.md) collection in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "basetask_delta",
  "sampleKeys": ["AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt-6oC2JgAQCQ47jE5P--SoVECqTdM17RAAAB4mDIAAA="]
}
-->
``` http
GET https://graph.microsoft.com/beta/me/tasks/lists/AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt-6oC2JgAQCQ47jE5P--SoVECqTdM17RAAAB4mDIAAA=/tasks/delta
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delta = await graphClient.Me.Tasks.Lists.AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt-6oC2JgAQCQ47jE5P--SoVECqTdM17RAAAB4mDIAAA=.Tasks.Delta
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
  "@odata.type": "Collection(microsoft.graph.baseTask)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(baseTask)",
    "@odata.deltaLink": "https://graph.microsoft.com/beta/me/tasks/lists/AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt-6oC2JgAQCQ47jE5P--SoVECqTdM17RAAAB4mDIAAA=/tasks/delta?$deltatoken=AVCnFFj2r7PtnjtkD-g_6dgDSPbEboZhaMYEytpd57pcJMrR9oGkCIjK_dyVkhNB1EQn1zcQt7YZTwCS0V5MNQo6Iy0-T0csAkLZTMlbiII.lVEHqD5xdDrH30csYKP6tEvoYa3WtFhmYLtKBSxCPpQ",
    "value": [
        {
            "@odata.type": "#microsoft.graph.task",
            "@odata.etag": "W/\"kOO4xOT//0qFRAqk3TNe0QAAAymRBQ==\"",
            "importance": "normal",
            "status": "notStarted",
            "displayName": "Read documentation",
            "createdDateTime": "2021-11-15T13:16:53.0831814Z",
            "lastModifiedDateTime": "2021-11-15T13:17:08.8273666Z",
            "id": "AAkALgAAAAAAHYQDEapmEc2byACqAC-EWg0AkOO4xOT--0qFRAqk3TNe0QAAAy35RwAA",
            "body": {
                "content": "",
                "contentType": "text"
            },
            "parentList": {
                "id": "AAMkAGVjMzJmMWZjLTgyYjgtNGIyNi1hOGQ0LWRjMjNmMGRmOWNiYQAuAAAAAAAboFsPFj7gQpLAt-6oC2JgAQCQ47jE5P--SoVECqTdM17RAAAB4mDIAAA="
            }
        }
    ]
}
```

