---
title: "reviewSetQuery: applyTags"
description: "Apply tags to documents that match the specified query."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# reviewSetQuery: applyTags

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Apply [tags](../resources/ediscovery-tag.md) to documents that match the specified [reviewSetQuery](../resources/ediscovery-reviewsetquery.md).

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
POST /compliance/ediscovery/cases/{caseId}/reviewSets/{reviewSetId}/queries/{reviewSetQueryId}/applyTags
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
|tagsToAdd|[microsoft.graph.ediscovery.tag](../resources/ediscovery-tag.md) collection|IDs of tags to add to the documents that match the query.|
|tagsToRemove|[microsoft.graph.ediscovery.tag](../resources/ediscovery-tag.md) collection|IDs of tags to remove from the documents that match the query.|

## Response

If successful, this action returns a `202 Accepted` response code.

If the tagging operation is started successfully, this action returns a `202 Accepted` response code. The response will also contain a `Location` header, which contains the location of the [tagOperation](../resources/ediscovery-tagOperation.md) that was created to handle the tagging. Check the status of the tagging operation by making a GET request to the location, when successfully completed, the [status](../resources/ediscovery-caseoperation.md#caseoperationstatus-values) will change to `succeeded`.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "reviewsetquery_applytags"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/reviewsets/6c95c2a6-31fa-45a8-93ef-dd4531974783/queries/b4798d14-748d-468e-a1ec-96a2b1d49677/applyTags
Content-Type: application/json

{
    "tagsToAdd": [
        {
            "id": "b4798d14-748d-468e-a1ec-96a2b1d49677"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tagsToAdd = new List<Microsoft.Graph.Ediscovery.Tag>()
{
	new Microsoft.Graph.Ediscovery.Tag
	{
		Id = "b4798d14-748d-468e-a1ec-96a2b1d49677"
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].ReviewSets["{ediscovery.reviewSet-id}"].Queries["{ediscovery.reviewSetQuery-id}"]
	.ApplyTags(tagsToAdd,null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 202 Accepted
cache-control: no-cache,
client-request-id: 56c9dd8b-d8f7-59ae-6733-38191862c9c9,
location: https://graph.microsoft.com/beta/compliance/ediscovery/cases('47746044-fd0b-4a30-acfc-5272b691ba5b')/operations('d77f7933e88842bab3221e280be9dc0b'),
request-id: c2397a81-e9c2-4851-b669-d87e0751e45a
```
