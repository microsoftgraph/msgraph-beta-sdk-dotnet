---
title: "Grant an appRoleAssignment for a service principal"
description: "Grant an app role assignment for a service principal."
ms.localizationpriority: high
doc_type: apiPageType
ms.prod: "applications"
author: "psignoret"
---

# Grant an appRoleAssignment for a service principal

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Assign an app role for a resource service principal, to a user, group, or client service principal.

App roles that are assigned to service principals are also known as [application permissions](/azure/active-directory/develop/v2-permissions-and-consent#permission-types). Application permissions can be granted directly with app role assignments, or through a [consent experience](/azure/active-directory/develop/application-consent-experience).

To grant an app role assignment, you need three identifiers:

- `principalId`: The `id` of the **user**, **group** or client **servicePrincipal** to which you are assigning the app role.
- `resourceId`: The `id` of the resource **servicePrincipal** which has defined the app role.
- `appRoleId`: The `id` of the **appRole** (defined on the resource service principal) to assign to a user, group, or service principal.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | AppRoleAssignment.ReadWrite.All and Application.Read.All, AppRoleAssignment.ReadWrite.All and Directory.Read.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | AppRoleAssignment.ReadWrite.All and Application.Read.All, AppRoleAssignment.ReadWrite.All and Directory.Read.All |

## HTTP request

You can address the service principal using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/appRoleAssignedTo
POST /servicePrincipals(appId='{appId}')/appRoleAssignedTo

```

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization | Bearer {token}. Required.  |
| Content-type | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [appRoleAssignment](../resources/approleassignment.md) object.

## Response

If successful, this method returns a `201 Created` response code and an [appRoleAssignment](../resources/approleassignment.md) object in the response body.

## Examples

### Request

Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "serviceprincipal_create_approleassignedto"
}-->

```http
POST https://graph.microsoft.com/beta/servicePrincipals/9028d19c-26a9-4809-8e3f-20ff73e2d75e/appRoleAssignedTo
Content-Type: application/json

{
  "principalId": "33ad69f9-da99-4bed-acd0-3f24235cb296",
  "resourceId": "9028d19c-26a9-4809-8e3f-20ff73e2d75e",
  "appRoleId": "ef7437e6-4f94-4a0a-a110-a439eb2aa8f7"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var appRoleAssignment = new AppRoleAssignment
{
	PrincipalId = Guid.Parse("33ad69f9-da99-4bed-acd0-3f24235cb296"),
	ResourceId = Guid.Parse("9028d19c-26a9-4809-8e3f-20ff73e2d75e"),
	AppRoleId = Guid.Parse("ef7437e6-4f94-4a0a-a110-a439eb2aa8f7")
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].AppRoleAssignedTo
	.Request()
	.AddAsync(appRoleAssignment);

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
  "@odata.type": "microsoft.graph.appRoleAssignment"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#servicePrincipals('9028d19c-26a9-4809-8e3f-20ff73e2d75e')/appRoleAssignedTo/$entity",
  "id": "-WmtM5na7Uus0D8kI1yylpU9Mdo0Pb9OoBJvd3T5eKc",
  "deletedDateTime": null,
  "appRoleId": "ef7437e6-4f94-4a0a-a110-a439eb2aa8f7",
  "creationTimestamp": "2021-02-15T16:14:59.8643039Z",
  "principalDisplayName": "Parents of Contoso",
  "principalId": "33ad69f9-da99-4bed-acd0-3f24235cb296",
  "principalType": "Group",
  "resourceDisplayName": "Fabrikam App",
  "resourceId": "9028d19c-26a9-4809-8e3f-20ff73e2d75e"
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create appRoleAssignment",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
