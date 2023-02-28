---
title: "List lastEstimateStatisticsOperation"
description: "Get the last ediscoveryEstimateOperation object and its properties."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# List lastEstimateStatisticsOperation
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the last [ediscoveryEstimateOperation](../resources/security-ediscoveryestimateoperation.md) objects and their properties.

>**Note:** This method only lists the last operation; it does not return a history of all operations.

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
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/searches/{ediscoverySearchId}/lastEstimateStatisticsOperation
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

If successful, this method returns a `200 OK` response code and a [microsoft.graph.security.ediscoveryEstimateOperation](../resources/security-ediscoveryestimateoperation.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_ediscoveryestimateoperation"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/searches/c61a5860-d634-4d14-aea7-d82b6f4eb7af/lastEstimateStatisticsOperation
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryEstimateOperation = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Searches["{security.ediscoverySearch-id}"].LastEstimateStatisticsOperation
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
  "@odata.type": "microsoft.graph.security.ediscoveryEstimateOperation"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.security.ediscoveryEstimateOperation",
    "createdDateTime": "2022-05-29T18:56:48.4649404Z",
    "completedDateTime": "2022-05-29T18:58:31.968065Z",
    "percentProgress": 100,
    "status": "succeeded",
    "action": "estimateStatistics",
    "id": "d80d2f2bc71d4544b75d4836bef4ff57",
    "indexedItemCount": 1756,
    "indexedItemsSize": 89489297,
    "unindexedItemCount": 1,
    "unindexedItemsSize": 57952,
    "mailboxCount": 4,
    "siteCount": 6,
    "createdBy": {
        "application": null,
        "user": {
            "id": "0d38933a-0bbd-41ca-9ebd-28c4b5ba7cb7",
            "displayName": null,
            "userPrincipalName": null
        }
    }
}
```

