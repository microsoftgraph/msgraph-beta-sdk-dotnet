---
title: "ediscoveryReviewSet: addToReviewSet"
description: "Start the process of adding a collection from Microsoft 365 services to a review set."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# ediscoveryReviewSet: addToReviewSet
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Start the process of adding a collection from Microsoft 365 services to a [review set](../resources/security-ediscoveryreviewset.md). After the operation is created, you can get the status of the operation by retrieving the `Location` parameter from the response headers. The location provides a URL that will return a [Add to review set operation](../resources/security-ediscoveryaddtoreviewsetoperation.md).


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
POST /security/cases/ediscoveryCases/{eDiscoveryCaseId}/reviewSets/{eDiscoveryReviewSetId}/addToReviewSet
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
|search|[microsoft.graph.security.ediscoverySearch](../resources/security-ediscoverysearch.md)|The ID of the eDiscovery search you'd like to add to the review set.|
|additionalDataOptions|additionalDataOptions|The options for adding items to reviewSet.|

### additionalDataOptions values
|Name|Description|
|:---|:---|
|allVersions|include all versions of a sharepoint document matching the source collection query. Caution: SharePoint versions can significantly increase the volume of items |
|linkedFiles|include linked files that were shared in outlook, teams, or yammer messages by attaching a link to the file.|

## Response

If successful, this action returns a `202 Accepted` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "ediscoveryreviewsetthis.addtoreviewset"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/reviewSets/63ef0fd7-0db2-45eb-a9d7-7d75c8239873/addToReviewSet
Content-Type: application/json

{
    "search": {
        "id": "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
    },
    "additionalDataOptions": "linkedFiles"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var search = new Microsoft.Graph.Security.EdiscoverySearch
{
	Id = "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
};

var additionalDataOptions = Microsoft.Graph.Security.AdditionalDataOptions.LinkedFiles;

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].ReviewSets["{security.ediscoveryReviewSet-id}"]
	.AddToReviewSet(search,additionalDataOptions)
	.Request()
	.PostAsync();

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
HTTP/1.1 202 Accepted
```
