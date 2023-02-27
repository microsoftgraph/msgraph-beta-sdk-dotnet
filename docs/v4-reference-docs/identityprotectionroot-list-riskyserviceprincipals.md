---
title: "List riskyServicePrincipals"
description: "Retrieve the properties and relationships of riskyServicePrincipal objects."
author: "ebasseri"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List riskyServicePrincipals
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of [riskyServicePrincipal](../resources/riskyserviceprincipal.md) objects.

>**Note:** Using the riskyServicePrincipals API requires an Entra Workload Identity Premium license.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|IdentityRiskyServicePrincipal.Read.All, IdentityRiskyServicePrincipal.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|IdentityRiskyServicePrincipal.Read.All, IdentityRiskyServicePrincipal.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identityProtection/riskyServicePrincipals
```

## Optional query parameters
This method supports the `$count`, `$filter`, `$select`, and `$top` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [riskyServicePrincipal](../resources/riskyserviceprincipal.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_riskyserviceprincipal"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityProtection/riskyServicePrincipals
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var riskyServicePrincipals = await graphClient.IdentityProtection.RiskyServicePrincipals
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
  "@odata.type": "Collection(microsoft.graph.riskyServicePrincipal)"
}
-->
```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#riskyServicePrincipal",
  "value": [
    {
      "id": "9089a539-a539-9089-39a5-899039a58990",
      "accountEnabled": true,
      "isProcessing": false,
      "riskLastUpdatedDateTime": "2021-08-14T13:06:51.0451374Z",
      "riskLevel": "high",
      "riskState": "atRisk",
      "riskDetail": "none",
      "displayName": "Contoso App",
      "appId": "b55552fe-a272-4b56-990b-95038d917878",
      "servicePrincipalType": "Application"
    }
  ]
}
```
