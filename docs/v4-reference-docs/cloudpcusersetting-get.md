---
title: "Get cloudPcUserSetting"
description: "Read the properties and relationships of a cloudPcUserSetting object."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Get cloudPcUserSetting

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [cloudPcUserSetting](../resources/cloudpcusersetting.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.Read.All, CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.Read.All, CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /deviceManagement/virtualEndpoint/userSettings/{id}
```

## Optional query parameters

This method supports `$select` and `$expand` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [cloudPcUserSetting](../resources/cloudpcusersetting.md) object in the response body.

## Examples

### Example 1: Get the properties of the specified user setting

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpcusersetting"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/userSettings/556092f8-92f8-5560-f892-6055f8926055
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcUserSetting = await graphClient.DeviceManagement.VirtualEndpoint.UserSettings["{cloudPcUserSetting-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcUserSetting"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.cloudPcUserSetting",
    "id": "556092f8-92f8-5560-f892-6055f8926055",
    "displayName": "String",
    "selfServiceEnabled": true,
    "localAdminEnabled": false,
    "restorePointSetting": {
      "frequencyInHours": 16,
      "userRestoreEnabled": true
    },
    "lastModifiedDateTime": "2021-02-01T10:29:57Z",
    "createdDateTime": "2021-02-01T10:29:57Z"
  }
}
```

### Example 2: Get the properties of the specified user setting and expand on the assignments

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpcusersetting_2"
}
-->

``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/usersettings/b0c2d35f-3385-46c8-a6f5-6c3dfad7ffff?$expand=assignments
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcUserSetting = await graphClient.DeviceManagement.VirtualEndpoint.UserSettings["{cloudPcUserSetting-id}"]
	.Request()
	.Expand("assignments")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcUserSetting"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.cloudPcUserSetting",
    "id": "b0c2d35f-3385-46c8-a6f5-6c3dfad7ffff",
    "displayName": "Display Name value",
    "selfServiceEnabled": true,
    "localAdminEnabled": false,
    "restorePointSetting": {
      "frequencyInHours": 16,
      "userRestoreEnabled": true
    },
    "lastModifiedDateTime": "2021-02-01T10:29:57Z",
    "createdDateTime": "2021-02-01T10:29:57Z",
    "assignments": [
      {
        "@odata.type": "microsoft.graph.cloudPcUserSettingAssignment",
        "id": "b0c2d35f-3385-46c8-a6f5-6c3dfad7708b_64ff06de-9c00-4a5a-98b5-7f5abe26ffff",
        "createdDateTime": "2021-02-01T10:29:57Z",
        "target": {
          "@odata.type":"microsoft.graph.cloudPCManagementGroupAssignmentTarget",
          "groupId":"64ff06de-9c00-4a5a-98b5-7f5abe26bfd9"
          }
      }
    ]
}
```
