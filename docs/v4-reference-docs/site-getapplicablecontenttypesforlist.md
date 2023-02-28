---
author: swapnil1993
title: "site: getApplicableContentTypesForList"
description: "Get site content types that can be added to a list."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "sites-and-lists"
---

# site: getApplicableContentTypesForList
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get [site][] [contentTypes][contentType] that can be added to a list.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /sites/{siteId}/getApplicableContentTypesForList
```

## Function parameters
In the request URL, provide the following query parameters with values.
The following table shows the parameters that can be used with this function.

|Parameter|Type|Description|
|-|-|-|
|listId| String | GUID of the list for which the applicable content types need to be fetched. Required. |

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

To list only custom content types, use `$filter=isBuiltin eq false`.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [contentType](../resources/contenttype.md) collection in the response body.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "site_getapplicablecontenttypesforlist"
}
-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/sites/{siteId}/getApplicableContentTypesForList(listId='{list-id}')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getApplicableContentTypesForList = await graphClient.Sites["{site-id}"]
	.GetApplicableContentTypesForList("{list-id}")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.contentType)"
}
-->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "value": [
    {
        "id":"0x",
        "description":"",
        "group":"_Hidden",
        "hidden":false,
        "name":"System",
        "base": {
            "name": "System",
            "id": "0x"
        }
    },
    {
        "id":"0x00A7470EADF4194E2E9ED1031B61DA0884",
        "name": "docSet",
        "description": "custom docset",
        "hidden":false,
        "base": {
            "name": "Document Set",
            "id": "0x0120D520"
        },
        "group": "Custom Content Types"
    }
  ]
}
```

[contentType]: ../resources/contentType.md
[site]: ../resources/site.md
