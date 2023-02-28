---
author: JeremyKelley
description: "Check in a checked out DriveItem resource, which makes the version of the document available to others."
title: "driveItem: checkin"
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# driveItem: checkin

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Check in a checked out **driveItem** resource, which makes the version of the document available to others.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Files.ReadWrite, Files.ReadWrite.All, Sites.ReadWrite.All    |
|Delegated (personal Microsoft account) | Files.ReadWrite, Files.ReadWrite.All    |
|Application | Files.ReadWrite.All, Sites.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /drives/{driveId}/items/{itemId}/checkin
POST /groups/{groupId}/drive/items/{itemId}/checkin
POST /me/drive/items/{item-id}/checkin
POST /sites/{siteId}/drive/items/{itemId}/checkin
POST /users/{userId}/drive/items/{itemId}/checkin
```

### Request body

In the request body, provide a JSON object with the following parameters.


|   Name    | Value  |                                                Description                                                |
| :-------- | :----- | :-------------------------------------------------------------------------------------------------------- |
| checkInAs | string | Optional. The status of the document after the check-in operation is complete. Can be `published` or unspecified. |
| comment   | string | A check-in comment that is associated with the version.                                                   |

## Example

This example checks in a file identified by `{item-id}`.


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "checkin-item", "scopes": "files.readwrite", "target": "action" } -->

```http
POST /drives/{drive-id}/items/{item-id}/checkin
Content-Type: application/json

{
  "comment": "Updating the latest guidelines"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var comment = "Updating the latest guidelines";

await graphClient.Drives["{drive-id}"].Items["{driveItem-id}"]
	.Checkin(null,comment)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

