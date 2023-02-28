---
title: "List roleEligibilityScheduleRequests"
description: "Get a list of the unifiedRoleEligibilityScheduleRequest objects and their properties."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# List roleEligibilityScheduleRequests
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [unifiedRoleEligibilityScheduleRequest](../resources/unifiedroleeligibilityschedulerequest.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleEligibilitySchedule.Read.Directory, RoleManagement.Read.Directory, RoleManagement.Read.All, RoleEligibilitySchedule.ReadWrite.Directory, RoleManagement.ReadWrite.Directory	|
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.ReadWrite.Directory |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /roleManagement/directory/roleEligibilityScheduleRequests
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [unifiedRoleEligibilityScheduleRequest](../resources/unifiedroleeligibilityschedulerequest.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_unifiedroleeligibilityschedulerequest"
}
-->
``` http
GET https://graph.microsoft.com/beta/roleManagement/directory/roleEligibilityScheduleRequests
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var roleEligibilityScheduleRequests = await graphClient.RoleManagement.Directory.RoleEligibilityScheduleRequests
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.unifiedRoleEligibilityScheduleRequest)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/directory/roleEligibilityScheduleRequests",
  "value": [
    {
      "id": "19757c21-7844-4478-b4b6-68aed0cd2d52",
      "status": "Provisioned",
      "createdDateTime": "2021-07-13T19:17:33.373Z",
      "completedDateTime": "2021-07-13T19:17:33.427Z",
      "approvalId": null,
      "customData": null,
      "action": "AdminAssign",
      "principalId": "5659e4d9-9ab6-4678-9f1b-72322d469e9b",
      "roleDefinitionId": "fdd7a751-b60b-444a-984c-02652fe8fa1c",
      "directoryScopeId": "/",
      "appScopeId": null,
      "isValidationOnly": false,
      "targetScheduleId": "19757c21-7844-4478-b4b6-68aed0cd2d52",
      "justification": null,
      "createdBy": {
        "application": null,
        "device": null,
        "user": {
          "displayName": null,
          "id": "fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f"
        }
      },
      "scheduleInfo": {
        "startDateTime": "2021-07-13T19:17:33.4258055Z",
        "recurrence": null,
        "expiration": {
          "type": "afterDateTime",
          "endDateTime": "2022-07-13T19:16:02.506Z",
          "duration": null
        }
      },
      "ticketInfo": {
      "ticketNumber": null,
      "ticketSystem": null
      }
    }
  ]
}
        
```

