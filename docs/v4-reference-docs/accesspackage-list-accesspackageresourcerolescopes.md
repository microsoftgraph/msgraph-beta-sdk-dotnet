---
title: "List accessPackageResourceRoleScopes"
description: "Retrieve a list of accesspackageresourcerolescope objects."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: "apiPageType"
---

# List accessPackageResourceRoleScopes

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve an access package with a list of [accessPackageResourceRoleScope](../resources/accesspackageresourcerolescope.md) objects. These objects represent the resource roles that an access package assigns to each subject. Each object links to an [accessPackageResourceRole](../resources/accesspackageresourcerole.md) and an [accessPackageResourceScope](../resources/accesspackageresourcescope.md).

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
GET /identityGovernance/entitlementManagement/accessPackages/{id}?$expand=accessPackageResourceRoleScopes($expand=accessPackageResourceRole,accessPackageResourceScope)
```

## Optional query parameters

This method supports the `$select`, `$filter`, and `$expand` OData query parameters to customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer \{token\}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [accessPackage](../resources/accesspackage.md) that contains a collection of [accessPackageResourceRoleScope](../resources/accesspackageresourcerolescope.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_accesspackageresourcerolescopes"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackages/{id}?$expand=accessPackageResourceRoleScopes($expand=accessPackageResourceRole,accessPackageResourceScope)
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessPackage = await graphClient.IdentityGovernance.EntitlementManagement.AccessPackages["{accessPackage-id}"]
	.Request()
	.Expand("accessPackageResourceRoleScopes($expand=accessPackageResourceRole,accessPackageResourceScope)")
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
  "@odata.type": "microsoft.graph.accessPackage",
  "isCollection": false
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json


{
    "id": "933a4822-aed1-445b-9623-62116cd07a39",
    "catalogId": "32efb28c-9a7a-446c-986b-ca6528c6669d",
    "displayName": "Test Package 9-9",
    "description": "Test Package 9-9",
    "isHidden": false,
    "accessPackageResourceRoleScopes": [
        {
            "id": "70113acf-4dcb-453f-b517-2394598d974e_22bfd707-ab6f-404f-b0b5-a5e6f5d0ba36",
            "createdBy": "alice@contoso.com",
            "createdDateTime": "2019-09-09T19:54:14.853Z",
            "modifiedBy": "alice@contoso.com",
            "modifiedDateTime": "2019-09-09T19:54:14.853Z",
            "accessPackageResourceRole": {
                "id": "70113acf-4dcb-453f-b517-2394598d974e",
                "displayName": "Owner",
                "originSystem": "origin-type",
                "originId": "Owner_7b56ede0-9b58-40bd-b11e-b3d18fc32698"
            },
            "accessPackageResourceScope": {
                "id": "22bfd707-ab6f-404f-b0b5-a5e6f5d0ba36",
                "displayName": "Root",
                "description": "Root Scope",
                "originId": "7b56ede0-9b58-40bd-b11e-b3d18fc32698",
                "originSystem": "origin-type",
                "isRootScope": true
            }
        }
    ]
}

```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List accessPackageResourceRoleScopes",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


