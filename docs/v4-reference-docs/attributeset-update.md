---
title: "Update attributeSet"
description: "Update the properties of an attributeSet object."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Update attributeSet
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [attributeSet](../resources/attributeset.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CustomSecAttributeDefinition.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CustomSecAttributeDefinition.ReadWrite.All|

The signed-in user must also be assigned the Attribute Definition Administrator [directory role](/azure/active-directory/roles/permissions-reference). By default, Global Administrator and other administrator roles do not have permissions to read, define, or assign custom security attributes.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /directory/attributeSets/{attributeSetId}
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
|description|String|Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Optional.|
|maxAttributesPerSet|Int32|Maximum number of custom security attributes that can be defined in this attribute set. Default value is `null`. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Optional.|



## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example: Update an attribute set

The following example updates the description and the maximum number of attributes for an attribute set named `Engineering`.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_attributeset"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/directory/attributeSets/Engineering
Content-Type: application/json
Content-length: 119

{
    "description":"Attributes for engineering team",
    "maxAttributesPerSet":20
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attributeSet = new AttributeSet
{
	Description = "Attributes for engineering team",
	MaxAttributesPerSet = 20
};

await graphClient.Directory.AttributeSets["{attributeSet-id}"]
	.Request()
	.UpdateAsync(attributeSet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```
