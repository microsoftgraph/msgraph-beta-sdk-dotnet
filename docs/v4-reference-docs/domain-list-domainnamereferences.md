---
title: "List domainNameReferences"
description: "Retrieve a list of directoryObject with a reference to the domain."
author: "adimitui"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List domainNameReferences

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [directoryObject](../resources/directoryobject.md) with a reference to the domain. The returned list will contain all directory objects that have a dependency on the domain.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Domain.Read.All, Domain.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Domain.Read.All, Domain.ReadWrite.All |

The work or school account needs to belong to one of the following roles:

* Global Administrator
* Domain Name Administrator
* Partner Tier2 Support
* Global Reader


When an application queries a relationship that returns a directoryObject type collection, if it does not have permission to read a certain derived type (like device), members of that type are returned but with limited information. With this behaviour applications can request the least privileged permissions they need, rather than rely on the set of *Directory.** permissions. For details, see [Limited information returned for inaccessible member objects](/graph/permissions-overview#limited-information-returned-for-inaccessible-member-objects).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /domains/{id}/domainNameReferences
```

## Optional query parameters

This method supports the `$select` and `$filter` [OData Query Parameters](/graph/query-parameters) to help customize the response. You can only filter by the OData type of the objects returned, for example, `/domains/{domainId}/domainNameReferences/microsoft.graph.group` and `/domains/{domainId}/domainNameReferences/microsoft.graph.user`.

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [directoryObject](../resources/directoryobject.md) objects in the response body.

## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_domainnamereferences",
  "sampleKeys": ["contoso.com"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/domains/contoso.com/domainNameReferences
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var domainNameReferences = await graphClient.Domains["{domain-id}"].DomainNameReferences
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

