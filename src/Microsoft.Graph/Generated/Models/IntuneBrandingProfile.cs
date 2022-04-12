using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IntuneBrandingProfile : Entity, IParsable {
        /// <summary>The list of group assignments for the branding profile</summary>
        public List<IntuneBrandingProfileAssignment> Assignments { get; set; }
        /// <summary>Collection of blocked actions on the company portal as per platform and device ownership types.</summary>
        public List<CompanyPortalBlockedAction> CompanyPortalBlockedActions { get; set; }
        /// <summary>E-mail address of the person/organization responsible for IT support</summary>
        public string ContactITEmailAddress { get; set; }
        /// <summary>Name of the person/organization responsible for IT support</summary>
        public string ContactITName { get; set; }
        /// <summary>Text comments regarding the person/organization responsible for IT support</summary>
        public string ContactITNotes { get; set; }
        /// <summary>Phone number of the person/organization responsible for IT support</summary>
        public string ContactITPhoneNumber { get; set; }
        /// <summary>Time when the BrandingProfile was created</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Text comments regarding what the admin has access to on the device</summary>
        public string CustomCanSeePrivacyMessage { get; set; }
        /// <summary>Text comments regarding what the admin doesn&apos;t have access to on the device</summary>
        public string CustomCantSeePrivacyMessage { get; set; }
        /// <summary>Text comments regarding what the admin doesn&apos;t have access to on the device</summary>
        public string CustomPrivacyMessage { get; set; }
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry { get; set; }
        /// <summary>Company/organization name that is displayed to end users</summary>
        public string DisplayName { get; set; }
        /// <summary>Customized device enrollment flow displayed to the end user . Possible values are: availableWithPrompts, availableWithoutPrompts, unavailable.</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability { get; set; }
        /// <summary>Boolean that represents whether the profile is used as default or not</summary>
        public bool? IsDefaultProfile { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Factory Reset&apos; action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Remove Device&apos; action on corporate owned devices.</summary>
        public bool? IsRemoveDeviceDisabled { get; set; }
        /// <summary>Customized image displayed in Company Portal apps landing page</summary>
        public MimeContent LandingPageCustomizedImage { get; set; }
        /// <summary>Time when the BrandingProfile was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo</summary>
        public MimeContent LightBackgroundLogo { get; set; }
        /// <summary>Display name of the company/organization’s IT helpdesk site</summary>
        public string OnlineSupportSiteName { get; set; }
        /// <summary>URL to the company/organization’s IT helpdesk site</summary>
        public string OnlineSupportSiteUrl { get; set; }
        /// <summary>URL to the company/organization’s privacy policy</summary>
        public string PrivacyUrl { get; set; }
        /// <summary>Description of the profile</summary>
        public string ProfileDescription { get; set; }
        /// <summary>Name of the profile</summary>
        public string ProfileName { get; set; }
        /// <summary>List of scope tags assigned to the branding profile</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate</summary>
        public bool? SendDeviceOwnershipChangePushNotification { get; set; }
        /// <summary>Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal</summary>
        public bool? ShowAzureADEnterpriseApps { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not</summary>
        public bool? ShowDisplayNameNextToLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not</summary>
        public bool? ShowLogo { get; set; }
        /// <summary>Boolean that indicates if Office WebApps will be shown in Company Portal</summary>
        public bool? ShowOfficeWebApps { get; set; }
        /// <summary>Primary theme color used in the Company Portal applications and web portal</summary>
        public RgbColor ThemeColor { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a theme color background behind the logo</summary>
        public MimeContent ThemeColorLogo { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IntuneBrandingProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrandingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<IntuneBrandingProfileAssignment>(IntuneBrandingProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"companyPortalBlockedActions", n => { CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>(CompanyPortalBlockedAction.CreateFromDiscriminatorValue).ToList(); } },
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customCanSeePrivacyMessage", n => { CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", n => { CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", n => { CustomPrivacyMessage = n.GetStringValue(); } },
                {"disableClientTelemetry", n => { DisableClientTelemetry = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", n => { EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isDefaultProfile", n => { IsDefaultProfile = n.GetBoolValue(); } },
                {"isFactoryResetDisabled", n => { IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", n => { IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", n => { LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"profileDescription", n => { ProfileDescription = n.GetStringValue(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", n => { SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", n => { ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", n => { ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
                {"themeColorLogo", n => { ThemeColorLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IntuneBrandingProfileAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<CompanyPortalBlockedAction>("companyPortalBlockedActions", CompanyPortalBlockedActions);
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customCanSeePrivacyMessage", CustomCanSeePrivacyMessage);
            writer.WriteStringValue("customCantSeePrivacyMessage", CustomCantSeePrivacyMessage);
            writer.WriteStringValue("customPrivacyMessage", CustomPrivacyMessage);
            writer.WriteBoolValue("disableClientTelemetry", DisableClientTelemetry);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentAvailabilityOptions>("enrollmentAvailability", EnrollmentAvailability);
            writer.WriteBoolValue("isDefaultProfile", IsDefaultProfile);
            writer.WriteBoolValue("isFactoryResetDisabled", IsFactoryResetDisabled);
            writer.WriteBoolValue("isRemoveDeviceDisabled", IsRemoveDeviceDisabled);
            writer.WriteObjectValue<MimeContent>("landingPageCustomizedImage", LandingPageCustomizedImage);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteStringValue("profileDescription", ProfileDescription);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("sendDeviceOwnershipChangePushNotification", SendDeviceOwnershipChangePushNotification);
            writer.WriteBoolValue("showAzureADEnterpriseApps", ShowAzureADEnterpriseApps);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showOfficeWebApps", ShowOfficeWebApps);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteObjectValue<MimeContent>("themeColorLogo", ThemeColorLogo);
        }
    }
}
