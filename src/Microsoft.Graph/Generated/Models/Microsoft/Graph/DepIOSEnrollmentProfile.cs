using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DepIOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Apperance screen is disabled</summary>
        public bool? AppearanceScreenDisabled { get; set; }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation { get; set; }
        /// <summary>Carrier URL for activating device eSIM.</summary>
        public string CarrierActivationUrl { get; set; }
        /// <summary>If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. 'enableAuthenticationViaCompanyPortal' must be set in order for this property to be set.</summary>
        public string CompanyPortalVppTokenId { get; set; }
        /// <summary>Indicates if Device To Device Migration is disabled</summary>
        public bool? DeviceToDeviceMigrationDisabled { get; set; }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad { get; set; }
        /// <summary>Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. 'enableAuthenticationViaCompanyPortal' and 'companyPortalVppTokenId' must be set for this property to be set.</summary>
        public bool? EnableSingleAppEnrollmentMode { get; set; }
        /// <summary>Indicates if Express Language screen is disabled</summary>
        public bool? ExpressLanguageScreenDisabled { get; set; }
        /// <summary>Indicates if temporary sessions is enabled</summary>
        public bool? ForceTemporarySession { get; set; }
        /// <summary>Indicates if home button sensitivity screen is disabled</summary>
        public bool? HomeButtonScreenDisabled { get; set; }
        /// <summary>Indicates if iMessage and FaceTime screen is disabled</summary>
        public bool? IMessageAndFaceTimeScreenDisabled { get; set; }
        /// <summary>Indicates the iTunes pairing mode. Possible values are: disallow, allow, requiresCertificate.</summary>
        public ITunesPairingMode? ITunesPairingMode { get; set; }
        /// <summary>Management certificates for Apple Configurator</summary>
        public List<ManagementCertificateWithThumbprint> ManagementCertificates { get; set; }
        /// <summary>Indicates if onboarding setup screen is disabled</summary>
        public bool? OnBoardingScreenDisabled { get; set; }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled { get; set; }
        /// <summary>Indicates timeout before locked screen requires the user to enter the device passocde to unlock it</summary>
        public int? PasscodeLockGracePeriodInSeconds { get; set; }
        /// <summary>Indicates if Preferred language screen is disabled</summary>
        public bool? PreferredLanguageScreenDisabled { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? RestoreCompletedScreenDisabled { get; set; }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled { get; set; }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount { get; set; }
        /// <summary>Indicates if the SIMSetup screen is disabled</summary>
        public bool? SimSetupScreenDisabled { get; set; }
        /// <summary>Indicates if the mandatory sofware update screen is disabled</summary>
        public bool? SoftwareUpdateScreenDisabled { get; set; }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? TemporarySessionTimeoutInSeconds { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? UpdateCompleteScreenDisabled { get; set; }
        /// <summary>Indicates that this apple device is designated to support 'shared device mode' scenarios. This is distinct from the 'shared iPad' scenario. See Shared iOS and iPadOS devices.</summary>
        public bool? UserlessSharedAadModeEnabled { get; set; }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? UserSessionTimeoutInSeconds { get; set; }
        /// <summary>Indicates if the watch migration screen is disabled</summary>
        public bool? WatchMigrationScreenDisabled { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? WelcomeScreenDisabled { get; set; }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appearanceScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).AppearanceScreenDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", (o,n) => { (o as DepIOSEnrollmentProfile).AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"carrierActivationUrl", (o,n) => { (o as DepIOSEnrollmentProfile).CarrierActivationUrl = n.GetStringValue(); } },
                {"companyPortalVppTokenId", (o,n) => { (o as DepIOSEnrollmentProfile).CompanyPortalVppTokenId = n.GetStringValue(); } },
                {"deviceToDeviceMigrationDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).DeviceToDeviceMigrationDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", (o,n) => { (o as DepIOSEnrollmentProfile).EnableSharedIPad = n.GetBoolValue(); } },
                {"enableSingleAppEnrollmentMode", (o,n) => { (o as DepIOSEnrollmentProfile).EnableSingleAppEnrollmentMode = n.GetBoolValue(); } },
                {"expressLanguageScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).ExpressLanguageScreenDisabled = n.GetBoolValue(); } },
                {"forceTemporarySession", (o,n) => { (o as DepIOSEnrollmentProfile).ForceTemporarySession = n.GetBoolValue(); } },
                {"homeButtonScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).HomeButtonScreenDisabled = n.GetBoolValue(); } },
                {"iMessageAndFaceTimeScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).IMessageAndFaceTimeScreenDisabled = n.GetBoolValue(); } },
                {"iTunesPairingMode", (o,n) => { (o as DepIOSEnrollmentProfile).ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"managementCertificates", (o,n) => { (o as DepIOSEnrollmentProfile).ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>().ToList(); } },
                {"onBoardingScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).OnBoardingScreenDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).PassCodeDisabled = n.GetBoolValue(); } },
                {"passcodeLockGracePeriodInSeconds", (o,n) => { (o as DepIOSEnrollmentProfile).PasscodeLockGracePeriodInSeconds = n.GetIntValue(); } },
                {"preferredLanguageScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).PreferredLanguageScreenDisabled = n.GetBoolValue(); } },
                {"restoreCompletedScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).RestoreCompletedScreenDisabled = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", (o,n) => { (o as DepIOSEnrollmentProfile).SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"simSetupScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).SimSetupScreenDisabled = n.GetBoolValue(); } },
                {"softwareUpdateScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).SoftwareUpdateScreenDisabled = n.GetBoolValue(); } },
                {"temporarySessionTimeoutInSeconds", (o,n) => { (o as DepIOSEnrollmentProfile).TemporarySessionTimeoutInSeconds = n.GetIntValue(); } },
                {"updateCompleteScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).UpdateCompleteScreenDisabled = n.GetBoolValue(); } },
                {"userlessSharedAadModeEnabled", (o,n) => { (o as DepIOSEnrollmentProfile).UserlessSharedAadModeEnabled = n.GetBoolValue(); } },
                {"userSessionTimeoutInSeconds", (o,n) => { (o as DepIOSEnrollmentProfile).UserSessionTimeoutInSeconds = n.GetIntValue(); } },
                {"watchMigrationScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).WatchMigrationScreenDisabled = n.GetBoolValue(); } },
                {"welcomeScreenDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).WelcomeScreenDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", (o,n) => { (o as DepIOSEnrollmentProfile).ZoomDisabled = n.GetBoolValue(); } },
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
