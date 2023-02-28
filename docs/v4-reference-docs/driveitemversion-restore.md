---
author: JeremyKelley
description: "Restore a previous version of a DriveItem to be the current version. This will create a new version with the contents of the previous version, but preserves all existing versions of the file."
ms.date: 09/10/2017
title: Restore a previous version
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Restore a previous version of a DriveItem

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Restore a previous version of a DriveItem to be the current version. This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

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
POST /drives/{driveId}/items/{itemId}/versions/{version-id}/restoreVersion
POST /groups/{groupId}/drive/items/{itemId}/versions/{version-id}/restoreVersion
POST /me/drive/items/{item-id}/versions/{version-id}/restoreVersion
POST /sites/{siteId}/drive/items/{itemId}/versions/{version-id}/restoreVersion
POST /users/{userId}/drive/items/{itemId}/versions/{version-id}/restoreVersion
```

### Request body

No request body is required.

## Example

This example restores a version of a file identified by `{item-id}` and `{version-id}`.


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "restore-item-version", "scopes": "files.readwrite", "target": "action" } -->

```http
POST /drives/{drive-id}/items/{item-id}/versions/{version-id}/restoreVersion
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Drives["{drive-id}"].Items["{driveItem-id}"].Versions["{driveItemVersion-id}"]
	.RestoreVersion()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

