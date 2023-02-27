---
title: "ediscoveryCustodian: removeHold"
description: "**TODO: Add Description**"
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# ediscoveryCustodian: removeHold
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
Start the process of removing hold from [eDiscovery custodians](../resources/security-ediscoverycustodian.md). After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers. The location provides a URL that will return an [eDiscoveryHoldOperation](../resources/security-ediscoveryholdoperation.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/cases/ediscoveryCases/{ediscoveryCaseId}/custodians/removeHold
POST /security/cases/ediscoveryCases/{ediscoveryCaseId}/custodians/{eDiscoveryCustodianId}/removeHold
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|ids|String collection|The IDs of custodians to apply hold. Optional.|


## Response

If successful, this action returns a `202 Accepted` response code.

## Examples
### Example 1: Remove hold from multiple custodians
#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "ediscoverycustodianthis.removehold_forIDs"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/custodians/removeHold
Content-Type: application/json

{
  "ids": [
    "7f697316-43ed-48e1-977f-261be050db93", "b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ids = new List<String>()
{
	"7f697316-43ed-48e1-977f-261be050db93",
	"b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8"
};

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Custodians
	.RemoveHold(ids)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 202 Accepted
```

### Example 2: Remove hold from a single custodian
#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "ediscoverycustodianthis.removehold_single_custodian"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/custodians/c25c3914f9f743ee9cbaa25377e0cec6/removeHold
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Custodians["{security.ediscoveryCustodian-id}"]
	.RemoveHold()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 202 Accepted
```
