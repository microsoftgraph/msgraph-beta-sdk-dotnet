---
title: "Update privilegedRoleSettings"
description: "Update the role settings for the given role setting. A privilegedRoleSettings object will be returned."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "rkarim-ms"
---

# Update privilegedRoleSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the role settings for the given role setting. A [privilegedRoleSettings](../resources/privilegedrolesettings.md) object will be returned.
## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

>**Note:** The requester must have the Privileged Role Administrator role to update role settings. 

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | PrivilegedAccess.ReadWrite.AzureAD    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PUT /privilegedRoles/{id}/settings
```

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, supply a JSON representation of a [privilegedRoleSettings](../resources/privilegedrolesettings.md) object.

The following table lists the properties that you can supply when you update a role setting.

|Property|Type|Description|
|:---------------|:--------|:----------|
|elevationDuration|duration|The duration when the role is activated. Required.|
|id|string|The unique identifier for the role settings. Read-only. Required.|
|isMfaOnElevationConfigurable|boolean|**true** if mfaOnElevation is configurable. **false** if mfaOnElevation is not configurable. Required.|
|lastGlobalAdmin|Boolean|For internal use only.|
|maxElavationDuration|duration|Maximum duration for the activated role. Required.|
|mfaOnElevation|Boolean|**true** if MFA is required to activate the role. **false** if MFA is not required to activate the role. Required.|
|minElevationDuration|duration|Minimum duration for the activated role. Required.|
|notificationToUserOnElevation|Boolean|**true** if send notification to the end user when the role is activated. **false** if do not send notification when the role is activated. Required.|
|ticketingInfoOnElevation|Boolean|**true** if the ticketing information is required when activate the role. **false** if the ticketing information is not required when activate the role. Required.|
|approvalOnElevation|Boolean|**true** if the approval is required when activate the role. **false** if the approval is not required when activate the role. Required.|
|approverIds|string collection|List of Approval IDs, if approval is required for activation.|

## Response

If successful, this method returns a `204 No Content` response code.

Note that the tenant needs to be registered to PIM. Otherwise, the HTTP 403 Forbidden status code will be returned.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "put_privilegedrolesettings"
}-->
```http
PUT https://graph.microsoft.com/beta/privilegedRoles/{id}/settings
Content-type: application/json

{
    "id": "9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3",
    "elevationDuration": "PT8H",
    "notificationToUserOnElevation": false,
    "ticketingInfoOnElevation": true,
    "mfaOnElevation": false,
    "maxElavationDuration": "PT0S",
    "minElevationDuration": "PT0S",
    "lastGlobalAdmin": false,
    "isMfaOnElevationConfigurable": true,
    "approvalOnElevation": false,
    "approverIds": ["e2b2a2fb-13d7-495c-adc9-941fe966793f", "22770e3f-b9b4-418e-9dea-d0e3d2f275dd"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var privilegedRoleSettings = new PrivilegedRoleSettings
{
	Id = "9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3",
	ElevationDuration = new Duration("PT8H"),
	NotificationToUserOnElevation = false,
	TicketingInfoOnElevation = true,
	MfaOnElevation = false,
	MaxElavationDuration = new Duration("PT0S"),
	MinElevationDuration = new Duration("PT0S"),
	LastGlobalAdmin = false,
	IsMfaOnElevationConfigurable = true,
	ApprovalOnElevation = false,
	ApproverIds = new List<String>()
	{
		"e2b2a2fb-13d7-495c-adc9-941fe966793f",
		"22770e3f-b9b4-418e-9dea-d0e3d2f275dd"
	}
};

await graphClient.PrivilegedRoles["{privilegedRole-id}"].Settings
	.Request()
	.PutAsync(privilegedRoleSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

