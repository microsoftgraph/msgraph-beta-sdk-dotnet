---
title: "cloudPcReports: getSharedUseLicenseUsageReport"
description: "Get the shared use license usage reports, such as servicePlanId, licenseCount, and claimedLicenseCount, for real-time, 7 days, or 28 days trend."
author: "rbayetov"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPcReports: getSharedUseLicenseUsageReport

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a usage report on shared-use licenses, such as **servicePlanId**, **licenseCount**, and **claimedLicenseCount**, for real-time, 7 days, or 28 days trend.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | CloudPC.Read.All, CloudPC.ReadWrite.All     |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | CloudPC.Read.All, CloudPC.ReadWrite.All     |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /deviceManagement/virtualEndpoint/reports/getSharedUseLicenseUsageReport
```

## Request headers

| Name          | Description                 |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

| Parameter  | Type              | Description                                                                                           |
| :--------- | :---------------- | :---------------------------------------------------------------------------------------------------- |
| reportName | String            | Specifies the report name.                                                                            |
| filter     | String            | OData filter syntax. Supported filters include `and`, `or`, `lt`, `le`, `gt`, `ge`, and `eq`.         |
| select     | String collection | OData select syntax. Represents the selected columns of the reports.                                  |
| search     | String            | Specifies a string to search.                                                                         |
| groupBy    | String collection | Specifies how to group the reports. If used, must have the same content as the **select** parameter.  |
| orderBy    | String collection | Specifies how to sort the reports.                                                                    |
| skip       | Int32             | The number of records to skip.                                                                        |
| top        | Int32             | The number of top records to return.                                                                  |

## Response

If successful, this action returns a `200 OK` response code and a Stream in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpcreportsthis.getSharedUseLicenseUsageReport"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/reports/getSharedUseLicenseUsageReport
Content-Type: application/json
Content-length: 199

{
    "reportName": "SharedUseLicenseUsageReport",
    "filter": "ServicePlanId eq '2d1d344e-d10c-41bb-953b-b3a47521dca0' and DateTimeUTC gt datetime'2022-11-30'",
    "select":["ServicePlanId", "LicenseCount", "ClaimedLicenseCount", "DateTimeUTC"],
    "skip": 0,
    "top": 100
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var reportName = CloudPcReportName.SharedUseLicenseUsageReport;

var filter = "ServicePlanId eq '2d1d344e-d10c-41bb-953b-b3a47521dca0' and DateTimeUTC gt datetime'2022-11-30'";

var select = new List<String>()
{
	"ServicePlanId",
	"LicenseCount",
	"ClaimedLicenseCount",
	"DateTimeUTC"
};

var skip = 0;

var top = 100;

await graphClient.DeviceManagement.VirtualEndpoint.Reports
	.GetSharedUseLicenseUsageReport(reportName,filter,select,null,null,null,skip,top)
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
  "TotalRowCount": 2,
  "Schema": [
    {
      "name": "ServicePlanId",
      "type": "String"
    },
    {
      "name": "LicenseCount",
      "type": "Int32"
    },
    {
      "name": "ClaimedLicenseCount",
      "type": "Int32"
    },
    {
      "name": "DateTimeUTC",
      "type": "DateTime"
    }
  ],
  "Values": [
    [
      "2d1d344e-d10c-41bb-953b-b3a47521dca0", 100, 10, "2022-12-02T00:00:00"
    ],
    [
      "2d1d344e-d10c-41bb-953b-b3a47521dca0", 100, 11, "2022-12-01T00:00:00"
    ]
  ]
}
```
