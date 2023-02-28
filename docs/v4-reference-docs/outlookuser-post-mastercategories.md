---
title: "Create Outlook category"
description: "Create an outlookCategory object in the user's master list of categories."
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# Create Outlook category

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create an [outlookCategory](../resources/outlookcategory.md) object in the user's master list of categories.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | MailboxSettings.ReadWrite    |
|Delegated (personal Microsoft account) | MailboxSettings.ReadWrite   |
|Application | MailboxSettings.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /me/outlook/masterCategories
POST /users/{id|userPrincipalName}/outlook/masterCategories
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of an [outlookCategory](../resources/outlookcategory.md) object.

## Response

If successful, this method returns a `201 Created` response code and an [outlookCategory](../resources/outlookcategory.md) object in the response body.

## Example
### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_outlookcategory_from_outlookuser"
}-->
```http
POST https://graph.microsoft.com/beta/me/outlook/masterCategories
Content-type: application/json
Content-Length: 70

{
   "displayName": "Project expenses",
   "color": "preset9"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var outlookCategory = new OutlookCategory
{
	DisplayName = "Project expenses",
	Color = CategoryColor.Preset9
};

await graphClient.Me.Outlook.MasterCategories
	.Request()
	.AddAsync(outlookCategory);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response. 
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.outlookCategory"
} -->
```http
HTTP/1.1 201 Created
Content-type: application/json

{
   "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('8ae6f565-0d7f-4ead-853e-7db94c912a1f')/outlook/masterCategories/$entity",
   "id": "bac262b7-485d-4739-b436-e31467d64fac",
   "displayName": "Project expenses",
   "color": "preset9"
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create outlookCategory",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


