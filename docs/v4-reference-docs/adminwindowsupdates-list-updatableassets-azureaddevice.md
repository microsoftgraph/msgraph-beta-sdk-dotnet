---
title: "List azureADDevice resources"
description: "Get a list of azureADDevice objects and their properties."
author: "ryan-k-williams"
ms.localizationpriority: medium
ms.prod: "w10"
doc_type: apiPageType
---

# List azureADDevice resources
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of [azureADDevice](../resources/windowsupdates-azureaddevice.md) objects and their properties.

This operation filters on the fully qualified resource type, `microsoft.graph.windowsUpdates.azureADDevice`, which inherits from [updatableAsset](../resources/windowsupdates-updatableasset.md).

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
GET /admin/windows/updates/updatableAssets/microsoft.graph.windowsUpdates.azureADDevice
```

## Optional query parameters
This method supports some of the [OData query parameters](/graph/query-parameters) to help customize the response, including `$count`, `$filter`, `$orderBy`, `$select`, `$skip`, and `$top`.

To use a query parameter on a property that is not inherited from [updatableAsset](../resources/windowsupdates-updatableasset.md), include the full resource type. For example, to select the **errors** property, use `$select=microsoft.graph.windowsUpdates.azureADDevice/errors`.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [azureADDevice](../resources/windowsupdates-azureaddevice.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_azureaddevice"
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/windows/updates/updatableAssets/microsoft.graph.windowsUpdates.azureADDevice
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var updatableAssets = await graphClient.Admin.Windows.Updates.UpdatableAssets
	.Request()
	.Filter("isof('microsoft.graph.windowsUpdates.azureADDevice')")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.windowsUpdates.azureADDevice)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.windowsUpdates.azureADDevice",
      "id": "983f03cd-03cd-983f-cd03-3f98cd033f98",
      "errors": [],
      "enrollments": [
        {
          "@odata.type": "microsoft.graph.windowsUpdates.updateManagementEnrollment",
          "updateCategory": "feature"
        }
      ]
    },
    {
      "@odata.type": "#microsoft.graph.windowsUpdates.azureADDevice",
      "id": "90b91efa-6d46-42cd-ad4d-381831773a85",
      "errors": [],
      "enrollments": []
    },
    {
      "@odata.type": "#microsoft.graph.windowsUpdates.azureADDevice",
      "id": "0ee3eb63-caf3-44ce-9769-b83188cc683d",
      "errors": [
        {
          "@odata.type": "microsoft.graph.windowsUpdates.azureADDeviceRegistrationError"
        }
      ],
      "enrollments": []
    }
  ]
}
```

