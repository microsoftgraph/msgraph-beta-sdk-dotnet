---
title: "Create customSecurityAttributeDefinition"
description: "Create a new customSecurityAttributeDefinition object."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Create customSecurityAttributeDefinition
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [customSecurityAttributeDefinition](../resources/customsecurityattributedefinition.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CustomSecAttributeDefinition.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CustomSecAttributeDefinition.ReadWrite.All|

The signed-in user must also be assigned the Attribute Definition Administrator [directory role](/azure/active-directory/roles/permissions-reference. By default, Global Administrator and other administrator roles do not have permissions to read, define, or assign custom security attributes.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /directory/customSecurityAttributeDefinitions
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [customSecurityAttributeDefinition](../resources/customsecurityattributedefinition.md) object.

The following table shows the properties that you can configure when you create the [customSecurityAttributeDefinition](../resources/customsecurityattributedefinition.md).

|Property|Type|Description|
|:---|:---|:---|
|attributeSet|String|Name of the attribute set. Case insensitive. Required.|
|description|String|Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Cannot contain spaces or special characters. Can be changed later. Optional.|
|isCollection|Boolean|Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If `type` is set to Boolean, `isCollection` cannot be set to true. Required.|
|isSearchable|Boolean|Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values. Cannot be changed later. Required.|
|name|String|Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive. Required.|
|status|String|Specifies whether the custom security attribute is active or deactivated. Acceptable values are `Available` and `Deprecated`. Can be changed later. Required.|
|type|String|Data type for the custom security attribute values. Supported types are `Boolean`, `Integer`, and `String`. Cannot be changed later. Required.|
|usePreDefinedValuesOnly|Boolean|Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If `type` is set to Boolean, `usePreDefinedValuesOnly` cannot be set to true. Required.|

The `id` property is auto generated and cannot be set.

## Response

If successful, this method returns a `201 Created` response code and a [customSecurityAttributeDefinition](../resources/customsecurityattributedefinition.md) object in the response body.

## Examples

### Example 1: Add a custom security attribute

The following example adds a new custom security attribute definition that is a single free-form value of type String.

+ Attribute set: `Engineering`
+ Attribute: `ProjectDate`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_customsecurityattributedefinition"
}
-->
``` http
POST https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions
Content-Type: application/json

{
    "attributeSet":"Engineering",
    "description":"Target completion date",
    "isCollection":false,
    "isSearchable":true,
    "name":"ProjectDate",
    "status":"Available",
    "type":"String",
    "usePreDefinedValuesOnly": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customSecurityAttributeDefinition = new CustomSecurityAttributeDefinition
{
	AttributeSet = "Engineering",
	Description = "Target completion date",
	IsCollection = false,
	IsSearchable = true,
	Name = "ProjectDate",
	Status = "Available",
	Type = "String",
	UsePreDefinedValuesOnly = false
};

await graphClient.Directory.CustomSecurityAttributeDefinitions
	.Request()
	.AddAsync(customSecurityAttributeDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.customSecurityAttributeDefinition"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/customSecurityAttributeDefinitions/$entity",
    "attributeSet": "Engineering",
    "description": "Target completion date",
    "id": "Engineering_ProjectDate",
    "isCollection": false,
    "isSearchable": true,
    "name": "ProjectDate",
    "status": "Available",
    "type": "String",
    "usePreDefinedValuesOnly": false
}
```

### Example 2: Add a custom security attribute that supports multiple predefined values

The following example adds a new custom security attribute definition that supports multiple values of type String that are predefined.

+ Attribute set: `Engineering`
+ Attribute: `Project`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_customsecurityattributedefinition_v2"
}
-->
``` http
POST https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions
Content-Type: application/json
Content-length: 310

{
    "attributeSet":"Engineering",
    "description":"Active projects for user",
    "isCollection":true,
    "isSearchable":true,
    "name":"Project",
    "status":"Available",
    "type":"String",
    "usePreDefinedValuesOnly": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customSecurityAttributeDefinition = new CustomSecurityAttributeDefinition
{
	AttributeSet = "Engineering",
	Description = "Active projects for user",
	IsCollection = true,
	IsSearchable = true,
	Name = "Project",
	Status = "Available",
	Type = "String",
	UsePreDefinedValuesOnly = true
};

await graphClient.Directory.CustomSecurityAttributeDefinitions
	.Request()
	.AddAsync(customSecurityAttributeDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.customSecurityAttributeDefinition"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/customSecurityAttributeDefinitions/$entity",
    "attributeSet": "Engineering",
    "description": "Active projects for user",
    "id": "Engineering_Project",
    "isCollection": true,
    "isSearchable": true,
    "name": "Project",
    "status": "Available",
    "type": "String",
    "usePreDefinedValuesOnly": true
}
```

### Example 3: Add a custom security attribute with a list of predefined values

The following example adds a new custom security attribute definition with a list of predefined values as a collection of strings.

+ Attribute set: `Engineering`
+ Attribute: `Project`
+ Attribute data type: Collection of Strings
+ Predefined values: `Alpine`, `Baker`, `Cascade`

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_customsecurityattributedefinition_allowedvalues"
}
-->
``` http
POST https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions
Content-Type: application/json

{
    "attributeSet": "Engineering",
    "description": "Active projects for user",
    "isCollection": true,
    "isSearchable": true,
    "name": "Project",
    "status": "Available",
    "type": "String",
    "usePreDefinedValuesOnly": true,
    "allowedValues": [
        {
            "id": "Alpine",
            "isActive": true
        },
        {
            "id": "Baker",
            "isActive": true
        },
        {
            "id": "Cascade",
            "isActive": true
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customSecurityAttributeDefinition = new CustomSecurityAttributeDefinition
{
	AttributeSet = "Engineering",
	Description = "Active projects for user",
	IsCollection = true,
	IsSearchable = true,
	Name = "Project",
	Status = "Available",
	Type = "String",
	UsePreDefinedValuesOnly = true,
	AllowedValues = new CustomSecurityAttributeDefinitionAllowedValuesCollectionPage()
	{
		new AllowedValue
		{
			Id = "Alpine",
			IsActive = true
		},
		new AllowedValue
		{
			Id = "Baker",
			IsActive = true
		},
		new AllowedValue
		{
			Id = "Cascade",
			IsActive = true
		}
	}
};

await graphClient.Directory.CustomSecurityAttributeDefinitions
	.Request()
	.AddAsync(customSecurityAttributeDefinition);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.customSecurityAttributeDefinition"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/customSecurityAttributeDefinitions/$entity",
    "attributeSet": "Engineering",
    "description": "Active projects for user",
    "id": "Engineering_Project",
    "isCollection": true,
    "isSearchable": true,
    "name": "Project",
    "status": "Available",
    "type": "String",
    "usePreDefinedValuesOnly": true
}
```
