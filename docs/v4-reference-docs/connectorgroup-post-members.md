---
title: "Add connector to connectorGroup"
description: "Use this API to add a connector to a connectorGroup."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Add connector to connectorGroup

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a [connector](../resources/connector.md) to a [connectorGroup](../resources/connectorgroup.md).

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}/members/$ref

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer. Required.|
| Content-type | application/json. Required. |

## Request body
In the request body, supply a JSON representation of a link to a [connector](../resources/connector.md) object.

## Response

If successful, this method returns a `201 Created` response code and a [connector](../resources/connector.md) object in the response body.

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_connector_from_connectorgroup"
}-->
```http
POST https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}/members/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectors/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var connectorReference = new ReferenceRequestBody
{
	ODataId = "https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectors/{id}"
};

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"].ConnectorGroups["{connectorGroup-id}"].Members.References
	.Request()
	.AddAsync(connectorReference);

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
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Add connector to connectorGroup",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->



