---
title: "Update customSecurityAttributeDefinition"
description: "Update the properties of a customSecurityAttributeDefinition object."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Update customSecurityAttributeDefinition
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [customSecurityAttributeDefinition](../resources/customsecurityattributedefinition.md) object.

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
PATCH /directory/customSecurityAttributeDefinitions/{customSecurityAttributeDefinitionId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|
|OData-Version|4.01. Optional.|

> [!NOTE]
> To update the predefined values for a custom security attribute, you must add the **OData-Version** header and assign it the value `4.01`.

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated. 

|Property|Type|Description|
|:---|:---|:---|
|description|String|Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Optional.|
|status|String|Specifies whether the custom security attribute is active or deactivated. Acceptable values are `Available` and `Deprecated`. Optional.|
|usePreDefinedValuesOnly|Boolean|Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can be changed from true to false, but cannot be changed from false to true. If `type` is set to Boolean, `usePreDefinedValuesOnly` cannot be set to true. Optional.|



## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Update a custom security attribute

The following example updates the description for a custom security attribute definition.

+ Attribute set: `Engineering`
+ Attribute: `ProjectDate`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_customsecurityattributedefinition",
  "sampleKeys": ["Engineering_ProjectDate"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions/Engineering_ProjectDate
Content-Type: application/json

{
  "description": "Target completion date (YYYY/MM/DD)",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customSecurityAttributeDefinition = new CustomSecurityAttributeDefinition
{
	Description = "Target completion date (YYYY/MM/DD)"
};

await graphClient.Directory.CustomSecurityAttributeDefinitions["{customSecurityAttributeDefinition-id}"]
	.Request()
	.UpdateAsync(customSecurityAttributeDefinition);

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

### Example 2: Update the predefined values for a custom security attribute

The following example updates the status of an existing predefined value and adds a new predefined value for a custom security attribute definition.

+ Attribute set: `Engineering`
+ Attribute: `Project`
+ Attribute data type: Collection of Strings
+ Update predefined value: `Baker`
+ New predefined value: `Skagit`

> [!NOTE]
> For this request, you must add the **OData-Version** header and assign it the value `4.01`.

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_customsecurityattributedefinition_allowedvalues",
  "sampleKeys": ["Engineering_Project"]
}
-->
``` msgraph-interactive
PATCH https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions/Engineering_Project
Content-Type: application/json
OData-Version: 4.01

{
    "allowedValues@delta": [
        {
            "id": "Baker",
            "isActive": false
        },
        {
            "id": "Skagit",
            "isActive": true
        }
    ]
}
```

# [C#](#tab/csharp)
```
Snippet not available
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

### Example 3: Deactivate a custom security attribute

The following example deactivates a custom security attribute definition.

+ Attribute set: `Engineering`
+ Attribute: `Project`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_customsecurityattributedefinition_deactivate",
  "sampleKeys": ["Engineering_Project"]
}
-->
``` http
PATCH https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions/Engineering_Project
Content-Type: application/json

{
  "status": "Deprecated"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var customSecurityAttributeDefinition = new CustomSecurityAttributeDefinition
{
	Status = "Deprecated"
};

await graphClient.Directory.CustomSecurityAttributeDefinitions["{customSecurityAttributeDefinition-id}"]
	.Request()
	.UpdateAsync(customSecurityAttributeDefinition);

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
