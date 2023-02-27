---
title: "Update schema"
description: "Update the properties of a schema for an externalConnection."
ms.localizationpriority: medium
author: "mecampos"
ms.prod: "search"
doc_type: "apiPageType"
---

# Update schema

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [schema](../resources/externalconnectors-schema.md) for an [externalConnection](../resources/externalconnectors-externalconnection.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ExternalConnection.ReadWrite.OwnedBy, ExternalConnection.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ExternalConnection.ReadWrite.OwnedBy, ExternalConnection.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /external/connections/{connectionId}/schema
```

## Request headers

| Name                  | Description                                                        |
|:----------------------|:-------------------------------------------------------------------|
| Authorization         | Bearer {token}. Required.                                          |
| Content-Type          | application/json. Required.                                        |
| Prefer: respond-async | Use this to cause the request to execute asynchronously. Optional. |

## Request body

In the request body, supply a JSON representation of a [schema](../resources/externalconnectors-schema.md) object.

When you register a custom item schema, the **schema** object **must** have the **baseType** property set to `microsoft.graph.externalItem` and **must** contain the **properties** property. The **properties** object **must** contain at least one property, up to a maximum of 128.

## Response

If successful, this method returns a `202 Accepted` response code and a URL in the `Location` response header that can be used to [get the operation status](../api/externalconnectors-connectionoperation-get.md).

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_schema",
  "sampleKeys": ["contosohr"]
}-->

```http
PATCH https://graph.microsoft.com/beta/external/connections/contosohr/schema
Content-type: application/json

{
  "baseType": "microsoft.graph.externalItem",
  "properties": [
    {
      "name": "ticketTitle",
      "type": "string",
      "isSearchable": "true",
      "isRetrievable": "true",
      "labels": [
        "title"
      ]
    },
    {
      "name": "priority",
      "type": "string",
      "isQueryable": "true",
      "isRetrievable": "true",
      "isSearchable": "false"
    },
    {
      "name": "assignee",
      "type": "string",
      "isRetrievable": "true"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var schema = new Microsoft.Graph.ExternalConnectors.Schema
{
	BaseType = "microsoft.graph.externalItem",
	Properties = new List<Microsoft.Graph.ExternalConnectors.Property>()
	{
		new Microsoft.Graph.ExternalConnectors.Property
		{
			Name = "ticketTitle",
			Type = Microsoft.Graph.ExternalConnectors.PropertyType.String,
			IsSearchable = true,
			IsRetrievable = true,
			Labels = new List<Microsoft.Graph.ExternalConnectors.Label>()
			{
				Microsoft.Graph.ExternalConnectors.Label.Title
			}
		},
		new Microsoft.Graph.ExternalConnectors.Property
		{
			Name = "priority",
			Type = Microsoft.Graph.ExternalConnectors.PropertyType.String,
			IsQueryable = true,
			IsRetrievable = true,
			IsSearchable = false
		},
		new Microsoft.Graph.ExternalConnectors.Property
		{
			Name = "assignee",
			Type = Microsoft.Graph.ExternalConnectors.PropertyType.String,
			IsRetrievable = true
		}
	}
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Schema
	.Request()
	.UpdateAsync(schema);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- markdownlint-enable MD024 -->

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
} -->

```http
HTTP/1.1 202 Accepted
Location: https://graph.microsoft.com/beta/external/connections/contosohr/operations/616bfeed-666f-4ce0-8cd9-058939010bfc

```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get schema",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
