---
title: "Get simulationReportOverview"
description: "Get an overview of an attack simulation and training campaign."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# Get simulationReportOverview
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get an overview of an attack simulation and training campaign.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | AttackSimulation.Read.All                   |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | AttackSimulation.Read.All                   |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /security/attackSimulation/simulations/{simulationId}/report/overview
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [simulationReportOverview](../resources/simulationreportoverview.md) object in the response body.

## Examples

### Request

The following is an example of a request.

<!-- {
  "blockType": "request",
  "name": "get_simulationreportoverview"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/attackSimulation/simulations/f1b13829-3829-f1b1-2938-b1f12938b1a/report/overview
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var simulations = await graphClient.Security.AttackSimulation.Simulations["{simulation-id}"]
	.Request()
	.Select("Report")
	.GetAsync();

var overview = simulations.Report.Overview;

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the request.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.simulationReportOverview"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "microsoft.graph.simulationReportOverview",
  "resolvedTargetsCount": 1,
  "simulationEventsContent": {
    "compromisedRate": 100.0,
    "events": [
      {
        "@odata.type": "microsoft.graph.simulationEvent",
        "eventName": "SuccessfullyDeliveredMail",
        "count": 1
      },
      {
        "@odata.type": "microsoft.graph.simulationEvent",
        "eventName": "ReportedEmail",
        "count": 0
      },
      {
        "@odata.type": "microsoft.graph.simulationEvent",
        "eventName": "EmailLinkClicked",
        "count": 1
      }
    ]
  },
  "trainingEventsContent": {
    "trainingsAssignedUserCount": 1,
    "assignedTrainingsInfos": [
      {
        "@odata.type": "microsoft.graph.assignedTrainingsInfo",
        "assignedUserCount": 1,
        "completedUserCount": 0,
        "displayName": "Sample Training"
      }
    ]
  },
  "recommendedActions": [
    {
      "@odata.type": "microsoft.graph.recommendedAction",
      "actionWebUrl": "https://recommendedSecurityAction.com",
      "title": "Sample Recommended Security Feature",
      "potentialScoreImpact": 5.0
    }
  ]
}
```

