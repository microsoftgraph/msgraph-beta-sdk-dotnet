---
title: "Create cloudPcExportJob"
description: "Create a new cloudPcExportJob object."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Create cloudPcExportJob
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [cloudPcExportJob](../resources/cloudpcexportjob.md) resource to initiate downloading the entire or specified portion of a report.

Use the [GET cloudPcExportJob](cloudpcexportjob-get.md) operation to verify the **exportJobStatus** property of the **cloudPcExportJob** resource. When the property becomes `completed`, the report has finished downloading in the location specified by the **exportUrl** property. 

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
POST /deviceManagement/virtualEndpoint/reports/exportJobs
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [cloudPcExportJob](../resources/cloudpcexportjob.md) object.

You can specify the following properties when creating a **cloudPcExportJob**.

|Property|Type|Description|
|:---|:---|:---|
|reportName|cloudPcReportName|The report name. The possible values are: `remoteConnectionHistoricalReports`, `dailyAggregatedRemoteConnectionReports`, `totalAggregatedRemoteConnectionReports`, `sharedUseLicenseUsageReport`, `sharedUseLicenseUsageRealTimeReport`,`unknownFutureValue`. Optional.|
|filter|String|The filter applied on the report. Optional.|
|select|String collection|The selected columns of the report. Optional.|
|format|String|The format of the exported report. Optional.|


## Response

If successful, this method returns a `201 Created` response code and a [cloudPcExportJob](../resources/cloudpcexportjob.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_cloudpcexportjob_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/reports/exportJobs
Content-Type: application/json
Content-length: 315

{
  "reportName": "TotalAggregatedRemoteConnectionReports",
  "select": [
      "CloudPcId",
      "ManagedDeviceName",
      "UserPrincipalName",
      "DaysSinceLastSignIn",
      "TotalUsageInHour"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcExportJob = new CloudPcExportJob
{
	ReportName = CloudPcReportName.TotalAggregatedRemoteConnectionReports,
	Select = new List<String>()
	{
		"CloudPcId",
		"ManagedDeviceName",
		"UserPrincipalName",
		"DaysSinceLastSignIn",
		"TotalUsageInHour"
	}
};

await graphClient.DeviceManagement.VirtualEndpoint.Reports.ExportJobs
	.Request()
	.AddAsync(cloudPcExportJob);

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
  "@odata.type": "microsoft.graph.cloudPcExportJob"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#deviceManagement/virtualEndpoint/reports/exportJobs/$entity",
    "id": "TotalAggregatedRemoteConnectionReports__d39979c9-a0a2-4916-a158-1b984742ffff",
    "reportName": "totalAggregatedRemoteConnectionReports",
    "filter": null,
    "select": [
        "CloudPcId",
        "ManagedDeviceName",
        "UserPrincipalName",
        "DaysSinceLastSignIn",
        "TotalUsageInHour"
    ],
    "format": null,
    "expirationDateTime": "0001-01-01T00:00:00Z",
    "requestDateTime": "2022-09-16T12:00:06.5137388Z",
    "exportJobStatus": "inProgress",
    "exportUrl": null
}
```

