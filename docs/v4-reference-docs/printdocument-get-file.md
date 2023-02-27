---
title: "Download printDocument binary file"
description: Download the binary file associated with the document.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Download printDocument binary file

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Download the binary file associated with a [printDocument](../resources/printdocument.md). Calling this method yields a redirect response with a pre-authenticated URL that can be used to download the payload.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

In addition to the following permissions, the user or app's tenant must have an active Universal Print subscription and have a permission that grants grants [Get printer](printer-get.md) access.

| Permission type                        | Permissions (from least to most privileged)                  |
| :------------------------------------- | :----------------------------------------------------------- |
| Delegated (work or school account)     | PrintJob.Read, PrintJob.Read.All, PrintJob.ReadWrite, PrintJob.ReadWrite.All |
| Delegated (personal Microsoft account) | Not Supported.                                               |
| Application                            | PrintJob.Read.All, PrintJob.ReadWrite.All                    |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /print/printers/{id}/jobs/{id}/documents/{id}/$value
```
## Request headers
| Name          | Description               |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns `302 Found` and the pre-authenticated download URL in the Location header.

## Examples
The following example shows how to call this API to acquire a pre-authenticated download URL. To start the download, follow the redirect URL in the response.

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_document_value",
  "sampleKeys": ["46140", "fcb0bc53-a446-41d0-bfc3-5c56cdbb0f2a", "bd260b1a-044e-4ca6-afa9-17d9a587d254"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/print/printers/fcb0bc53-a446-41d0-bfc3-5c56cdbb0f2a/jobs/46140/documents/bd260b1a-044e-4ca6-afa9-17d9a587d254/$value
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Print.Printers["{printer-id}"].Jobs["{printJob-id}"].Documents["{printDocument-id}"].Content
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 302 Found
Location: https://print.print.microsoft.com/downloads/bd260b1a-044e-4ca6-afa9-17d9a587d254?tempauthtoken={accesstoken}
```
