---
title: "privilegedRole: selfActivate"
description: "Activate the role that is assigned to the requester."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# privilegedRole: selfActivate

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the Privileged Identity Management (PIM) API for Azure Active Directory (Azure AD) roles is deprecated and stopped returning data on May 31, 2021. Use the new [PIM v3 API for managing Azure AD roles](/graph/api/resources/privilegedidentitymanagementv3-overview) or learn how to [migrate](/graph/api/resources/privilegedidentitymanagement-root#migrate-from-pim-v2-to-pim-v3-apis).

Activate the role that is assigned to the requester.

>**Note:** Effective December 2018, this API will no longer be supported and should not be used. Use the [Create PrivilegedRoleAssignmentRequest](privilegedroleassignmentrequest-post.md) instead.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

The requestor can only call ```selfActivate``` for the role that is assigned to him.
 

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.AccessAsUser.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /privilegedRoles/{id}/selfActivate
```

Note that ``{id}`` is the target role ID.
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|reason|string|Optional. Description about the reason for this role activation.|
|duration|string|Optional. Valid values could be ```min``` (minimal activation duration), ```default``` (default activation duration for the role), or a double value to specify how many hours is the activation. The specified duration cannot be longer than the role's activation duration from the role setting. |
|ticketNumber|string|Optional. The ticket number that is used to tracking this role activation.|
|ticketSystem|string|Optional. The ticket system.|

## Response

If successful, this method returns a `200 OK` response code and a [privilegedRoleAssignment](../resources/privilegedroleassignment.md) object in the response body.

Note that the tenant needs to be registered to PIM. Otherwise, the HTTP 403 Forbidden status code will be returned.
## Example
The following example shows how to call this API.
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "privilegedrole_selfactivate"
}-->
```http
POST https://graph.microsoft.com/beta/privilegedRoles/{id}/selfActivate
Content-type: application/json

{
  "reason": "reason-value",
  "duration": "duration-value",
  "ticketNumber": "ticketNumber-value",
  "ticketSystem": "ticketSystem-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reason = "reason-value";

var duration = "duration-value";

var ticketNumber = "ticketNumber-value";

var ticketSystem = "ticketSystem-value";

await graphClient.PrivilegedRoles["{privilegedRole-id}"]
	.SelfActivate(reason,duration,ticketNumber,ticketSystem)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

