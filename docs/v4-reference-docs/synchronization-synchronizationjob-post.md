---
title: "Create synchronizationJob"
description: "Create new synchronization job with a default synchronization schema. The job is created in a disabled state. Call Start job to start synchronization."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# Create synchronizationJob

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create new synchronization job with a default synchronization schema. The job is created in a disabled state. Call [Start job](synchronization-synchronizationjob-start.md) to start synchronization.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     |Directory.ReadWrite.All  |
|Delegated (personal Microsoft account) |Not supported.|
|Application                            |Application.ReadWrite.OwnedBy, Directory.ReadWrite.All  | 

## HTTP Request
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/synchronization/jobs/
```

## Request headers

| Name           | Type    | Description|
|:---------------|:--------|:-----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of the [synchronizationJob](../resources/synchronization-synchronizationjob.md) object to be created. The only required property is `templateId`. The `templateId` property must match one of the templates created for this application/service principal. To find available templates, use [List templates](synchronization-synchronizationtemplate-list.md).

## Response

If successful, returns a `201 Created` response code and a [synchronizationJob](../resources/synchronization-synchronizationjob.md) object in the response body.

## Example

##### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_synchronizationjob_from_synchronization"
}-->
```http
POST https://graph.microsoft.com/beta/servicePrincipals/{id}/synchronization/jobs
Content-type: application/json

{ 
    "templateId": "BoxOutDelta"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var synchronizationJob = new SynchronizationJob
{
	TemplateId = "BoxOutDelta"
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].Synchronization.Jobs
	.Request()
	.AddAsync(synchronizationJob);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

