---
title: "updatableAsset: unenrollAssetsById"
description: "Unenroll updatableAsset resources of the same type from update management by the deployment service."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# updatableAsset: unenrollAssetsById
Namespace: microsoft.graph.windowsUpdates

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Unenroll [updatableAsset](../resources/windowsupdates-updatableasset.md) resources of the same type from update management by the deployment service.

You can also use the method [unenrollAssets](windowsupdates-updatableasset-unenrollassets.md) to unenroll assets.

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
POST /admin/windows/updates/updatableAssets/unenrollAssetsById
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|updateCategory|microsoft.graph.windowsUpdates.updateCategory|The category of updates for the service to stop managing. Supports a subset of the values for **updateCategory**. Possible values are: `driver`, `feature`, `quality`, `unknownFutureValue`.|
|memberEntityType|String|The full type of the **updatableAsset** resources. Possible values are: `#microsoft.graph.windowsUpdates.azureADDevice`.|
|ids|String collection|List of identifiers corresponding to the **updatableAsset** resources to unenroll from update management by the service for the given **updateCategory**.|

## Response

If successful, this action returns a `202 Accepted` response code. It does not return anything in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "updatableasset_unenrollassetsbyid"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/windows/updates/updatableAssets/unenrollAssetsById
Content-Type: application/json

{
  "updateCategory": "feature",
  "memberEntityType": "#microsoft.graph.windowsUpdates.azureADDevice",
  "ids": [
    "String",
    "String",
    "String"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var updateCategory = Microsoft.Graph.WindowsUpdates.UpdateCategory.Feature;

var memberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice";

var ids = new List<String>()
{
	"String",
	"String",
	"String"
};

await graphClient.Admin.Windows.Updates.UpdatableAssets
	.UnenrollAssetsById(updateCategory,memberEntityType,ids)
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
HTTP/1.1 202 Accepted
```

