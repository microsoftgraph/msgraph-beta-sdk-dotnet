---
title: "unifiedRoleEligibilityScheduleRequest: cancel"
description: "Cancel a unifiedRoleEligibilityScheduleRequest."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# unifiedRoleEligibilityScheduleRequest: cancel
Namespace: microsoft.graph

Immediately cancel a [unifiedRoleEligibilityScheduleRequest](../resources/unifiedroleeligibilityschedulerequest.md) that is in a `Granted` status, and have the system automatically delete the cancelled request after 30 days. After calling this action, the **status** of the cancelled unifiedRoleEligibilityScheduleRequest changes to `Revoked`.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleEligibilitySchedule.ReadWrite.Directory, RoleManagement.ReadWrite.Directory	|
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.ReadWrite.Directory |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /roleManagement/directory/roleEligibilityScheduleRequests/{unifiedRoleEligibilityScheduleRequestsId}/cancel
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this action returns a `204 No Content` response code. Attempting to cancel a request that is not in a cancelable state, for example, a unifiedRoleEligibilityScheduleRequest object whose **status** is `Provisioned` or `Failed`, returns a `400 Bad Request` error code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "unifiedroleeligibilityschedulerequest_cancel"
}
-->
``` http
POST https://graph.microsoft.com/beta/roleManagement/directory/roleEligibilityScheduleRequests/532bef1f-c677-4564-aa6f-811444a4f018/cancel
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.RoleManagement.Directory.RoleEligibilityScheduleRequests["{unifiedRoleEligibilityScheduleRequest-id}"]
	.Cancel()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

