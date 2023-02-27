---
title: "reportRoot: getAttackSimulationRepeatOffenders"
description: "List repeat offender users of a tenant in attack simulation and training campaigns."
author: "stuartcl"
ms.localizationpriority: medium
ms.prod: "reports"
doc_type: apiPageType
---

# reportRoot: getAttackSimulationRepeatOffenders (deprecated)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

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


List the users of a tenant who have yielded to attacks more than once in attack simulation and training campaigns.

This function supports `@odata.nextLink` for pagination.

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
GET /reports/getAttackSimulationRepeatOffenders
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [attackSimulationRepeatOffender](../resources/attacksimulationrepeatoffender.md) collection in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "reportroot_getattacksimulationrepeatoffenders"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/getAttackSimulationRepeatOffenders
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getAttackSimulationRepeatOffenders = await graphClient.Reports
	.GetAttackSimulationRepeatOffenders()
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
  "@odata.type": "Collection(microsoft.graph.attackSimulationRepeatOffender)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "repeatOffenceCount": 1,
      "attackSimulationUser": {
        "userId": "99af58b9-ef1a-412b-a581-cb42fe8c8e21",
        "displayName": "Sample User",
        "email": "sampleuser@contoso.com"
      }
    }
  ]
}
```

## See also
[securityReportsRoot: getAttackSimulationRepeatOffenders](securityreportsroot-getattacksimulationrepeatoffenders.md)

