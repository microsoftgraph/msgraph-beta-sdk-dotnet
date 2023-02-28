---
title: "Delete schemaExtension"
description: "Delete the definition of a schema extension."
ms.localizationpriority: medium
author: "dkershaw10"
doc_type: apiPageType
ms.prod: "extensions"
---

# Delete schemaExtension

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete the definition of a [schema extension](../resources/schemaextension.md). Only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the `InDevelopment` state. Deleting a schema extension definition does not affect accessing custom data that has been added to resource instances based on that definition.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

> [!NOTE]
> Additionally for the delegated flow, the signed-in user can only delete schemaExtensions they own (where the **owner** property of the schemaExtension is the **appId** of an application the signed-in user owns).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /schemaExtensions/{id}
```

## Request headers
| Name      |Description|
|:----------|:----------|
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
  "name": "delete_schemaextension"
}-->
```http
DELETE https://graph.microsoft.com/beta/schemaExtensions/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.SchemaExtensions["{schemaExtension-id}"]
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

## See also

- [Add custom data to resources using extensions](/graph/extensibility-overview)
- [Add custom data to groups using schema extensions](/graph/extensibility-schema-groups)

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Delete schemaExtension",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


