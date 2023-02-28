---
title: "unifiedRoleEligibilitySchedule: filterByCurrentUser"
description: "Get a list of the unifiedRoleEligibilitySchedule objects and their properties filtered by a particular user principal"
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# unifiedRoleEligibilitySchedule: filterByCurrentUser
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [unifiedRoleEligibilitySchedule](../resources/unifiedRoleEligibilitySchedule.md) objects and their properties associated with a particular principal object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleEligibilitySchedule.Read.Directory, RoleManagement.Read.Directory, RoleManagement.Read.All, RoleEligibilitySchedule.ReadWrite.Directory, RoleManagement.ReadWrite.Directory |
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.Read.All, RoleManagement.Read.Directory, RoleManagement.ReadWrite.Directory|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET roleManagement/directory/roleEligibilitySchedules/filterByCurrentUser(on='principal')
```

## Function parameters
The following table shows the parameters that can be used with this method.

|Parameter|Type|Description|
|:---|:---|:---|
|on|roleEligibilityScheduleFilterByCurrentUserOptions|The currently signed-in user. Allowed value is `principal`.|

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [unifiedRoleEligibilitySchedule](../resources/unifiedroleeligibilityschedule.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "unifiedroleeligibilityschedule_filterbycurrentuser"
}
-->
``` http
GET https://graph.microsoft.com/beta/roleManagement/directory/roleEligibilitySchedules/filterByCurrentUser(on='principal')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var filterByCurrentUser = await graphClient.RoleManagement.Directory.RoleEligibilitySchedules
	.FilterByCurrentUser(RoleEligibilityScheduleFilterByCurrentUserOptions.Principal)
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response showing an eligibility schedule that is through a group assignment.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.unifiedRoleEligibilitySchedule)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(unifiedRoleEligibilitySchedule)",
    "value": [
        {
            "@odata.type": "#microsoft.graph.unifiedRoleEligibilitySchedule",
            "id": "6938d75d-ad66-4c7d-9028-0c9b00296945",
            "principalId": "c6ad1942-4afa-47f8-8d48-afb5d8d69d2f",
            "roleDefinitionId": "fe930be7-5e62-47db-91af-98c3a49a38b1",
            "directoryScopeId": "/",
            "appScopeId": null,
            "createdUsing": "6938d75d-ad66-4c7d-9028-0c9b00296945",
            "createdDateTime": "2021-08-09T10:15:05.96Z",
            "modifiedDateTime": "0001-01-01T08:00:00Z",
            "status": "Provisioned",
            "memberType": "Direct",
            "scheduleInfo": {
                "startDateTime": "2021-08-09T10:15:05.96Z",
                "recurrence": null,
                "expiration": {
                    "type": "noExpiration",
                    "endDateTime": null,
                    "duration": null
                }
            }
        }
    ]
}
```

