---
title: "Create externalItem"
description: "Create a new externalItem."
ms.localizationpriority: medium
author: "snlraju-msft"
ms.prod: "search"
doc_type: "apiPageType"
---

# Create externalItem

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [externalItem](../resources/externalconnectors-externalitem.md).

This API can be used to create a custom item. The containing [externalConnection](../resources/externalconnectors-externalconnection.md) must have a [schema](../resources/externalconnectors-schema.md) registered of the corresponding type.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ExternalItem.ReadWrite.OwnedBy, ExternalItem.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ExternalItem.ReadWrite.OwnedBy, ExternalItem.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PUT /external/connections/{connection-id}/items/{item-id}
```

## Path parameters

| Parameter     | Type   | Description                                         |
|:--------------|:-------|:----------------------------------------------------|
| connection-id | string | The `id` property of the containing [externalConnection](../resources/externalconnectors-externalconnection.md) |
| item-id       | string | The developer-provided `id` property of the [externalItem](../resources/externalconnectors-externalitem.md). If no item already exists with this `id`, a new item is created. If an item already exists with this `id`, it is overwritten by the object sent in the body. |

## Request headers

| Name          | Description                 |
|:--------------|:----------------------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [externalItem](../resources/externalconnectors-externalitem.md) object. The payload is limited to 4 MB.

### Creating an externalItem

When creating an `externalItem`, the following fields are required: `acl`, and `properties`. The `properties` object must contain at least one property.

All `DateTime` type properties must be in ISO 8601 format.

Properties on an `externalItem` should use type specifiers in the payload in the following scenarios:

- For `String` type properties, if the value contains non-ASCII characters.

    ```json
    "description@odata.type": "String",
    "description": "Kandierte Äpfel"
    ```

- For all collection types.

    ```json
    "categories@odata.type": "Collection(String)"
    "categories": [
      "red",
      "blue"
    ]
    ```

    > [!IMPORTANT]
    > When including a property of type `Collection(DateTime)`, you must use the type specifier `Collection(DateTimeOffset)`.

## Response

If successful, this method returns `200 OK` response code.

## Examples

### Example: Create a custom item

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_externalitem_from_connections",
  "sampleKeys": ["contosohr", "TSP228082938"]
}-->

```http
PUT https://graph.microsoft.com/beta/external/connections/contosohr/items/TSP228082938
Content-type: application/json

{
  "acl": [
    {
      "type": "user",
      "value": "e811976d-83df-4cbd-8b9b-5215b18aa874",
      "accessType": "grant",
      "identitySource": "azureActiveDirectory"
    },
    {
      "type": "group",
      "value": "14m1b9c38qe647f6a",
      "accessType": "deny",
      "identitySource": "external"
    }
  ],
  "properties": {
    "title": "Error in the payment gateway",
    "priority": 1,
    "assignee": "john@contoso.com"
  },
  "content": {
    "value": "Error in payment gateway...",
    "type": "text"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalItem = new Microsoft.Graph.ExternalConnectors.ExternalItem
{
	Acl = new List<Microsoft.Graph.ExternalConnectors.Acl>()
	{
		new Microsoft.Graph.ExternalConnectors.Acl
		{
			Type = Microsoft.Graph.ExternalConnectors.AclType.User,
			Value = "e811976d-83df-4cbd-8b9b-5215b18aa874",
			AccessType = Microsoft.Graph.ExternalConnectors.AccessType.Grant,
			IdentitySource = Microsoft.Graph.ExternalConnectors.IdentitySourceType.AzureActiveDirectory
		},
		new Microsoft.Graph.ExternalConnectors.Acl
		{
			Type = Microsoft.Graph.ExternalConnectors.AclType.Group,
			Value = "14m1b9c38qe647f6a",
			AccessType = Microsoft.Graph.ExternalConnectors.AccessType.Deny,
			IdentitySource = Microsoft.Graph.ExternalConnectors.IdentitySourceType.External
		}
	},
	Properties = new Microsoft.Graph.ExternalConnectors.Properties
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"title", "Error in the payment gateway"},
			{"priority", "1"},
			{"assignee", "john@contoso.com"}
		}
	},
	Content = new Microsoft.Graph.ExternalConnectors.ExternalItemContent
	{
		Value = "Error in payment gateway...",
		Type = Microsoft.Graph.ExternalConnectors.ExternalItemContentType.Text
	}
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Items["{externalConnectors.externalItem-id}"]
	.Request()
	.PutAsync(externalItem);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- markdownlint-enable MD024 -->

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 200 OK
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create externalItem",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
