---
title: "Update organizationalBrandingLocalization"
description: "Update the properties of an organizationalBrandingLocalization object."
author: "AlexanderMars"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update organizationalBrandingLocalization
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [organizationalBrandingLocalization](../resources/organizationalbrandinglocalization.md) object for a specific localization.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Organization.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Organization.ReadWrite.All |

## HTTP request

Only Stream data types, including **backgroundLogo** and **backgroundImage**, are updated using the PUT method. To update String data types, including **signInPageText** and **usernameHintText**, use the PATCH method. You cannot update Stream types with other data types in the same request.

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /organization/{organizationId}/branding/localizations/{organizationalBrandingLocalizationId}
PUT /organization/{organizationId}/branding/localizations/{organizationalBrandingLocalizationId}/{backgroundImage | bannerLogo | squareLogo}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| backgroundColor | String | Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is `#FFFFFF`. |
| backgroundImage | Stream | Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster. |
| bannerLogo | Stream | A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo. |
| customAccountResetCredentialsUrl | String | A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. |
| customCannotAccessYourAccountText | String | A string to replace the default "Can't access your account?" self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters. |
| customCSS | Stream | CSS styling that appears on the sign-in page. The allowed format is .css format only and not larger than 25KB. |
| customForgotMyPasswordText | String | A string to replace the default "Forgot my password" hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. |
| customPrivacyAndCookiesText | String | A string to replace the default "Privacy and Cookies" hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters. |
| customPrivacyAndCookiesUrl | String | A custom URL to replace the default URL of the "Privacy and Cookies" hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. |
| customTermsOfUseText | String | A string to replace the the default "Terms of Use" hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters. |
| customTermsOfUseUrl | String | A custom URL to replace the default URL of the "Terms of Use" hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters. |
| favicon | Stream | A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant. |
| headerBackgroundColor | String | The RGB color to apply to customize the color of the header. |
| headerLogo | Stream | A company logo that appears in the header of the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo. |
| loginPageLayoutConfiguration | [loginPageLayoutConfiguration](../resources/loginPageLayoutConfiguration.md) | Represents the layout configuration to be displayed on the login page for a tenant. |
| loginPageTextVisibilitySettings | [loginPageTextVisibilitySettings](../resources/loginPageTextVisibilitySettings.md) | Represents the various texts that can be hidden on the login page for a tenant. All the properties can be updated. |
| signInPageText | String | Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters. |
| squareLogo | Stream | A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.|
| squareLogoDark | Stream | A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.|
| usernameHintText | String | A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters. |

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Setting **bannerLogo** for the fr-FR localization using PUT

The following request updates the banner logo for the fr-FR localization.

#### Request

The following is an example of the request.



# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_organizationalbrandinglocalization",
  "sampleKeys": ["fr-FR", "d69179bf-f4a4-41a9-a9de-249c0f2efb1d"]
}-->

```msgraph-interactive
PUT https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/fr-FR/bannerLogo
Content-Type: image/jpeg

<Image>
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

using var stream = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(@"<Image>"));

await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"].BannerLogo
	.Request()
	.PutAsync<OrganizationalBrandingLocalization>(stream);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

### Example 2: Update the backgroundColor and signInPageText for the fr-FR localization using PATCH

The following request updates the banner logo for the `fr-FR` localization.

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_organizationalbrandinglocalization6",
  "sampleKeys": ["fr-FR", "d69179bf-f4a4-41a9-a9de-249c0f2efb1d"]
}-->

```msgraph-interactive
PATCH https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/fr-FR
Content-Type: application/json

{
    "backgroundColor":"#00000F",
    "signInPageText": "Welcome to Contoso France"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var organizationalBrandingLocalization = new OrganizationalBrandingLocalization
{
	BackgroundColor = "#00000F",
	SignInPageText = "Welcome to Contoso France"
};

await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"]
	.Request()
	.UpdateAsync(organizationalBrandingLocalization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```



### Example 3: Override a default branding value with a blank string

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_organizationalbrandinglocalization7",
  "sampleKeys": ["fr-FR", "d69179bf-f4a4-41a9-a9de-249c0f2efb1d"]
}-->

```msgraph-interactive
PATCH https://graph.microsoft.com/beta/organization/d69179bf-f4a4-41a9-a9de-249c0f2efb1d/branding/localizations/fr-FR
Content-Type: application/json

{
    "signInPageText": "Welcome to Contoso France.",
    "usernameHintText":" "
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var organizationalBrandingLocalization = new OrganizationalBrandingLocalization
{
	SignInPageText = "Welcome to Contoso France.",
	UsernameHintText = " "
};

await graphClient.Organization["{organization-id}"].Branding.Localizations["{organizationalBrandingLocalization-id}"]
	.Request()
	.UpdateAsync(organizationalBrandingLocalization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

Following the request, the **usernameHintText** for the `fr-FR` localization will be empty instead of inheriting the value from the default branding object.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```
