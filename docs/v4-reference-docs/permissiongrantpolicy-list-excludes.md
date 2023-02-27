---
title: "List excludes collection of permissionGrantPolicy"
description: "Retrieve a list of the condition sets which describe conditions under which a permission grant event is excluded in a permission grant policy."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# List excludes collection of permissionGrantPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the condition sets which are *excluded* in a [permissionGrantPolicy](../resources/permissiongrantpolicy.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Policy.Read.PermissionGrant, Directory.Read.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Policy.Read.PermissionGrant, Directory.Read.All |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /policies/permissionGrantPolicies/{id}/excludes
```

## Optional query parameters

This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers

| Name           | Description                |
|:---------------|:---------------------------|
| Authorization  | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) objects in the response body.

## Example

### Request

The following is an example of the request to retrieve the **excludes** condition sets of the built-in permission grant policy `microsoft-application-admin`. This permission grant policy includes all delegated permissions, and all application permissions excluding application permissions for Microsoft Graph and application permissions for Azure Active Directory Graph.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "permissiongrantpolicy_get_excludes",
  "sampleKeys": ["microsoft-application-admin"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/policies/permissionGrantPolicies/microsoft-application-admin/excludes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var excludes = await graphClient.Policies.PermissionGrantPolicies["{permissionGrantPolicy-id}"].Excludes
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
  "@odata.type": "microsoft.graph.permissionGrantConditionSet",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "c85b029f-4abf-47d8-ae61-d2a38299033a",
      "permissionClassification": "all",
      "permissionType": "application",
      "resourceApplication": "00000003-0000-0000-c000-000000000000",
      "permissions": [ "all" ],
      "clientApplicationIds": [ "all" ],
      "clientApplicationTenantIds": [ "all" ],
      "clientApplicationPublisherIds": [ "all" ],
      "clientApplicationsFromVerifiedPublisherOnly": false,
      "certifiedClientApplicationsOnly": false
    },
    {
      "id": "2a1fbb36-9d9a-42d8-8804-de2aa45aca80",
      "permissionClassification": "all",
      "permissionType": "application",
      "resourceApplication": "00000002-0000-0000-c000-000000000000",
      "permissions": [ "all" ],
      "clientApplicationIds": [ "all" ],
      "clientApplicationTenantIds": [ "all" ],
      "clientApplicationPublisherIds": [ "all" ],
      "clientApplicationsFromVerifiedPublisherOnly": false,
      "certifiedClientApplicationsOnly": false
    }
  ]
}
```
