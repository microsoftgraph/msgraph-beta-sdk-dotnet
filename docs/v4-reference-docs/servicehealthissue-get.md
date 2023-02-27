---
title: "Get serviceHealthIssue"
description: "Retrieve the properties and relationships of a serviceHealthIssue object."
author: "payiAzure"
ms.localizationpriority: medium
ms.prod: "service-communications"
doc_type: apiPageType
---

# Get serviceHealthIssue
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a [serviceHealthIssue](../resources/servicehealthissue.md) object.

This operation retrieves a specified service health issue for tenant. The operation returns an error if the issue does not exist for the tenant.

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
GET /admin/serviceAnnouncement/issues/{serviceHealthIssueId}
```

## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [serviceHealthIssue](../resources/servicehealthissue.md) object in the response body.

## Example

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["MO226784"],
  "name": "get_servicehealthissue"
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/serviceAnnouncement/issues/MO226784
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var serviceHealthIssue = await graphClient.Admin.ServiceAnnouncement.Issues["{serviceHealthIssue-id}"]
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
  "@odata.type": "microsoft.graph.serviceHealthIssue"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#admin/serviceAnnouncement/issues/$entity",
  "startDateTime": "2020-11-14T08:15:00Z",
  "endDateTime": "2020-11-14T09:45:00Z",
  "lastModifiedDateTime": "2020-11-14T11:06:53.353Z",
  "title": "Intermittently unable to access some Microsoft 365 services",
  "id": "MO226784",
  "impactDescription": "Users may have been intermittently unable to access some Microsoft 365 services.",
  "classification": "Advisory",
  "origin": "Microsoft",
  "status": "ServiceRestored",
  "service": "Microsoft 365 suite",
  "feature": "Access",
  "featureGroup": "Portal",
  "isResolved": true,
  "details": [],
  "posts": [
    {
      "createdDateTime": "2020-11-12T07:07:38.97Z",
      "postType": "Regular",
      "description": {
        "contentType": "Html",
        "content": "Title: Intermittently unable to invite partners to meetings using some Microsoft 365 services\n\nUser Impact: Users may have been intermittently unable to invite partners to meetings using some Microsoft 365 services."
      }
    }
  ]
}
```

