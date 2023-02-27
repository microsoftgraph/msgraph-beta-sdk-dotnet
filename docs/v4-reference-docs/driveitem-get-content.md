---
author: JeremyKelley
description: "Download the contents of the primary stream (file) of a driveItem. Only driveItems with the file property can be downloaded."
title: Download a file
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# Download the contents of a driveItem

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
> [!WARNING]
> **This endpoint requires TLS 1.2 to function normally.** Microsoft announced the deprecation of TLS 1.0 and 1.1 for Office 365 and Azure AD services. Although Microsoft Graph still supports these two protocols, you might experience transport-level errors. For more information about the TLS 1.0 and 1.1 deprecation, see [Enable support for TLS 1.2 in your environment](/troubleshoot/azure/active-directory/enable-support-tls-environment).

Download the contents of the primary stream (file) of a [driveItem](../resources/driveitem.md). Only **driveItems** with the **file** property can be downloaded.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All    |
|Delegated (personal Microsoft account) | Files.Read, Files.ReadWrite, Files.Read.All, Files.ReadWrite.All    |
|Application | Files.Read.All, Files.ReadWrite.All, Sites.Read.All, Sites.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /drives/{drive-id}/items/{item-id}/content
GET /groups/{group-id}/drive/items/{item-id}/content
GET /me/drive/root:/{item-path}:/content
GET /me/drive/items/{item-id}/content
GET /shares/{shareIdOrEncodedSharingUrl}/driveItem/content
GET /sites/{siteId}/drive/items/{item-id}/content
GET /users/{userId}/drive/items/{item-id}/content
```

## Optional request headers

| Name          | Value  | Description                                                                                                                                              |
|:--------------|:-------|:---------------------------------------------------------------------------------------------------------------------------------------------------------|
| if-none-match | String | If this request header is included and the eTag (or cTag) provided matches the current tag on the file, an `HTTP 304 Not Modified` response is returned. |

## Example

Here is an example to download a complete file.

### Request

# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "download-item-content", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/content
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Me.Drive.Items["{driveItem-id}"].Content
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

Returns a `302 Found` response redirecting to a pre-authenticated download URL for the file.
This is the same URL available through the `@microsoft.graph.downloadUrl` property on the DriveItem.

To download the contents of the file your application will need to follow the `Location` header in the response.
Many HTTP client libraries will automatically follow the 302 redirection and start downloading the file immedately.

Pre-authenticated download URLs are only valid for a short period of time (a few minutes) and do not require an `Authorization` header to download.

<!-- { "blockType": "response" } -->

```http
HTTP/1.1 302 Found
Location: https://b0mpua-by3301.files.1drv.com/y23vmagahszhxzlcvhasdhasghasodfi
```

## Downloading files in JavaScript apps
To download files in a JavaScript app, you cannot use the `/content` API, because this responds with a `302` redirect.
A `302` redirect is explicitly prohibited when a [Cross-Origin Resource Sharing (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) _preflight_ is required, such as when providing the **Authorization** header.

Instead, your app needs to select the `@microsoft.graph.downloadUrl` property, which returns the same URL that `/content` directs to.
This URL can then be requested directly using XMLHttpRequest.
Because these URLs are pre-authenticated, they can be retrieved without a CORS preflight request.

### Example

To retrieve the download URL for a file, first make a request that includes the `@microsoft.graph.downloadUrl` property:

```http
GET /drive/items/{item-ID}?select=id,@microsoft.graph.downloadUrl
```

This returns the ID and download URL for a file:

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "12319191!11919",
  "@microsoft.graph.downloadUrl": "https://..."
}
```

You can then make an XMLHttpRequest for the URL provided in `@microsoft.graph.downloadUrl` to retrieve the file.

## Partial range downloads

To download a partial range of bytes from the file, your app can use the `Range` header as specified in [RFC 2616](https://www.ietf.org/rfc/rfc2616.txt).
Note that you must append the `Range` header to the actual `@microsoft.graph.downloadUrl` URL and not to the request for `/content`.

<!-- { "blockType": "request", "name": "download-item-partial", "scopes": "files.read" } -->

```http
GET https://b0mpua-by3301.files.1drv.com/y23vmag
Range: bytes=0-1023
```

This will return an `HTTP 206 Partial Content` response with the request range of bytes from the file.
If the range cannot be generated the Range header may be ignored and an `HTTP 200` response would be returned with the full contents of the file.

<!-- { "blockType": "response", "name": "download-item-partial", "@odata.type": "stream" } -->

```http
HTTP/1.1 206 Partial Content
Content-Range: bytes 0-1023/2048

<first 1024 bytes of file>
```

### Error responses

See [Error Responses][error-response] for more info about
how errors are returned.

[error-response]: /graph/errors

<!--
{
  "type": "#page.annotation",
  "description": "Download the contents of a DriveItem.",
  "keywords": "",
  "section": "documentation",
  "tocPath": "Items/Download",
  "suppressions": [
  ]
}
-->


