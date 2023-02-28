---
title: "Update page"
description: "Update the content of a OneNote page."
ms.localizationpriority: medium
author: "jewan-microsoft"
ms.prod: "onenote"
doc_type: apiPageType
---

# Update page

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the content of a OneNote page.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Notes.ReadWrite, Notes.ReadWrite.All    |
|Delegated (personal Microsoft account) | Notes.ReadWrite    |
|Application | Notes.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/onenote/pages/{id}/content
PATCH /users/{id | userPrincipalName}/onenote/pages/{id}/content
PATCH /groups/{id}/onenote/pages/{id}/content
PATCH /sites/{id}/onenote/pages/{id}/content
```
## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required. |
| Content-Type | string | `application/json` |

## Request body
In the request body, supply an array of [patchContentCommand](../resources/patchcontentcommand.md) objects that represent the changes to the page. For more information and examples, see [Update OneNote page content](/graph/onenote-update-page).

## Response

If successful, this method returns a `204 No Content` response code.  No JSON data is returned for a PATCH request.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_page"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/onenote/pages/{id}/content
Content-type: application/json

[
   {
    'target':'#para-id',
    'action':'insert',
    'position':'before',
    'content':'<img src="image-url-or-part-name" alt="image-alt-text" />'
  }, 
  {
    'target':'#list-id',
    'action':'append',
    'content':'<li>new-page-content</li>'
  }
]
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(@"[
   {
    'target':'#para-id',
    'action':'insert',
    'position':'before',
    'content':'<img src=""image-url-or-part-name"" alt=""image-alt-text"" />'
  }, 
  {
    'target':'#list-id',
    'action':'append',
    'content':'<li>new-page-content</li>'
  }
]
"));

var pages = new OnenotePage();
pages.Content = stream;

await graphClient.Me.Onenote.Pages["{onenotePage-id}"]
	.Request()
	.UpdateAsync(pages);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

