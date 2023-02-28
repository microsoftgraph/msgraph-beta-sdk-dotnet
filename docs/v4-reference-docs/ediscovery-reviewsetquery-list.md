---
title: "List reviewSetQueries"
description: "Retrieve a list of reviewSetQuery objects."
ms.localizationpriority: medium
author: "mahage-msft"
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# List reviewSetQueries

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of eDiscovery [reviewSetQuery](../resources/ediscovery-reviewsetquery.md) objects.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /compliance/ediscovery/cases/{id}/reviewSets/{id}/queries
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.ediscovery.reviewSetQuery](../resources/ediscovery-reviewsetquery.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_reviewsetquery"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/compliance/ediscovery/cases/2eef613a-ca2d-42f4-89fe-84d5198ddedf/reviewSets/b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8/queries
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queries = await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].ReviewSets["{ediscovery.reviewSet-id}"].Queries
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.reviewSetQuery",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/compliance/ediscovery/$metadata#cases('2eef613a-ca2d-42f4-89fe-84d5198ddedf')/reviewSets('b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8')/queries",
    "@odata.nextLink": "https://graph.microsoft.com/beta/compliance/ediscovery/cases('2eef613a-ca2d-42f4-89fe-84d5198ddedf')/reviewSets('b26888b3-e1f5-47c5-bdf2-33d1b90cb2e8')/queries?$skipToken=<encodedPageToken>",
    "value": [
        {
            "id": "f7859ebb-5546-4f96-937a-9cf5723e9809",
            "displayName": "Query 1",
            "createdBy": {
                "user": {
                    "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
                    "displayName": "eDiscovery admin"
                }
            },
            "createdDateTime": "2020-03-02T12:07:52.6520503Z",
            "lastModifiedBy": {
                "user": {
                    "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
                    "displayName": "eDiscovery admin"
                }
            },
            "lastModifiedDateTime": "2020-03-02T12:07:52.6520503Z",
            "query": "(Cc:aa)"
        },
        {
            "id": "7c4b98e1-fe18-4887-be81-79f7a24b15c8",
            "displayName": "New query1",
            "description": null,
            "createdBy": {
                "user": {
                    "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
                    "displayName": "eDiscovery admin"
                }
            },
            "createdDateTime": "2020-03-02T16:17:19.3564678Z",
            "lastModifiedBy": {
                "user": {
                    "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
                    "displayName": "eDiscovery admin"
                }
            },
            "lastModifiedDateTime": "2020-03-02T16:17:19.3564678Z",
            "query": "subject:\"Quarterly Financials\""
        }
    ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List queries",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


