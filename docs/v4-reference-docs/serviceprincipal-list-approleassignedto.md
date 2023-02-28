---
title: "List appRoleAssignments granted for a service principal"
description: "Retrieve a list of app role assignments granted for a service principal."
ms.localizationpriority: high
doc_type: apiPageType
ms.prod: "applications"
author: "sureshja"
---

# List appRoleAssignments granted for a service principal

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [appRoleAssignment](../resources/approleassignment.md) that users, groups, or client service principals have been granted for the given resource service principal.

For example, if the resource service principal is the service principal for the Microsoft Graph API, this will return all service principals that have been granted any app-only permissions to Microsoft Graph.

If the resource service principal is an application that has app roles granted to users and groups, this will return all the users and groups assigned app roles for this application.

>**Note** This request might have replication delays for app role assignments that were recently granted or removed.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.Read.All, Directory.Read.All, Application.ReadWrite.All, Directory.ReadWrite.All  |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Application.Read.All, Directory.Read.All, Application.ReadWrite.OwnedBy, Application.ReadWrite.All, Directory.ReadWrite.All |

> [!NOTE]
> The *Application.ReadWrite.OwnedBy* permission allows an app to call `GET /applications` and `GET /servicePrincipals` to list all applications and service principals in the tenant. This scope of access has been allowed for the permission.
## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /servicePrincipals/{id}/appRoleAssignedTo
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

If successful, this method returns a `200 OK` response code and a collection of [appRoleAssignment](../resources/approleassignment.md) objects in the response body.

## Example

### Request

The following is an example of the request to retrieve the app roles assignments that have been granted for a given resource service principal.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "serviceprincipal_get_approleassignedto"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals/8e881353-1735-45af-af21-ee1344582a4d/appRoleAssignedTo
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var appRoleAssignedTo = await graphClient.ServicePrincipals["{servicePrincipal-id}"].AppRoleAssignedTo
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Here is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.appRoleAssignment",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#appRoleAssignments",
  "value": [
    {
      "id": "41W1zT6z1U-kJxf62svfp1HFE8pMZhxDun-ThPczmJE",
      "creationTimestamp": "2021-02-02T04:22:45.9480566Z",
      "appRoleId": "00000000-0000-0000-0000-000000000000",
      "principalDisplayName": "MOD Administrator",
      "principalId": "cdb555e3-b33e-4fd5-a427-17fadacbdfa7",
      "principalType": "User",
      "resourceDisplayName": "dxprovisioning-graphapi-client",
      "resourceId": "8e881353-1735-45af-af21-ee1344582a4d"
    }
  ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List appRoleAssignments",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->



