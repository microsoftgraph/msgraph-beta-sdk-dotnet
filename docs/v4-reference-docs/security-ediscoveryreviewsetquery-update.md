---
title: "Update ediscoveryReviewSetQuery"
description: "Update the properties of an ediscoveryReviewSetQuery object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---
# Update ediscoveryReviewSetQuery
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [ediscoveryReviewSetQuery](../resources/security-ediscoveryreviewsetquery.md) object.

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
PATCH /security/cases/ediscoveryCases/{ediscoveryCaseId}/reviewSets/{ediscoveryReviewSetId}/queries/{queryId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The name of the query. Required.|
|contentQuery|String|The KQL query for the review set. For details, see [Query and filter content in a review set](/microsoft-365/compliance/review-set-search).|



## Response

If successful, this method returns a `204 No content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_ediscoveryreviewsetquery"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/reviewSets/63ef0fd7-0db2-45eb-a9d7-7d75c8239873/queries/5f426fdc-f027-40db-b7cc-453cf06dc996
Content-Type: application/json

{
    "displayName": "My Query 1 (update)",
    "contentQuery": "(Author=\"edisons\")"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryReviewSetQuery = new Microsoft.Graph.Security.EdiscoveryReviewSetQuery
{
	DisplayName = "My Query 1 (update)",
	ContentQuery = "(Author=\"edisons\")"
};

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].ReviewSets["{security.ediscoveryReviewSet-id}"].Queries["{security.ediscoveryReviewSetQuery-id}"]
	.Request()
	.UpdateAsync(ediscoveryReviewSetQuery);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No content.
```
