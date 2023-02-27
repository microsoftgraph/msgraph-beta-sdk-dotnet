---
title: "Create userAttributeAssignments"
description: "Create a new identityUserFlowAttributeAssignment object."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Create userAttributeAssignments

Namespace: microsoft.graph

Create a new identityUserFlowAttributeAssignment object in a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported|
|Application|IdentityUserFlow.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /identity/b2cUserFlows/{id}/userAttributeAssignments
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [identityUserFlowAttributeAssignment](../resources/identityuserflowattributeassignment.md) object.

The following table shows the properties that are required when you create the [identityUserFlowAttributeAssignment](../resources/identityuserflowattributeassignment.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The display name of the identityUserFlowAttribute within a user flow.|
|isOptional|Boolean|Determines whether the identityUserFlowAttribute is optional. `true` means the user doesn't have to provide a value. `false` means the user cannot complete sign-up without providing a value.|
|requiresVerification|Boolean|Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user's phone number or email address.|
|userAttributeValues|[userAttributeValuesItem](../resources/userattributevaluesitem.md) collection|The input options for the user flow attribute. Only applicable when the userInputType is `radioSingleSelect`, `dropdownSingleSelect`, or `checkboxMultiSelect`.|
|userInputType|identityUserFlowAttributeInputType|The input type of the user flow attribute. Possible values are: `textBox`, `dateTimeDropdown`, `radioSingleSelect`, `dropdownSingleSelect`, `emailBox`, `checkboxMultiSelect`.|
|userAttribute|[identityUserFlowAttribute](../resources/identityuserflowattribute.md)|The identifier for the user flow attribute to include in the user flow assignment.

## Response

If successful, this method returns a `201 Created` response code and an [identityUserFlowAttributeAssignment](../resources/identityuserflowattributeassignment.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_identityuserflowattributeassignment_from__1",
  "sampleKeys": ["B2C_1_Consumer"]
}
-->

``` http
POST https://graph.microsoft.com/beta/identity/b2cUserFlows/B2C_1_Consumer/userAttributeAssignments
Content-Type: application/json

{
    "isOptional": false,
    "requiresVerification": false,
    "userInputType": "TextBox",
    "displayName": "Shoe size",
    "userAttributeValues": [],
    "userAttribute": {
        "id": "extension_guid_shoeSize"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identityUserFlowAttributeAssignment = new IdentityUserFlowAttributeAssignment
{
	IsOptional = false,
	RequiresVerification = false,
	UserInputType = IdentityUserFlowAttributeInputType.TextBox,
	DisplayName = "Shoe size",
	UserAttributeValues = new List<UserAttributeValuesItem>()
	{
	},
	UserAttribute = new IdentityUserFlowAttribute
	{
		Id = "extension_guid_shoeSize"
	}
};

await graphClient.Identity.B2cUserFlows["{b2cIdentityUserFlow-id}"].UserAttributeAssignments
	.Request()
	.AddAsync(identityUserFlowAttributeAssignment);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.identityUserFlowAttributeAssignment"
}
-->

``` http
HTTP/1.1 201 Created
Location: https://graph.microsoft.com/beta/identity/b2xUserFlows/B2C_1_Consumer/userAttributeAssignments/extension_guid_shoeSize
Content-Type: application/json

{
    "id": "extension_guid_shoeSize",
    "isOptional": false,
    "requiresVerification": false,
    "userInputType": "TextBox",
    "displayName": "Shoe size",
    "userAttributeValues": []
}
```
