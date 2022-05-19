using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The DepIOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to iOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.</summary>
    public class DepIOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Apperance screen is disabled</summary>
        public bool? AppearanceScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(AppearanceScreenDisabled)); }
            set { BackingStore?.Set(nameof(AppearanceScreenDisabled), value); }
        }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation {
            get { return BackingStore?.Get<bool?>(nameof(AwaitDeviceConfiguredConfirmation)); }
            set { BackingStore?.Set(nameof(AwaitDeviceConfiguredConfirmation), value); }
        }
        /// <summary>Carrier URL for activating device eSIM.</summary>
        public string CarrierActivationUrl {
            get { return BackingStore?.Get<string>(nameof(CarrierActivationUrl)); }
            set { BackingStore?.Set(nameof(CarrierActivationUrl), value); }
        }
        /// <summary>If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. &apos;enableAuthenticationViaCompanyPortal&apos; must be set in order for this property to be set.</summary>
        public string CompanyPortalVppTokenId {
            get { return BackingStore?.Get<string>(nameof(CompanyPortalVppTokenId)); }
            set { BackingStore?.Set(nameof(CompanyPortalVppTokenId), value); }
        }
        /// <summary>Indicates if Device To Device Migration is disabled</summary>
        public bool? DeviceToDeviceMigrationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceToDeviceMigrationDisabled)); }
            set { BackingStore?.Set(nameof(DeviceToDeviceMigrationDisabled), value); }
        }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad {
            get { return BackingStore?.Get<bool?>(nameof(EnableSharedIPad)); }
            set { BackingStore?.Set(nameof(EnableSharedIPad), value); }
        }
        /// <summary>Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. &apos;enableAuthenticationViaCompanyPortal&apos; and &apos;companyPortalVppTokenId&apos; must be set for this property to be set.</summary>
        public bool? EnableSingleAppEnrollmentMode {
            get { return BackingStore?.Get<bool?>(nameof(EnableSingleAppEnrollmentMode)); }
            set { BackingStore?.Set(nameof(EnableSingleAppEnrollmentMode), value); }
        }
        /// <summary>Indicates if Express Language screen is disabled</summary>
        public bool? ExpressLanguageScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ExpressLanguageScreenDisabled)); }
            set { BackingStore?.Set(nameof(ExpressLanguageScreenDisabled), value); }
        }
        /// <summary>Indicates if temporary sessions is enabled</summary>
        public bool? ForceTemporarySession {
            get { return BackingStore?.Get<bool?>(nameof(ForceTemporarySession)); }
            set { BackingStore?.Set(nameof(ForceTemporarySession), value); }
        }
        /// <summary>Indicates if home button sensitivity screen is disabled</summary>
        public bool? HomeButtonScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(HomeButtonScreenDisabled)); }
            set { BackingStore?.Set(nameof(HomeButtonScreenDisabled), value); }
        }
        /// <summary>Indicates if iMessage and FaceTime screen is disabled</summary>
        public bool? IMessageAndFaceTimeScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(IMessageAndFaceTimeScreenDisabled)); }
            set { BackingStore?.Set(nameof(IMessageAndFaceTimeScreenDisabled), value); }
        }
        /// <summary>Indicates the iTunes pairing mode. Possible values are: disallow, allow, requiresCertificate.</summary>
        public Microsoft.Graph.Beta.Models.ITunesPairingMode? ITunesPairingMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ITunesPairingMode?>(nameof(ITunesPairingMode)); }
            set { BackingStore?.Set(nameof(ITunesPairingMode), value); }
        }
        /// <summary>Management certificates for Apple Configurator</summary>
        public List<ManagementCertificateWithThumbprint> ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>>(nameof(ManagementCertificates)); }
            set { BackingStore?.Set(nameof(ManagementCertificates), value); }
        }
        /// <summary>Indicates if onboarding setup screen is disabled</summary>
        public bool? OnBoardingScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(OnBoardingScreenDisabled)); }
            set { BackingStore?.Set(nameof(OnBoardingScreenDisabled), value); }
        }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>(nameof(PassCodeDisabled)); }
            set { BackingStore?.Set(nameof(PassCodeDisabled), value); }
        }
        /// <summary>Indicates timeout before locked screen requires the user to enter the device passocde to unlock it</summary>
        public int? PasscodeLockGracePeriodInSeconds {
            get { return BackingStore?.Get<int?>(nameof(PasscodeLockGracePeriodInSeconds)); }
            set { BackingStore?.Set(nameof(PasscodeLockGracePeriodInSeconds), value); }
        }
        /// <summary>Indicates if Preferred language screen is disabled</summary>
        public bool? PreferredLanguageScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(PreferredLanguageScreenDisabled)); }
            set { BackingStore?.Set(nameof(PreferredLanguageScreenDisabled), value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? RestoreCompletedScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(RestoreCompletedScreenDisabled)); }
            set { BackingStore?.Set(nameof(RestoreCompletedScreenDisabled), value); }
        }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled {
            get { return BackingStore?.Get<bool?>(nameof(RestoreFromAndroidDisabled)); }
            set { BackingStore?.Set(nameof(RestoreFromAndroidDisabled), value); }
        }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount {
            get { return BackingStore?.Get<int?>(nameof(SharedIPadMaximumUserCount)); }
            set { BackingStore?.Set(nameof(SharedIPadMaximumUserCount), value); }
        }
        /// <summary>Indicates if the SIMSetup screen is disabled</summary>
        public bool? SimSetupScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(SimSetupScreenDisabled)); }
            set { BackingStore?.Set(nameof(SimSetupScreenDisabled), value); }
        }
        /// <summary>Indicates if the mandatory sofware update screen is disabled</summary>
        public bool? SoftwareUpdateScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(SoftwareUpdateScreenDisabled)); }
            set { BackingStore?.Set(nameof(SoftwareUpdateScreenDisabled), value); }
        }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? TemporarySessionTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(TemporarySessionTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(TemporarySessionTimeoutInSeconds), value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? UpdateCompleteScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(UpdateCompleteScreenDisabled)); }
            set { BackingStore?.Set(nameof(UpdateCompleteScreenDisabled), value); }
        }
        /// <summary>Indicates that this apple device is designated to support &apos;shared device mode&apos; scenarios. This is distinct from the &apos;shared iPad&apos; scenario. See https://docs.microsoft.com/mem/intune/enrollment/device-enrollment-shared-ios</summary>
        public bool? UserlessSharedAadModeEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UserlessSharedAadModeEnabled)); }
            set { BackingStore?.Set(nameof(UserlessSharedAadModeEnabled), value); }
        }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? UserSessionTimeoutInSeconds {
            get { return BackingStore?.Get<int?>(nameof(UserSessionTimeoutInSeconds)); }
            set { BackingStore?.Set(nameof(UserSessionTimeoutInSeconds), value); }
        }
        /// <summary>Indicates if the watch migration screen is disabled</summary>
        public bool? WatchMigrationScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(WatchMigrationScreenDisabled)); }
            set { BackingStore?.Set(nameof(WatchMigrationScreenDisabled), value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? WelcomeScreenDisabled {
            get { return BackingStore?.Get<bool?>(nameof(WelcomeScreenDisabled)); }
            set { BackingStore?.Set(nameof(WelcomeScreenDisabled), value); }
        }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ZoomDisabled)); }
            set { BackingStore?.Set(nameof(ZoomDisabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DepIOSEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepIOSEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appearanceScreenDisabled", n => { AppearanceScreenDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"carrierActivationUrl", n => { CarrierActivationUrl = n.GetStringValue(); } },
                {"companyPortalVppTokenId", n => { CompanyPortalVppTokenId = n.GetStringValue(); } },
                {"deviceToDeviceMigrationDisabled", n => { DeviceToDeviceMigrationDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"enableSingleAppEnrollmentMode", n => { EnableSingleAppEnrollmentMode = n.GetBoolValue(); } },
                {"expressLanguageScreenDisabled", n => { ExpressLanguageScreenDisabled = n.GetBoolValue(); } },
                {"forceTemporarySession", n => { ForceTemporarySession = n.GetBoolValue(); } },
                {"homeButtonScreenDisabled", n => { HomeButtonScreenDisabled = n.GetBoolValue(); } },
                {"iMessageAndFaceTimeScreenDisabled", n => { IMessageAndFaceTimeScreenDisabled = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue).ToList(); } },
                {"onBoardingScreenDisabled", n => { OnBoardingScreenDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"passcodeLockGracePeriodInSeconds", n => { PasscodeLockGracePeriodInSeconds = n.GetIntValue(); } },
                {"preferredLanguageScreenDisabled", n => { PreferredLanguageScreenDisabled = n.GetBoolValue(); } },
                {"restoreCompletedScreenDisabled", n => { RestoreCompletedScreenDisabled = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"simSetupScreenDisabled", n => { SimSetupScreenDisabled = n.GetBoolValue(); } },
                {"softwareUpdateScreenDisabled", n => { SoftwareUpdateScreenDisabled = n.GetBoolValue(); } },
                {"temporarySessionTimeoutInSeconds", n => { TemporarySessionTimeoutInSeconds = n.GetIntValue(); } },
                {"updateCompleteScreenDisabled", n => { UpdateCompleteScreenDisabled = n.GetBoolValue(); } },
                {"userlessSharedAadModeEnabled", n => { UserlessSharedAadModeEnabled = n.GetBoolValue(); } },
                {"userSessionTimeoutInSeconds", n => { UserSessionTimeoutInSeconds = n.GetIntValue(); } },
                {"watchMigrationScreenDisabled", n => { WatchMigrationScreenDisabled = n.GetBoolValue(); } },
                {"welcomeScreenDisabled", n => { WelcomeScreenDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appearanceScreenDisabled", AppearanceScreenDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteStringValue("carrierActivationUrl", CarrierActivationUrl);
            writer.WriteStringValue("companyPortalVppTokenId", CompanyPortalVppTokenId);
            writer.WriteBoolValue("deviceToDeviceMigrationDisabled", DeviceToDeviceMigrationDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("enableSingleAppEnrollmentMode", EnableSingleAppEnrollmentMode);
            writer.WriteBoolValue("expressLanguageScreenDisabled", ExpressLanguageScreenDisabled);
            writer.WriteBoolValue("forceTemporarySession", ForceTemporarySession);
            writer.WriteBoolValue("homeButtonScreenDisabled", HomeButtonScreenDisabled);
            writer.WriteBoolValue("iMessageAndFaceTimeScreenDisabled", IMessageAndFaceTimeScreenDisabled);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("onBoardingScreenDisabled", OnBoardingScreenDisabled);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteIntValue("passcodeLockGracePeriodInSeconds", PasscodeLockGracePeriodInSeconds);
            writer.WriteBoolValue("preferredLanguageScreenDisabled", PreferredLanguageScreenDisabled);
            writer.WriteBoolValue("restoreCompletedScreenDisabled", RestoreCompletedScreenDisabled);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("simSetupScreenDisabled", SimSetupScreenDisabled);
            writer.WriteBoolValue("softwareUpdateScreenDisabled", SoftwareUpdateScreenDisabled);
            writer.WriteIntValue("temporarySessionTimeoutInSeconds", TemporarySessionTimeoutInSeconds);
            writer.WriteBoolValue("updateCompleteScreenDisabled", UpdateCompleteScreenDisabled);
            writer.WriteBoolValue("userlessSharedAadModeEnabled", UserlessSharedAadModeEnabled);
            writer.WriteIntValue("userSessionTimeoutInSeconds", UserSessionTimeoutInSeconds);
            writer.WriteBoolValue("watchMigrationScreenDisabled", WatchMigrationScreenDisabled);
            writer.WriteBoolValue("welcomeScreenDisabled", WelcomeScreenDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
