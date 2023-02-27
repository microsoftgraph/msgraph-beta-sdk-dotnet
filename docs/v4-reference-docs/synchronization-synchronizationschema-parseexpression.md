---
title: "synchronizationSchema: parseExpression"
description: "(../resources/synchronization_attributemappingsource.md) object. "
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# synchronizationSchema: parseExpression

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Parse a given string expression into an [attributeMappingSource](../resources/synchronization-attributemappingsource.md) object.

For more information about expressions, see [Writing Expressions for Attribute Mappings in Azure Active Directory](/azure/active-directory/active-directory-saas-writing-expressions-for-attribute-mappings).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     |Directory.ReadWrite.All  |
|Delegated (personal Microsoft account) |Not supported.|
|Application                            |Application.ReadWrite.OwnedBy, Directory.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/synchronization/jobs/{id}/schema/parseExpression
POST /servicePrincipals/{id}/synchronization/templates/{id}/schema/parseExpression

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|expression               |String               |Expression to parse.|
|testInputObject          |[expressionInputObject](../resources/synchronization-expressioninputobject.md)|Test data object to evaluate expression against. Optional.|
|targetAttributeDefinition|[attributeDefinition](../resources/synchronization-attributedefinition.md) |Definition of the attribute that will be mapped to this expression. Optional.|

## Response
If successful, this method returns a `200 OK` response code and a [parseExpressionResponse](../resources/synchronization-parseexpressionresponse.md) object in the response body.

## Example

##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "synchronizationschema_parseexpression"
}-->
```http
POST https://graph.microsoft.com/beta/servicePrincipals/{id}/synchronization/jobs/{id}/schema/parseExpression
Content-type: application/json

{
    "expression":"Replace([preferredLanguage], \"-\", , , \"_\", ,  )",
    "targetAttributeDefinition":null,
    "testInputObject": {
        definition: null,
        properties:[
            { key: "objectId", value : "66E4A8CC-1B7B-435E-95F8-F06CEA133828" },
            { key: "IsSoftDeleted", value: "false"},
            { key: "accountEnabled", value: "true"},
            { key: "streetAddress", value: "1 Redmond Way"},
            { key: "city", value: "Redmond"},
            { key: "state", value: "WA"},
            { key: "postalCode", value: "98052"},
            { key: "country", value: "USA"},
            { key: "department", value: "Sales"},
            { key: "displayName", value: "John Smith"},
            { key: "extensionAttribute1", value: "Sample 1"},
            { key: "extensionAttribute2", value: "Sample 2"},
            { key: "extensionAttribute3", value: "Sample 3"},
            { key: "extensionAttribute4", value: "Sample 4"},
            { key: "extensionAttribute5", value: "Sample 5"},
            { key: "extensionAttribute6", value: "Sample 6"},
            { key: "extensionAttribute7", value: "Sample 1"},
            { key: "extensionAttribute8", value: "Sample 1"},
            { key: "extensionAttribute9", value: "Sample 1"},
            { key: "extensionAttribute10", value: "Sample 1"},
            { key: "extensionAttribute11", value: "Sample 1"},
            { key: "extensionAttribute12", value: "Sample 1"},
            { key: "extensionAttribute13", value: "Sample 1"},
            { key: "extensionAttribute14", value: "Sample 1"},
            { key: "extensionAttribute15", value: "Sample 1"},
            { key: "givenName", value: "John"},
            { key: "jobTitle", value: "Finance manager"},
            { key: "mail", value: "johns@contoso.com"},
            { key: "mailNickname", value: "johns"},
            { key: "manager", value: "maxs@contoso.com"},
            { key: "mobile", value: "425-555-0010"},
            { key: "onPremisesSecurityIdentifier", value: "66E4A8CC-1B7B-435E-95F8-F06CEA133828"},
            { key: "passwordProfile.password", value: ""},
            { key: "physicalDeliveryOfficeName", value: "Main Office"},
            { key: "preferredLanguage", value: "EN-US"},
            { key: "proxyAddresses", value: ""},
            { key: "surname", value: "Smith"},
            { key: "telephoneNumber", value: "425-555-0011"},
            { key: "userPrincipalName", value: "johns@contoso.com"},
            { key: "appRoleAssignments", "value@odata.type":"#Collection(String)", value: ["Default Assignment"] }
        ]
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var expression = "Replace([preferredLanguage], \"-\", , , \"_\", ,  )";

AttributeDefinition targetAttributeDefinition = null;

var testInputObject = new ExpressionInputObject
{
	Definition = null,
	Properties = new List<StringKeyObjectValuePair>()
	{
		new StringKeyObjectValuePair
		{
			Key = "objectId",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "66E4A8CC-1B7B-435E-95F8-F06CEA133828"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "IsSoftDeleted",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "false"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "accountEnabled",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "true"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "streetAddress",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "1 Redmond Way"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "city",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Redmond"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "state",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "WA"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "postalCode",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "98052"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "country",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "USA"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "department",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sales"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "displayName",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "John Smith"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute1",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute2",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 2"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute3",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 3"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute4",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 4"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute5",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 5"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute6",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 6"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute7",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute8",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute9",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute10",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute11",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute12",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute13",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute14",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "extensionAttribute15",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Sample 1"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "givenName",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "John"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "jobTitle",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Finance manager"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "mail",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "johns@contoso.com"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "mailNickname",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "johns"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "manager",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "maxs@contoso.com"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "mobile",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "425-555-0010"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "onPremisesSecurityIdentifier",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "66E4A8CC-1B7B-435E-95F8-F06CEA133828"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "passwordProfile.password",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", ""}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "physicalDeliveryOfficeName",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Main Office"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "preferredLanguage",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "EN-US"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "proxyAddresses",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", ""}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "surname",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "Smith"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "telephoneNumber",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "425-555-0011"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "userPrincipalName",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value", "johns@contoso.com"}
			}
		},
		new StringKeyObjectValuePair
		{
			Key = "appRoleAssignments",
			AdditionalData = new Dictionary<string, object>()
			{
				{"value@odata.type", "#Collection(String)"},
				{"value", "[\"Default Assignment\"]"}
			}
		}
	}
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].Synchronization.Jobs["{synchronizationJob-id}"].Schema
	.ParseExpression(expression,testInputObject,targetAttributeDefinition)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

