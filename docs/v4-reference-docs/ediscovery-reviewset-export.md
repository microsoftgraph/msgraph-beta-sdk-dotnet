---
title: "reviewSet: export"
description: "Initiate an export from a reviewSet."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# reviewSet: export

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Initiate an export from a **reviewSet**.  For details, see [Export documents from a review set in Advanced eDiscovery](/microsoft-365/compliance/export-documents-from-review-set).

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
POST /compliance/ediscovery/cases/{caseId}/reviewsets/{reviewsetId}/export
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
|outputName|String| Name of the export. Required. |
|description|String| Description of the export |
|azureBlobContainer|String| When exporting to your own Azure storage account, this is the container URL. |
|azureBlobToken|String| When exporting to your own Azure storage account, SAS token for the container URL. |
|exportOptions| [microsoft.graph.ediscovery.exportOptions](../resources/ediscovery-caseexportoperation.md#exportoptions-values) |Specifies options that control the format of the export. Possible values are: `originalFiles`, `text`, `pdfReplacement`, `fileInfo`, `tags`.|
|exportStructure|[microsoft.graph.ediscovery.exportFileStructure](../resources/ediscovery-caseexportoperation.md#exportfilestructure-values)| Options that control file structure and packaging of the export. Possible values are: `none`, `directory`, `pst`.|

## Response

If the export is started successfully, this action returns a `202 Accepted` response code. The response will also contain a `Location` header, which contains the location of the [caseExportOperation](../resources/ediscovery-caseexportoperation.md) that was created to handle the export. Check the status of the export operation by making a GET request to the location, when successfully completed, the [status](../resources/ediscovery-caseoperation.md#caseoperationstatus-values) will change to `succeeded`.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "reviewset_export"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/99e865fc-e29f-479a-ba83-9e58eb017103/reviewsets/e44ac2cb-f8b4-4fd8-aa1c-1391b46ba9cc/export
Content-Type: application/json

{
  "outputName": "2020-12-06 Contoso investigation export",
  "description": "Export for the Contoso investigation",
  "exportOptions": "originalFiles,fileInfo,tags",
  "exportStructure": "directory"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var outputName = "2020-12-06 Contoso investigation export";

var description = "Export for the Contoso investigation";

var exportOptions = Microsoft.Graph.Ediscovery.ExportOptions.OriginalFiles | Microsoft.Graph.Ediscovery.ExportOptions.FileInfo | Microsoft.Graph.Ediscovery.ExportOptions.Tags;

var exportStructure = Microsoft.Graph.Ediscovery.ExportFileStructure.Directory;

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].ReviewSets["{ediscovery.reviewSet-id}"]
	.Export(exportStructure,outputName,description,null,null,exportOptions)
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
client-request-id: 3ec98906-7187-927e-5203-2ed4533175c6,
location: https://graph.microsoft.com/beta/compliance/ediscovery/cases('5b840b94-f821-4c4a-8cad-3a90062bf51a')/operations('2ad2da7c7dbb404abfbbb28b7b6babd6'),
request-id: 9e6b9230-113c-49de-8f7d-ecb90d35b0de
```
