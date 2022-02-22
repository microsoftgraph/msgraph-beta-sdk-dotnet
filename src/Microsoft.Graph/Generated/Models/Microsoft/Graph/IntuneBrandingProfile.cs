using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
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
        /// <summary>Text comments regarding what the admin doesn't have access to on the device</summary>
        public string CustomCantSeePrivacyMessage { get; set; }
        /// <summary>Text comments regarding what the admin doesn't have access to on the device</summary>
        public string CustomPrivacyMessage { get; set; }
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry { get; set; }
        /// <summary>Company/organization name that is displayed to end users</summary>
        public string DisplayName { get; set; }
        /// <summary>Customized device enrollment flow displayed to the end user . Possible values are: availableWithPrompts, availableWithoutPrompts, unavailable.</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability { get; set; }
        /// <summary>Boolean that represents whether the profile is used as default or not</summary>
        public bool? IsDefaultProfile { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the 'Factory Reset' action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the 'Remove Device' action on corporate owned devices.</summary>
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as IntuneBrandingProfile).Assignments = n.GetCollectionOfObjectValues<IntuneBrandingProfileAssignment>().ToList(); } },
                {"companyPortalBlockedActions", (o,n) => { (o as IntuneBrandingProfile).CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>().ToList(); } },
                {"contactITEmailAddress", (o,n) => { (o as IntuneBrandingProfile).ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", (o,n) => { (o as IntuneBrandingProfile).ContactITName = n.GetStringValue(); } },
                {"contactITNotes", (o,n) => { (o as IntuneBrandingProfile).ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", (o,n) => { (o as IntuneBrandingProfile).ContactITPhoneNumber = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as IntuneBrandingProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customCanSeePrivacyMessage", (o,n) => { (o as IntuneBrandingProfile).CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", (o,n) => { (o as IntuneBrandingProfile).CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", (o,n) => { (o as IntuneBrandingProfile).CustomPrivacyMessage = n.GetStringValue(); } },
                {"disableClientTelemetry", (o,n) => { (o as IntuneBrandingProfile).DisableClientTelemetry = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as IntuneBrandingProfile).DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", (o,n) => { (o as IntuneBrandingProfile).EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isDefaultProfile", (o,n) => { (o as IntuneBrandingProfile).IsDefaultProfile = n.GetBoolValue(); } },
                {"isFactoryResetDisabled", (o,n) => { (o as IntuneBrandingProfile).IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", (o,n) => { (o as IntuneBrandingProfile).IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", (o,n) => { (o as IntuneBrandingProfile).LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as IntuneBrandingProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lightBackgroundLogo", (o,n) => { (o as IntuneBrandingProfile).LightBackgroundLogo = n.GetObjectValue<MimeContent>(); } },
                {"onlineSupportSiteName", (o,n) => { (o as IntuneBrandingProfile).OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", (o,n) => { (o as IntuneBrandingProfile).OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", (o,n) => { (o as IntuneBrandingProfile).PrivacyUrl = n.GetStringValue(); } },
                {"profileDescription", (o,n) => { (o as IntuneBrandingProfile).ProfileDescription = n.GetStringValue(); } },
                {"profileName", (o,n) => { (o as IntuneBrandingProfile).ProfileName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as IntuneBrandingProfile).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", (o,n) => { (o as IntuneBrandingProfile).SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", (o,n) => { (o as IntuneBrandingProfile).ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", (o,n) => { (o as IntuneBrandingProfile).ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", (o,n) => { (o as IntuneBrandingProfile).ShowLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", (o,n) => { (o as IntuneBrandingProfile).ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", (o,n) => { (o as IntuneBrandingProfile).ThemeColor = n.GetObjectValue<RgbColor>(); } },
                {"themeColorLogo", (o,n) => { (o as IntuneBrandingProfile).ThemeColorLogo = n.GetObjectValue<MimeContent>(); } },
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
