---
title: "Start sync after uploading files to an educationSynchronizationProfile"
description: "Verify the files uploaded to a specific school data synchronization profile in the tenant. If the verification is successful, synchronization will start on the profile. Otherwise, the response will contain errors and warnings. If the response contains errors, the synchronization will not start. If the response contains only warnings, synchronization will start."
ms.localizationpriority: medium
author: "mmast-msft"
ms.prod: "education"
doc_type: apiPageType
---

# Start sync after uploading files to an educationSynchronizationProfile

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Verify the files uploaded to a specific school data [synchronization profile](../resources/educationsynchronizationprofile.md) in the tenant. If the verification is successful, synchronization will start on the profile. Otherwise, the response will contain errors and warnings. If the response contains errors, the synchronization will not start. If the response contains only warnings, synchronization will start.

> **Note:** Use this method only when the data provider is of type [educationcsvdataprovider](../resources/educationcsvdataprovider.md). Also, the profile's state property needs to be provisioned before it can be started. Poll the profile object to check its state property.

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
POST /education/synchronizationProfiles/{id}/start
```

## Request headers
| Name       | Type | Description|
|:-----------|:------|:----------|
| Authorization  | string  | Bearer {token}. Required.  |

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code. If unsuccessful, it returns a `400 Bad Request`. The response contains a collection of [educationFileSynchronizationVerificationMessage](../resources/educationfilesynchronizationverificationmessage.md) objects as part of the response body if any errors or warnings were found.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_educationSynchronizationProfile_start"
}-->
```http
POST https://graph.microsoft.com/beta/education/synchronizationProfiles/{id}/start
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Education.SynchronizationProfiles["{educationSynchronizationProfile-id}"]
	.Start()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

