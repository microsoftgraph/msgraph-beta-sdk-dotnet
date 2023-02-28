---
title: "Delete accessPackage"
description: "Delete accessPackage."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: "apiPageType"
---

# Delete accessPackage

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an [accessPackage](../resources/accesspackage.md) object.

You cannot delete an access package if it has any **accessPackageAssignment**. To delete the access package, first [query if there are any assignments](entitlementmanagement-list-accesspackageassignments.md) with a filter to indicate the specific access package, such as: `$filter=accessPackage/id eq 'a914b616-e04e-476b-aa37-91038f0b165b'`. For more information on how to remove assignments that are still in the delivered state, see [Remove an assignment](entitlementmanagement-post-accesspackageassignmentrequests.md#example-4-remove-an-assignment).


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
DELETE /identityGovernance/entitlementManagement/accessPackages/{id}
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer \{token\}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_accesspackage"
}-->

```http
DELETE https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackages/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.IdentityGovernance.EntitlementManagement.AccessPackages["{accessPackage-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

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
  "description": "Delete accessPackage",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


