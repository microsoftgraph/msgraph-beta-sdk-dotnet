---
title: "Update synchronizationTemplate"
description: "Update (override) the synchronization template associated with a given application."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# Update synchronizationTemplate

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update (override) the synchronization template associated with a given application.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     |Directory.ReadWrite.All  |
|Delegated (personal Microsoft account) |Not supported.|
|Application                            |Application.ReadWrite.OwnedBy, Directory.ReadWrite.All | 

### HTTP Request
<!-- { "blockType": "ignored" } -->
```http
PATCH applications/{id}/synchronization/templates/{templateId}
```

## Request headers

| Name           | Type    | Description|
|:---------------|:--------|:-----------|
| Authorization  | string  | Bearer {token}. Required. |

## Request body

In the request body, supply the [synchronizationTemplate](../resources/synchronization-synchronizationtemplate.md) object to replace the existing template. Make sure all properties are provided. Missing properties will be erased.

### Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

### Examples

##### Request
The following is an example of a request. 

>**Note:** The request object shown here is shortened for readability. Include all the properties in an actual call.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_synchronizationtemplate"
}-->
```http
PUT https://graph.microsoft.com/beta/applications/{id}/synchronization/templates/{templateId}
Authorization: Bearer <token>
Content-type: application/json

{
    "id": "Slack",
    "applicationId": "{id}",
    "factoryTag": "CustomSCIM"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var synchronizationTemplate = new SynchronizationTemplate
{
	Id = "Slack",
	ApplicationId = Guid.Parse("{id}"),
	FactoryTag = "CustomSCIM"
};

await graphClient.Applications["{application-id}"].Synchronization.Templates["{synchronizationTemplate-id}"]
	.Request()
	.Header("Authorization","Bearer <token>")
	.PutAsync(synchronizationTemplate);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

