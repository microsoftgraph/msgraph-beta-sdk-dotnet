---
title: "Delete directoryObject"
description: "Delete directoryObject."
author: "keylimesoda"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Delete directoryObject

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a directory object, for example, a group, user, application, or service principal.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### Delete a user

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | User.ReadWrite.All |

### Delete a group

| Permission type                        | Permissions (from least to most privileged)                                                 |
| :------------------------------------- | :------------------------------------------------------------------------------------------ |
| Delegated (work or school account)     | Group.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                                                                              |
| Application                            | Group.ReadWrite.All                             |

### Delete an application or service principal

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Application.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
DELETE /directoryObjects/{id}

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

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_directoryobject"
}-->
```http
DELETE https://graph.microsoft.com/beta/directoryObjects/ffab4dce-9b82-49a6-b7c7-1a143106598c
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.DirectoryObjects["{directoryObject-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

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
  "description": "Delete directoryObject",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


