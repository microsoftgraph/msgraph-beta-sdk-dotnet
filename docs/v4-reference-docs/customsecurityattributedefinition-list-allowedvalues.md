---
title: "List allowedValues"
description: "Get a list of the allowedValue objects and their properties."
author: "rolyon"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List allowedValues
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [allowedValue](../resources/allowedvalue.md) objects and their properties.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CustomSecAttributeDefinition.Read.All, CustomSecAttributeDefinition.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CustomSecAttributeDefinition.Read.All, CustomSecAttributeDefinition.ReadWrite.All|

The signed-in user must also be assigned one of the following [directory roles](/azure/active-directory/roles/permissions-reference):

+ Attribute Assignment Reader
+ Attribute Definition Reader
+ Attribute Assignment Administrator
+ Attribute Definition Administrator

By default, Global Administrator and other administrator roles do not have permissions to read, define, or assign custom security attributes.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /directory/customSecurityAttributeDefinitions/{customSecurityAttributeDefinitionId}/allowedValues
```


## Optional query parameters
This method supports the `$select` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [allowedValue](../resources/allowedvalue.md) objects in the response body.

## Examples

### Example: Get all predefined values

The following example gets all predefined values for a custom security attribute definition.

+ Attribute set: `Engineering`
+ Attribute: `Project`

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_allowedvalue",
  "sampleKeys": ["Engineering_Project"]
}
-->
``` http
GET https://graph.microsoft.com/beta/directory/customSecurityAttributeDefinitions/Engineering_Project/allowedValues
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var allowedValues = await graphClient.Directory.CustomSecurityAttributeDefinitions["{customSecurityAttributeDefinition-id}"].AllowedValues
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.allowedValue)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#directory/customSecurityAttributeDefinitions('Engineering_Project')/allowedValues",
    "value": [
        {
            "id": "Cascade",
            "isActive": true
        },
        {
            "id": "Baker",
            "isActive": true
        },
        {
            "id": "Alpine",
            "isActive": true
        }
    ]
}
```
