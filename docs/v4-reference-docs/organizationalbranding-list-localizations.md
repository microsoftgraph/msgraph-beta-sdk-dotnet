---
title: "List localizations"
description: "Get the organizationalBrandingLocalization resources from the localizations navigation property."
author: "AlexanderMars"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List localizations
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve all localization branding objects, including the default branding.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | User.Read, Organization.Read.All, User.ReadBasic.All, User.Read.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Organization.Read.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /organization/{organizationId}/branding/localizations
```

## Optional query parameters
This method supports only the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [organizationalBrandingLocalization](../resources/organizationalbrandinglocalization.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_organizationalbrandinglocalization"
}
-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/84841066-274d-4ec0-a5c1-276be684bdd3/branding/localizations/
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var localizations = await graphClient.Organization["{organization-id}"].Branding.Localizations
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.organizationalBrandingLocalization)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#organization('84841066-274d-4ec0-a5c1-276be684bdd3')/branding/localizations",
    "value": [
        {
            "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/directoryObjects/$/Microsoft.DirectoryServices.Organization('84841066-274d-4ec0-a5c1-276be684bdd3')//localizations/0",
            "id": "0",
            "backgroundColor": " ",
            "backgroundImageRelativeUrl": "c1c6b6c8-ctwpxrbizfcsectmtir3yvna3hrhaib9j7ueqv0ldne/logintenantbranding/0/illustration?ts=637635061764954395",
            "bannerLogoRelativeUrl": "c1c6b6c8-ctwpxrbizfcsectmtir3yvna3hrhaib9j7ueqv0ldne/logintenantbranding/0/bannerlogo?ts=637635061773126717",
            "cdnList": [
                "secure.aadcdn.microsoftonline-p.com",
                "aadcdn.msftauthimages.net",
                "aadcdn.msauthimages.net"
            ],
            "customAccountResetCredentialsUrl": null,
            "customCannotAccessYourAccountText": null,
            "customCannotAccessYourAccountUrl": null,
            "customCSS": null,
            "customCSSRelativetUrl": null,
            "customForgotMyPasswordText": null,
            "customPrivacyAndCookiesText": null,
            "customPrivacyAndCookiesUrl": null,
            "customTermsOfUseText": null,
            "customTermsOfUseUrl": null,
            "customResetItNowText": null,
            "faviconRelativeUrl": null,
            "headerBackgroundColor": null,
            "headerLogoRelativeUrl": null,
            "signInPageText": "Contoso",
            "squareLogoRelativeUrl": "c1c6b6c8-urr-dzbkz44n5kuo9kzl1kziuujjcdqonoe2owyacso/logintenantbranding/0/tilelogo?ts=637535563832888580",
            "squareLogoDarkRelativeUrl": null,
            "usernameHintText": " ",
            "loginPageLayoutConfiguration": {
              "layoutTemplateType": "default",
              "isHeaderShown": false,
              "isFooterShown": true
             },
            "loginPageTextVisibilitySettings": {
              "hideCannotAccessYourAccount": false,
              "hideForgotMyPassword": false,
              "hideResetItNow": false,
              "hideTermsOfUse": true,
              "hidePrivacyAndCookies": true
            }
        },
        {
            "@odata.id": "https://graph.microsoft.com/v2/84841066-274d-4ec0-a5c1-276be684bdd3/directoryObjects/$/Microsoft.DirectoryServices.Organization('84841066-274d-4ec0-a5c1-276be684bdd3')//localizations/fr",
            "id": "fr",
            "backgroundColor": "#FFFF33",
            "backgroundImageRelativeUrl": null,
            "bannerLogoRelativeUrl": null,
            "cdnList": [],
            "customAccountResetCredentialsUrl": null,
            "customCannotAccessYourAccountText": null,
            "customCannotAccessYourAccountUrl": null,
            "customCSS": null,
            "customCSSRelativetUrl": null,
            "customForgotMyPasswordText": null,
            "customPrivacyAndCookiesText": null,
            "customPrivacyAndCookiesUrl": null,
            "customTermsOfUseText": null,
            "customTermsOfUseUrl": null,
            "customResetItNowText": null,
            "faviconRelativeUrl": null,
            "headerBackgroundColor": null,
            "headerLogoRelativeUrl": null,
            "signInPageText": "Contoso",
            "squareLogoRelativeUrl": "c1c6b6c8-urr-dzbkz44n5kuo9kzl1kziuujjcdqonoe2owyacso/logintenantbranding/0/tilelogo?ts=637535563832888580",
            "squareLogoDarkRelativeUrl": null,
            "usernameHintText": " ",
            "loginPageLayoutConfiguration": {
              "layoutTemplateType": "default",
              "isHeaderShown": false,
              "isFooterShown": true
             },
            "loginPageTextVisibilitySettings": {
              "hideCannotAccessYourAccount": false,
              "hideForgotMyPassword": false,
              "hideResetItNow": false,
              "hideTermsOfUse": true,
              "hidePrivacyAndCookies": true
            }
        }
    ]
}
```

