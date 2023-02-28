---
title: "Add custodianSources"
description: "Add custodial dataSource objects to a source collection."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Add custodianSources

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add custodian [dataSource](../resources/ediscovery-datasource.md) objects to a source collection.

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
POST /compliance/ediscovery/cases/{caseId}/sourceCollections/{sourceCollectionId}/custodianSources/$ref
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [dataSource](../resources/ediscovery-datasource.md) object.

The following table shows the properties that are required when you create the [dataSource](../resources/ediscovery-datasource.md).

|Property|Type|Description|
|:---|:---|:---|
|@odata.id|String|String that defines the custodial object. See the example that follows.|

## Response

If successful, this method returns a `204 No Content` response code and a [microsoft.graph.ediscovery.dataSource](../resources/ediscovery-datasource.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_datasource_from__2"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/sourceCollections/1a9b4145d8f84e39bc45a7f68c5c5119/custodianSources/$ref
Content-Type: application/json

{
  "@odata.id":"https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/custodians/ab3a628a383045eba344b3caecba3104/userSources/31423539-3846-4333-4136-353644383531"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var dataSourceReference = new ReferenceRequestBody
{
	ODataId = "https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/custodians/ab3a628a383045eba344b3caecba3104/userSources/31423539-3846-4333-4136-353644383531"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].SourceCollections["{ediscovery.sourceCollection-id}"].CustodianSources.References
	.Request()
	.AddAsync(dataSourceReference);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response"
}
-->

``` http
HTTP/1.1 204 No Content
```
