---
title: "Delete connectorGroup"
description: "Delete a connectorGroup."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Delete connectorGroup

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [connectorGroup](../resources/connectorgroup.md). All [connectors](../resources/connector.md) and applications must be removed from the connector group before a connector group can be deleted.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer. Required|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_connectorgroup"
}-->
```http
DELETE https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"].ConnectorGroups["{connectorGroup-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

