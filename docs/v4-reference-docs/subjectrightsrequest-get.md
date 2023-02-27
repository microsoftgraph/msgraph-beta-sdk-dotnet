---
title: "Get subjectRightsRequest"
description: "Read the properties and relationships of a subjectRightsRequest object."
author: "skadam-msft"
ms.localizationpriority: medium
ms.prod: "compliance"
doc_type: apiPageType
---

# Get subjectRightsRequest
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [subjectRightsRequest](../resources/subjectRightsRequest.md) object.

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
GET /security/subjectRightsRequests/{subjectRightsRequestId}
GET /privacy/subjectRightsRequests/{subjectRightsRequestId}
```

## Optional query parameters

This method does not support the [OData query parameter](/graph/query-parameters) to help customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [subjectRightsRequest](../resources/subjectRightsRequest.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_subjectRightsRequest"
}
-->
``` http
GET https://graph.microsoft.com/beta/privacy/subjectRightsRequests/{subjectRightsRequestId}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var subjectRightsRequest = await graphClient.Privacy.SubjectRightsRequests["{subjectRightsRequest-id}"]
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
  "@odata.type": "microsoft.graph.subjectRightsRequest"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "type": "export",
    "dataSubjectType": "customer",
    "regulations": [
        "GDPR"
    ],
    "displayName": "Export request for Monica Thompson",
    "description": "This is a export request",
    "status": "active",
    "internalDueDateTime": "2022-06-20T22:42:28Z",
    "lastModifiedDateTime": "2022-04-20T22:42:28Z",
    "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
    "createdDateTime": "2022-04-19T22:42:28Z",
    "stages": [
        {
            "stage": "contentRetrieval",
            "status": "notStarted",
            "error": null
        },
        {
            "stage": "contentReview",
            "status": "notStarted",
            "error": null
        },
        {
            "stage": "generateReport",
            "status": "notStarted",
            "error": null
        },
        {
            "stage": "caseResolved",
            "status": "notStarted",
            "error": null
        }
    ],
    "createdBy": {
        "user": {
            "id": "1B761ED2-AA7E-4D82-9CF5-C09D737B6167",
            "displayName": "srradmin@contoso.com"
        }
    },
    "lastModifiedBy": {
        "user": {
            "id": "1B761ED2-AA7E-4D82-9CF5-C09D737B6167",
            "displayName": "srradmin@contoso.com"
        }
    },
    "dataSubject": {
        "firstName": "Monica",
        "lastName": "Thompson",
        "email": "Monica.Thompson@contoso.com",
        "residency": "USA",
        "SSN": "123-456-7890"
    },
    "team": {
        "id": "5484809c-fb5b-415a-afc6-da7ff601034e",
        "webUrl": "https://teams.contoso.com/teams/teamid"
    },
    "includeAllVersions": false,
    "pauseAfterEstimate": true,
    "includeAuthoredContent": true,
    "externalId": null,
    "contentQuery": "(('Monica Thompson' OR 'Monica.Thompson@contoso.com') OR (participants=Monica.Thompson@contoso.com))",
    "mailboxLocations": null,
    "siteLocations": {
        "@odata.type": "microsoft.graph.subjectRightsRequestAllSiteLocation"
    }
}
```

