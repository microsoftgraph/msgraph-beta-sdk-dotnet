---
title: "securityReportsRoot: getAttackSimulationSimulationUserCoverage"
description: "List training coverage for each tenant user in attack simulation and training campaigns."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "reports"
doc_type: apiPageType
---

# securityReportsRoot: getAttackSimulationSimulationUserCoverage
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List [training coverage](../resources/attacksimulationtrainingusercoverage.md) for each tenant user in attack simulation and training campaigns.

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
GET /reports/security/getAttackSimulationSimulationUserCoverage
GET /reports/getAttackSimulationSimulationUserCoverage
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and an [attackSimulationSimulationUserCoverage](../resources/attacksimulationsimulationusercoverage.md) collection in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "securityreportsrootthis.getattacksimulationsimulationusercoverage"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/security/getAttackSimulationSimulationUserCoverage
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getAttackSimulationSimulationUserCoverage = await graphClient.Reports.Security
	.GetAttackSimulationSimulationUserCoverage()
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
  "@odata.type": "Collection(microsoft.graph.attackSimulationSimulationUserCoverage)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.attackSimulationSimulationUserCoverage)",
    "@odata.nextLink": "https://graph.microsoft.com/beta/reports/security/getAttackSimulationSimulationUserCoverage?$skiptoken=rZDNasMwEIRfxei%2bRLFWtgRxwZKsYCil0J9rcCORGlI7yHLbvH3j0pQefCqew7LMsOzHbEL%2fkbRuVzvfxTaeC6ItMpVxBKpKBkh5CcIKhLVUSLUtdaYFSbr3%2fe4%2b9Ccf4vmuefMFuW2GaH3cv3pXO5K0v3HdOf9ZEEqmP1fzuTmOfju27hKgYJbmFSjGNGCuLKRZJYEKIxApo6WQZHWzWYz0sXk5%2bmmdp%2fx78I35EEPbHQryNPgwzJKgqGiKUoK%2boACmQoFMDQdmM56uc2O4qZbt7EcwM65alPS%2fnW1DP56m0r4A",
    "value": [
        {
            "simulationCount": 1063,
            "latestSimulationDateTime": "2022-02-10T10:45:50Z",
            "clickCount": 0,
            "compromisedCount": 0,
            "attackSimulationUser": {
                "userId": "9a00ce98-2c83-41be-89f7-6fdff7950aa9",
                "displayName": "Reed Flores",
                "email": "reed@contoso.com"
            }
        },
        {
            "simulationCount": null,
            "latestSimulationDateTime": null,
            "clickCount": null,
            "compromisedCount": null,
            "attackSimulationUser": {
                "userId": "e911a813-d360-4b1a-b3df-375dde934f2b",
                "displayName": "no role",
                "email": ""
            }
        }
    ]
}
```

## See also
[reportRoot: getAttackSimulationSimulationUserCoverage](reportroot-getattacksimulationsimulationusercoverage.md) (deprecated)
