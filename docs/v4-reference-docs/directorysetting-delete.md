---
title: "Delete directorySetting"
description: "Delete a directory setting."
author: "adimitui"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Delete directorySetting

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a directory setting.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

### For all settings except the Consent Policy Settings object

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Directory.ReadWrite.All |

### For the Consent Policy Settings object

The following permissions are required to update the "Consent Policy Settings" **directorySetting** object.

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Policy.ReadWrite.Authorization    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Policy.ReadWrite.Authorization |

## HTTP request
<!-- { "blockType": "ignored" } -->
Delete a tenant-wide setting.
```http
DELETE /settings/{directorySettingId}
```

<!-- { "blockType": "ignored" } -->
Delete a group-specific setting.
```http
DELETE /groups/{groupId}/settings/{directorySettingId}
```

## Request headers
| Name       | Description|
|:---------------|:----------|
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
  "name": "delete_directorysetting"
}-->
```msgraph-interactive
DELETE https://graph.microsoft.com/beta/settings/3c105fc3-2254-4861-9e2d-d59e2126f3ef
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Settings["{directorySetting-id}"]
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
  "description": "Delete directorySetting",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


