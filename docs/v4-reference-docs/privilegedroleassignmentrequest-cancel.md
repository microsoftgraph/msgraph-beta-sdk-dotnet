---
title: "Cancel privilegedRoleAssignmentRequest"
description: "Cancel a privilegedRoleAssignmentRequest."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# Cancel privilegedRoleAssignmentRequest

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure Active Directory (Azure AD) roles is deprecated and stopped returning data on May 31, 2021. Use the new [PIM v3 API for managing Azure AD roles](/graph/api/resources/privilegedidentitymanagementv3-overview) or learn how to [migrate](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Cancel a [privilegedRoleAssignmentRequest](../resources/privilegedroleassignmentrequest.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD    |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |


### HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /privilegedRoleAssignmentRequests/{requestid}/cancel
```

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 Ok` response code. It returns [privilegedRoleAssignmentRequest](../resources/privilegedroleassignmentrequest.md) in the response body.

### Error codes
This API returns the standard HTTP error codes. In addition, it returns the custom error codes listed in the following table.

|Error code     | Error message              |
|:--------------------| :---------------------|
| 400 BadRequest | RequestId cannot be Null. |
| 400 BadRequest | Request with request ID not found. |
| 400 BadRequest | Cancellation can be done only on status Scheduled and PendingApproval. |
| 403 UnAuthorized | Requester not allowed to make Cancel call or request not found. |

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cancel_privilegedRoleAssignmentRequests"
}-->
```http
POST https://graph.microsoft.com/beta/privilegedRoleAssignmentRequests/7c53453e-d5a4-41e0-8eb1-32d5ec8bfdee/cancel
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.PrivilegedRoleAssignmentRequests["{privilegedRoleAssignmentRequest-id}"]
	.Cancel()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

