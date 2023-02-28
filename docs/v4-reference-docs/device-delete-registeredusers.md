---
title: "Delete registeredUsers"
description: "Remove a user as a registered user of the device."
ms.localizationpriority: medium
author: "michaelrm97"
ms.prod: "directory-management"
doc_type: apiPageType
---

# Delete registeredUser

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Remove a user as a registered user of the device.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.AccessAsUser.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |


When an application queries a relationship that returns a directoryObject type collection, if it does not have permission to read a certain derived type (like device), members of that type are returned but with limited information. With this behaviour applications can request the least privileged permissions they need, rather than rely on the set of *Directory.** permissions. For details, see [Limited information returned for inaccessible member objects](/graph/permissions-overview#limited-information-returned-for-inaccessible-member-objects).

The calling user must also be in one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference): *Global Administrator*, *Intune Administrator*, or *Windows 365 Administrator*.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /devices/{id}/registeredUsers/{id}/$ref
```
> [!CAUTION]
> If `/$ref` is not appended to the request and the calling app has permissions to manage the user who is a registered user of the device, the user will also be deleted from Azure Active Directory (Azure AD); otherwise, a `403 Forbidden` error is returned. You can restore deleted users through the [Restore deleted items API](directory-deleteditems-restore.md).

## Request headers
| Name       | Description|
|:-----------|:------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_registeredusers"
}-->
```msgraph-interactive
DELETE https://graph.microsoft.com/beta/devices/{id}/registeredUsers/{id}/$ref
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Devices["{device-id}"].RegisteredUsers["{directoryObject-id}"].Reference
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

