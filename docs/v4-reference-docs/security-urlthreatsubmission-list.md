---
title: "List urlThreatSubmissions"
description: "Get a list of the urlThreatSubmission objects and their properties."
author: "caigen"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# List urlThreatSubmissions
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [urlThreatSubmission](../resources/security-urlthreatsubmission.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ThreatSubmission.Read,ThreatSubmission.ReadWrite,ThreatSubmission.Read.All,ThreatSubmission.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|ThreatSubmission.Read.All,ThreatSubmission.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /security/threatSubmission/urlThreats
```

## Optional query parameters
This method supports `$filter`, `$top`, `$skipToken` and `$count` to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [urlThreatSubmission](../resources/security-urlthreatsubmission.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_urlthreatsubmission"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/threatSubmission/urlThreats
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var urlThreats = await graphClient.Security.ThreatSubmission.UrlThreats
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
  "@odata.type": "Collection(microsoft.graph.security.urlThreatSubmission)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/threatSubmission/urlThreatSubmission/$entity",
      "@odata.type": "#microsoft.graph.security.urlThreatSubmission",
      "category": "phishing",  
      "id": "49c5ef5b-1f65-444a-e6b9-08d772ea2059",
      "createdDateTime": "2021-10-10T03:30:18.6890937Z",
      "contentType": "url",
      "webUrl": "http://phishing.contoso.com",
      "status": "running",
      "source": "administrator",
      "createdBy": {
        "user": {
          "identity": "c52ce8db-3e4b-4181-93c4-7d6b6bffaf60",
          "displayName": "Ronald Admin",
          "email": "tifc@a830edad9050849eqtpwbjzxodq.onmicrosoft.com"
        }
      },
      "result": {
        "detail": "underInvestigation"
      },
      "adminReview": null,
      "tenantId" : "39238e87-b5ab-4ef6-a559-af54c6b07b42"
    }
  ]
}
```

