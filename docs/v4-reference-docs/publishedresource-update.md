---
title: "Update publishedResource"
description: "Update the properties of a [publishedResource](../resources/publishedresource.md) object."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Update publishedResource

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of publishedresource  [publishedResource](../resources/publishedresource.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:--------------------------------------|:---------------------------------------------------------|
| Delegated (work or school account)     | OnPremisesPublishingProfiles.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Not supported. |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH ~/onPremisesPublishingProfiles/{publishingType}/publishedResources/{id1}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token} |

## Request body

In the request body, supply the values for relevant fields to update. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

The following table lists the properties that can be updated.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|displayName|String|Represents an on-premises published resource name.|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_publishedresource"
}-->

```http
PATCH https://graph.microsoft.com/beta/onPremisesPublishingProfiles/provisioning/publishedResources/1234b780-965f-4149-85c5-a8c73e58b67d

{
    "displayName": "Demo provisioning (updated)"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var publishedResource = new PublishedResource
{
	DisplayName = "Demo provisioning (updated)"
};

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"].PublishedResources["{publishedResource-id}"]
	.Request()
	.UpdateAsync(publishedResource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

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
  "description": "Update publishedresource",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



