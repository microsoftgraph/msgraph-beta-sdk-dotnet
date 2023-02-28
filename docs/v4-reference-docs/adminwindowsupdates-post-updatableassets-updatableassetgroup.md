---
title: "Create updatableAssetGroup"
description: "Create a new updatableAssetGroup object."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# Create updatableAssetGroup
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [updatableAssetGroup](../resources/windowsupdates-updatableassetgroup.md) object.

The **updatableAssetGroup** resource inherits from [updatableAsset](../resources/windowsupdates-updatableasset.md).

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
POST /admin/windows/updates/updatableAssets
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [updatableAssetGroup](../resources/windowsupdates-updatableassetgroup.md) object.

No properties are required.


## Response

If successful, this method returns a `201 Created` response code and an [updatableAssetGroup](../resources/windowsupdates-updatableassetgroup.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_updatableassetgroup_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/windows/updates/updatableAssets
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.updatableAssetGroup"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var updatableAsset = new Microsoft.Graph.WindowsUpdates.UpdatableAssetGroup
{
};

await graphClient.Admin.Windows.Updates.UpdatableAssets
	.Request()
	.AddAsync(updatableAsset);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.windowsUpdates.updatableAssetGroup"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.windowsUpdates.updatableAssetGroup",
  "id": "5c55730b-730b-5c55-0b73-555c0b73555c"
}
```

