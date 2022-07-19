using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
        public string BackgroundColor {
            get { return BackingStore?.Get<string>("backgroundColor"); }
            set { BackingStore?.Set("backgroundColor", value); }
        }
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
        public byte[] BackgroundImage {
            get { return BackingStore?.Get<byte[]>("backgroundImage"); }
            set { BackingStore?.Set("backgroundImage", value); }
        }
        /// <summary>A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string BackgroundImageRelativeUrl {
            get { return BackingStore?.Get<string>("backgroundImageRelativeUrl"); }
            set { BackingStore?.Set("backgroundImageRelativeUrl", value); }
        }
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] BannerLogo {
            get { return BackingStore?.Get<byte[]>("bannerLogo"); }
            set { BackingStore?.Set("bannerLogo", value); }
        }
        /// <summary>A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
        public string BannerLogoRelativeUrl {
            get { return BackingStore?.Get<string>("bannerLogoRelativeUrl"); }
            set { BackingStore?.Set("bannerLogoRelativeUrl", value); }
        }
        /// <summary>A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.</summary>
        public List<string> CdnList {
            get { return BackingStore?.Get<List<string>>("cdnList"); }
            set { BackingStore?.Set("cdnList", value); }
        }
        /// <summary>A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomAccountResetCredentialsUrl {
            get { return BackingStore?.Get<string>("customAccountResetCredentialsUrl"); }
            set { BackingStore?.Set("customAccountResetCredentialsUrl", value); }
        }
        /// <summary>A string to replace the default &apos;Can&apos;t access your account?&apos; self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomCannotAccessYourAccountText {
            get { return BackingStore?.Get<string>("customCannotAccessYourAccountText"); }
            set { BackingStore?.Set("customCannotAccessYourAccountText", value); }
        }
        /// <summary>A custom URL to replace the default URL of the self-service password reset (SSPR) &apos;Can&apos;t access your account?&apos; hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.</summary>
        public string CustomCannotAccessYourAccountUrl {
            get { return BackingStore?.Get<string>("customCannotAccessYourAccountUrl"); }
            set { BackingStore?.Set("customCannotAccessYourAccountUrl", value); }
        }
        /// <summary>A string to replace the default &apos;Forgot my password&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomForgotMyPasswordText {
            get { return BackingStore?.Get<string>("customForgotMyPasswordText"); }
            set { BackingStore?.Set("customForgotMyPasswordText", value); }
        }
        /// <summary>A string to replace the default &apos;Privacy and Cookies&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomPrivacyAndCookiesText {
            get { return BackingStore?.Get<string>("customPrivacyAndCookiesText"); }
            set { BackingStore?.Set("customPrivacyAndCookiesText", value); }
        }
        /// <summary>A custom URL to replace the default URL of the &apos;Privacy and Cookies&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomPrivacyAndCookiesUrl {
            get { return BackingStore?.Get<string>("customPrivacyAndCookiesUrl"); }
            set { BackingStore?.Set("customPrivacyAndCookiesUrl", value); }
        }
        /// <summary>A string to replace the default &apos;reset it now&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the &apos;reset it now&apos; hyperlink text is currently not supported.</summary>
        public string CustomResetItNowText {
            get { return BackingStore?.Get<string>("customResetItNowText"); }
            set { BackingStore?.Set("customResetItNowText", value); }
        }
        /// <summary>A string to replace the the default &apos;Terms of Use&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomTermsOfUseText {
            get { return BackingStore?.Get<string>("customTermsOfUseText"); }
            set { BackingStore?.Set("customTermsOfUseText", value); }
        }
        /// <summary>A custom URL to replace the default URL of the &apos;Terms of Use&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.</summary>
        public string CustomTermsOfUseUrl {
            get { return BackingStore?.Get<string>("customTermsOfUseUrl"); }
            set { BackingStore?.Set("customTermsOfUseUrl", value); }
        }
        /// <summary>A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.</summary>
        public byte[] Favicon {
            get { return BackingStore?.Get<byte[]>("favicon"); }
            set { BackingStore?.Set("favicon", value); }
        }
        /// <summary>A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string FaviconRelativeUrl {
            get { return BackingStore?.Get<string>("faviconRelativeUrl"); }
            set { BackingStore?.Set("faviconRelativeUrl", value); }
        }
        /// <summary>The RGB color to apply to customize the color of the header.</summary>
        public string HeaderBackgroundColor {
            get { return BackingStore?.Get<string>("headerBackgroundColor"); }
            set { BackingStore?.Set("headerBackgroundColor", value); }
        }
        /// <summary>Represents the various texts that can be hidden on the login page for a tenant.</summary>
        public Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings"); }
            set { BackingStore?.Set("loginPageTextVisibilitySettings", value); }
        }
        /// <summary>Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.</summary>
        public string SignInPageText {
            get { return BackingStore?.Get<string>("signInPageText"); }
            set { BackingStore?.Set("signInPageText", value); }
        }
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] SquareLogo {
            get { return BackingStore?.Get<byte[]>("squareLogo"); }
            set { BackingStore?.Set("squareLogo", value); }
        }
        /// <summary>A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string SquareLogoRelativeUrl {
            get { return BackingStore?.Get<string>("squareLogoRelativeUrl"); }
            set { BackingStore?.Set("squareLogoRelativeUrl", value); }
        }
        /// <summary>A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can&apos;t exceed 64 characters.</summary>
        public string UsernameHintText {
            get { return BackingStore?.Get<string>("usernameHintText"); }
            set { BackingStore?.Set("usernameHintText", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalBrandingProperties and sets the default values.
        /// </summary>
        public OrganizationalBrandingProperties() : base() {
            OdataType = "#microsoft.graph.organizationalBrandingProperties";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrganizationalBrandingProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.organizationalBranding" => new OrganizationalBranding(),
                "#microsoft.graph.organizationalBrandingLocalization" => new OrganizationalBrandingLocalization(),
                _ => new OrganizationalBrandingProperties(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", n => { BackgroundImage = n.GetByteArrayValue(); } },
                {"backgroundImageRelativeUrl", n => { BackgroundImageRelativeUrl = n.GetStringValue(); } },
                {"bannerLogo", n => { BannerLogo = n.GetByteArrayValue(); } },
                {"bannerLogoRelativeUrl", n => { BannerLogoRelativeUrl = n.GetStringValue(); } },
                {"cdnList", n => { CdnList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"customAccountResetCredentialsUrl", n => { CustomAccountResetCredentialsUrl = n.GetStringValue(); } },
                {"customCannotAccessYourAccountText", n => { CustomCannotAccessYourAccountText = n.GetStringValue(); } },
                {"customCannotAccessYourAccountUrl", n => { CustomCannotAccessYourAccountUrl = n.GetStringValue(); } },
                {"customForgotMyPasswordText", n => { CustomForgotMyPasswordText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesText", n => { CustomPrivacyAndCookiesText = n.GetStringValue(); } },
                {"customPrivacyAndCookiesUrl", n => { CustomPrivacyAndCookiesUrl = n.GetStringValue(); } },
                {"customResetItNowText", n => { CustomResetItNowText = n.GetStringValue(); } },
                {"customTermsOfUseText", n => { CustomTermsOfUseText = n.GetStringValue(); } },
                {"customTermsOfUseUrl", n => { CustomTermsOfUseUrl = n.GetStringValue(); } },
                {"favicon", n => { Favicon = n.GetByteArrayValue(); } },
                {"faviconRelativeUrl", n => { FaviconRelativeUrl = n.GetStringValue(); } },
                {"headerBackgroundColor", n => { HeaderBackgroundColor = n.GetStringValue(); } },
                {"loginPageTextVisibilitySettings", n => { LoginPageTextVisibilitySettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>(Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings.CreateFromDiscriminatorValue); } },
                {"signInPageText", n => { SignInPageText = n.GetStringValue(); } },
                {"squareLogo", n => { SquareLogo = n.GetByteArrayValue(); } },
                {"squareLogoRelativeUrl", n => { SquareLogoRelativeUrl = n.GetStringValue(); } },
                {"usernameHintText", n => { UsernameHintText = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>("loginPageTextVisibilitySettings", LoginPageTextVisibilitySettings);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteByteArrayValue("squareLogo", SquareLogo);
            writer.WriteStringValue("squareLogoRelativeUrl", SquareLogoRelativeUrl);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
