---
title: "Delete oAuth2PermissionGrant (a delegated permission grant)"
description: "Delete an oAuth2PermissionGrant, representing a delegated permission grant."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# Delete oAuth2PermissionGrant (a delegated permission grant)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an [oAuth2PermissionGrant](../resources/oauth2permissiongrant.md), representing a delegated permission grant.

When a delegated permission grant is deleted, the access it granted is revoked. Existing access tokens will continue to be valid for their lifetime, but new access tokens will not be granted for the delegated permissions identified in the deleted **oAuth2PermissionGrant**.

> [!NOTE]
> There may be two delegated permission grants authorizing an application to act on behalf of a user when calling an API. This can happen when a user consents for the application on their own behalf (creating an **oAuth2PermissionGrant** with **consentType** *Principal*, identifying the user) and then an administrator grants tenant-wide admin consent on behalf of all users (creating a second **oAuth2PermissionGrant** with **consentType** of *AllPrincipals*).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | DelegatedPermissionGrant.ReadWrite.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | DelegatedPermissionGrant.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
DELETE /oauth2PermissionGrants/{id}
```

## Request headers

| Name       | Description|
|:---------------|:--------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_oAuth2PermissionGrant",
  "sampleKeys": ["l5eW7x0ga0-WDOntXzHateQDNpSH5-lPk9HjD3Sarjk"]
}-->
```http
DELETE https://graph.microsoft.com/beta/oauth2PermissionGrants/l5eW7x0ga0-WDOntXzHateQDNpSH5-lPk9HjD3Sarjk
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Oauth2PermissionGrants["{oAuth2PermissionGrant-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete oAuth2PermissionGrant",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


