---
title: "Update contactMergeSuggestions"
description: "Update the properties of a contactMergeSuggestions object."
author: "kevinbellinger"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# Update contactMergeSuggestions
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [contactMergeSuggestions](../resources/contactmergesuggestions.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|User.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /me/settings/contactMergeSuggestions
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|isEnabled|Boolean|`true` if the duplicate contact merge suggestions feature is enabled for user; `false` if the feature is disabled. Default is `true`.|



## Response

If successful, this method returns a `204 No Content` response code and the value is updated on the backend.

## Examples

The following example updates the **isEnabled** privacy setting to disable the duplicate contacts merge suggestions feature.

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_contactmergesuggestions"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/me/settings/contactMergeSuggestions
Content-Type: application/json

{
  "isEnabled": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contactMergeSuggestions = new ContactMergeSuggestions
{
	IsEnabled = false
};

await graphClient.Me.Settings.ContactMergeSuggestions
	.Request()
	.UpdateAsync(contactMergeSuggestions);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response. 

<!-- {
  "blockType": "response",
  "name": "update_contactmergesuggestions"
}
-->
``` http
HTTP/1.1 204 No Content
```

