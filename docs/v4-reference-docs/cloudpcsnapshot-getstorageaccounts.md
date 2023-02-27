---
title: "cloudPCSnapshot: getStorageAccounts"
description: "List all storage accounts that can be used to store snapshot(s) of a Cloud PC for forensic analysis."
author: "xhan2077"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Get cloudPcForensicStorageAccount
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List all storage accounts [cloudPcForensicStorageAccount](../resources/cloudpcforensicstorageaccount.md) that can be used to store a snapshot or snapshots of a Cloud PC for forensic analysis.

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
GET /deviceManagement/virtualEndpoint/snapshots/getStorageAccounts(subscriptionId='{subscriptionId}')
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and zero or more [cloudPcForensicStorageAccount](../resources/cloudpcsnapshot.md) objects in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpcforensicstorageaccount"
}
-->
``` http
GET /deviceManagement/virtualEndpoint/snapshots/getStorageAccounts(subscriptionId='cb6ad4c4-8a17-4245-a644-e4436b1ee204')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getStorageAccounts = await graphClient.DeviceManagement.VirtualEndpoint.Snapshots
	.GetStorageAccounts("cb6ad4c4-8a17-4245-a644-e4436b1ee204")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcForensicStorageAccount"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context":"https://graph.microsoft.com/beta/$metadata#cloudPcForensicStorageAccounts",
    "value":[
        {
            "storageAccountId": "/subscriptions/{subscription-id}/resourceGroups/res2627/providers/Microsoft.Storage/storageAccounts/sto1125",
            "storageAccountName":"sto1125"
        },
        {
            "storageAccountId": "/subscriptions/{subscription-id}/resourceGroups/res9407/providers/Microsoft.Storage/storageAccounts/sto8596",
            "storageAccountName":"sto8596"
        }
    ]
}
```

