---
title: "cloudPC: changeUserAccountType"
description: "Change the account type of the user on a specific Cloud PC."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: changeUserAccountType
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Change the account type of the user on a specific Cloud PC.

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
POST /deviceManagement/virtualEndpoint/cloudPCs/{cloudPCId}/changeUserAccountType
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|userAccountType|[cloudPcUserAccountType](../resources/cloudpcorganizationsettings.md#cloudpcuseraccounttype-values)|The account type of the user on provisioned Cloud PCs. Possible values are: `standardUser`, `administrator`, and `unknownFutureValue`.|


## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpc_changeuseraccounttype"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/cloudPCs/4b5ad5e0-6a0b-4ffc-818d-36bb23cf4dbd/changeUserAccountType
Content-Type: application/json
Content-length: 35

{
  "userAccountType": "administrator"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userAccountType = CloudPcUserAccountType.Administrator;

await graphClient.DeviceManagement.VirtualEndpoint.CloudPCs["{cloudPC-id}"]
	.ChangeUserAccountType(userAccountType)
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
