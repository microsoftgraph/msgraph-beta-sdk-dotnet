---
title: "Get richLongRunningOperation"
description: "Read the properties of a richLongRunningOperation object."
author: "swapnil1993"
ms.localizationpriority: medium
ms.prod: "sites-and-lists"
doc_type: apiPageType
---

# Get richLongRunningOperation
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties of a [richLongRunningOperation](../resources/richlongrunningoperation.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /sites/{siteId}/operations/{richLongRunningOperation-ID}
GET /sites/{siteId}/lists/{listId}/operations/{richLongRunningOperation-ID}
```


## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [richLongRunningOperation](../resources/richlongrunningoperation.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_richlongrunningoperation"
}
-->
``` http
GET https://graph.microsoft.com/beta/sites/{siteId}/operations/{richLongRunningOperation-ID}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var richLongRunningOperation = await graphClient.Sites["{site-id}"].Operations["{richLongRunningOperation-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.richLongRunningOperation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "contentTypeCopy,0x010100298A15181454D84EBB62EDD7559FCBFE",
  "createdDateTime": "2022-01-24T16:28:23Z",
  "resourceId": "0x010100298A15181454D84EBB62EDD7559FCBFE",
  "resourceLocation": "https://graph.microsoft.com/beta/sites/5b3ea0e2-5fed-45ab-a8b8-7f7cd97189d6/contentTypes/0x010100298A15181454D84EBB62EDD7559FCBFE",
  "status": "succeeded",
  "type": "contentTypeCopy"
}
```

