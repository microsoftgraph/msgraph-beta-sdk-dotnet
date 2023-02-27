---
title: "Create cloudPcUserSetting"
description: "Create a new cloudPcUserSetting ."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Create cloudPcUserSetting

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [cloudPcUserSetting](../resources/cloudpcusersetting.md) object.

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
POST /deviceManagement/virtualEndpoint/userSettings
```

## Request headers

| Name          | Description                |
| :------------ | :------------------------  |
| Authorization | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [cloudPcUserSetting](../resources/cloudpcusersetting.md) object.

The following table shows the properties that are required when you create the [cloudPcUserSetting](../resources/cloudpcusersetting.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The setting name as it appears in the UI. |
|localAdminEnabled|Boolean|To turn on the local admin option, change this setting to `True`.  |
|selfServiceEnabled|Boolean|To turn on the self service option, change this setting to `True`. |
|restorePointSetting|[cloudPcRestorePointSetting](../resources/cloudpcrestorepointsetting.md)|Defines how frequently a restore point is created (that is, a snapshot is taken) for users' provisioned Cloud PCs (default is 12 hours), and whether the user is allowed to restore their own Cloud PCs to a backup made at a specific point in time.|
|lastModifiedDateTime|DateTimeOffset|The last date and time the setting was modified. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'. |

## Response

If successful, this method returns a `201 Created` response code and a [cloudPcUserSetting](../resources/cloudpcusersetting.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_cloudpcusersetting_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/userSettings
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcUserSetting",
  "displayName": "Example",
  "selfServiceEnabled": false,
  "localAdminEnabled": true,
  "restorePointSetting": {
    "frequencyInHours": 16,
    "userRestoreEnabled": true
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcUserSetting = new CloudPcUserSetting
{
	DisplayName = "Example",
	SelfServiceEnabled = false,
	LocalAdminEnabled = true,
	RestorePointSetting = new CloudPcRestorePointSetting
	{
		FrequencyInHours = 16,
		UserRestoreEnabled = true
	}
};

await graphClient.DeviceManagement.VirtualEndpoint.UserSettings
	.Request()
	.AddAsync(cloudPcUserSetting);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcUserSetting"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcUserSetting",
  "id": "556092f8-92f8-5560-f892-6055f8926055",
  "displayName": "Example",
  "selfServiceEnabled": false,
  "localAdminEnabled": true,
  "restorePointSetting": {
    "frequencyInHours": 16,
    "userRestoreEnabled": true
  },
  "lastModifiedDateTime": "2021-02-01T10:29:57Z"  
}
```

