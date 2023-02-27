---
title: "List attachments"
description: "Retrieve a list of attachment objects attached to a post."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "groups"
doc_type: apiPageType
---

# List attachments

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [attachment](../resources/attachment.md) objects attached to a post.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Group.Read.All, Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request
Get the attachments for a [post](../resources/post.md) in a [conversationThread](../resources/conversationthread.md) of a group. Specifying the parent [conversation](../resources/conversation.md) is optional.

<!-- { "blockType": "ignored" } -->
```http
GET /groups/{id}/threads/{id}/posts/{id}/attachments
GET /groups/{id}/conversations/{id}/threads/{id}/posts/{id}/attachments
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

In particular, you can use the $expand query parameter to include all of the post attachments
inline with the rest of the post properties. For example:

<!-- { "blockType": "ignored" } -->
```
GET https://graph.microsoft.com/beta/groups/{id}/threads/{id}/posts/{id}?$expand=attachments
```
## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [Attachment](../resources/attachment.md) objects in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_get_attachments_beta",
  "sampleKeys": ["1848753d-185d-4c08-a4e4-6ee40521d115","AAQkADJfolA==","AAMkADJ-aHAAA="]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/groups/1848753d-185d-4c08-a4e4-6ee40521d115/threads/AAQkADJfolA==/posts/AAMkADJ-aHAAA=/attachments
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attachments = await graphClient.Groups["{group-id}"].Threads["{conversationThread-id}"].Posts["{post-id}"].Attachments
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

