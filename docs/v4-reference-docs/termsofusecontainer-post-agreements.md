---
title: "Create agreement"
description: "Create a new agreement object."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "raprakasMSFT"
---

# Create agreement

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [agreement](../resources/agreement.md) object.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Agreement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

When calling on behalf of a user, the user needs to belong to one of the following directory roles. To learn more about directory roles, see [Azure AD built-in roles](/azure/active-directory/roles/permissions-reference):
+ Global Administrator
+ Conditional Access Administrator
+ Security Administrator

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /identityGovernance/termsOfUse/agreements
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply a JSON representation of [agreement](../resources/agreement.md) object.

The following table shows the properties that are required when you create a user.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|displayName|String|Display name of the agreement.|
|isViewingBeforeAcceptanceRequired|Boolean|Indicates whether the user has to expand and view the agreement before accepting.|
|files/fileName|String|Name of the agreement file (for example, TOU.pdf).|
|files/isDefault|Boolean|Indicates whether this is the default agreement file if none of the culture matches the client preference. If none of the file is marked as default, the first one will be treated as default.|
|files/language|String|Culture of the agreement file in the format languagecode2-country/regioncode2. languagecode2 is a lowercase two-letter code derived from ISO 639-1. country/regioncode2 is derived from ISO 3166 and usually consists of two uppercase letters, or a BCP-47 language tag (for example, en-US).|
|files/fileData/data|Binary|Data representing the terms of use the PDF document.|

## Response
If successful, this method returns a `201, Created` response code and [agreement](../resources/agreement.md) object in the response body.

## Example
##### Request
In the request body, supply a JSON representation of the [agreement](../resources/agreement.md) object.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_agreement_from_agreements"
}-->
```http
POST https://graph.microsoft.com/beta/identityGovernance/termsOfUse/agreements
Content-type: application/json

{
  "displayName": "Contoso ToU for guest users",
  "isViewingBeforeAcceptanceRequired": true,
  "files": [
    {
      "fileName": "TOU.pdf",
      "language": "en",
      "isDefault": true,
      "fileData": {
        "data": "SGVsbG8gd29ybGQ=//truncated-binary"
      }
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var agreement = new Agreement
{
	DisplayName = "Contoso ToU for guest users",
	IsViewingBeforeAcceptanceRequired = true,
	Files = new AgreementFilesCollectionPage()
	{
		new AgreementFileLocalization
		{
			FileName = "TOU.pdf",
			Language = "en",
			IsDefault = true,
			FileData = new AgreementFileData
			{
				Data = Convert.FromBase64String("SGVsbG8gd29ybGQ=//truncated-binary")
			}
		}
	}
};

await graphClient.IdentityGovernance.TermsOfUse.Agreements
	.Request()
	.AddAsync(agreement);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

