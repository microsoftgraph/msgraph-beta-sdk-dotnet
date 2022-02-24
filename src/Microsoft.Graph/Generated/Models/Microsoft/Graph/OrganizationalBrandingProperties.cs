using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
        public string BackgroundColor { get; set; }
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
        public byte[] BackgroundImage { get; set; }
        /// <summary>A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string BackgroundImageRelativeUrl { get; set; }
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] BannerLogo { get; set; }
        /// <summary>A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
        public string BannerLogoRelativeUrl { get; set; }
        /// <summary>A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.</summary>
        public List<string> CdnList { get; set; }
        /// <summary>A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomAccountResetCredentialsUrl { get; set; }
        /// <summary>A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomCannotAccessYourAccountText { get; set; }
        /// <summary>A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.</summary>
        public string CustomCannotAccessYourAccountUrl { get; set; }
        /// <summary>A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomForgotMyPasswordText { get; set; }
        /// <summary>A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomPrivacyAndCookiesText { get; set; }
        /// <summary>A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomPrivacyAndCookiesUrl { get; set; }
        /// <summary>A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.</summary>
        public string CustomResetItNowText { get; set; }
        /// <summary>A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomTermsOfUseText { get; set; }
        /// <summary>A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.</summary>
        public string CustomTermsOfUseUrl { get; set; }
        /// <summary>A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.</summary>
        public byte[] Favicon { get; set; }
        /// <summary>A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string FaviconRelativeUrl { get; set; }
        /// <summary>The RGB color to apply to customize the color of the header.</summary>
        public string HeaderBackgroundColor { get; set; }
        /// <summary>Represents the various texts that can be hidden on the login page for a tenant.</summary>
        public LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings { get; set; }
        /// <summary>Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.</summary>
        public string SignInPageText { get; set; }
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] SquareLogo { get; set; }
        /// <summary>A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string SquareLogoRelativeUrl { get; set; }
        /// <summary>String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.</summary>
        public string UsernameHintText { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"backgroundColor", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundImage = n.GetByteArrayValue(); } },
                {"backgroundImageRelativeUrl", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundImageRelativeUrl = n.GetStringValue(); } },
                {"bannerLogo", (o,n) => { (o as OrganizationalBrandingProperties).BannerLogo = n.GetByteArrayValue(); } },
                {"bannerLogoRelativeUrl", (o,n) => { (o as OrganizationalBrandingProperties).BannerLogoRelativeUrl = n.GetStringValue(); } },
                {"cdnList", (o,n) => { (o as OrganizationalBrandingProperties).CdnList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"customAccountResetCredentialsUrl", (o,n) => { (o as OrganizationalBrandingProperties).CustomAccountResetCredentialsUrl = n.GetStringValue(); } },
                {"customCannotAccessYourAccountText", (o,n) => { (o as OrganizationalBrandingProperties).CustomCannotAccessYourAccountText = n.GetStringValue(); } },
                {"customCannotAccessYourAccountUrl", (o,n) => { (o as OrganizationalBrandingProperties).CustomCannotAccessYourAccountUrl = n.GetStringValue(); } },
                {"customForgotMyPasswordText", (o,n) => { (o as OrganizationalBrandingProperties).CustomForgotMyPasswordText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesText", (o,n) => { (o as OrganizationalBrandingProperties).CustomPrivacyAndCookiesText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesUrl", (o,n) => { (o as OrganizationalBrandingProperties).CustomPrivacyAndCookiesUrl = n.GetStringValue(); } },
                {"customResetItNowText", (o,n) => { (o as OrganizationalBrandingProperties).CustomResetItNowText = n.GetStringValue(); } },
                {"customTermsOfUseText", (o,n) => { (o as OrganizationalBrandingProperties).CustomTermsOfUseText = n.GetStringValue(); } },
                {"customTermsOfUseUrl", (o,n) => { (o as OrganizationalBrandingProperties).CustomTermsOfUseUrl = n.GetStringValue(); } },
                {"favicon", (o,n) => { (o as OrganizationalBrandingProperties).Favicon = n.GetByteArrayValue(); } },
                {"faviconRelativeUrl", (o,n) => { (o as OrganizationalBrandingProperties).FaviconRelativeUrl = n.GetStringValue(); } },
                {"headerBackgroundColor", (o,n) => { (o as OrganizationalBrandingProperties).HeaderBackgroundColor = n.GetStringValue(); } },
                {"loginPageTextVisibilitySettings", (o,n) => { (o as OrganizationalBrandingProperties).LoginPageTextVisibilitySettings = n.GetObjectValue<LoginPageTextVisibilitySettings>(); } },
                {"signInPageText", (o,n) => { (o as OrganizationalBrandingProperties).SignInPageText = n.GetStringValue(); } },
                {"squareLogo", (o,n) => { (o as OrganizationalBrandingProperties).SquareLogo = n.GetByteArrayValue(); } },
                {"squareLogoRelativeUrl", (o,n) => { (o as OrganizationalBrandingProperties).SquareLogoRelativeUrl = n.GetStringValue(); } },
                {"usernameHintText", (o,n) => { (o as OrganizationalBrandingProperties).UsernameHintText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteByteArrayValue("backgroundImage", BackgroundImage);
            writer.WriteStringValue("backgroundImageRelativeUrl", BackgroundImageRelativeUrl);
            writer.WriteByteArrayValue("bannerLogo", BannerLogo);
            writer.WriteStringValue("bannerLogoRelativeUrl", BannerLogoRelativeUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("cdnList", CdnList);
            writer.WriteStringValue("customAccountResetCredentialsUrl", CustomAccountResetCredentialsUrl);
            writer.WriteStringValue("customCannotAccessYourAccountText", CustomCannotAccessYourAccountText);
            writer.WriteStringValue("customCannotAccessYourAccountUrl", CustomCannotAccessYourAccountUrl);
            writer.WriteStringValue("customForgotMyPasswordText", CustomForgotMyPasswordText);
            writer.WriteStringValue("customPrivacyAndCookiesText", CustomPrivacyAndCookiesText);
            writer.WriteStringValue("customPrivacyAndCookiesUrl", CustomPrivacyAndCookiesUrl);
            writer.WriteStringValue("customResetItNowText", CustomResetItNowText);
            writer.WriteStringValue("customTermsOfUseText", CustomTermsOfUseText);
            writer.WriteStringValue("customTermsOfUseUrl", CustomTermsOfUseUrl);
            writer.WriteByteArrayValue("favicon", Favicon);
            writer.WriteStringValue("faviconRelativeUrl", FaviconRelativeUrl);
            writer.WriteStringValue("headerBackgroundColor", HeaderBackgroundColor);
            writer.WriteObjectValue<LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings", LoginPageTextVisibilitySettings);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteByteArrayValue("squareLogo", SquareLogo);
            writer.WriteStringValue("squareLogoRelativeUrl", SquareLogoRelativeUrl);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
