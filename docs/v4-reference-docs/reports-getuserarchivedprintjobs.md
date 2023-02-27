---
title: "reports: getUserArchivedPrintJobs"
description: Get a list of archived print jobs for a particular user.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# reports: getUserArchivedPrintJobs

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of archived print jobs for a particular user.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

In addition to the following permissions, the user's tenant must have an active Universal Print subscription.

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| Reports.Read.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /print/reports/getUserArchivedPrintJobs(userId=userId-value,startDateTime=startDateTime-value,endDateTime=endDateTime-value)
GET /reports/getUserArchivedPrintJobs(userId=userId-value,startDateTime=startDateTime-value,endDateTime=endDateTime-value)
```
## Request headers
| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |

## Function Parameters
In the request URL, provide the following function parameters with values:

| Parameter     | Type                 | Required? | Description                                                          |
|---------------|----------------------|-----------|----------------------------------------------------------------------|
| `userId`      | `Edm.String`         | Yes       | The ID of the user to return data for.                               |
| `startDateTime` | `Edm.DateTimeOffset` | No        | The start date (inclusive) for the time period to include data from. |
| `endDateTime`   | `Edm.DateTimeOffset` | No        | The end date (inclusive) for the time period to include data from. |

>**Note:** If a value is not required, pass the parameter with null value.
## Response
If successful, this method returns a `200 OK` response code and a collection of [archivedPrintJob](../resources/archivedprintjob.md) objects in the response body.

## Example
The following example shows how to call this API.
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "reports-getuserarchivedprintjobs",
  "sampleKeys": ["016b5565-3bbf-4067-b9ff-4d68167eb1a6"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/print/reports/getUserArchivedPrintJobs(userId='016b5565-3bbf-4067-b9ff-4d68167eb1a6',startDateTime=2021-05-24,endDateTime=2021-05-25)
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getUserArchivedPrintJobs = await graphClient.Print.Reports
	.GetUserArchivedPrintJobs("016b5565-3bbf-4067-b9ff-4d68167eb1a6","2021-05-24","2021-05-25")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

