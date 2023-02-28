---
title: "Create privilegedRoleAssignmentRequest"
description: "Create a privilegedroleassignmentrequest object."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# Create privilegedRoleAssignmentRequest

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure Active Directory (Azure AD) roles is deprecated and stopped returning data on May 31, 2021. Use the new [PIM v3 API for managing Azure AD roles](/graph/api/resources/privilegedidentitymanagementv3-overview) or learn how to [migrate](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Create a [privilegedroleassignmentrequest](../resources/privilegedroleassignmentrequest.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD    |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /privilegedRoleAssignmentRequests
```

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, supply a JSON representation of [privilegedroleassignmentrequest](../resources/privilegedroleassignmentrequest.md) object. 

| Property	   | Type	 |  Description|
|:---------------|:--------|:----------|
|roleId|String|The ID of the role. Required.|
|type|String|Represents the type of the operation on the role assignment. The value can be `AdminAdd`: Administrators add users to roles;`UserAdd`: Users add role assignments. Required.|
|assignmentState|String|The state of the assignment. The value can be `Eligible` for eligible assignment `Active` - if it is directly assigned `Active` by administrators, or activated on an eligible assignment by the users. Possible values are: ``NotStarted``, `Completed`, `RequestedApproval`, `Scheduled`, `Approved`, `ApprovalDenied`, `ApprovalAborted`, `Cancelling`, `Cancelled`, `Revoked`, `RequestExpired`. Required.|
|reason|String|The reason needs to be provided for the role assignment request for audit and review purpose.|
|schedule|[governanceSchedule](../resources/governanceschedule.md)|The schedule of the role assignment request.|

## Response
If successful, this method returns a `201 Created` response code and a [privilegedRoleAssignmentRequest](../resources/privilegedroleassignmentrequest.md) object in the response body.

### Error codes
This API returns that standard HTTP error codes. In addition, it can return the error codes listed in the following table.

|Error code     | Error message              | 
|:--------------------| :---------------------|
| 400 BadRequest | RoleAssignmentRequest property was NULL |
| 400 BadRequest | Unable to deserialize roleAssignmentRequest Object. |
| 400 BadRequest | RoleId is required. |
| 400 BadRequest | Schedule start date must be specified and should be greater than Now. |
| 400 BadRequest | A schedule already exists for this user, role and schedule type. |
| 400 BadRequest | A pending approval already exists for this user, role and approval type. |
| 400 BadRequest | Requestor reason is missing. |
| 400 BadRequest | Requestor reason should be less than 500 characters. |
| 400 BadRequest | Elevation duration must be between 0.5 and {from setting}. |
| 400 BadRequest | There is a overlap between scheduled activation and the request. |
| 400 BadRequest | The role is already activated. |
| 400 BadRequest | GenericElevateUserToRoleAssignments: Tickting information is required and not supplied in the activation process. |
| 400 BadRequest | There is a overlap between scheduled activation and the request. |
| 403 UnAuthorized | Elevation requires Multi-Factor Authentication. |
| 403 UnAuthorized | On behalf of elevation is not allowed. |

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_privilegedroleassignmentrequest"
}-->
```http
POST https://graph.microsoft.com/beta/privilegedRoleAssignmentRequests
Content-type: application/json

{
    "duration": "2",
    "reason": "Activate the role for business purpose",
    "ticketNumber": "234",
    "ticketSystem": "system",
    "schedule": {
        "startDateTime": "2018-02-08T02:35:17.903Z"
    },
    "type": "UserAdd",
    "assignmentState": "Active",
    "roleId": "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var privilegedRoleAssignmentRequest = new PrivilegedRoleAssignmentRequestObject
{
	Duration = "2",
	Reason = "Activate the role for business purpose",
	TicketNumber = "234",
	TicketSystem = "system",
	Schedule = new GovernanceSchedule
	{
		StartDateTime = DateTimeOffset.Parse("2018-02-08T02:35:17.903Z")
	},
	Type = "UserAdd",
	AssignmentState = "Active",
	RoleId = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
};

await graphClient.PrivilegedRoleAssignmentRequests
	.Request()
	.AddAsync(privilegedRoleAssignmentRequest);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

