---
title: "List applications"
description: "Retrieve a list of application objects associated with the connectorGroup."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# List applications assigned to a connectorGroup

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [application](../resources/application.md) objects associated with the [connectorGroup](../resources/connectorgroup.md). This list contains all applications assigned to the specific connector group.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}/applications
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer. Required|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [application](../resources/application.md) objects in the response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_applications"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}/applications
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var applications = await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"].ConnectorGroups["{connectorGroup-id}"].Applications
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

