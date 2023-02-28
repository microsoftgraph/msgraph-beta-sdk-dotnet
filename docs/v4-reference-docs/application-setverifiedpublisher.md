---
title: "application: setVerifiedPublisher"
description: "Set the verified publisher of an application."
ms.localizationpriority: medium
author: "jesakowi"
ms.prod: "applications"
doc_type: "apiPageType"
---

# application: setVerifiedPublisher

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Set the the [verifiedPublisher](../resources/verifiedPublisher.md) on an [application](../resources/application.md). For more information, including prerequisites to setting a verified publisher, see [Publisher verification](/azure/active-directory/develop/publisher-verification-overview).

## Permissions

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported |
|Application | Not supported |

## HTTP request

You can address the application using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->
```http
POST /applications/{id}/setVerifiedPublisher
POST /applications(appId='{appId}')/setVerifiedPublisher
```

## Request headers

| Name           | Description                |
|:---------------|:---------------------------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type   | application/json. Required.|

## Request body

In the request body, provide the following required properties.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
| verifiedPublisherId | string | The Microsoft Partner Network ID (MPNID) of the verified publisher to be set on the application, from the publisher's Partner Center account. |

## Response

If successful, this method returns a `204 No Content` response code.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "application_setverifiedpublisher"
}-->

```http
POST https://graph.microsoft.com/beta/applications/{id}/setVerifiedPublisher
Content-type: application/json

{
    "verifiedPublisherId": "1234567"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var verifiedPublisherId = "1234567";

await graphClient.Applications["{application-id}"]
	.SetVerifiedPublisher(verifiedPublisherId)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: e7beba93-bb0b-42ea-96c8-231aa61d755e
2020-09-09 21:16:07 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "application: setVerifiedPublisher",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}-->
