---
author: JeremyKelley
description: "Use this API to retrieve the contents of an item in a specific format."
ms.date: 09/10/2017
title: Convert to other formats
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Download a file in another format

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
> [!WARNING]
> **This endpoint requires TLS 1.2 to function normally.** Microsoft announced the deprecation of TLS 1.0 and 1.1 for Office 365 and Azure AD services. Although Microsoft Graph still supports these two protocols, you might experience transport-level errors. For more information about the TLS 1.0 and 1.1 deprecation, see [Enable support for TLS 1.2 in your environment](/troubleshoot/azure/active-directory/enable-support-tls-environment).

Use this API to retrieve the contents of an item in a specific format.
Not all files can be converted into all formats.

To download the item in its original format, see [download an item's contents](driveitem-get-content.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:------------------------------------|
| Delegated (work or school account)     | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All |
| Delegated (personal Microsoft account) | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All |
| Application                            | Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /drive/items/{item-id}/content?format={format}
GET /drive/root:/{path and filename}:/content?format={format}
```

## Query parameters

| Parameter      | Type  | Description                                                    |
|:----------|:-------|:---------------------------------------------------------------|
| _format_  | string | Specify the format the item's content should be downloaded as. |

The following values are valid for the **format** parameter:

| Value | Description                        | Supported source extensions
|:------|:-----------------------------------|---------------------------------
| glb   | Converts the item into GLB format  | cool, fbx, obj, ply, stl, 3mf
| html  | Converts the item into HTML format | eml, md, msg
| jpg   | Converts the item into JPG format  | 3g2, 3gp, 3gp2, 3gpp, 3mf, ai, arw, asf, avi, bas, bash, bat, bmp, c, cbl, cmd, cool, cpp, cr2, crw, cs, css, csv, cur, dcm, dcm30, dic, dicm, dicom, dng, doc, docx, dwg, eml, epi, eps, epsf, epsi, epub, erf, fbx, fppx, gif, glb, h, hcp, heic, heif, htm, html, ico, icon, java, jfif, jpeg, jpg, js, json, key, log, m2ts, m4a, m4v, markdown, md, mef, mov, movie, mp3, mp4, mp4v, mrw, msg, mts, nef, nrw, numbers, obj, odp, odt, ogg, orf, pages, pano, pdf, pef, php, pict, pl, ply, png, pot, potm, potx, pps, ppsx, ppsxm, ppt, pptm, pptx, ps, ps1, psb, psd, py, raw, rb, rtf, rw1, rw2, sh, sketch, sql, sr2, stl, tif, tiff, ts, txt, vb, webm, wma, wmv, xaml, xbm, xcf, xd, xml, xpm, yaml, yml
| pdf   | Converts the item into PDF format  | doc, docx, epub, eml, htm, html, md, msg, odp, ods, odt, pps, ppsx, ppt, pptx, rtf, tif, tiff, xls, xlsm, xlsx

## Optional request headers

| Name            | Value   | Description                                                                                                                                              |
|:----------------|:--------|:---------------------------------------------------------------------------------------------------------------------------------------------------------|
| _if-none-match_ | String  | If this request header is included and the eTag (or cTag) provided matches the current tag on the file, an `HTTP 304 Not Modified` response is returned. |

## Example

# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "convert-item-content", "scopes": "files.read" } -->

```msgraph-interactive
GET /drive/items/{item-id}/content?format={format}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("format", "{format}")
};

var stream = await graphClient.Drive.Items["{driveItem-id}"].Content
	.Request( queryOptions )
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

