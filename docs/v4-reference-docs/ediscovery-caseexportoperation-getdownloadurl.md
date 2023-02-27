---
title: "caseExportOperation: getDownloadUrl"
description: "Returns the download URL "
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# caseExportOperation: getDownloadUrl

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Returns the download URL for an export when the export is ready.

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
GET /compliance/ediscovery/cases/{caseId}/operations/{operationId}/microsoft.graph.ediscovery.caseExportOperation/getDownloadUrl
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a String in the response body. The value field represents the download URL from where the export can be retrieved.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "caseexportoperation_getdownloadurl"
}
-->

``` http
GET https://graph.microsoft.com/beta/compliance/ediscovery/cases/99e865fc-e29f-479a-ba83-9e58eb017103/operations/63926d4779c243458902328d83f61f53/microsoft.graph.ediscovery.caseExportOperation/getDownloadUrl
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var @string = await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].Operations["{ediscovery.caseOperation-id}"]
	.GetDownloadUrl()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Edm.String"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Edm.String",
    "value": "https://nam01pkgg0052.blob.edproxy.nam01.ediscovery.outlook.com/packaging0041e27c6c924a48befe348d34066c25/d0b6d2a7-5fc5-44f0-9bca-6b9d34a9410b.zip?sv=2018-03-28&sr=c&sig=TRFQNUGFtuVO7zd39oNJjzcQYJus2TXY%2B50aed4pJJM%3D&se=2020-12-28T23%3A06%3A26Z&sp=racwdl"
}
```
