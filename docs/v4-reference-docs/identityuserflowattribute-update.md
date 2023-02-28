---
title: "Update identityUserFlowAttribute"
description: "Update properties of an identityUserFlowAttribute."
ms.localizationpriority: medium
doc_type: apiPageType
author: "jkdouglas"
ms.prod: "identity-and-sign-in"
---

# Update identityUserFlowAttribute

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [identityUserFlowAttribute](../resources/identityuserflowattribute.md) object. Only custom user flow attributes can be updated.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application| IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External Identity User Flow Attributes administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /identity/userFlowAttributes/{id}
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON object with one or more properties that need to be updated for an [identityUserFlowAttribute](../resources/identityuserflowattribute.md) object.

>**Note:** Only the **description** property can be updated.

|Property|Type|Description|
|:---------------|:--------|:----------|
|description|String|The description of the user flow attribute. It is shown to the user at the time of sign up.|

## Response

If successful, this method returns a `204 No Content` response code. If unsuccessful, a `4xx` error will be returned with specific details.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_userFlowAttributes",
  "sampleKeys": ["extension_d09380e2b4c642b9a203fb816a04a7ad_Hobby"]
}
-->

``` http
PATCH https://graph.microsoft.com/beta/identity/userFlowAttributes/extension_d09380e2b4c642b9a203fb816a04a7ad_Hobby
Content-type: application/json

{
  "description": "Your new hobby"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityUserFlowAttribute = new IdentityUserFlowAttribute
{
	Description = "Your new hobby"
};

await graphClient.Identity.UserFlowAttributes["{identityUserFlowAttribute-id}"]
	.Request()
	.UpdateAsync(identityUserFlowAttribute);

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
