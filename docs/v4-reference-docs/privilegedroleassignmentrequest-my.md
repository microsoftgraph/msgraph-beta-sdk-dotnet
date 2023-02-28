---
title: "privilegedRoleAssignmentRequest: my"
description: "Get the requester's privileged role assignment requests."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# privilegedRoleAssignmentRequest: my

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure Active Directory (Azure AD) roles is deprecated and stopped returning data on May 31, 2021. Use the new [PIM v3 API for managing Azure AD roles](/graph/api/resources/privilegedidentitymanagementv3-overview) or learn how to [migrate](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Get the requester's privileged role assignment requests.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD, Directory.Read.All    |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /privilegedRoleAssignmentRequests/my
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns `200 OK` response code and [privilegedRoleAssignmentRequest](../resources/privilegedroleassignmentrequest.md) collection object in the response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "privilegedroleassignmentrequest_my)"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/privilegedRoleAssignmentRequests/my
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var my = await graphClient.PrivilegedRoleAssignmentRequests
	.My()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

