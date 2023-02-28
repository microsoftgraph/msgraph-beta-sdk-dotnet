---
title: "Create identityUserFlowAttribute"
description: "Create a new identityUserFlowAttribute object."
ms.localizationpriority: medium
doc_type: apiPageType
author: "jkdouglas"
ms.prod: "identity-and-sign-in"
---

# Create identityUserFlowAttribute

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [identityUserFlowAttribute](../resources/identityuserflowattribute.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application|IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External Identity User Flow Attribute administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identity/userFlowAttributes
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON representation of [identityUserFlowAttribute](../resources/identityuserflowattribute.md).

|Property|Type|Description|
|:---------------|:--------|:----------|
|id|String|The identifier of the user flow attribute. This is a read-only attribute that is automatically created.|
|displayName|String|The display name of the user flow attribute.|
|description|String|The description of the user flow attribute. It's shown to the user at the time of sign-up.|
|userFlowAttributeType|String|The type of the user flow attribute. This is a read-only attribute that is automatically set. Depending on the type of attribute, the values for this property will be `builtIn` or `custom`.|
|dataType|String|The data type of the user flow attribute. This cannot be modified once the custom user flow attribute is created. The supported values for **dataType** are:<br/><ul><li>`string` : denotes that the dataType for the identityUserFlowAttribute is a string. </li><li>`boolean` : denotes that the dataType for the identityUserFlowAttribute is a boolean.</li><li>`int64` : denotes that the dataType for the identityUserFlowAttribute is an integer.</li></ul>|

## Response

If successful, this method returns a `201 Created` response code and [identityUserFlowAttribute](../resources/identityuserflowattribute.md) object in the response body. If unsuccessful, a `4xx` error will be returned with specific details.

## Examples

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_userFlowAttribute_from_userFlowAttributes"
}
-->

``` http
POST https://graph.microsoft.com/beta/identity/userFlowAttributes
Content-type: application/json

{
  "displayName": "Hobby",
  "description": "Your hobby",
  "dataType": "string",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityUserFlowAttribute = new IdentityUserFlowAttribute
{
	DisplayName = "Hobby",
	Description = "Your hobby",
	DataType = IdentityUserFlowAttributeDataType.String
};

await graphClient.Identity.UserFlowAttributes
	.Request()
	.AddAsync(identityUserFlowAttribute);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityUserFlowAttribute"
} -->

```http
HTTP/1.1 201 Created
Location: https://graph.microsoft.com/beta/identity/userFlowAttributes/extension_7a95ecd9489b4fb9a45722b913c4703b_Hobby
Content-type: application/json

{
    "id": "extension_d09380e2b4c642b9a203fb816a04a7ad_Hobby",
    "displayName": "Hobby",
    "description": "Your hobby",
    "userFlowAttributeType": "custom",
    "dataType": "string"
}
```
