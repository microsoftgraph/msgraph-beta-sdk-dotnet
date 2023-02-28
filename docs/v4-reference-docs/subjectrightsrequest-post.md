---
title: "Create subjectRightsRequest"
description: "Create a new subjectRightsRequest object."
author: "skadam-msft"
ms.localizationpriority: medium
ms.prod: "compliance"
doc_type: apiPageType
---

# Create subjectRightsRequest
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [subjectRightsRequest](../resources/subjectrightsrequest.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|SubjectRightsRequest.ReadWrite.All|
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
POST /security/subjectRightsRequests
POST /privacy/subjectRightsRequests

```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [subjectRightsRequest](../resources/subjectrightsrequest.md) object.

The following table shows the properties that are required when you create the [subjectRightsRequest](../resources/subjectrightsrequest.md).

|Property|Type|Description|
|:---|:---|:---|
| contentQuery         | String | KQL based content query that should be used for search. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
|dataSubject|[microsoft.graph.dataSubject](../resources/datasubject.md)|Contains the properties for data subject for the request.|
|dataSubjectType|dataSubjectType|Data subject type. Possible values are: `customer`, `currentEmployee`, `formerEmployee`, `prospectiveEmployee`, `student`, `teacher`, `faculty`, `other`, `unknownFutureValue`.|
|description|String|Description for the request.|
|displayName|String|Name of the request.|
| externalId           | String| The external ID for the request that is immutable after creation and is used for tracking the request for the external system. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
| includeAllVersions   | Boolean | Include all versions of the documents. By default, the current copies of the documents will be returned. If SharePoint sites have versioning enabled, including all versions will include the historical copies of the documents. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
| includeAuthoredContent| Boolean | Include content authored by the data subject. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
|internalDueDateTime|DateTimeOffset|Internal due date that is used for tracking the request completion.|
| mailboxLocations     | [subjectRightsRequestMailboxLocation](../resources/subjectrightsrequestmailboxlocation.md)|The mailbox locations that should be searched. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
| pauseAfterEstimate   | Boolean| Pause the request after estimate has finished. By default, the data estimate will run and then pause, allowing you to preview results and then select the option to retrieve data in the UI. You can set this property to `false` if you want it to perform the estimate and then automatically begin with the retrieval of the content. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
|regulations|String collection|One or more regulations for the request.|
| siteLocations| [subjectRightsRequestSiteLocation](../resources/subjectrightsrequestsitelocation.md)| The SharePoint and OneDrive site locations that should be searched. This property is defined only for APIs accessed using the `\security` query path and not the `\privacy` query path.|
|type|subjectRightsRequestType|Type of the request. Possible values are: `export`, `access`, `tagForAction`, `unknownFutureValue`. The `delete` type is currently not supported.|

## Response

If successful, this method returns a `201 Created` response code and a [subjectRightsRequest](../resources/subjectRightsRequest.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_subjectRightsRequest_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/privacy/subjectRightsRequests
Content-Type: application/json

{
    "type": "export",
    "contentQuery": "((\"Diego Siciliani\" OR \"Diego.Siciliani@contoso.com\") OR (participants:\"Diego.Siciliani@contoso.com\"))",
    "dataSubjectType": "customer",
    "externalId": "F53BF2DA-607D-412A-B568-FAA0F023AC0B",
    "displayName": "Export report for customer Id: 12345",
    "description": "This is a export request",
    "includeAllVersions": false,
    "includeAuthoredContent": true,
    "internalDueDateTime": "2022-07-20T22:42:28Z",
    "dataSubject": {
        "firstName": "Diego",
        "lastName": "Siciliani",
        "email": "Diego.Siciliani@contoso.com",
        "residency": "USA"
    },
    "mailboxLocations": null,
    "pauseAfterEstimate": true,
    "regulations": [
        "CCPA"
    ],
    "siteLocations": {
        "@odata.type": "microsoft.graph.subjectRightsRequestAllSiteLocation"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var subjectRightsRequest = new SubjectRightsRequestObject
{
	Type = SubjectRightsRequestType.Export,
	ContentQuery = "((\"Diego Siciliani\" OR \"Diego.Siciliani@contoso.com\") OR (participants:\"Diego.Siciliani@contoso.com\"))",
	DataSubjectType = DataSubjectType.Customer,
	ExternalId = "F53BF2DA-607D-412A-B568-FAA0F023AC0B",
	DisplayName = "Export report for customer Id: 12345",
	Description = "This is a export request",
	IncludeAllVersions = false,
	IncludeAuthoredContent = true,
	InternalDueDateTime = DateTimeOffset.Parse("2022-07-20T22:42:28Z"),
	DataSubject = new DataSubject
	{
		FirstName = "Diego",
		LastName = "Siciliani",
		Email = "Diego.Siciliani@contoso.com",
		Residency = "USA"
	},
	MailboxLocations = null,
	PauseAfterEstimate = true,
	Regulations = new List<String>()
	{
		"CCPA"
	},
	SiteLocations = new SubjectRightsRequestAllSiteLocation
	{
	}
};

await graphClient.Privacy.SubjectRightsRequests
	.Request()
	.AddAsync(subjectRightsRequest);

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
HTTP/1.1 201 Created
Content-Type: application/json

{
    "type": "export",
    "dataSubjectType": "customer",
    "regulations": [
        "CCPA"
    ],
    "displayName": "Export report for customer Id: 12345",
    "description": "This is a export request",
    "status": "active",
    "internalDueDateTime": "2022-07-20T22:42:28Z",
    "lastModifiedDateTime": "2022-05-10T22:42:28Z",
    "id": "CA084038-C5D2-493D-8DAB-23FC12393C76",
    "createdDateTime": "2022-05-10T22:42:28Z",
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
        "firstName": "Diego",
        "lastName": "Siciliani",
        "email": "Diego.Siciliani@contoso.com",
        "residency": "USA"
    },
    "team": {
        "id": "5484809c-fb5b-415a-afc6-da7ff601034e",
        "webUrl": "https://teams.contoso.com/teams/teamid"
    },
    "includeAllVersions": false,
    "pauseAfterEstimate": false,
    "includeAuthoredContent": false,
    "externalId": "F53BF2DA-607D-412A-B568-FAA0F023AC0B",
    "contentQuery": "((\"Diego Siciliani\" OR \"Diego.Siciliani@contoso.com\") OR (participants:\"Diego.Siciliani@contoso.com\"))",
    "mailboxLocations": null,
    "siteLocations": {
        "@odata.type": "microsoft.graph.subjectRightsRequestAllSiteLocation"
    }
}
```

