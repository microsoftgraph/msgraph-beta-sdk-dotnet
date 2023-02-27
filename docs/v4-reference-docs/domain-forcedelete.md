---
title: "domain: forceDelete"
description: "Deletes a domain using an asynchronous operation."
author: "adimitui"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# domain: forceDelete

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Deletes a domain using an asynchronous operation.

Prior to calling [forceDelete](domain-forcedelete.md), you must update or remove any references to **Exchange** as the provisioning service.

The following actions are performed as part of this operation:

* Renames the UPN, EmailAddress, and ProxyAddress of users with references to the deleted domain.

* Renames the EmailAddress of groups with references to the deleted domain.

* Renames the identifierUris of applications with references to the deleted domain.

* If the number of objects to be renamed is greater than 1,000, an error is returned.

* If one of the applications to be renamed is a multi-tenant app, an error is returned.

After the domain deletion completes, API operations for the deleted domain will return a 404 HTTP response code. To verify deletion of a domain, you can perform a [get domain](domain-get.md). If the domain was successfully deleted, a 404 HTTP response code will be returned in the response.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Domain.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Domain.ReadWrite.All |

The work or school account needs to belong to one of the following roles:

* Global Administrator
* Domain Name Administrator
* Partner Tier2 Support

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /domains/{id}/forceDelete
```

> For {id}, specify the domain with its fully qualified domain name.

## Request headers

| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required.|
| Content-Type  | application/json |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|disableUserAccounts|Boolean| Option to disable renamed user accounts. If a user account is disabled, the user will not be allowed to sign in.<br>*True* (default) - User accounts renamed as part of this operation are disabled.<br>*False* - User accounts renamed as part of this operation are not disabled. |

## Response

If successful, this method returns `200 OK` response code. 

## Example
### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "domain_forcedelete",
  "sampleKeys": ["contoso.com"]
}-->
```http
POST https://graph.microsoft.com/beta/domains/contoso.com/forceDelete
Content-type: application/json

{
  "disableUserAccounts": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var disableUserAccounts = true;

await graphClient.Domains["{domain-id}"]
	.ForceDelete(disableUserAccounts)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 200 OK
```
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "domain: forcedelete",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


