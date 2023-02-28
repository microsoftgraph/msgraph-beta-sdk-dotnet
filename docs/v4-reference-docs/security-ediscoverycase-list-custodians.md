---
title: "List ediscoveryCustodian"
description: "Get a list of the ediscovery custodian object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# List ediscoveryCustodian
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [custodian](../resources/security-ediscoverycustodian.md) objects and their properties.

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
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/custodians
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.
## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.security.ediscoveryCustodian](../resources/security-ediscoverycustodian.md) objects in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_ediscoverycustodian_from_"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/custodians
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var custodians = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Custodians
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
  "@odata.type": "microsoft.graph.security.ediscoveryCustodian"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/custodians",
    "@odata.count": 1,
    "value": [
        {
            "status": "active",
            "holdStatus": "notApplied",
            "createdDateTime": "2022-05-23T00:58:19.0702426Z",
            "lastModifiedDateTime": "2022-05-23T00:58:19.0702436Z",
            "releasedDateTime": null,
            "id": "0053a61a3b6c42738f7606791716a22a",
            "displayName": "Alex Wilber",
            "email": "AlexW@M365x809305.OnMicrosoft.com",
            "acknowledgedDateTime": "0001-01-01T00:00:00Z"
        }
    ]
}
```

