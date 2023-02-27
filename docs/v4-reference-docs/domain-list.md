---
title: "List domains"
description: "Retrieve a list of domain objects."
author: "adimitui"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List domains

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of domain objects.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Domain.Read.All, Domain.ReadWrite.All, Directory.Read.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Domain.Read.All, Domain.ReadWrite.All, Directory.Read.All |

The work or school account needs to belong to one of the following roles:

* Global Administrator
* User Administrator
* Helpdesk Administrator
* Service Support Administrator
* Billing Administrator
* Mailbox Administrator
* Partner Tier1 Support
* Partner Tier2 Support
* Directory Readers
* Directory Writers
* AdHoc License Administrator
* Application Administrator
* Security Reader
* Security Administrator
* Privileged Role Administrator
* Cloud Application Administrator
* Customer LockBox Access Approver
* Dynamics 365 Administrator
* Power BI Administrator
* Azure Information Protection Administrator
* Desktop Analytics Administrator
* License Administrator
* Microsoft Managed Desktop Administrator
* Privileged Authentication Administrator
* Teams Communications Administrator
* Teams Communications Support Engineer
* Authentication Administrator
* Teams Communications Support Specialist
* Teams Administrator
* Insights Administrator
* Compliance Data Administrator
* Security Operator
* Kaizala Administrator
* Global Reader
* Volume Licensing Business Center User
* Volume Licensing Service Center User
* Modern Commerce User
* Microsoft Store for Business User
* Directory Reviewer
* Domain Name Administrator
* Users
* Guest User
* Restricted Guest User

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /domains
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required.|
| Accept         | application/json; |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [domain](../resources/domain.md) objects in the response body.
## Example
##### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_domains"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/domains
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var domains = await graphClient.Domains
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

