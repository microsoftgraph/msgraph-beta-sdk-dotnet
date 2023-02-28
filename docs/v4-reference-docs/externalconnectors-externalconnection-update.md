---
title: "Update externalConnection"
description: "Update the properties of an externalConnection."
ms.localizationpriority: medium
author: "snlraju-msft"
ms.prod: "search"
doc_type: "apiPageType"
---

# Update connection

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [externalConnection](../resources/externalconnectors-externalconnection.md).

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
PATCH /external/connections/{id}
```

## Request headers

| Name          | Description                 |
|:--------------|:----------------------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed. The following properties can be updated.

| Property      | Type                                           | Description |
|:--------------|:-----------------------------------------------|:------------|
| configuration | [microsoft.graph.externalConnectors.configuration](../resources/externalconnectors-configuration.md) | Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. |
| description   | String                                         | Description of the connection displayed in the Microsoft 365 admin center. |
| name          | String                                         | The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. |

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of the request.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_connection",
  "sampleKeys": ["contosohr"]
}-->

```http
PATCH https://graph.microsoft.com/beta/external/connections/contosohr
Content-type: application/json

{
  "name": "Contoso HR Service Tickets",
  "description": "Connection to index HR service tickets"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var externalConnection = new Microsoft.Graph.ExternalConnectors.ExternalConnection
{
	Name = "Contoso HR Service Tickets",
	Description = "Connection to index HR service tickets"
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"]
	.Request()
	.UpdateAsync(externalConnection);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- markdownlint-enable MD024 -->

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update connection",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
