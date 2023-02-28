---
title: "cloudPcUserSetting: assign"
description: "Assign a Cloud PC user setting to user groups."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPcUserSetting: assign

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Assign a [cloudPcUserSetting](../resources/cloudpcusersetting.md) to user groups.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /deviceManagement/virtualEndpoint/userSettings/{id}/assign
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [cloudPcUserSettingAssignment](../resources/cloudpcusersettingassignment.md) object.

|Parameter|Type|Description|
|:---|:---|:---|
|assignments|[cloudPcUserSettingAssignment](../resources/cloudpcusersettingassignment.md) collection | The collection of Cloud PC user setting resources each to be assigned to the corresponding target group. Only Microsoft 365 groups and security groups in Azure AD are currently supported. |

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpcusersetting_assign",
  "sampleKeys": ["b0c2d35f-3385-46c8-a6f5-6c3dfad7708b_64ff06de-9c00-4a5a-98b5-7f5abe26ffff"]
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/userSettings/b0c2d35f-3385-46c8-a6f5-6c3dfad7708b_64ff06de-9c00-4a5a-98b5-7f5abe26ffff/assign
Content-Type: application/json

{
  "assignments": [
    {
      "id": "b0c2d35f-3385-46c8-a6f5-6c3dfad7708b_64ff06de-9c00-4a5a-98b5-7f5abe26ffff",
      "target":{
        "@odata.type": "microsoft.graph.cloudPcManagementGroupAssignmentTarget",
        "groupId":"64ff06de-9c00-4a5a-98b5-7f5abe26ffff"
        }
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var assignments = new List<CloudPcUserSettingAssignment>()
{
	new CloudPcUserSettingAssignment
	{
		Id = "b0c2d35f-3385-46c8-a6f5-6c3dfad7708b_64ff06de-9c00-4a5a-98b5-7f5abe26ffff",
		Target = new CloudPcManagementGroupAssignmentTarget
		{
			GroupId = "64ff06de-9c00-4a5a-98b5-7f5abe26ffff"
		}
	}
};

await graphClient.DeviceManagement.VirtualEndpoint.UserSettings["{cloudPcUserSetting-id}"]
	.Assign(assignments)
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
