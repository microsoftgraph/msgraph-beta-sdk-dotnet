---
title: "Get userInsightsSettings"
description: "Retrieve the properties of a userInsightsSettings object."
author: "simonhult"
ms.localizationpriority: medium
ms.prod: "insights"
doc_type: "apiPageType"
---

# Get userInsightsSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the user-customizable privacy settings for [itemInsights](../resources/iteminsights.md) and [meeting hours insights](https://support.microsoft.com/office/update-your-meeting-hours-using-the-profile-card-0613d113-d7c1-4faa-bb11-c8ba30a78ef1).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, User.ReadWrite |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |


## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/settings/itemInsights
GET /users/{userId}/settings/itemInsights
```

>**Note:** Requests with a `userId` or `userPrincipalName` are only accessible by the user or by a user with the User.ReadWrite.All permissions. To learn more, see [Permissions](/graph/permissions-reference).

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [userInsightsSettings](../resources/userinsightssettings.md) object in the response body.

## Examples

### Request

The following is an example of the request to get user item insights and meeting hours insights settings.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_userInsightsSettings"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/me/settings/itemInsights
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userInsightsSettings = await graphClient.Me.Settings.ItemInsights
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response. 
> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.userInsightsSettings",
  "name": "get_userInsightsSettings"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "isEnabled": true
}
```


