---
title: "securityReportsRoot: getAttackSimulationRepeatOffenders"
description: "List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "reports"
doc_type: apiPageType
---

# securityReportsRoot: getAttackSimulationRepeatOffenders
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns.

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
GET /reports/security/getAttackSimulationRepeatOffenders
GET /reports/getAttackSimulationRepeatOffenders
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and an [attackSimulationRepeatOffender](../resources/attacksimulationrepeatoffender.md) collection in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "securityreportsrootthis.getattacksimulationrepeatoffenders"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/security/getAttackSimulationRepeatOffenders
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getAttackSimulationRepeatOffenders = await graphClient.Reports.Security
	.GetAttackSimulationRepeatOffenders()
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
  "@odata.type": "Collection(microsoft.graph.attackSimulationRepeatOffender)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.attackSimulationRepeatOffender)",
    "@odata.nextLink": "https://graph.microsoft.com/beta/reports/security/getAttackSimulationRepeatOffenders?$skiptoken=+RID%3",
    "value": [
        {
            "repeatOffenceCount": 5,
            "attackSimulationUser": {
                "userId": "6fcdab00-385b-46f2-a329-b843b49e9147",
                "displayName": "Reed Flores",
                "email": "reed@contoso.com"
            }
        },
        {
            "repeatOffenceCount": 638,
            "attackSimulationUser": {
                "userId": "478a22cd-aecc-41df-b995-88c8de17aaf5",
                "displayName": "Reed Flores",
                "email": "reed@contoso.com"
            }
        }
    ]
}

```

## See also
[reportRoot: getAttackSimulationRepeatOffenders](reportroot-getattacksimulationrepeatoffenders.md) (deprecated)
