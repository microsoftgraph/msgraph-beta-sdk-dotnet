---
title: Get printServiceEndpoint
description: Retrieve the properties and relationships of a print service endpoint.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Get printServiceEndpoint

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of a print service endpoint.

> [!NOTE]
> In order to use the Universal Print service, the user or app's tenant must have an active Universal Print subscription.

## Permissions

One of the following permissions is required to call these APIs. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:------------------------------------|
| Delegated (work or school account)     | PrintJob.ReadBasic, PrintJob.Read, PrintJob.ReadBasic.All, PrinterShare.ReadBasic.All, PrintJob.Read.All, Printer.Read.All, PrinterShare.Read.All, PrintConnector.Read.All, PrintSettings.Read.All, PrintJob.ReadWriteBasic, PrintJob.ReadWrite, PrintJob.ReadWriteBasic.All, Printer.ReadWrite.All, PrinterShare.ReadWrite.All, PrintJob.ReadWrite.All, PrintConnector.ReadWrite.All, PrintSettings.ReadWrite.All, Printer.Create, PrintJob.Create |
| Delegated (personal Microsoft account) | Not supported.                      |
| Application                            | Not supported.                      |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /print/services/{id}/endpoints/{name}
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

If successful, this method returns a `200 OK` response code and a [printServiceEndpoint](../resources/printserviceendpoint.md) object in the response body.
## Example

##### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_printserviceendpoint"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/print/services/{id}/endpoints/{name}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printServiceEndpoint = await graphClient.Print.Services["{printService-id}"].Endpoints["{printServiceEndpoint-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

