using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
    public class IntuneBrand : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Collection of blocked actions on the company portal as per platform and device ownership types.</summary>
        public List<CompanyPortalBlockedAction> CompanyPortalBlockedActions {
            get { return BackingStore?.Get<List<CompanyPortalBlockedAction>>(nameof(CompanyPortalBlockedActions)); }
            set { BackingStore?.Set(nameof(CompanyPortalBlockedActions), value); }
        }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
        public string ContactITEmailAddress {
            get { return BackingStore?.Get<string>(nameof(ContactITEmailAddress)); }
            set { BackingStore?.Set(nameof(ContactITEmailAddress), value); }
        }
        /// <summary>Name of the person/organization responsible for IT support.</summary>
        public string ContactITName {
            get { return BackingStore?.Get<string>(nameof(ContactITName)); }
            set { BackingStore?.Set(nameof(ContactITName), value); }
        }
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
        public string ContactITNotes {
            get { return BackingStore?.Get<string>(nameof(ContactITNotes)); }
            set { BackingStore?.Set(nameof(ContactITNotes), value); }
        }
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
        public string ContactITPhoneNumber {
            get { return BackingStore?.Get<string>(nameof(ContactITPhoneNumber)); }
            set { BackingStore?.Set(nameof(ContactITPhoneNumber), value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can see and do on managed devices.</summary>
        public string CustomCanSeePrivacyMessage {
            get { return BackingStore?.Get<string>(nameof(CustomCanSeePrivacyMessage)); }
            set { BackingStore?.Set(nameof(CustomCanSeePrivacyMessage), value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomCantSeePrivacyMessage {
            get { return BackingStore?.Get<string>(nameof(CustomCantSeePrivacyMessage)); }
            set { BackingStore?.Set(nameof(CustomCantSeePrivacyMessage), value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomPrivacyMessage {
            get { return BackingStore?.Get<string>(nameof(CustomPrivacyMessage)); }
            set { BackingStore?.Set(nameof(CustomPrivacyMessage), value); }
        }
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
        public MimeContent DarkBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>(nameof(DarkBackgroundLogo)); }
            set { BackingStore?.Set(nameof(DarkBackgroundLogo), value); }
        }
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry {
            get { return BackingStore?.Get<bool?>(nameof(DisableClientTelemetry)); }
            set { BackingStore?.Set(nameof(DisableClientTelemetry), value); }
        }
        /// <summary>Company/organization name that is displayed to end users.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Customized device enrollment flow displayed to the end user . Possible values are: availableWithPrompts, availableWithoutPrompts, unavailable.</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability {
            get { return BackingStore?.Get<EnrollmentAvailabilityOptions?>(nameof(EnrollmentAvailability)); }
            set { BackingStore?.Set(nameof(EnrollmentAvailability), value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Factory Reset&apos; action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled {
            get { return BackingStore?.Get<bool?>(nameof(IsFactoryResetDisabled)); }
            set { BackingStore?.Set(nameof(IsFactoryResetDisabled), value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Remove Device&apos; action on corporate owned devices.</summary>
        public bool? IsRemoveDeviceDisabled {
            get { return BackingStore?.Get<bool?>(nameof(IsRemoveDeviceDisabled)); }
            set { BackingStore?.Set(nameof(IsRemoveDeviceDisabled), value); }
        }
        /// <summary>Customized image displayed in Company Portal app landing page</summary>
        public MimeContent LandingPageCustomizedImage {
            get { return BackingStore?.Get<MimeContent>(nameof(LandingPageCustomizedImage)); }
            set { BackingStore?.Set(nameof(LandingPageCustomizedImage), value); }
        }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
        public MimeContent LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>(nameof(LightBackgroundLogo)); }
            set { BackingStore?.Set(nameof(LightBackgroundLogo), value); }
        }
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteName {
            get { return BackingStore?.Get<string>(nameof(OnlineSupportSiteName)); }
            set { BackingStore?.Set(nameof(OnlineSupportSiteName), value); }
        }
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string>(nameof(OnlineSupportSiteUrl)); }
            set { BackingStore?.Set(nameof(OnlineSupportSiteUrl), value); }
        }
        /// <summary>URL to the company/organization’s privacy policy.</summary>
        public string PrivacyUrl {
            get { return BackingStore?.Get<string>(nameof(PrivacyUrl)); }
            set { BackingStore?.Set(nameof(PrivacyUrl), value); }
        }
        /// <summary>List of scope tags assigned to the default branding profile</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate</summary>
        public bool? SendDeviceOwnershipChangePushNotification {
            get { return BackingStore?.Get<bool?>(nameof(SendDeviceOwnershipChangePushNotification)); }
            set { BackingStore?.Set(nameof(SendDeviceOwnershipChangePushNotification), value); }
        }
        /// <summary>Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal</summary>
        public bool? ShowAzureADEnterpriseApps {
            get { return BackingStore?.Get<bool?>(nameof(ShowAzureADEnterpriseApps)); }
            set { BackingStore?.Set(nameof(ShowAzureADEnterpriseApps), value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo {
            get { return BackingStore?.Get<bool?>(nameof(ShowDisplayNameNextToLogo)); }
            set { BackingStore?.Set(nameof(ShowDisplayNameNextToLogo), value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo {
            get { return BackingStore?.Get<bool?>(nameof(ShowLogo)); }
            set { BackingStore?.Set(nameof(ShowLogo), value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo {
            get { return BackingStore?.Get<bool?>(nameof(ShowNameNextToLogo)); }
            set { BackingStore?.Set(nameof(ShowNameNextToLogo), value); }
        }
        /// <summary>Boolean that indicates if Office WebApps will be shown in Company Portal</summary>
        public bool? ShowOfficeWebApps {
            get { return BackingStore?.Get<bool?>(nameof(ShowOfficeWebApps)); }
            set { BackingStore?.Set(nameof(ShowOfficeWebApps), value); }
        }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
        public RgbColor ThemeColor {
            get { return BackingStore?.Get<RgbColor>(nameof(ThemeColor)); }
            set { BackingStore?.Set(nameof(ThemeColor), value); }
        }
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IntuneBrand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"companyPortalBlockedActions", n => { CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>(CompanyPortalBlockedAction.CreateFromDiscriminatorValue).ToList(); } },
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"customCanSeePrivacyMessage", n => { CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", n => { CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", n => { CustomPrivacyMessage = n.GetStringValue(); } },
                {"darkBackgroundLogo", n => { DarkBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"disableClientTelemetry", n => { DisableClientTelemetry = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", n => { EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isFactoryResetDisabled", n => { IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", n => { IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", n => { LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", n => { SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", n => { ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", n => { ShowNameNextToLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", n => { ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CompanyPortalBlockedAction>("companyPortalBlockedActions", CompanyPortalBlockedActions);
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteStringValue("customCanSeePrivacyMessage", CustomCanSeePrivacyMessage);
            writer.WriteStringValue("customCantSeePrivacyMessage", CustomCantSeePrivacyMessage);
            writer.WriteStringValue("customPrivacyMessage", CustomPrivacyMessage);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteBoolValue("disableClientTelemetry", DisableClientTelemetry);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentAvailabilityOptions>("enrollmentAvailability", EnrollmentAvailability);
            writer.WriteBoolValue("isFactoryResetDisabled", IsFactoryResetDisabled);
            writer.WriteBoolValue("isRemoveDeviceDisabled", IsRemoveDeviceDisabled);
            writer.WriteObjectValue<MimeContent>("landingPageCustomizedImage", LandingPageCustomizedImage);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("sendDeviceOwnershipChangePushNotification", SendDeviceOwnershipChangePushNotification);
            writer.WriteBoolValue("showAzureADEnterpriseApps", ShowAzureADEnterpriseApps);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteBoolValue("showOfficeWebApps", ShowOfficeWebApps);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
