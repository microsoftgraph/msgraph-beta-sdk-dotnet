---
title: "Get transitiveReports for a user"
description: "Get the count of transitive reports for a user."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# Get transitiveReports for a user

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a count of transitive reports for a user.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


| Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
| Delegated (work or school account) | User.Read, User.Read.All, Directory.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application | User.Read, User.Read.All, Directory.Read.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /users/{id}/transitiveReports/$count
```
## Optional query parameters

This method supports the `$filter` query parameter for only the **accountEnabled** property. For more information about using query parameters, see [OData query parameters](/graph/query-parameters).

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| ConsistencyLevel | eventual. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a count of transitive reports for the user in the response body.

## Examples

### Request

The following is an example of the request. The `$count` query segment is required.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_transitivereports_user"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/users/45b7d2e7-b882-4a80-ba97-10b7a63b8fa4/transitiveReports/$count
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var int32 = await graphClient.Users["{user-id}"].TransitiveReports.$count
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 200 OK
Content-type: text/plain

```

`5`
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get transitiveReports for a user",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
