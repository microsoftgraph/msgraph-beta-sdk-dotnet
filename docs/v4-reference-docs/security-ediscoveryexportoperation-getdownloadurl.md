---
title: "ediscoveryExportOperation: getDownloadUrl"
description: "return a downloadUrl from where the export content is delivered as a stream"
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# ediscoveryExportOperation: getDownloadUrl
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

If a Azure blob url is not provided in export action, the export operation exports the files to an internal store. Contents of this store can be fetched by calling into this function. This will return a downloadUrl where the zipped content is delivered as a stream.


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
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/operations/{eDiscoveryCaseOperationId}/microsoft.graph.security.ediscoveryExportOperation/getDownloadUrl
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a String in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "ediscoveryexportoperationthis.getdownloadurl"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/operations/c5ae226f457547a582ef0eb6dbfaee25/microsoft.graph.security.ediscoveryExportOperation/getDownloadUrl
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var @string = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Operations["{security.caseOperation-id}"]
	.GetDownloadUrl()
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
  "@odata.type": "Edm.String"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: text/plain

{
    "https://sdfpkgg0021.blob.edproxy.aed01.ediscovery.outlook.com/packaging120g37c10016472cb0abf28fac5800b0/6dec1a1c-0577-424f-819c-9542edc47f5a.zip?{SASToken}"
}
```

