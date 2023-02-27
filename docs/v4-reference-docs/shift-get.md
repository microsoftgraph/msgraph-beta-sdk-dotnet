---
title: "Get shift"
description: "Get a shift by ID."
author: "akumar39"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Get shift

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a [shift](../resources/shift.md) object by ID.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Schedule.Read.All, Group.Read.All, Schedule.ReadWrite.All, Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Schedule.Read.All, Schedule.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /teams/{teamId}/schedule/shifts/{shiftId}
```

## Optional query parameters

This method does not support OData query parameters to customize the response.

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [shift](../resources/shift.md) object in the response body.

## Example

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "shift-get-1"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/teams/{teamId}/schedule/shifts/{shiftId}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var shift = await graphClient.Teams["{team-id}"].Schedule.Shifts["{shift-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.shift"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
	"id": "SHFT_ca485cdd-a42c-4b93-9e6a-6fa54fd45fe1",
	"createdDateTime": "2019-06-06T20:15:38.9Z",
	"lastModifiedDateTime": "2019-11-18T01:12:08.318Z",
	"schedulingGroupId": "TAG_d18fd675-3ac8-41b2-8038-d17fdac8b0d3",
	"userId": "a7b0c8c4-3f5c-492f-ab13-40f0e0f0ffa8",
	"draftShift": null,
	"lastModifiedBy": {
		"application": null,
		"device": null,
		"conversation": null,
		"user": {
			"id": "1c717a55-febd-4850-b5f6-101f3a29972c",
			"displayName": "Sumanth Lingom"
		}
	}
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get a shift by id",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


