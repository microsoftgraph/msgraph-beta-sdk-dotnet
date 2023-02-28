---
title: "Get ediscoveryReviewTag"
description: "Read the properties and relationships of an ediscoveryReviewTag object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# Get ediscoveryReviewTag
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [ediscoveryReviewTag](../resources/security-ediscoveryreviewtag.md) object.

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
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/tags/{ediscoveryReviewTagId}
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/reviewSets/{ediscoveryReviewSetId}/files/{ediscoveryFileId}/tags/{ediscoveryReviewTagId}
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/reviewSets/{ediscoveryReviewSetId}/files/{ediscoveryFileId}/tags/{ediscoveryReviewTagId}/parent
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/reviewSets/{ediscoveryReviewSetId}/files/{ediscoveryFileId}/tags/{ediscoveryReviewTagId}/childTags/{ediscoveryReviewTagId}
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

If successful, this method returns a `200 OK` response code and an [microsoft.graph.security.ediscoveryReviewTag](../resources/security-ediscoveryreviewtag.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_ediscoveryreviewtag"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/tags/062de822f17a4a2e9b833aa3f6c37108
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryReviewTag = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Tags["{security.ediscoveryReviewTag-id}"]
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
  "@odata.type": "microsoft.graph.security.ediscoveryReviewTag"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('58399dff-cebe-478f-b1af-d3227f1fd645')/tags/$entity",
    "displayName": "My tag",
    "description": null,
    "lastModifiedDateTime": "2022-05-23T19:41:01.7432683Z",
    "childSelectability": "Many",
    "id": "062de822f17a4a2e9b833aa3f6c37108",
    "createdBy": {
        "application": null,
        "user": {
            "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
            "displayName": "MOD Administrator",
            "userPrincipalName": "admin@M365x809305.onmicrosoft.com"
        }
    }
}
```

