---
title: "Get organizationalBrandingLocalization"
description: "Read the properties and relationships of an organizationalBrandingLocalization object."
author: "AlexanderMars"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get organizationalBrandingLocalization
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [organizationalBrandingLocalization](../resources/organizationalbrandinglocalization.md) object. To retrieve a localization branding object, specify the value of **id** in the URL.

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
GET /organization/{organizationId}/branding/localizations/{organizationalBrandingLocalizationId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [organizationalBrandingLocalization](../resources/organizationalbrandinglocalization.md) object in the response body.

## Examples

### Example 1: Get the localized branding for a specific locale (fr-FR)

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_organizationalbrandinglocalization",
  "sampleKeys": ["fr-FR", "d69179bf-f4a4-41a9-a9de-249c0f2efb1d"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/fr-FR
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var organizationalBrandingLocalization = await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.organizationalBrandingLocalization"
} -->
```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#organization('99b24e1b-abec-4598-9d63-a2baf0a3cea1')/branding/localizations/$entity",
    "@odata.type": "#microsoft.graph.organizationalBrandingProperties",
    "@odata.id": "https://graph.microsoft.com/v2/99b24e1b-abec-4598-9d63-a2baf0a3cea1/directoryObjects/$/Microsoft.DirectoryServices.Organization('99b24e1b-abec-4598-9d63-a2baf0a3cea1')//localizations('fr-FR')/fr-FR",
    "id": "fr-FR",
    "backgroundColor": " ",
    "backgroundImageRelativeUrl": null,
    "bannerLogoRelativeUrl": "c1c6b6c8-urr-dzbkz44n5kuo9kzl1kziuujjcdqonoe2owyacso/logintenantbranding/1036/bannerlogo?ts=637673868626068858",
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
    "squareLogoDarkRelativeUrl": "c1c6b6c8-urr-dzbkz44n5kuo9kzl1kziuujjcdqonoe2owyacso/logintenantbranding/0/tilelogo?ts=637535563832888580",    
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
```

### Example 2: Get the value of signInPageText for a specific locale

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_organizationalbrandinglocalization_locale_signInPageText",
  "sampleKeys": ["fr-FR", "99b24e1b-abec-4598-9d63-a2baf0a3cea1"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/99b24e1b-abec-4598-9d63-a2baf0a3cea1/branding/localizations/fr-FR/signInPageText
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var localizations = await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"]
	.Request()
	.Select("SignInPageText")
	.GetAsync();

var signInPageText = localizations.SignInPageText;

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.organizationalBrandingLocalization"
} -->

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#organization('99b24e1b-abec-4598-9d63-a2baf0a3cea1')/branding/localizations('fr-FR')/usernameHintText",
    "value": "Welcome to Contoso France"
}
```

### Example 3: Get the bannerLogo for the default locale

The following example returns the **bannerLogo** object for the default locale. You may specify the **id** as `default` or `0` in the request URL. If the object is not set, the request returns an empty response.

#### Request

The following is an example of the request.

<!-- {
  "blockType": "ignored",
  "name": "get_organizationalbranding_defaultlocale_bannerLogo"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/default/bannerLogo
```

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.organizationalBranding"
} -->

```http
HTTP/1.1 200 OK
Content-Type: image/*

<Image>
```

### Example 4: Get the bannerLogo for the fr-FR locale

The following example returns the **bannerLogo** object for the `fr-FR` locale whose bannerLogo is not set.

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_organizationalbranding_frlocale_default_bannerLogo",
  "sampleKeys": ["d69179bf-f4a4-41a9-a9de-249c0f2efb1d"]
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/default/bannerLogo
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"].BannerLogo
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.organizationalBranding"
} -->

```http
HTTP/1.1 200 OK

{}
```
