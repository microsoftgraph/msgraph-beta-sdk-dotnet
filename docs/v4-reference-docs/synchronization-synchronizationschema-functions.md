---
title: "synchronizationSchema: functions"
description: "List all the functions currently supported in the attributeMappingSource."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# synchronizationSchema: functions

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List all the functions currently supported in the [attributeMappingSource](../resources/synchronization-attributemappingsource.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     |Directory.Read.All  |
|Delegated (personal Microsoft account) |Not supported.|
|Application                            |Application.ReadWrite.OwnedBy, Directory.ReadWrite.All | 

## HTTP Request
<!-- { "blockType": "ignored" } -->
```http
GET /servicePrincipals/{id}/synchronization/jobs/{jobId}/schema/functions
GET /servicePrincipals/{id}/synchronization/templates/{templateId}/schema/functions
GET /applications/{id}/synchronization/templates/{templateId}/schema/functions
```

## Request headers

| Name           | Type    | Description|
|:---------------|:--------|:-----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [attributemappingFunctionSchema](../resources/synchronization-attributemappingfunctionschema.md) objects in the response body.

## Example

##### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "synchronizationschema_functions"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals/{id}/synchronization/jobs/{jobId}/schema/functions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var functions = await graphClient.ServicePrincipals["{servicePrincipal-id}"].Synchronization.Jobs["{synchronizationJob-id}"].Schema
	.Functions()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

