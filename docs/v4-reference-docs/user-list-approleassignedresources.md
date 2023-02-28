---
title: "List appRoleAssignedResources"
description: "Get the service principals to which the user has an app role assignment either directly or through group membership."
author: "eringreenlee"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# List appRoleAssignedResources
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the service principals to which the user has an app role assignment either directly or through group membership.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                             |
| :------------------------------------- | :---------------------------------------------------------------------- |
| Delegated (work or school account)     | User.ReadBasic.All, Directory.Read.All, AppRoleAssignment.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                                                          |
| Application                            | Directory.Read.All, AppRoleAssignment.ReadWrite.All                     |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /me/appRoleAssignedResources?$count=true
ConsistencyLevel: eventual

GET /users/{userId}/appRoleAssignedResources?$count=true
ConsistencyLevel: eventual
```

## Optional query parameters
This method supports the `$count`, `$expand`, `$filter`, `$orderBy`, `$select`, and `$top` [OData query parameters](/graph/query-parameters) to help customize the response. The queries are supported only when you use the **ConsistencyLevel** header set to `eventual` and `$count`. For more information, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
| ConsistencyLevel | eventual. This header and `$count` are required when calling this API. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries). |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [servicePrincipal](../resources/serviceprincipal.md) objects in the response body. If you don't specify the `$count` query parameter and set the **ConsistencyLevel** header to `eventual`, this API returns  `404 Not Found error`.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_approleassignedresources_users"
}
-->
``` http
GET https://graph.microsoft.com/beta/me/appRoleAssignedResources?$count=true&$select=displayName,accountEnabled,servicePrincipalType,signInAudience
ConsistencyLevel: eventual
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("$count", "true")
};

var appRoleAssignedResources = await graphClient.Me.AppRoleAssignedResources
	.Request( queryOptions )
	.Header("ConsistencyLevel","eventual")
	.Select("displayName,accountEnabled,servicePrincipalType,signInAudience")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.servicePrincipal",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "0b372abb-b32e-459c-b263-b81ab6448df1",
      "accountEnabled":true,
      "displayName":"amasf",
      "servicePrincipalType":"Application",
      "signInAudience":"AzureADMyOrg"
    }
  ]
}
```
