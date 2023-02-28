---
title: "List userAttributeAssignments"
description: "Get the identityUserFlowAttributeAssignment resources from the userAttributeAssignments navigation property in a b2cIdentityUserFlow."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List userAttributeAssignments

Namespace: microsoft.graph

Get the identityUserFlowAttributeAssignment resources from the userAttributeAssignments navigation property in a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|IdentityUserFlow.Read.All, IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|IdentityUserFlow.Read.All, IdentityUserFlow.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /identity/b2cUserFlows/{id}/userAttributeAssignments
```

## Optional query parameters

This method supports the `$select` and `$expand` parameters to get the details of the user flow attribute. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [identityUserFlowAttributeAssignment](../resources/identityuserflowattributeassignment.md) objects in the response body.

## Examples

### Example 1: List userAttributeAssignments in a b2cIdentityUserFlow

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_identityuserflowattributeassignment_1"
}
-->

``` http
GET https://graph.microsoft.com/beta/identity/b2cUserFlows/{id}/userAttributeAssignments?
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userAttributeAssignments = await graphClient.Identity.B2cUserFlows["{b2cIdentityUserFlow-id}"].UserAttributeAssignments
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.identityUserFlowAttributeAssignment)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.identityUserFlowAttributeAssignment",
    "value": [
        {
            "id": "City",
            "isOptional": false,
            "requiresVerification": false,
            "userInputType": "RadioSingleSelect",
            "displayName": "City",
            "userAttributeValues": [
                {
                    "name": "S",
                    "value": "1",
                    "isDefault": true
                }
            ]
        },
        {
            "id": "extension_guid_shoeSize",
            "isOptional": false,
            "requiresVerification": false,
            "userInputType": "TextBox",
            "displayName": "Shoe size",
            "userFlowId": "B2C_1_Consumer",
            "userAttributeValues": []
        }
    ]
}
```

### Example 2: List userAttributeAssignments in a b2cIdentityUserFlow and expand userAttribute

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_identityuserflowattributeassignment_expand_1"
}
-->

``` http
GET https://graph.microsoft.com/beta/identity/b2cUserFlows/{id}/userAttributeAssignments?$expand=userAttribute
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userAttributeAssignments = await graphClient.Identity.B2cUserFlows["{b2cIdentityUserFlow-id}"].UserAttributeAssignments
	.Request()
	.Expand("userAttribute")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.identityUserFlowAttributeAssignment)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.identityUserFlowAttributeAssignment",
    "value": [
        {
            "id": "City",
            "isOptional": false,
            "requiresVerification": false,
            "userInputType": "RadioSingleSelect",
            "displayName": "City",
            "userAttributeValues": [
                {
                    "name": "S",
                    "value": "1",
                    "isDefault": true
                }
            ],
            "userAttribute": {
                "@odata.type": "#Microsoft.Graph.BuiltInUserFlowAttribute",
                "id": "City",
                "displayName": "City",
                "description": "your city",
                "userFlowAttributeType": "builtIn",
                "dataType": "string"
            }
        },
        {
            "id": "extension_guid_shoeSize",
            "isOptional": false,
            "requiresVerification": false,
            "userInputType": "TextBox",
            "displayName": "Shoe size",
            "userFlowId": "B2C_1_Consumer",
            "userAttributeValues": [],
            "userAttribute": {
                "@odata.type": "#Microsoft.Graph.CustomUserFlowAttribute",
                "id": "extension_guid_shoeSize",
                "displayName": "Shoe size",
                "description": "Your shoe size",
                "userFlowAttributeType": "custom",
                "dataType": "string"
            }
        }
    ]
}
```
