---
title: "List roleEligibilityScheduleInstances"
description: "Get a list of the unifiedRoleEligibilityScheduleInstance objects and their properties."
author: "rkarim-ms"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# List roleEligibilityScheduleInstancess
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [unifiedRoleEligibilityScheduleInstance](../resources/unifiedroleeligibilityscheduleinstance.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|RoleEligibilitySchedule.Read.Directory, RoleManagement.Read.Directory, RoleManagement.Read.All, RoleEligibilitySchedule.ReadWrite.Directory, RoleManagement.ReadWrite.Directory|
|Delegated (personal Microsoft account)|Not supported|
|Application|RoleManagement.Read.All, RoleManagement.Read.Directory, RoleManagement.ReadWrite.Directory|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /roleManagement/directory/roleEligibilityScheduleInstances
```

## Optional query parameters
This method supports the `$select` and `$filter` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [unifiedRoleEligibilityScheduleInstance](../resources/unifiedroleeligibilityscheduleinstance.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_unifiedroleeligibilityscheduleinstance"
}
-->
``` http
GET https://graph.microsoft.com/beta/roleManagement/directory/roleEligibilityScheduleInstances
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var roleEligibilityScheduleInstances = await graphClient.RoleManagement.Directory.RoleEligibilityScheduleInstances
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
  "@odata.type": "Collection(microsoft.graph.unifiedRoleEligibilityScheduleInstance)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#roleManagement/directory/roleEligibilityScheduleInstances",
  "value": [
    {
      "id": "UafX_Qu2SkSYTAJlL-j6HCssmvzcHW1IohFf6Mp3-h9xbmLcN0jrQL5KvCnYihF4-2-e",
      "principalId": "fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f",
      "roleDefinitionId": "fdd7a751-b60b-444a-984c-02652fe8fa1c",
      "directoryScopeId": "/administrativeUnits/dc626e71-4837-40eb-be4a-bc29d88a1178",
      "appScopeId": null,
      "startDateTime": "2021-07-27T14:03:04.4Z",
      "endDateTime": null,
      "memberType": "Direct",
      "roleEligibilityScheduleId": "3dc04956-5e79-4e84-a2fc-4c168bb30a5f"
    },
    {
      "id": "UafX_Qu2SkSYTAJlL-j6HLFkgTmWUd1JraI2S0n5myc-1-e",
      "principalId": "398164b1-5196-49dd-ada2-364b49f99b27",
      "roleDefinitionId": "fdd7a751-b60b-444a-984c-02652fe8fa1c",
      "directoryScopeId": "/",
      "appScopeId": null,
      "startDateTime": "2021-07-27T13:51:08.43Z",
      "endDateTime": null,
      "memberType": "Direct",
      "roleEligibilityScheduleId": "313af44a-07c9-43a7-9970-5072a6b5591f"
    }
  ]
}
```

