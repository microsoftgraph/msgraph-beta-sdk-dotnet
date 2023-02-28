---
title: "Create permissionGrantConditionSet in includes collection of permissionGrantPolicy"
description: "Add conditions under which a permission grant event is included in a permission grant policy."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "identity-and-sign-in"
author: "psignoret"
---

# Create permissionGrantConditionSet in includes collection of permissionGrantPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add conditions under which a permission grant event is *included* in a permission grant policy. You do this by adding a [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) to the **includes** collection of a  [permissionGrantPolicy](../resources/permissionGrantPolicy.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Policy.ReadWrite.PermissionGrant |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Policy.ReadWrite.PermissionGrant |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /policies/permissionGrantPolicies/{id}/includes
```

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization | Bearer {token}. Required.  |
| Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) object.

## Response

If successful, this method returns a `201 Created` response code and an [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) object in the response body.

## Examples

### Example 1: Create a permission grant policy for client apps that are from verified publishers 

#### Request

In this example, *all* delegated permissions for client apps that are from verified publishers are included in the permission grant policy. Because all the other conditions from the [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) were omitted, they will take their default values, which in each case is the most-inclusive.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "truncated": true,
  "name": "permissiongrantpolicy_create_includes_for_verified_publishers"
}-->

```http
POST https://graph.microsoft.com/beta/policies/permissionGrantPolicies/{id}/includes
Content-Type: application/json

{
  "permissionType": "delegated",
  "clientApplicationsFromVerifiedPublisherOnly": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var permissionGrantConditionSet = new PermissionGrantConditionSet
{
	PermissionType = PermissionType.Delegated,
	ClientApplicationsFromVerifiedPublisherOnly = true
};

await graphClient.Policies.PermissionGrantPolicies["{permissionGrantPolicy-id}"].Includes
	.Request()
	.AddAsync(permissionGrantConditionSet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.permissionGrantConditionSet"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "75ffda85-9314-43bc-bf19-554a7d079e96",
  "permissionClassification": "all",
  "permissionType": "delegated",
  "resourceApplication": "any",
  "permissions": ["all"],
  "clientApplicationIds": ["all"],
  "clientApplicationTenantIds": ["all"],
  "clientApplicationPublisherIds": ["all"],
  "clientApplicationsFromVerifiedPublisherOnly": true,
  "certifiedClientApplicationsOnly": false
}
```
### Example 2: Create a permission grant policy for client apps that are Microsoft 365 certified  

#### Request

In this example, *all* delegated permissions for all client apps that are Microsoft 365 certified are included in the permission grant policy. Since having a verified publisher is a pre-requisite for an app to be considered Microsoft 365 certified, it is not necessary to explicitly require a verified publisher. Because all the other conditions from the [permissionGrantConditionSet](../resources/permissiongrantconditionset.md) were omitted, they will take their default values, which in each case is the most-inclusive.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "truncated": true,
  "name": "permissiongrantpolicy_create_includes_for_M365_certified"
}-->

```http
POST https://graph.microsoft.com/beta/policies/permissionGrantPolicies/{id}/includes
Content-Type: application/json

{
  "permissionType": "delegated",
  "certifiedClientApplicationsOnly": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var permissionGrantConditionSet = new PermissionGrantConditionSet
{
	PermissionType = PermissionType.Delegated,
	CertifiedClientApplicationsOnly = true
};

await graphClient.Policies.PermissionGrantPolicies["{permissionGrantPolicy-id}"].Includes
	.Request()
	.AddAsync(permissionGrantConditionSet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.permissionGrantConditionSet"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "75ffda85-9314-43bc-bf19-554a7d079e96",
  "permissionClassification": "all",
  "permissionType": "delegated",
  "resourceApplication": "any",
  "permissions": ["all"],
  "clientApplicationIds": ["all"],
  "clientApplicationTenantIds": ["all"],
  "clientApplicationPublisherIds": ["all"],
  "clientApplicationsFromVerifiedPublisherOnly": true,
  "certifiedClientApplicationsOnly": true
}
```
