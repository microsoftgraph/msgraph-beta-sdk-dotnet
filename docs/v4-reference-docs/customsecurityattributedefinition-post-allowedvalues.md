---
title: "Create allowedValue"
description: "Create a new allowedValue object."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Create allowedValue
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [allowedValue](../resources/allowedvalue.md) object.

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
POST /directory/customSecurityAttributeDefinitions/{customSecurityAttributeDefinitionId}/allowedValues
```


## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [allowedValue](../resources/allowedvalue.md) object.

The following table shows the properties that are required when you create the [allowedValue](../resources/allowedvalue.md).

|Property|Type|Description|
|:---|:---|:---|
|id|String|Identifier for the predefined value. Can be up to 64 characters long and include Unicode characters. Can include spaces, but some special characters are not allowed. Cannot be changed later. Case sensitive. Required.|
|isActive|Boolean|Indicates whether the predefined value is active or deactivated. If set to `false`, this predefined value cannot be assigned to any additional supported directory objects. Required.|



## Response

If successful, this method returns a `201 Created` response code and an [allowedValue](../resources/allowedvalue.md) object in the response body.

## Examples

### Example: Add a predefined value

The following example adds a predefined value to a custom security attribute definition.

+ Attribute set: `Engineering`
+ Attribute: `Project`
+ Predefined value: `Alpine`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_allowedvalue",
  "sampleKeys": ["Engineering_Project"]
}
-->
``` http
POST https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions/Engineering_Project/allowedValues
Content-Type: application/json

{
    "id":"Alpine",
    "isActive":"true"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var allowedValue = new AllowedValue
{
	Id = "Alpine",
	IsActive = true
};

await graphClient.Directory.CustomSecurityAttributeDefinitions["{customSecurityAttributeDefinition-id}"].AllowedValues
	.Request()
	.AddAsync(allowedValue);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.allowedValue"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/customSecurityAttributeDefinitions('Engineering_Project')/allowedValues/$entity",
    "id": "Alpine",
    "isActive": true
}
```
