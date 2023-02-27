---
title: "cloudPcReports: getRealTimeRemoteConnectionStatus"
description: "Get the real-time connection status information for a Cloud PC."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPcReports: getRealTimeRemoteConnectionStatus
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the real-time connection status information, such as **signInStatus** or **daysSinceLastUse**, for a Cloud PC.

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
GET /deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='id')
```

## Function parameters
In the request URL, provide the following query parameters with values.

|Parameter|Type|Description|
|:---|:---|:---|
|cloudPcId|String|The id of the Cloud PC.|


## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a Stream in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpcreportsthis.getrealtimeremoteconnectionstatus"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/reports/getRealTimeRemoteConnectionStatus(cloudPcId='f5ff445f-7488-40f8-8ab9-ee784a9fffff')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.DeviceManagement.VirtualEndpoint.Reports
	.GetRealTimeRemoteConnectionStatus("f5ff445f-7488-40f8-8ab9-ee784a9fffff")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Edm.Stream"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/octet-stream

{
    "TotalRowCount": 1,
    "Schema": [
        {
            "Column": "CloudPcId",
            "PropertyType": "String"
        },
        {
            "Column": "ManagedDeviceName",
            "PropertyType": "String"
        },
        {
            "Column": "SignInStatus",
            "PropertyType": "String"
        },
        {
            "Column": "DaysSinceLastSignIn",
            "PropertyType": "Int64"
        }
    ],
    "Values": [
        [
            "40f9315c-5b63-4126-9f89-b7dcb14569a8",
            "CPC-DisplayName",
            "SignedIn",
            0
        ]
    ]
}
```

