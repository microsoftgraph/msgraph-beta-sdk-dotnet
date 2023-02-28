---
title: "educationSynchronizationProfile: uploadUrl"
description: "Retrieve a shared access signature (SAS) for uploading source files to Azure blob storage for a specific school data synchronization profile in the tenant. The SAS token has a validity of one hour."
author: "mmast-msft"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# educationSynchronizationProfile: uploadUrl

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a shared access signature (SAS) for uploading source files to Azure blob storage for a specific school data [synchronization profile](../resources/educationsynchronizationprofile.md) in the tenant. The SAS token has a validity of one hour.

The upload URL is provided only for the [CSV data provider](../resources/educationcsvdataprovider.md).

> **Note:** To access the blob storage with the SAS token, use the [Azure storage SDKs](https://github.com/search?q=org%3AAzure+azure-storage) or [AzCopy](/azure/storage/storage-use-azcopy).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions |
|:-----------|:----------|
| Delegated (work or school account) | EduAdministration.ReadWrite |
|Delegated (personal Microsoft account|Not supported.|
|Application|EduAdministration.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /education/synchronizationProfiles/{id}/uploadUrl
```

## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and a SAS URL for the [educationSynchronizationProfile](../resources/educationsynchronizationprofile.md) in the response body.

If a previous request is still being processed, this method returns a `409 Conflict` indicating that the upload is presently blocked for the [educationSynchronizationProfile](../resources/educationsynchronizationprofile.md).

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_educationSynchronizationProfile_uploadurl"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/education/synchronizationProfiles/{id}/uploadUrl
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var @string = await graphClient.Education.SynchronizationProfiles["{educationSynchronizationProfile-id}"]
	.UploadUrl()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

