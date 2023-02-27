---
title: "Update Outlook category"
description: "Update the writable property, **color**, of the specified outlookCategory object. You cannot modify the **displayName** property "
ms.localizationpriority: medium
author: "abheek-das"
ms.prod: "outlook"
doc_type: apiPageType
---

# Update Outlook category

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the writable property, **color**, of the specified [outlookCategory](../resources/outlookcategory.md) object. You cannot modify the **displayName** property
once you have created the category.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | MailboxSettings.ReadWrite    |
|Delegated (personal Microsoft account) | MailboxSettings.ReadWrite    |
|Application | MailboxSettings.ReadWrite |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /me/outlook/masterCategories/{id}
PATCH /users/{id|userPrincipalName}/outlook/masterCategories/{id}
```

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body
will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|color|String|A pre-set color constant that characterizes a category, and that is mapped to one of 25 predefined colors. |

## Response

If successful, this method returns a `200 OK` response code and updated [outlookCategory](../resources/outlookcategory.md) object in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_outlookcategory"
}-->
```http
PATCH https://graph.microsoft.com/beta/me/outlook/masterCategories/bac262b7-485d-4739-b436-e31467d64fac
Content-type: application/json

{
  "color":"preset15"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var outlookCategory = new OutlookCategory
{
	Color = CategoryColor.Preset15
};

await graphClient.Me.Outlook.MasterCategories["{outlookCategory-id}"]
	.Request()
	.UpdateAsync(outlookCategory);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

