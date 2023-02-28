---
title: "Update sourceCollection"
description: "Update the properties of a sourceCollection object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Update sourceCollection

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [sourceCollection](../resources/ediscovery-sourcecollection.md) object.

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
PATCH /compliance/ediscovery/cases/{caseId}/sourceCollections/{sourceCollectionId}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

|Property|Type|Description|
|:---|:---|:---|
|contentQuery|String|The query string in KQL (Keyword Query Language) query. For details, see [Keyword queries and search conditions for Content Search and eDiscovery](/microsoft-365/compliance/keyword-queries-and-search-conditions).  You can refine searches by using fields paired with values; for example, `subject:"Quarterly Financials" AND Date>=06/01/2016 AND Date<=07/01/2016`.|
|dataSourceScopes|microsoft.graph.ediscovery.dataSourceScopes|When specified, the collection will span across a service for an entire workload. Possible values are: `none`,`allTenantMailboxes`,`allTenantSites`,`allCaseCustodians`,`allCaseNoncustodialDataSources`. **Note:** Either one custodian or specifying dataSourceScope is required when creating a source collection.|
|description|String|The description of the **sourceCollection**.|
|displayName|String|The display name of the **sourceCollection**.|

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_sourcecollection"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/compliance/ediscovery/cases/{caseId}/sourceCollections/1a9b4145d8f84e39bc45a7f68c5c5119
Content-Type: application/json

{
    "displayName": "Quarterly Financials search",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var sourceCollection = new Microsoft.Graph.Ediscovery.SourceCollection
{
	DisplayName = "Quarterly Financials search"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].SourceCollections["{ediscovery.sourceCollection-id}"]
	.Request()
	.UpdateAsync(sourceCollection);

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
HTTP/1.1 204 No Content
```
