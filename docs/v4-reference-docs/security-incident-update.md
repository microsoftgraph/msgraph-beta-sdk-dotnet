---
title: "Update incident"
description: "Update the properties of an incident object."
ms.date: 09/09/2021
author: "BenAlfasi"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Update incident
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [incident](../resources/security-incident.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|SecurityIncident.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|SecurityIncident.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /security/incidents/{incidentId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|assignedTo|String|Owner of the incident, or null if no owner is assigned. Free editable text.|
|classification|microsoft.graph.security.alertClassification|The specification for the incident. Possible values are: `unknown`, `falsePositive`, `truePositive`, `informationalExpectedActivity`, `unknownFutureValue`.|
|determination|microsoft.graph.security.alertDetermination|Specifies the determination of the incident. Possible values are: `unknown`, `apt`, `malware`, `securityPersonnel`, `securityTesting`, `unwantedSoftware`, `other`, `multiStagedAttack`, `compromisedUser`, `phishing`, `maliciousUserActivity`, `clean`, `insufficientData`, `confirmedUserActivity`, `lineOfBusinessApplication`, `unknownFutureValue`.|
|status|microsoft.graph.security.incidentStatus|The status of the incident. Possible values are: `active`, `resolved`, `redirected`, `unknownFutureValue`.|
|customTags|String collection|Array of custom tags associated with an incident.|


## Response

If successful, this method returns a `200 OK` response code and an updated [incident](../resources/security-incident.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "sampleKeys": ["2972395"],
  "name": "update_incident"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/security/incidents/2972395
Content-Type: application/json

{
    "classification": "TruePositive",
    "determination": "MultiStagedAttack",
    "customTags": [
      "Demo"
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var incident = new Microsoft.Graph.Security.Incident
{
	Classification = Microsoft.Graph.Security.AlertClassification.TruePositive,
	Determination = Microsoft.Graph.Security.AlertDetermination.MultiStagedAttack,
	CustomTags = new List<String>()
	{
		"Demo"
	}
};

await graphClient.Security.Incidents["{security.incident-id}"]
	.Request()
	.UpdateAsync(incident);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.security.incident",
  "truncated": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.incident",
    "id": "2972395",
    "incidentWebUrl": "https://security.microsoft.com/incidents/2972395?tid=12f988bf-16f1-11af-11ab-1d7cd011db47",
    "redirectIncidentId": null,
    "displayName": "Multi-stage incident involving Initial access & Command and control on multiple endpoints reported by multiple sources",
    "tenantId": "b3c1b5fc-828c-45fa-a1e1-10d74f6d6e9c",
    "createdDateTime": "2021-08-13T08:43:35.5533333Z",
    "lastUpdateDateTime": "2021-09-30T09:35:45.1133333Z",
    "assignedTo": "KaiC@contoso.onmicrosoft.com",
    "classification": "TruePositive",
    "determination": "MultiStagedAttack",
    "status": "Active",
    "severity": "Medium",
    "customTags": [
      "Demo"
    ],
    "comments": [
      {
		"comment": "Demo incident",
		"createdBy": "DavidS@contoso.onmicrosoft.com",
		"createdTime": "2021-09-30T12:07:37.2756993Z"
      }
    ]
}
```

