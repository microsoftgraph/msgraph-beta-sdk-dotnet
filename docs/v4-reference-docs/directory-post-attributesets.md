---
title: "Create attributeSet"
description: "Create a new attributeSet object."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Create attributeSet
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [attributeSet](../resources/attributeset.md) object.

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
POST /directory/attributeSets
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [attributeSet](../resources/attributeset.md) object.

The following table shows the properties that you can configure when you create the [attributeSet](../resources/attributeset.md).

|Property|Type|Description|
|:---|:---|:---|
|description|String|Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later. Optional.|
|id|String|Identifier for the attribute set that is unique within a tenant. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive. Required.|
|maxAttributesPerSet|Int32|Maximum number of custom security attributes that can be defined in this attribute set. Default value is `null`. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later. Optional.|


## Response

If successful, this method returns a `201 Created` response code and an [attributeSet](../resources/attributeset.md) object in the response body.

## Examples

### Example: Add an attribute set

The following example adds a new attribute set named `Engineering`.

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_attributeset"
}
-->
``` http
POST https://graph.microsoft.com/beta/directory/attributeSets
Content-Type: application/json

{
    "id":"Engineering",
    "description":"Attributes for engineering team",
    "maxAttributesPerSet":25
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var attributeSet = new AttributeSet
{
	Id = "Engineering",
	Description = "Attributes for engineering team",
	MaxAttributesPerSet = 25
};

await graphClient.Directory.AttributeSets
	.Request()
	.AddAsync(attributeSet);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.attributeSet"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/attributeSets/$entity",
    "description": "Attributes for engineering team",
    "id": "Engineering",
    "maxAttributesPerSet": 25
}
```
