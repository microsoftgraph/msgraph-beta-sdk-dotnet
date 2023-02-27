---
title: "serviceHealthIssue: incidentReport"
description: "Provide the Post-Incident Review (PIR) document of a specified service issue for tenant."
author: "payiAzure"
ms.localizationpriority: medium
ms.prod: "service-communications"
doc_type: apiPageType
---

# serviceHealthIssue: incidentReport
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Provide the Post-Incident Review (PIR) document of a specified service issue for tenant.

An issue only with status of `PostIncidentReviewPublished` indicates that the PIR document exists for the issue. The operation returns an error if the specified issue doesn't exist for the tenant or if PIR document does not exist for the issue.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ServiceHealth.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|ServiceHealth.Read.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /admin/serviceAnnouncement/issues/{serviceHealthIssueId}/incidentReport
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a file stream in the response body.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["MO248163"],
  "name": "servicehealthissue_incidentreport"
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/serviceAnnouncement/issues/MO248163/incidentReport
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Admin.ServiceAnnouncement.Issues["{serviceHealthIssue-id}"]
	.IncidentReport()
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
Content-Type: application/json

{
  "value": "Stream"
}
```

