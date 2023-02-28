---
title: "Get documentSetVersion"
description: "Read the properties and relationships of a documentSetVersion object."
author: "swapnil1993"
ms.localizationpriority: medium
ms.prod: "sites-and-lists"
doc_type: apiPageType
---

# Get documentSetVersion
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [documentSetVersion](../resources/documentsetversion.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)| Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All|
|Delegated (personal Microsoft account)| Not supported. |
|Application| Sites.Read.All, Sites.ReadWrite.All, Sites.Manage.All, Sites.FullControl.All, Sites.Selected|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /sites/{siteId}/lists/{listId}/items/{itemId}/documentSetVersions/{documentSetVersionId}
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

If successful, this method returns a `200 OK` response code and a [documentSetVersion](../resources/documentsetversion.md) object in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_documentsetversion",
  "sampleKeys": ["2", "1", "root", "Documents"]
}
-->
``` http
GET https://graph.microsoft.com/beta/sites/root/lists/Documents/items/2/documentSetVersions/1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var documentSetVersion = await graphClient.Sites["{site-id}"].Lists["{list-id}"].Items["{listItem-id}"].DocumentSetVersions["{documentSetVersion-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "name": "get_documentsetversion",
  "truncated": true,
  "@odata.type": "microsoft.graph.documentSetVersion"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "id": "1",
    "lastModifiedDateTime": "2022-04-05T04:53:42Z",
    "comment": "v1",
    "createdDateTime": "2022-04-05T04:53:42Z",
    "shouldCaptureMinorVersion": false,
    "lastModifiedBy": {
        "user": {
            "displayName": "Tenant Admin User",
            "email": "admin@contoso.sharepoint.com"
        }
    },
    "items": [
        {
            "itemId": "a5d83ae7-8c3e-4a2c-bc3e-8f276db857bf",
            "versionId": "1.0"
        }
    ],
    "createdBy": {
        "user": {
            "displayName": "Tenant Admin User",
            "email": "admin@contoso.sharepoint.com"
        }
    }
}
```

