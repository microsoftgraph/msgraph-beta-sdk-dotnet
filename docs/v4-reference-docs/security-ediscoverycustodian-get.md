---
title: "Get ediscoveryCustodian"
description: "Read the properties and relationships of an ediscoveryCustodian object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Get ediscoveryCustodian
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [ediscoveryCustodian](../resources/security-ediscoverycustodian.md) object.

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
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/custodians/{ediscoveryCustodianId}
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/reviewSets/{ediscoveryReviewSetId}/files/{ediscoveryFileId}/custodian
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [microsoft.graph.security.ediscoveryCustodian](../resources/security-ediscoverycustodian.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_ediscoverycustodian"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/custodians/0053a61a3b6c42738f7606791716a22a
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryCustodian = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Custodians["{security.ediscoveryCustodian-id}"]
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
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/custodians/$entity",
    "status": "active",
    "holdStatus": "applied",
    "createdDateTime": "0001-01-01T00:00:00Z",
    "lastModifiedDateTime": "2022-05-23T02:35:42.9272828Z",
    "releasedDateTime": "0001-01-01T00:00:00Z",
    "id": "0053a61a3b6c42738f7606791716a22a",
    "displayName": "Alex Wilber",
    "email": "AlexW@M365x809305.OnMicrosoft.com",
    "acknowledgedDateTime": "0001-01-01T00:00:00Z"
}
```
