---
title: "driveItem: restore"
description: "Restore a driveItem that has been deleted and is currently in the recycle bin."
ms.localizationpriority: medium
author: "JeremyKelley"
ms.prod: files
doc_type: "apiPageType"
---

# driveItem: restore

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Restore a [driveItem](../resources/driveitem.md) that has been deleted and is currently in the recycle bin. 

>**Note**: This functionality is currently only available for OneDrive Personal.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not supported. |
| Delegated (personal Microsoft account) | Files.ReadWrite.All |
| Application                            | Files.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /me/drive/items/{item-id}/restore
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token} |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter     | Type                                         | Description |
|:--------------|:---------------------------------------------|:------------|
|parentReference|[ItemReference](../resources/itemreference.md)| Optional. Reference to the parent item the deleted item will be restored to. |
|name           |String                                        | Optional. The new name for the restored item. If this isn't provided, the same name will be used as the original. |

## Response

If successful, this method returns `200 OK` response code and the restored [driveItem](../resources/driveitem.md) object in the response body.

## Examples

The following example shows how to call this API.

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "restore-item",
  "scopes": "files.readwrite",
  "target": "action"
}-->

```http
POST https://graph.microsoft.com/beta/me/drive/items/{item-id}/restore
Content-type: application/json

{
  "parentReference": {
    "id": "String",
  },
  "name": "String"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var parentReference = new ItemReference
{
	Id = "String"
};

var name = "String";

await graphClient.Me.Drive.Items["{driveItem-id}"]
	.Restore(parentReference,name)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.driveItem"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "1312abc!1231",
  "name": "new-restored-item-name.txt",
  "size": 19121,
  "lastModifiedDateTime": "2017-12-12T10:40:59Z"
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Restore a DriveItem.",
  "keywords": "retore,item,driveitem",
  "section": "documentation",
  "tocPath": "Items/Restore"
}-->


