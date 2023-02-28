---
title: "List servicePrincipals"
description: "Retrieve a list of servicePrincipal objects."
ms.localizationpriority: high
doc_type: apiPageType
ms.prod: "applications"
author: "sureshja"
---

# List servicePrincipals

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [servicePrincipal](../resources/serviceprincipal.md) objects.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
| Delegated (work or school account) | Application.Read.All, Application.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Application.ReadWrite.OwnedBy, Application.ReadWrite.All, Directory.Read.All |

> [!NOTE]
> A service principal can retrieve its own application and service principal details without being granted any application permissions.
> The *Application.ReadWrite.OwnedBy* permission allows an app to call `GET /applications` and `GET /servicePrincipals` to list all applications and service principals in the tenant. This scope of access has been allowed for the permission.

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /servicePrincipals
```

## Optional query parameters

This method supports the `$count`, `$expand`, `$filter`, `$orderBy`, `$search`, `$select`, and `$top` [OData query parameters](/graph/query-parameters) to help customize the response. The default and maximum page sizes are 100 and 999 service principal objects respectively. Some queries are supported only when you use the **ConsistencyLevel** header set to `eventual` and `$count`. For more information, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

By default, this API doesn't return the value of the **key** in the **keyCredentials** property when listing all service principals. To retrieve the public key info in **key**, the **keyCredentials** property must be specified in a `$select` query. For example, `$select=id,appId,keyCredentials`.

The use of `$select` to get **keyCredentials** for service principals has a throttling limit of 150 requests per minute for every tenant.

## Request headers

| Name | Description |
|:---- |:----------- |
| Authorization | Bearer {token}. Required. |
| ConsistencyLevel | eventual. This header and `$count` are required when using `$search`, or in specific usage of `$filter`. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries). |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [servicePrincipal](../resources/serviceprincipal.md) objects in the response body.

## Examples

### Example 1: Get a list of service principals

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_serviceprincipal"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var servicePrincipals = await graphClient.ServicePrincipals
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.

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
      "accountEnabled":true,
      "displayName":"amasf",
      "publisherName":"Contoso",
      "servicePrincipalType":"Application",
      "signInAudience":"AzureADMyOrg"
    }
  ]
}
```

### Example 2: Get only a count of service principals

#### Request

The following is an example of the request. This request requires the **ConsistencyLevel** header set to `eventual` because `$count` is in the request. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

>**Note:** The `$count` and `$search` query parameters are currently not available in Azure AD B2C tenants.

<!-- {
  "blockType": "ignored",
  "name": "get_count_only"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals/$count
ConsistencyLevel: eventual
```

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 200 OK
Content-type: text/plain

893
```

### Example 3: Use $filter and $top to get one service principal with a display name that starts with 'a' including a count of returned objects

#### Request

The following is an example of the request. This request requires the **ConsistencyLevel** header set to `eventual` and the `$count=true` query string because the request has both the `$orderBy` and `$filter` query parameters. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

>**Note:** The `$count` and `$search` query parameters are currently not available in Azure AD B2C tenants.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_serviceprincipals_startswith"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals?$filter=startswith(displayName, 'a')&$count=true&$top=1&$orderby=displayName
ConsistencyLevel: eventual
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("$count", "true")
};

var servicePrincipals = await graphClient.ServicePrincipals
	.Request( queryOptions )
	.Header("ConsistencyLevel","eventual")
	.Filter("startswith(displayName, 'a')")
	.OrderBy("displayName")
	.Top(1)
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
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
  "@odata.context":"https://graph.microsoft.com/beta/$metadata#servicePrinciples",
  "@odata.count":1,
  "value":[
    {
      "accountEnabled":true,
      "displayName":"a",
      "publisherName":"Contoso",
      "servicePrincipalType":"Application",
      "signInAudience":"AzureADMyOrg"
    }
  ]
}
```

### Example 4: Use $search to get service principals with display names that contain the letters 'Team' including a count of returned objects

#### Request

The following is an example of the request. This request requires the **ConsistencyLevel** header set to `eventual` because `$search` and the `$count=true` query string is in the request. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

>**Note:** The `$count` and `$search` query parameters are currently not available in Azure AD B2C tenants.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_serviceprincipals_search_count_select"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/servicePrincipals?$search="displayName:Team"&$count=true&$select=accountEnabled,displayName,publisherName,servicePrincipalType,signInAudience
ConsistencyLevel: eventual
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("$count", "true"),
	new QueryOption("$search", "\"displayName:Team\"")
};

var servicePrincipals = await graphClient.ServicePrincipals
	.Request( queryOptions )
	.Header("ConsistencyLevel","eventual")
	.Select("accountEnabled,displayName,publisherName,servicePrincipalType,signInAudience")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.
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
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#servicePrincipals(accountEnabled,displayName,publisherName,servicePrincipalType,signInAudience)",
  "@odata.count":1396,
  "value":[
    {
      "accountEnabled":true,
      "displayName":"myContosoTeam",
      "publisherName":"Contoso",
      "servicePrincipalType":"Application",
      "signInAudience":"AzureADMyOrg"
    }
  ]
}
```

### Example 5: Get service principals with less than two owners

#### Request

Here is an example of the request. This request requires the **ConsistencyLevel** header set to `eventual` because `$count` is in the request. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

>**Note:** The `$count` and `$search` query parameters are currently not available in Azure AD B2C tenants.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_serviceprincipals_lessthan2owners"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/serviceprincipals?$filter=owners/$count eq 0 or owners/$count eq 1&$count=true&$select=id,displayName
ConsistencyLevel: eventual
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("$count", "true")
};

var serviceprincipals = await graphClient.Serviceprincipals
	.Request( queryOptions )
	.Header("ConsistencyLevel","eventual")
	.Filter("owners/$count eq 0 or owners/$count eq 1")
	.Select("id,displayName")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Here is an example of the response.
> **Note:** The response object shown here might be shortened for readability.

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
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#servicePrincipals(id,displayName)",
    "@odata.count": 3,
    "value": [
        {
            "id": "c4ca17b7-4f3e-4c3a-b884-bfa4100c745d",
            "displayName": "Box"
        },
        {
            "id": "b5966bf3-e895-4f01-ae19-64f434c35b58",
            "displayName": "LinkedIn"
        },
        {
            "id": "ed17bd95-fbef-43eb-abea-9496e46eee42",
            "displayName": "BrowserStack"
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List servicePrincipals",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->



