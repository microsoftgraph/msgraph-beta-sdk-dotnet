---
title: "List accessPackageAssignmentResourceRoles"
description: "Retrieve a list of accessPackageAssignmentResourceRole objects."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: "apiPageType"
---

# List accessPackageAssignmentResourceRoles

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [accessPackageAssignmentResourceRole](../resources/accesspackageassignmentresourcerole.md) objects.  The resulting list includes all the resource roles of all assignments that the caller has access to read, across all catalogs and access packages.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | EntitlementManagement.Read.All, EntitlementManagement.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | EntitlementManagement.Read.All, EntitlementManagement.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles
```

## Optional query parameters

This method supports the `$select`, `$filter`, and `$expand` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

For example, to retrieve only access package assignment resource roles for a particular user, you can include a query with a filter targeting the object ID of that user `?$expand=accessPackageSubject&$filter=accessPackageSubject/objectId+eq+'9b835e5c-bf18-4ad9-8556-9b1ea0019c6b'`.


## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer \{token\}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [accessPackageAssignmentResourceRole](../resources/accesspackageassignmentresourcerole.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accesspackageassignmentresourceroles"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackageAssignmentResourceRoles = await graphClient.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentResourceRoles
	.Request()
	.GetAsync();

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
  "@odata.type": "microsoft.graph.accessPackageAssignmentResourceRole",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "1bf101d2-4d9c-437f-bbf5-3d13d98f5479",
      "originId": "originId-value",
      "originSystem": "SharePointOnline",
      "status": "Fulfilled"
    }
  ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List accessPackageAssignmentResourceRoles",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


