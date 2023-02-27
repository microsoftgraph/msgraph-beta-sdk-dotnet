---
title: "Delete customAccessPackageWorkflowExtension"
description: "Delete a customAccessPackageWorkflowExtension object."
author: "currenmehta-zz"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Delete customAccessPackageWorkflowExtension
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [customAccessPackageWorkflowExtension](../resources/customaccesspackageworkflowextension.md) object. The custom workflow extension must first be removed from any associated [policies](../resources/accesspackageassignmentpolicy.md) before it can be deleted. Follow these steps to remove the custom workflow extension from any associated policies:
1. First retrieve the accessPackageCatalogId by calling the [Get accessPackageAssignmentPolicies](accesspackageassignmentpolicy-get.md) operation and appending `?$expand=accessPackage($expand=accessPackageCatalog)` to the query. For example, `https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies?$expand=accessPackage($expand=accessPackageCatalog)`.
2. Use the access package catalog ID and retrieve the ID of the **customAccessPackageWorkflowExtension** object that you want to delete by running the [LIST customAccessPackageWorkflowExtensions](accesspackagecatalog-list-customaccesspackageworkflowextensions.md) operation.
3. Call the [Update accessPackageAssignmentPolicy](accesspackageassignmentpolicy-update.md) operation to remove the custom workflow extension object from the policy. For an example, see [Example 2: Remove the customExtensionHandlers from a policy](accesspackageassignmentpolicy-update.md#example-2-remove-the-customextensionhandlers-from-a-policy).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|EntitlementManagement.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|EntitlementManagement.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /identityGovernance/entitlementManagement/accessPackageCatalogs/{catalogId}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtensionId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_customaccesspackageworkflowextension"
}
-->
``` http
DELETE /identityGovernance/entitlementManagement/accessPackageCatalogs/32efb28c-9a7a-446c-986b-ca6528c6669d/customAccessPackageWorkflowExtensions/98ffaec5-ae8e-4902-a434-5ffc5d3d3cd0
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs["{accessPackageCatalog-id}"].CustomAccessPackageWorkflowExtensions["{customAccessPackageWorkflowExtension-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Response
```
