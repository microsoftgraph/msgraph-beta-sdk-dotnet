---
title: "application: removePassword"
description: "Remove a password from an application"
ms.localizationpriority: medium
author: "sureshja"
ms.prod: "applications"
doc_type: "apiPageType"
---

# application: removePassword

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Removes a password from an [application](../resources/application.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Application.ReadWrite.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Application.ReadWrite.All |
| Application                            | Application.ReadWrite.OwnedBy, Application.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request

You can address the application using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->
```http
POST /applications/{id}/removePassword
POST /applications(appId='{appId}')/removePassword
```

## Request headers

| Name           | Description                |
|:---------------|:---------------------------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type   | application/json. Required.|

## Request body

| Property	| Type | Description|
|:----------|:-----|:-----------|
| keyId     | Guid | The unique identifier for the password. Required. |

## Response

If successful, this method returns a `204 No content` response code.

## Examples

The following is example shows how to call this API.

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "application_removepassword"
}-->

```http
POST https://graph.microsoft.com/beta/applications/{id}/removePassword
Content-type: application/json

{
    "keyId": "f0b0b335-1d71-4883-8f98-567911bfdca6"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var keyId = Guid.Parse("f0b0b335-1d71-4883-8f98-567911bfdca6");

await graphClient.Applications["{application-id}"]
	.RemovePassword(keyId)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "application: removePassword",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



