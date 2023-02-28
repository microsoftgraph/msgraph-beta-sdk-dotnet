---
title: "Create delegatedPermissionClassification"
description: "Classify a permission by adding a delegatedPermissionClassification to the API's service principal."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "applications"
author: "psignoret"
---

# Create delegatedPermissionClassification

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Classify a delegated permission by adding a [delegatedPermissionClassification](../resources/delegatedpermissionclassification.md) to the [servicePrincipal](../resources/servicePrincipal.md) representing the API.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Policy.ReadWrite.PermissionGrant |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Policy.ReadWrite.PermissionGrant |

## HTTP request

You can address the service principal using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/delegatedPermissionClassifications
POST /servicePrincipals(appId='{appId}')/delegatedPermissionClassifications

```

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization | Bearer {token}. Required.  |
| Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [delegatedPermissionClassification](../resources/delegatedpermissionclassification.md) object.

## Response

If successful, this method returns a `201 Created` response code and an [delegatedPermissionClassification](../resources/delegatedpermissionclassification.md) object in the response body.

## Examples

### Request

In the following example, the delegated permission "User.Read" is being classified "low".


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "serviceprincipal_create_delegatedpermissionclassification"
}-->

```http
POST https://graph.microsoft.com/beta/servicePrincipals/{id}/delegatedPermissionClassifications
Content-Type: application/json

{
  "permissionId": "e1fe6dd8-ba31-4d61-89e7-88639da4683d",
  "permissionName": "User.Read",
  "classification": "low"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delegatedPermissionClassification = new DelegatedPermissionClassification
{
	PermissionId = "e1fe6dd8-ba31-4d61-89e7-88639da4683d",
	PermissionName = "User.Read",
	Classification = PermissionClassificationType.Low
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].DelegatedPermissionClassifications
	.Request()
	.AddAsync(delegatedPermissionClassification);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.delegatedPermissionClassification"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "2G3-4TG6YU2J54hjnaRoPQE",
  "permissionId": "e1fe6dd8-ba31-4d61-89e7-88639da4683d",
  "permissionName": "User.Read",
  "classification": "low"
}
```

