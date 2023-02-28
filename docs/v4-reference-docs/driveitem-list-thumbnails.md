---
author: JeremyKelley
description: "Retrieve a collection of ThumbnailSet resources for a DriveItem resource."
ms.date: 09/10/2017
title: Retrieve thumbnails for a file or folder
ms.localizationpriority: medium
ms.prod: "sharepoint"
doc_type: apiPageType
---
# List thumbnails for a DriveItem

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.
> [!WARNING]
> **This endpoint requires TLS 1.2 to function normally.** Microsoft announced the deprecation of TLS 1.0 and 1.1 for Office 365 and Azure AD services. Although Microsoft Graph still supports these two protocols, you might experience transport-level errors. For more information about the TLS 1.0 and 1.1 deprecation, see [Enable support for TLS 1.2 in your environment](/troubleshoot/azure/active-directory/enable-support-tls-environment).

Retrieve a collection of [ThumbnailSet](../resources/thumbnailset.md) resources for a [DriveItem](../resources/driveitem.md) resource.

A DriveItem can be represented by zero or more [ThumbnailSet](../resources/thumbnailset.md) resources.
Each **thumbnailSet** can have one or more [**thumbnail**](../resources/thumbnail.md) objects, which are images that represent the item.
For example, a **thumbnailSet** may include **thumbnail** objects, such as common ones including `small`, `medium`, or `large`.

There are many ways to work with thumbnails on OneDrive.
Here are the most common ones:

* Enumerate available thumbnails for an item
* Retrieve a single thumbnail for an item
* Retrieve thumbnail content
* Retrieve thumbnails for multiple items in a single request
* Retrieve custom thumbnail sizes
* Upload a custom thumbnail for an item
* Determine if a custom uploaded thumbnail exists


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
GET /drives/{drive-id}/items/{item-id}/thumbnails
GET /groups/{group-id}/drive/items/{item-id}/thumbnails
GET /me/drive/items/{item-id}/thumbnails
GET /sites/{site-id}/drive/items/{item-id}/thumbnails
GET /users/{user-id}/drive/items/{item-id}/thumbnails
```

## Optional query parameters

This method supports the `$select` [OData query parameter](/graph/query-parameters) to customize the response.

Additionally, this method supports retrieving the thumbnail with the original orientation EXIF value and without the applied rotation by appending the `originalOrientation=true` query parameter.
This is currently only supported on OneDrive Personal.

## Response

If successful, this method returns a `200 OK` response code and collection of [ThumbnailSet](../resources/thumbnailset.md) objects in the response body.

## Example

Here is an example of the request which retrieves available thumbnails for an item in the current user's OneDrive.


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "enum-item-thumbnails", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/thumbnails
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var thumbnails = await graphClient.Me.Drive.Items["{driveItem-id}"].Thumbnails
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- { "blockType": "response", "@odata.type": "Collection(microsoft.graph.thumbnailSet)" } -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "0",
      "small": { "height": 64, "width": 96, "url": "https://sn3302files..."},
      "medium": { "height": 117, "width": 176, "url": "https://sn3302files..."},
      "large": { "height": 533, "width": 800, "url": "https://sn3302files..."}
    }
  ]
}
```

## Get a single thumbnail

Retrieve the metadata for a single thumbnail and size by addressing it directly in a request.

### HTTP request


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "get-one-thumbnail", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/thumbnails/{thumb-id}/{size}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var response = await graphClient.Me.Drive.Items["{driveItem-id}"].Thumbnails["{thumbnailSet-id}"]["{thumbnailSet-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

# [HTTP](#tab/http)
<!-- { "blockType": "request", "name":"get-thumbnail-content", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/thumbnails/{thumb-id}/{size}/content
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var content = await graphClient.Me.Drive.Items["{driveItem-id}"].Thumbnails["{thumbnailSet-id}"]["{thumbnailSet-id}"].Content
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The service responds with a redirect to the thumbnail URL.

<!-- { "blockType": "response" } -->

```http
HTTP/1.1 302 Found
Location: https://b0mpua-by3301.files.1drv.com/y23vmagahszhxzlcvhasdhasghasodfi
```

Thumbnail URLs are cache-safe. The URL will change, if the item changes in a way that requires a new thumbnail to be generated.


## Getting thumbnails while listing DriveItems

If you are retrieving a list of DriveItem resources to display, you can use the _$expand_ query string parameter to also include the thumbnails for those resources.
This enables your app to retrieve thumbnails and items in a single request, instead of issuing many requests.

### HTTP request


# [HTTP](#tab/http)
<!-- { "blockType": "request", "name":"get-thumbnail-while-listing", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/children?$expand=thumbnails
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var children = await graphClient.Me.Drive.Items["{driveItem-id}"].Children
	.Request()
	.Expand("thumbnails")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The service responses with the list of DriveItems and their thumbnails.

<!-- { "blockType": "response", "@odata.type": "Collection(microsoft.graph.driveItem)", "truncated": true } -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "id": "182331E8-2788-4932-B52A-A6550577043F",
      "name": "my photo.jpg",
      "thumbnails": [
        {
          "small": { "width": 96,
                     "height": 96,
                     "url": "https://sn3302files..."
                   }
        }
      ]
    },
    {
      "id": "2D223953-A56B-4D9B-ADF3-13E7820673A2",
      "name": "presentation.pptx",
      "thumbnails": [
        {
          "small": { "width": 96,
                     "height": 96,
                     "url": "https://sn3302files..."
                   }
        }
      ]
    }
  ]
}
```

## Size values

This table defines the possible thumbnail sizes.
While you can request any arbitrary thumbnail size, the defined values are likely to exist and return a value quickly:

| Name           | Resolution  | Aspect Ratio | Description                                                          |
|:---------------|:------------|:-------------|:---------------------------------------------------------------------|
| `small`        | 96 longest  | Original     | Small, highly compressed thumbnail cropped to a square aspect ratio. |
| `medium`       | 176 longest | Original     | Cropped to the standard item size for the OneDrive web view.         |
| `large`        | 800 longest | Original     | Thumbnail with the longest edge resized to 800 pixels.               |
| `smallSquare`  | 96x96       | Square Crop  | Small square thumbnail                                               |
| `mediumSquare` | 176x176     | Square Crop  | Small square thumbnail                                               |
| `largeSquare`  | 800x800     | Square Crop  | Large square thumbnail                                               |

## Requesting custom thumbnail sizes

In addition to the defined sizes, your app can request a custom thumbnail size by specifying the dimensions of the thumbnail prefixed with `c`.
For example if your app needs thumbnails that are 300x400, it can request that size like this:


# [HTTP](#tab/http)
<!-- { "blockType": "request","name": "get-thumbnail-custom-size", "scopes": "files.read" } -->

```msgraph-interactive
GET /me/drive/items/{item-id}/thumbnails?select=c300x400_crop
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("select", "c300x400_crop")
};

var thumbnails = await graphClient.Me.Drive.Items["{driveItem-id}"].Thumbnails
	.Request( queryOptions )
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

