---
title: "List oAuth2PermissionGrants (delegated permission grants)"
description: "Retrieve a list of oauth2PermissionGrant objects, representing delegated permission grants."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# List oauth2PermissionGrants (delegated permission grants)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [oAuth2PermissionGrant](../resources/oauth2permissiongrant.md) objects, representing delegated permissions which have been granted for client applications to access APIs on behalf of signed-in users.

> [!NOTE]
> This request might have replication delays for delegated permission grants that were recently created, updated, or deleted. This delay will be minimized if a filter on `clientId` is specified.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.Read.All, DelegatedPermissionGrant.ReadWrite.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Directory.Read.All, DelegatedPermissionGrant.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /oauth2PermissionGrants
```

## Optional query parameters

This method supports the `$filter` (`eq`) [OData query parameter](/graph/query-parameters) to help customize the response.

## Request headers

| Name | Description |
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [oAuth2PermissionGrant](../resources/oauth2permissiongrant.md) objects in the response body.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_oauth2permissiongrants"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/oauth2PermissionGrants
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var oauth2PermissionGrants = await graphClient.Oauth2PermissionGrants
	.Request()
	.GetAsync();

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
  "@odata.type": "microsoft.graph.oAuth2PermissionGrant",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#oauth2PermissionGrants",
    "value": [
        {
            "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/oauth2PermissionGrants/AVs6JuUDjkCFV7q2gd8QTPimBBgj5iBFj0C6GwwRxC0",
            "clientId": "263a5b01-03e5-408e-8557-bab681df104c",
            "consentType": "AllPrincipals",
            "expiryTime": "2022-01-29T10:32:59.5138373Z",
            "id": "AVs6JuUDjkCFV7q2gd8QTPimBBgj5iBFj0C6GwwRxC0",
            "principalId": null,
            "resourceId": "1804a6f8-e623-4520-8f40-ba1b0c11c42d",
            "scope": "User.Read Group.ReadWrite.All",
            "startTime": "0001-01-01T00:00:00Z"
        },
        {
            "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/oauth2PermissionGrants/AVs6JuUDjkCFV7q2gd8QTOQDNpSH5-lPk9HjD3Sarjk",
            "clientId": "263a5b01-03e5-408e-8557-bab681df104c",
            "consentType": "AllPrincipals",
            "expiryTime": "2031-08-02T14:05:12.575045Z",
            "id": "AVs6JuUDjkCFV7q2gd8QTOQDNpSH5-lPk9HjD3Sarjk",
            "principalId": null,
            "resourceId": "943603e4-e787-4fe9-93d1-e30f749aae39",
            "scope": "Tasks.ReadWrite Files.ReadWrite.All Files.ReadWrite Contacts.ReadWrite Calendars.ReadWrite Mail.ReadWrite Directory.AccessAsUser.All Directory.ReadWrite.All Group.ReadWrite.All Group.Read.All User.ReadWrite Mail.ReadWrite.Shared Mail.Send.Shared Calendars.ReadWrite.Shared Contacts.ReadWrite.Shared Tasks.ReadWrite.Shared Sites.ReadWrite.All Files.ReadWrite.AppFolder Files.ReadWrite.Selected Notes.ReadWrite Notes.ReadWrite.All MailboxSettings.ReadWrite DeviceManagementManagedDevices.PrivilegedOperations.All DeviceManagementManagedDevices.ReadWrite.All DeviceManagementRBAC.ReadWrite.All DeviceManagementApps.ReadWrite.All DeviceManagementConfiguration.ReadWrite.All openid profile Directory.Read.All User.Read.All User.ReadWrite.All ChannelMember.ReadWrite.All DeviceManagementServiceConfiguration.ReadWrite.All",
            "startTime": "0001-01-01T00:00:00Z"
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List oauth2PermissionGrants",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


