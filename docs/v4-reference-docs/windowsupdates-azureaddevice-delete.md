---
title: "Delete azureADDevice"
description: "Delete an azureADDevice object."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# Delete azureADDevice
Namespace: microsoft.graph.windowsUpdates

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an [azureADDevice](../resources/windowsupdates-azureaddevice.md) object.

When an Azure AD device is deleted, it is unregistered from the deployment service and automatically unenrolled from management by the service for all update categories, as well as removed from every [deploymentAudience](../resources/windowsupdates-deploymentaudience.md) and [updatableAssetGroup](../resources/windowsupdates-updatableassetgroup.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|WindowsUpdates.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|WindowsUpdates.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /admin/windows/updates/updatableAssets/{azureADDeviceId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `202 Accepted` response code. It does not return anything in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_azureaddevice"
}
-->
``` http
DELETE https://graph.microsoft.com/beta/admin/windows/updates/updatableAssets/983f03cd-03cd-983f-cd03-3f98cd033f98
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Admin.Windows.Updates.UpdatableAssets["{windowsUpdates.updatableAsset-id}"]
	.Request()
	.DeleteAsync();

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
HTTP/1.1 202 Accepted
```

