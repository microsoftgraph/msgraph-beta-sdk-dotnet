---
title: "Get cloudPcExportJob"
description: "Read the properties and relationships of a cloudPcExportJob object."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Get cloudPcExportJob
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [cloudPcExportJob](../resources/cloudpcexportjob.md) object.

You can download a report by first [creating a new cloudPcExportJob resource](cloudpcreports-post-exportjobs.md) to initiate downloading.

Use this GET operation to verify the **exportJobStatus** property of the **cloudPcExportJob** resource. When the property becomes `completed`, the report has finished downloading in the location specified by the **exportUrl** property. 

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
GET /deviceManagement/virtualEndpoint/reports/exportJobs/{cloudPcExportJobId}
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [cloudPcExportJob](../resources/cloudpcexportjob.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpcexportjob"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/reports/exportJobs/TotalAggregatedRemoteConnectionReports__d39979c9-a0a2-4916-a158-1b984742ffff
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcExportJob = await graphClient.DeviceManagement.VirtualEndpoint.Reports.ExportJobs["{cloudPcExportJob-id}"]
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
  "@odata.type": "microsoft.graph.cloudPcExportJob"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.type": "#microsoft.graph.cloudPcExportJob",
    "id": "TotalAggregatedRemoteConnectionReports__d39979c9-a0a2-4916-a158-1b984742ffff",
    "reportName": "totalAggregatedRemoteConnectionReports",
    "format": "csv",
    "select":  ["CloudPcId", "ManagedDeviceName", "UserPrincipalName", "DaysSinceLastSignIn", "TotalUsageInHour"],
    "filter": null,
    "requestDateTime": "2022-09-16T12:00:06.5137388Z",
    "expirationDateTime": "0001-01-01T00:00:00Z",
    "exportJobStatus": "completed",
    "exportUrl": "https://westus01repexpstorage.blob.core.windows.net/599fe3a3-0285-4e7f-9c83-ffdf37914e27/remoteConnectionEvents_af34378a-cf5a-418d-b735-54b0ee155118.zip"
  }
}
```

