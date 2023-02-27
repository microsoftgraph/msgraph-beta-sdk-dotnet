---
title: "subjectRightsRequest: getFinalReport"
description: "Get the final report for a subject rights request."
author: "skadam-msft"
ms.localizationpriority: medium
ms.prod: "compliance"
doc_type: apiPageType
---

# subjectRightsRequest: getFinalReport
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the final report for a subject rights request. The report is a text file that contains information about the files that were included by the privacy administrator.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|SubjectRightsRequest.Read.All, SubjectRightsRequest.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported|

## HTTP request

> [!CAUTION]
> The subject rights request API under the `/privacy` node is deprecated and will stop returning data on March 30, 2025. Please use the new path under `/security`.
<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /security/subjectRightsRequests{subjectRightsRequestId}/getFinalReport
GET /privacy/subjectRightsRequests{subjectRightsRequestId}/getFinalReport
```

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

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "subjectRightsRequest_getfinalreport"
}
-->
``` http
GET https://graph.microsoft.com/beta/privacy/subjectRightsRequests/{subjectRightsRequestId}/getFinalReport
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Privacy.SubjectRightsRequests["{subjectRightsRequest-id}"]
	.GetFinalReport()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
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

Id, Workload, Size, ImmutableId, FileName, FilePath, ItemUrl
```

