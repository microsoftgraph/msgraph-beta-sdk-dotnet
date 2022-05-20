using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the organizationalBranding singleton.</summary>
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
        public string BackgroundColor {
            get { return BackingStore?.Get<string>(nameof(BackgroundColor)); }
            set { BackingStore?.Set(nameof(BackgroundColor), value); }
        }
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
        public byte[] BackgroundImage {
            get { return BackingStore?.Get<byte[]>(nameof(BackgroundImage)); }
            set { BackingStore?.Set(nameof(BackgroundImage), value); }
        }
        /// <summary>A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string BackgroundImageRelativeUrl {
            get { return BackingStore?.Get<string>(nameof(BackgroundImageRelativeUrl)); }
            set { BackingStore?.Set(nameof(BackgroundImageRelativeUrl), value); }
        }
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] BannerLogo {
            get { return BackingStore?.Get<byte[]>(nameof(BannerLogo)); }
            set { BackingStore?.Set(nameof(BannerLogo), value); }
        }
        /// <summary>A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.</summary>
        public string BannerLogoRelativeUrl {
            get { return BackingStore?.Get<string>(nameof(BannerLogoRelativeUrl)); }
            set { BackingStore?.Set(nameof(BannerLogoRelativeUrl), value); }
        }
        /// <summary>A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.</summary>
        public List<string> CdnList {
            get { return BackingStore?.Get<List<string>>(nameof(CdnList)); }
            set { BackingStore?.Set(nameof(CdnList), value); }
        }
        /// <summary>A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomAccountResetCredentialsUrl {
            get { return BackingStore?.Get<string>(nameof(CustomAccountResetCredentialsUrl)); }
            set { BackingStore?.Set(nameof(CustomAccountResetCredentialsUrl), value); }
        }
        /// <summary>A string to replace the default &apos;Can&apos;t access your account?&apos; self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomCannotAccessYourAccountText {
            get { return BackingStore?.Get<string>(nameof(CustomCannotAccessYourAccountText)); }
            set { BackingStore?.Set(nameof(CustomCannotAccessYourAccountText), value); }
        }
        /// <summary>A custom URL to replace the default URL of the self-service password reset (SSPR) &apos;Can&apos;t access your account?&apos; hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.</summary>
        public string CustomCannotAccessYourAccountUrl {
            get { return BackingStore?.Get<string>(nameof(CustomCannotAccessYourAccountUrl)); }
            set { BackingStore?.Set(nameof(CustomCannotAccessYourAccountUrl), value); }
        }
        /// <summary>A string to replace the default &apos;Forgot my password&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomForgotMyPasswordText {
            get { return BackingStore?.Get<string>(nameof(CustomForgotMyPasswordText)); }
            set { BackingStore?.Set(nameof(CustomForgotMyPasswordText), value); }
        }
        /// <summary>A string to replace the default &apos;Privacy and Cookies&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomPrivacyAndCookiesText {
            get { return BackingStore?.Get<string>(nameof(CustomPrivacyAndCookiesText)); }
            set { BackingStore?.Set(nameof(CustomPrivacyAndCookiesText), value); }
        }
        /// <summary>A custom URL to replace the default URL of the &apos;Privacy and Cookies&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.</summary>
        public string CustomPrivacyAndCookiesUrl {
            get { return BackingStore?.Get<string>(nameof(CustomPrivacyAndCookiesUrl)); }
            set { BackingStore?.Set(nameof(CustomPrivacyAndCookiesUrl), value); }
        }
        /// <summary>A string to replace the default &apos;reset it now&apos; hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the &apos;reset it now&apos; hyperlink text is currently not supported.</summary>
        public string CustomResetItNowText {
            get { return BackingStore?.Get<string>(nameof(CustomResetItNowText)); }
            set { BackingStore?.Set(nameof(CustomResetItNowText), value); }
        }
        /// <summary>A string to replace the the default &apos;Terms of Use&apos; hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.</summary>
        public string CustomTermsOfUseText {
            get { return BackingStore?.Get<string>(nameof(CustomTermsOfUseText)); }
            set { BackingStore?.Set(nameof(CustomTermsOfUseText), value); }
        }
        /// <summary>A custom URL to replace the default URL of the &apos;Terms of Use&apos; hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.</summary>
        public string CustomTermsOfUseUrl {
            get { return BackingStore?.Get<string>(nameof(CustomTermsOfUseUrl)); }
            set { BackingStore?.Set(nameof(CustomTermsOfUseUrl), value); }
        }
        /// <summary>A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.</summary>
        public byte[] Favicon {
            get { return BackingStore?.Get<byte[]>(nameof(Favicon)); }
            set { BackingStore?.Set(nameof(Favicon), value); }
        }
        /// <summary>A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string FaviconRelativeUrl {
            get { return BackingStore?.Get<string>(nameof(FaviconRelativeUrl)); }
            set { BackingStore?.Set(nameof(FaviconRelativeUrl), value); }
        }
        /// <summary>The RGB color to apply to customize the color of the header.</summary>
        public string HeaderBackgroundColor {
            get { return BackingStore?.Get<string>(nameof(HeaderBackgroundColor)); }
            set { BackingStore?.Set(nameof(HeaderBackgroundColor), value); }
        }
        /// <summary>Represents the various texts that can be hidden on the login page for a tenant.</summary>
        public Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings LoginPageTextVisibilitySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LoginPageTextVisibilitySettings>(nameof(LoginPageTextVisibilitySettings)); }
            set { BackingStore?.Set(nameof(LoginPageTextVisibilitySettings), value); }
        }
        /// <summary>Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.</summary>
        public string SignInPageText {
            get { return BackingStore?.Get<string>(nameof(SignInPageText)); }
            set { BackingStore?.Set(nameof(SignInPageText), value); }
        }
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] SquareLogo {
            get { return BackingStore?.Get<byte[]>(nameof(SquareLogo)); }
            set { BackingStore?.Set(nameof(SquareLogo), value); }
        }
        /// <summary>A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.</summary>
        public string SquareLogoRelativeUrl {
            get { return BackingStore?.Get<string>(nameof(SquareLogoRelativeUrl)); }
            set { BackingStore?.Set(nameof(SquareLogoRelativeUrl), value); }
        }
        /// <summary>A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can&apos;t exceed 64 characters.</summary>
        public string UsernameHintText {
            get { return BackingStore?.Get<string>(nameof(UsernameHintText)); }
            set { BackingStore?.Set(nameof(UsernameHintText), value); }
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
                "#microsoft.graph.organizationalBrandingProperties" => new OrganizationalBrandingProperties(),
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
