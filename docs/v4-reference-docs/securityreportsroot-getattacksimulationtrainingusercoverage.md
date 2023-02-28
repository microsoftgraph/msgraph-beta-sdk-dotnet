---
title: "securityReportsRoot: getAttackSimulationTrainingUserCoverage"
description: "List training coverage for tenant users in attack simulation and training campaigns."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "reports"
doc_type: apiPageType
---

# securityReportsRoot: getAttackSimulationTrainingUserCoverage
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List training coverage for tenant users in attack simulation and training campaigns.

This function supports `@odata.nextLink` for pagination.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | AttackSimulation.Read.All                   |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | AttackSimulation.Read.All                   |

## HTTP request
---
author: "stuartcl"
ms.localizationpriority: high
ms.prod: "reports"
ms.topic: include
---

<!-- markdownlint-disable MD041-->
>[!CAUTION]
>Make sure to access the following methods from the `https://graph.microsoft.com/beta/reports/security` endpoint:
>- **getAttackSimulationRepeatOffenders**
>- **getAttackSimulationSimulationUserCoverage**
>- **getAttackSimulationTrainingUserCoverage** 
>
>The query endpoints for these methods have changed from `https://graph.microsoft.com/beta/reports` to `https://graph.microsoft.com/beta/reports/security`. 
>Methods on the `https://graph.microsoft.com/beta/reports/` endpoint are deprecated as of July 15, 2022, and will stop returning data starting August 20, 2022.


<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /reports/security/getAttackSimulationTrainingUserCoverage
GET /reports/getAttackSimulationTrainingUserCoverage
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and an [attackSimulationTrainingUserCoverage](../resources/attacksimulationtrainingusercoverage.md) collection in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "securityreportsrootthis.getattacksimulationtrainingusercoverage"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/security/getAttackSimulationTrainingUserCoverage
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getAttackSimulationTrainingUserCoverage = await graphClient.Reports.Security
	.GetAttackSimulationTrainingUserCoverage()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.attackSimulationTrainingUserCoverage)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.attackSimulationTrainingUserCoverage)",
    "@odata.nextLink": "https://graph.microsoft.com/beta/reports/security/getAttackSimulationTrainingUserCoverage?$skiptoken=+RID%3",
    "value": [
        {
            "userTrainings": [
                {
                    "assignedDateTime": "2021-07-28T07:33:47.493239Z",
                    "completionDateTime": null,
                    "trainingStatus": "assigned",
                    "displayName": "Phishing"
                },
                {
                    "assignedDateTime": "2021-07-28T07:33:47.493239Z",
                    "completionDateTime": "2022-01-14T03:11:58Z",
                    "trainingStatus": "completed",
                    "displayName": ""
                }
            ],
            "attackSimulationUser": {
                "userId": "c5e40ca7-4c09-4801-a140-5ef733d1de0e",
                "displayName": null,
                "email": null
            }
        }
    ]
}
```

## See also
[reportRoot: getAttackSimulationTrainingUserCoverage](reportroot-getattacksimulationtrainingusercoverage.md) (deprecated)
