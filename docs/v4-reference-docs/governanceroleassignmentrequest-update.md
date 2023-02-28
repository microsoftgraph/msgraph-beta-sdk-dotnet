---
title: "Update governanceRoleAssignmentRequests"
description: "Enable administrators to update their decisions (`AdminApproved` or `AdminDenied`) on governanceRoleAssignmentRequests that are in status of `PendingAdminDecision`."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# Update governanceRoleAssignmentRequests

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure resources will be deprecated soon. Please use the new [Azure REST PIM API for Azure resource roles](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Enable administrators to update their decisions (`AdminApproved` or `AdminDenied`) on [governanceRoleAssignmentRequests](../resources/governanceroleassignmentrequest.md) that are in status of `PendingAdminDecision`.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference#privileged-access-permissions).

>**Note:** This API also requires that the requester have at least one `Active` administrator role assignment (`owner` or `user access administrator`) on the resource that the [governanceRoleAssignmentRequest](../resources/governanceroleassignmentrequest.md) belongs to. 

### Azure resources

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureResources |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

### Azure AD

| Permission type | Permissions |
|:--------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

### Groups

|Permission type | Permissions |
|:-------------- |:----------- |
| Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureADGroup |
| Delegated (personal Microsoft account) | Not supported. |
| Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /privilegedAccess/azureResources/roleAssignmentRequests/{id}/updateRequest   
```

## Request headers
| Name           | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|
| Content-type  | application/json|

## Request body

|Parameters	     |Type	                 |Required |Description|
|:-------------|:----------------------|:--------|:----------|
|reason        |String                 |✓        |The reason provided by the administrator for his decision.|
|decision        |String                 |✓        |The administrator decision of the role assignment request. The value should be updated as `AdminApproved` or `AdminDenied`.|
|schedule      |[governanceSchedule](../resources/governanceschedule.md)|        | The schedule of the role assignment request. For status of `AdminApproved`, it is required.|
|assignmentState      |String|         | The state of assignment, and the values can be `Eligible` or `Active`. For decision of `AdminApproved`, it is required. |
### Response
This method can only be applied to requests that are in status of `PendingAdminDecision`.

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "updaterequest_governanceroleassignmentrequest"
}-->
```http
POST https://graph.microsoft.com/beta/privilegedAccess/azureResources/roleAssignmentRequests/7c53453e-d5a4-41e0-8eb1-32d5ec8bfdee/updateRequest
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.PrivilegedAccess["{privilegedAccess-id}"].RoleAssignmentRequests["{governanceRoleAssignmentRequest-id}"]
	.UpdateRequest(null,null,null,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

