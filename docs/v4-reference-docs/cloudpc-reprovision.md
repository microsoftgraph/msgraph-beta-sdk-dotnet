---
title: "cloudPC: reprovision"
description: "Reprovision a specific Cloud PC."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: reprovision

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Reprovision a specific Cloud PC.

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

To reprovision the [cloudPC](../resources/cloudpc.md) of the specified user (who is the signed-in user) in the organization using delegated permission:

``` http
POST /me/cloudPCs/{id}/reprovision
POST /users/{userId}/cloudPCs/{id}/reprovision
```

To reprovision the specified [cloudPC](../resources/cloudpc.md) in the organization, using either delegated permission (the signed-in user should be the administrator) or application permission:

``` http
POST /deviceManagement/virtualEndpoint/cloudPCs/{id}/reprovision
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

> **Note**: Only the APIs for **admin** support request body.

In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|osVersion|[cloudPcOperatingSystem](../resources/cloudpcorganizationsettings.md#cloudpcoperatingsystem-values)|The version of the operating system (OS) to provision on Cloud PCs. Possible values are: `windows10`, `windows11`, and `unknownFutureValue`.|
|userAccountType|[cloudPcUserAccountType](../resources/cloudpcorganizationsettings.md#cloudpcuseraccounttype-values)|The account type of the user on provisioned Cloud PCs. Possible values are: `standardUser`, `administrator`, and `unknownFutureValue`.|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Reprovision the cloudPC for the administrator

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpc_reprovision"
}
-->

``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/cloudPCs/4b5ad5e0-6a0b-4ffc-818d-36bb23cf4dbd/reprovision
Content-Type: application/json
Content-length: 61

{
  "userAccountType": "administrator",
  "osVersion": "windows10"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userAccountType = CloudPcUserAccountType.Administrator;

var osVersion = CloudPcOperatingSystem.Windows10;

await graphClient.DeviceManagement.VirtualEndpoint.CloudPCs["{cloudPC-id}"]
	.Reprovision(userAccountType,osVersion)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```

### Example 2: Reprovision the cloudPC for the signed-in user

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_cloudpc_reprovision"
}
-->

``` http
POST https://graph.microsoft.com/beta/me/cloudPCs/36bd4942-0ca8-11ed-861d-0242ac120002/reprovision
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.CloudPCs["{cloudPC-id}"]
	.Reprovision(null,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```
