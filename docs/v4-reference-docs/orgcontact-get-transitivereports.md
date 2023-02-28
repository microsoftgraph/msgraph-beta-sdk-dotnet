---
title: "Get transitiveReports for orgContact"
description: "Get the count of transitive reports for an organizational contact."
author: "dkershaw10"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Get transitiveReports for orgContact

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a count of transitive reports for an organizational contact.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


| Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
| Delegated (work or school account) | OrgContact.Read, OrgContact.Read.All, Directory.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application | OrgContact.Read, OrgContact.Read.All, Directory.Read.All |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /contacts/{id}/transitiveReports/$count
```

## Optional query parameters

This method does not support the use of query parameters, but does require the `$count` query segment.

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| ConsistencyLevel | eventual. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a count of transitive reports for an organizational contact in the response body.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_transitivereports"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/contacts/45b7d2e7-b882-4a80-ba97-10b7a63b8fa4/transitiveReports/$count
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var int32 = await graphClient.Contacts["{orgContact-id}"].TransitiveReports.$count
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
  "description": "Get transitiveReports",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
