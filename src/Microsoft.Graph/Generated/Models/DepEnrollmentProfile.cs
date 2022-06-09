using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DepEnrollmentProfile : EnrollmentProfile, IParsable {
        /// <summary>Indicates if Apple id setup pane is disabled</summary>
        public bool? AppleIdDisabled {
            get { return BackingStore?.Get<bool?>(nameof(AppleIdDisabled)); }
            set { BackingStore?.Set(nameof(AppleIdDisabled), value); }
        }
        /// <summary>Indicates if Apple pay setup pane is disabled</summary>
        public bool? ApplePayDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ApplePayDisabled)); }
            set { BackingStore?.Set(nameof(ApplePayDisabled), value); }
        }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation {
            get { return BackingStore?.Get<bool?>(nameof(AwaitDeviceConfiguredConfirmation)); }
            set { BackingStore?.Set(nameof(AwaitDeviceConfiguredConfirmation), value); }
        }
        /// <summary>Indicates if diagnostics setup pane is disabled</summary>
        public bool? DiagnosticsDisabled {
            get { return BackingStore?.Get<bool?>(nameof(DiagnosticsDisabled)); }
            set { BackingStore?.Set(nameof(DiagnosticsDisabled), value); }
        }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad {
            get { return BackingStore?.Get<bool?>(nameof(EnableSharedIPad)); }
            set { BackingStore?.Set(nameof(EnableSharedIPad), value); }
        }
        /// <summary>Indicates if this is the default profile</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>Indicates if the profile is mandatory</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>(nameof(IsMandatory)); }
            set { BackingStore?.Set(nameof(IsMandatory), value); }
        }
        /// <summary>Indicates the iTunes pairing mode. Possible values are: disallow, allow, requiresCertificate.</summary>
        public Microsoft.Graph.Beta.Models.ITunesPairingMode? ITunesPairingMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ITunesPairingMode?>(nameof(ITunesPairingMode)); }
            set { BackingStore?.Set(nameof(ITunesPairingMode), value); }
        }
        /// <summary>Indicates if Location service setup pane is disabled</summary>
        public bool? LocationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(LocationDisabled)); }
            set { BackingStore?.Set(nameof(LocationDisabled), value); }
        }
        /// <summary>Indicates if Mac OS file vault is disabled</summary>
        public bool? MacOSFileVaultDisabled {
            get { return BackingStore?.Get<bool?>(nameof(MacOSFileVaultDisabled)); }
            set { BackingStore?.Set(nameof(MacOSFileVaultDisabled), value); }
        }
        /// <summary>Indicates if Mac OS registration is disabled</summary>
        public bool? MacOSRegistrationDisabled {
            get { return BackingStore?.Get<bool?>(nameof(MacOSRegistrationDisabled)); }
            set { BackingStore?.Set(nameof(MacOSRegistrationDisabled), value); }
        }
        /// <summary>Management certificates for Apple Configurator</summary>
        public List<ManagementCertificateWithThumbprint> ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>>(nameof(ManagementCertificates)); }
            set { BackingStore?.Set(nameof(ManagementCertificates), value); }
        }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>(nameof(PassCodeDisabled)); }
            set { BackingStore?.Set(nameof(PassCodeDisabled), value); }
        }
        /// <summary>Indicates if the profile removal option is disabled</summary>
        public bool? ProfileRemovalDisabled {
            get { return BackingStore?.Get<bool?>(nameof(ProfileRemovalDisabled)); }
            set { BackingStore?.Set(nameof(ProfileRemovalDisabled), value); }
        }
        /// <summary>Indicates if Restore setup pane is blocked</summary>
        public bool? RestoreBlocked {
            get { return BackingStore?.Get<bool?>(nameof(RestoreBlocked)); }
            set { BackingStore?.Set(nameof(RestoreBlocked), value); }
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
        /// <summary>Indicates if siri setup pane is disabled</summary>
        public bool? SiriDisabled {
            get { return BackingStore?.Get<bool?>(nameof(SiriDisabled)); }
            set { BackingStore?.Set(nameof(SiriDisabled), value); }
        }
        /// <summary>Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.</summary>
        public bool? SupervisedModeEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SupervisedModeEnabled)); }
            set { BackingStore?.Set(nameof(SupervisedModeEnabled), value); }
        }
        /// <summary>Support department information</summary>
        public string SupportDepartment {
            get { return BackingStore?.Get<string>(nameof(SupportDepartment)); }
            set { BackingStore?.Set(nameof(SupportDepartment), value); }
        }
        /// <summary>Support phone number</summary>
        public string SupportPhoneNumber {
            get { return BackingStore?.Get<string>(nameof(SupportPhoneNumber)); }
            set { BackingStore?.Set(nameof(SupportPhoneNumber), value); }
        }
        /// <summary>Indicates if &apos;Terms and Conditions&apos; setup pane is disabled</summary>
        public bool? TermsAndConditionsDisabled {
            get { return BackingStore?.Get<bool?>(nameof(TermsAndConditionsDisabled)); }
            set { BackingStore?.Set(nameof(TermsAndConditionsDisabled), value); }
        }
        /// <summary>Indicates if touch id setup pane is disabled</summary>
        public bool? TouchIdDisabled {
            get { return BackingStore?.Get<bool?>(nameof(TouchIdDisabled)); }
            set { BackingStore?.Set(nameof(TouchIdDisabled), value); }
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
        public static new DepEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleIdDisabled", n => { AppleIdDisabled = n.GetBoolValue(); } },
                {"applePayDisabled", n => { ApplePayDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"diagnosticsDisabled", n => { DiagnosticsDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"locationDisabled", n => { LocationDisabled = n.GetBoolValue(); } },
                {"macOSFileVaultDisabled", n => { MacOSFileVaultDisabled = n.GetBoolValue(); } },
                {"macOSRegistrationDisabled", n => { MacOSRegistrationDisabled = n.GetBoolValue(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue).ToList(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"profileRemovalDisabled", n => { ProfileRemovalDisabled = n.GetBoolValue(); } },
                {"restoreBlocked", n => { RestoreBlocked = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"siriDisabled", n => { SiriDisabled = n.GetBoolValue(); } },
                {"supervisedModeEnabled", n => { SupervisedModeEnabled = n.GetBoolValue(); } },
                {"supportDepartment", n => { SupportDepartment = n.GetStringValue(); } },
                {"supportPhoneNumber", n => { SupportPhoneNumber = n.GetStringValue(); } },
                {"termsAndConditionsDisabled", n => { TermsAndConditionsDisabled = n.GetBoolValue(); } },
                {"touchIdDisabled", n => { TouchIdDisabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("appleIdDisabled", AppleIdDisabled);
            writer.WriteBoolValue("applePayDisabled", ApplePayDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteBoolValue("diagnosticsDisabled", DiagnosticsDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteBoolValue("locationDisabled", LocationDisabled);
            writer.WriteBoolValue("macOSFileVaultDisabled", MacOSFileVaultDisabled);
            writer.WriteBoolValue("macOSRegistrationDisabled", MacOSRegistrationDisabled);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteBoolValue("profileRemovalDisabled", ProfileRemovalDisabled);
            writer.WriteBoolValue("restoreBlocked", RestoreBlocked);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("siriDisabled", SiriDisabled);
            writer.WriteBoolValue("supervisedModeEnabled", SupervisedModeEnabled);
            writer.WriteStringValue("supportDepartment", SupportDepartment);
            writer.WriteStringValue("supportPhoneNumber", SupportPhoneNumber);
            writer.WriteBoolValue("termsAndConditionsDisabled", TermsAndConditionsDisabled);
            writer.WriteBoolValue("touchIdDisabled", TouchIdDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
