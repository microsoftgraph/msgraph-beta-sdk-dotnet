---
title: "Get organization"
description: "Retrieve the properties and relationships of currently authenticated organization."
ms.localizationpriority: medium
author: "adimitui"
ms.prod: "directory-management"
doc_type: apiPageType
---

# Get organization

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the properties and relationships of the currently authenticated organization.

Since the **organization** resource supports [extensions](/graph/extensibility-overview), you can also use the `GET` operation to get custom properties and extension data in an **organization** instance.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, Organization.Read.All, Directory.Read.All, Organization.ReadWrite.All, Directory.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Organization.Read.All, Directory.Read.All, Organization.ReadWrite.All, Directory.ReadWrite.All |

The calling user must also be in one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference):

* Global Administrator
* User Administrator
* User
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
* Customer LockBox Access Approver
* Dynamics 365 Administrator
* Power BI Administrator
* Azure Information Protection Administrator
* Desktop Analytics Administrator
* License Administrator
* Microsoft Managed Desktop Administrator
* Authentication Administrator
* Privileged Authentication Administrator
* Teams Communications Administrator
* Teams Communications Support Engineer
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
* Guest User
* Restricted Guest User

> **Note**: Applications granted the User.Read permission are able to read only the **id**, **displayName**, and **verifiedDomains** properties of the organization.  All other properties will return with `null` values. To read all properties, use Organization.Read.All.

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /organization
```

## Optional query parameters

This method supports only the `$select` [OData query parameter](/graph/query-parameters) to help customize the response.

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of one [organization](../resources/organization.md) object in the response body.

## Example

##### Request

Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_organization_1"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/84841066-274d-4ec0-a5c1-276be684bdd3
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var organization = await graphClient.Organization["{organization-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

