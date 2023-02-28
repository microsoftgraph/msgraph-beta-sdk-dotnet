---
title: "List oauth2PermissionGrants"
description: "Retrieve a list of oAuth2PermissionGrant objects, representing delegated permission grants."
ms.localizationpriority: high
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# List oauth2PermissionGrants

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [oAuth2PermissionGrant](../resources/oAuth2PermissionGrant.md) entities, which represent delegated permissions granted to enable a client application to access an API on behalf of the user.

> [!NOTE]
> Querying the delegated permission grants for a user will only return delegated permissions grants that are specifically for the given user. Delegated permissions granted on behalf of all users in the organization are _not_ included in the response.

> [!NOTE]
> This request might have replication delays for delegated permission grants that were recently created, updated, or deleted.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.ReadBasic.All, Directory.Read.All, DelegatedPermissionGrant.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Directory.Read.All, DelegatedPermissionGrant.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /me/oauth2PermissionGrants
GET /users/{id | userPrincipalName}/oauth2PermissionGrants
```

## Optional query parameters

This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Name           | Description                |
|:---------------|:---------------------------|
| Authorization  | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [oAuth2PermissionGrant](../resources/oauth2permissiongrant.md) objects in the response body.

## Examples

### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_user_oAuth2PermissionGrants"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/users/7d54cb02-aaa3-4016-9f9c-a4b49422dd9b/oauth2PermissionGrants
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var oauth2PermissionGrants = await graphClient.Users["{user-id}"].Oauth2PermissionGrants
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Here is an example of the response.

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
  "value": [
    {
      "clientId": "85477313-ea43-4c7d-b8a4-54fed35d0b60",
      "consentType": "Principal",
      "expiryTime": "2021-09-19T07:06:52.6843299Z",
      "id": "E3NHhUPqfUy4pFT-010LYFo5-ycA-_5Fhl7nHbaJ7qACy1R9o6oWQJ-cpLSUIt2b",
      "principalId": "7d54cb02-aaa3-4016-9f9c-a4b49422dd9b",
      "resourceId": "27fb395a-fb00-45fe-865e-e71db689eea0",
      "scope": " Contacts.ReadWrite openid profile",
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
  "description": "List oAuth2PermissionGrants",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


