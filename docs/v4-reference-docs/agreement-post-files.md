---
title: "Create agreementFileLocalization"
description: "Create a new localized agreement file."
author: "raprakasMSFT"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Create agreementFileLocalization
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new localized agreement file.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | Agreement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            | Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /agreements/{agreementsId}/files
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [agreementFileLocalization](../resources/agreementfilelocalization.md) object.

You can specify the following properties when creating an **agreementFileLocalization**.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Localized display name of the policy file of an agreement. The localized display name is shown to end users who view the agreement.|
|fileData|[agreementFileData](../resources/agreementfiledata.md)|Data that represents the terms of use PDF document.|
|fileName|String|Name of the agreement file (for example, TOU.pdf). |
|isDefault|Boolean|If none of the languages matches the client preference, indicates whether this is the default agreement file . If none of the files are marked as default, the first one is treated as the default. Read-only.|
|isMajorVersion|Boolean|Indicates whether the agreement file is a major version update. Major version updates invalidate the agreement's acceptances on the corresponding language.|
|language|String|The language of the agreement file in the format "languagecode2-country/regioncode2". "languagecode2" is a lowercase two-letter code derived from ISO 639-1, while "country/regioncode2" is derived from ISO 3166 and usually consists of two uppercase letters, or a BCP-47 language tag. For example, U.S. English is `en-US`.|



## Response

If successful, this method returns a `200 OK` response code and an [agreementFileLocalization](../resources/agreementfilelocalization.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_agreementfilelocalization_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/termsOfUse/agreements/94410bbf-3d3e-4683-8149-f034e55c39dd/files
Content-Type: application/json

{
    "fileName": "Contoso ToU for guest users (French)",
    "language": "fr-FR",
    "isDefault": false,
    "isMajorVersion": false,
    "displayName": "Contoso ToU for guest users (French)",
    "fileData": {
        "data": "base64JVBERi0xLjUKJb/3ov4KNCAwIG9iago8PCAvTGluZWFyaX//truncated-binary-data"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var agreementFileLocalization = new AgreementFileLocalization
{
	FileName = "Contoso ToU for guest users (French)",
	Language = "fr-FR",
	IsDefault = false,
	IsMajorVersion = false,
	DisplayName = "Contoso ToU for guest users (French)",
	FileData = new AgreementFileData
	{
		Data = Convert.FromBase64String("base64JVBERi0xLjUKJb/3ov4KNCAwIG9iago8PCAvTGluZWFyaX//truncated-binary-data")
	}
};

await graphClient.IdentityGovernance.TermsOfUse.Agreements["{agreement-id}"].Files
	.Request()
	.AddAsync(agreementFileLocalization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.agreementFileLocalization"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identityGovernance/termsOfUse/agreements('94410bbf-3d3e-4683-8149-f034e55c39dd')/files/$entity",
    "id": "90d1723c-52c1-40e3-a51a-da99a82c0327",
    "fileName": "Contoso ToU for guest users (French)",
    "displayName": "Contoso ToU for guest users (French)",
    "language": "fr-FR",
    "isDefault": false,
    "isMajorVersion": false,
    "createdDateTime": "2022-03-04T14:38:22.8292386Z",
    "fileData": {
        "data": "base64JVBERi0xLjUKJb/"
    }
}
```

