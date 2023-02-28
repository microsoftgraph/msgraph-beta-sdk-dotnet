---
title: "cloudPcReports: getTotalAggregatedRemoteConnectionReports"
description: "Get the total aggregated remote connection usage of a Cloud PC during a given time span."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPcReports: getTotalAggregatedRemoteConnectionReports
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the total aggregated remote connection usage of a Cloud PC during a given time span.

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
POST /deviceManagement/virtualEndpoint/reports/getTotalAggregatedRemoteConnectionReports
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
|filter|String|OData filter syntax. Supported filters include `and`, `or`, `lt`, `le`, `gt`, `ge` and `eq`.|
|select|String collection|OData select syntax. Represents the selected columns of the reports. |
|search|String|Specifies a string to search|
|groupBy|String collection|Specify how to group the reports. If used, must have the same contents as select parameter|
|orderBy|String collection|Specify how to sort the reports.|
|skip|Int32|Number of records to skip.|
|top|Int32|The number of top records to return.|



## Response

If successful, this action returns a `200 OK` response code and a Stream in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpcreportsthis.gettotalaggregatedremoteconnectionreports"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/reports/getTotalAggregatedRemoteConnectionReports
Content-Type: application/json
Content-length: 199

{
    "top": 25,
    "skip": 0,
    "filter": "(TotalUsageInHour ge 40 and TotalUsageInHour le 80)",
    "select": [
        "CloudPcId",
        "ManagedDeviceName",
        "UserPrincipalName",
        "TotalUsageInHour",
        "DaysSinceLastSignIn"
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var top = 25;

var skip = 0;

var filter = "(TotalUsageInHour ge 40 and TotalUsageInHour le 80)";

var select = new List<String>()
{
	"CloudPcId",
	"ManagedDeviceName",
	"UserPrincipalName",
	"TotalUsageInHour",
	"DaysSinceLastSignIn"
};

await graphClient.DeviceManagement.VirtualEndpoint.Reports
	.GetTotalAggregatedRemoteConnectionReports(filter,select,null,null,null,skip,top)
	.Request()
	.PostAsync();

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
            "Column": "UserPrincipalName",
            "PropertyType": "String"
        },
        {
            "Column": "TotalUsageInHour",
            "PropertyType": "Double"
        },
        {
            "Column": "DaysSinceLastSignIn",
            "PropertyType": "Int64"
        }
    ],
    "Values": [
        [
            "40f9315c-5b63-4126-9f89-b7dcb145ffff",
            "CPC-DisplayName",
            "connie@cpccontoso.onmicrosoft.com",
            66.36944444444444,
            0
        ]
    ]
}
```

