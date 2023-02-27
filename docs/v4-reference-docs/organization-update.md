---
title: "Update organization"
description: "Update the properties of the currently authenticated organization."
ms.localizationpriority: medium
author: "adimitui"
ms.prod: "directory-management"
doc_type: apiPageType
---

# Update organization

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of the currently authenticated organization. In this case, `organization` is defined as a collection of exactly one record, and so its **ID** must be specified in the request.  The **ID** is also known as the **tenantId** of the organization.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type | Permissions (from least to most privileged) |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Organization.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Organization.ReadWrite.All |

The calling user must also be in one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference):

* Global Administrator
* Partner Tier2 Support
* Billing Administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /organization/{id}
```

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization  | Bearer {token}. Required. |
| Content-Type   | application/json |


## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property  | Type |Description|
|:---------------|:--------|:----------|
|marketingNotificationEmails|String collection|                                        **Notes**: not nullable.            |
|privacyProfile|[privacyProfile](../resources/privacyprofile.md)|The privacy profile of an organization (set statementUrl and contactEmail).            |
|securityComplianceNotificationMails|String collection||
|securityComplianceNotificationPhones|String collection||
|technicalNotificationMails|String collection|                                        **Notes**: not nullable.            |

Since the **organization** resource supports [extensions](/graph/extensibility-overview), you can use the `PATCH` operation to 
add, update, or delete your own app-specific data in custom properties of an extension in an existing **organization** instance.

## Response

If successful, this method returns `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_organization"
}-->

```http
PATCH https://graph.microsoft.com/beta/organization/84841066-274d-4ec0-a5c1-276be684bdd3
Content-type: application/json

{
  "marketingNotificationEmails" : ["marketing@contoso.com"],
  "privacyProfile" :
    {
      "contactEmail":"alice@contoso.com",
      "statementUrl":"https://contoso.com/privacyStatement"
    },
  "securityComplianceNotificationMails" : ["security@contoso.com"],
  "securityComplianceNotificationPhones" : ["(123) 456-7890"],
  "technicalNotificationMails" : ["tech@contoso.com"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var organization = new Organization
{
	MarketingNotificationEmails = new List<String>()
	{
		"marketing@contoso.com"
	},
	PrivacyProfile = new PrivacyProfile
	{
		ContactEmail = "alice@contoso.com",
		StatementUrl = "https://contoso.com/privacyStatement"
	},
	SecurityComplianceNotificationMails = new List<String>()
	{
		"security@contoso.com"
	},
	SecurityComplianceNotificationPhones = new List<String>()
	{
		"(123) 456-7890"
	},
	TechnicalNotificationMails = new List<String>()
	{
		"tech@contoso.com"
	}
};

await graphClient.Organization["{organization-id}"]
	.Request()
	.UpdateAsync(organization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

