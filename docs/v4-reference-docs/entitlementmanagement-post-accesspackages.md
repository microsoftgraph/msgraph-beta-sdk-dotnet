---
title: "Create accessPackage"
description: "Create a new accessPackage."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: "apiPageType"
---

# Create accessPackage

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [accessPackage](../resources/accesspackage.md) object.

The access package will be added to an existing [accessPackageCatalog](../resources/accesspackagecatalog.md). After the access package is created, you can then create [accessPackageAssignmentPolicies](../resources/accesspackageassignmentpolicy.md) which specify how users are assigned to the access package.


## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | EntitlementManagement.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | EntitlementManagement.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identityGovernance/entitlementManagement/accessPackages
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer \{token\}. Required. |
| Content-type  | application/json. Required.  |

## Request body

In the request body, supply a JSON representation of an [accessPackage](../resources/accesspackage.md) object.

## Response

If successful, this method returns a 201 Created response code and a new [accessPackage](../resources/accesspackage.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_accesspackage_from_accesspackages"
}-->

```http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackages
Content-type: application/json

{
  "catalogId": "aa2f6514-3232-46e7-a08a-2411ad8d7128",
  "displayName": "sales reps",
  "description": "outside sales representatives"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackage = new AccessPackage
{
	CatalogId = "aa2f6514-3232-46e7-a08a-2411ad8d7128",
	DisplayName = "sales reps",
	Description = "outside sales representatives"
};

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackages
	.Request()
	.AddAsync(accessPackage);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessPackage"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "56ff43fd-6b05-48df-9634-956a777fce6d",
  "catalogId": "aa2f6514-3232-46e7-a08a-2411ad8d7128",
  "displayName": "sales reps",
  "description": "outside sales representatives",
  "isHidden": false,
  "isRoleScopesVisible": false
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create accessPackage",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


