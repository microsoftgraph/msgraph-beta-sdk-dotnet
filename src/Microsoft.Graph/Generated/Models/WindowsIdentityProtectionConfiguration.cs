using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsIdentityProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Boolean value used to enable enhanced anti-spoofing for facial feature recognition on Windows Hello face authentication.</summary>
        public bool? EnhancedAntiSpoofingForFacialFeaturesEnabled {
            get { return BackingStore?.Get<bool?>(nameof(EnhancedAntiSpoofingForFacialFeaturesEnabled)); }
            set { BackingStore?.Set(nameof(EnhancedAntiSpoofingForFacialFeaturesEnabled), value); }
        }
        /// <summary>Integer value specifies the period (in days) that a PIN can be used before the system requires the user to change it. Valid values are 0 to 730 inclusive. Valid values 0 to 730</summary>
        public int? PinExpirationInDays {
            get { return BackingStore?.Get<int?>(nameof(PinExpirationInDays)); }
            set { BackingStore?.Set(nameof(PinExpirationInDays), value); }
        }
        /// <summary>This value configures the use of lowercase characters in the Windows Hello for Business PIN. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? PinLowercaseCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(PinLowercaseCharactersUsage)); }
            set { BackingStore?.Set(nameof(PinLowercaseCharactersUsage), value); }
        }
        /// <summary>Integer value that sets the maximum number of characters allowed for the work PIN. Valid values are 4 to 127 inclusive and greater than or equal to the value set for the minimum PIN. Valid values 4 to 127</summary>
        public int? PinMaximumLength {
            get { return BackingStore?.Get<int?>(nameof(PinMaximumLength)); }
            set { BackingStore?.Set(nameof(PinMaximumLength), value); }
        }
        /// <summary>Integer value that sets the minimum number of characters required for the Windows Hello for Business PIN. Valid values are 4 to 127 inclusive and less than or equal to the value set for the maximum PIN. Valid values 4 to 127</summary>
        public int? PinMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PinMinimumLength)); }
            set { BackingStore?.Set(nameof(PinMinimumLength), value); }
        }
        /// <summary>Controls the ability to prevent users from using past PINs. This must be set between 0 and 50, inclusive, and the current PIN of the user is included in that count. If set to 0, previous PINs are not stored. PIN history is not preserved through a PIN reset. Valid values 0 to 50</summary>
        public int? PinPreviousBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PinPreviousBlockCount)); }
            set { BackingStore?.Set(nameof(PinPreviousBlockCount), value); }
        }
        /// <summary>Boolean value that enables a user to change their PIN by using the Windows Hello for Business PIN recovery service.</summary>
        public bool? PinRecoveryEnabled {
            get { return BackingStore?.Get<bool?>(nameof(PinRecoveryEnabled)); }
            set { BackingStore?.Set(nameof(PinRecoveryEnabled), value); }
        }
        /// <summary>Controls the ability to use special characters in the Windows Hello for Business PIN. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? PinSpecialCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(PinSpecialCharactersUsage)); }
            set { BackingStore?.Set(nameof(PinSpecialCharactersUsage), value); }
        }
        /// <summary>This value configures the use of uppercase characters in the Windows Hello for Business PIN. Possible values are: blocked, required, allowed, notConfigured.</summary>
        public ConfigurationUsage? PinUppercaseCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>(nameof(PinUppercaseCharactersUsage)); }
            set { BackingStore?.Set(nameof(PinUppercaseCharactersUsage), value); }
        }
        /// <summary>Controls whether to require a Trusted Platform Module (TPM) for provisioning Windows Hello for Business. A TPM provides an additional security benefit in that data stored on it cannot be used on other devices. If set to False, all devices can provision Windows Hello for Business even if there is not a usable TPM.</summary>
        public bool? SecurityDeviceRequired {
            get { return BackingStore?.Get<bool?>(nameof(SecurityDeviceRequired)); }
            set { BackingStore?.Set(nameof(SecurityDeviceRequired), value); }
        }
        /// <summary>Controls the use of biometric gestures, such as face and fingerprint, as an alternative to the Windows Hello for Business PIN.  If set to False, biometric gestures are not allowed. Users must still configure a PIN as a backup in case of failures.</summary>
        public bool? UnlockWithBiometricsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UnlockWithBiometricsEnabled)); }
            set { BackingStore?.Set(nameof(UnlockWithBiometricsEnabled), value); }
        }
        /// <summary>Boolean value that enables Windows Hello for Business to use certificates to authenticate on-premise resources.</summary>
        public bool? UseCertificatesForOnPremisesAuthEnabled {
            get { return BackingStore?.Get<bool?>(nameof(UseCertificatesForOnPremisesAuthEnabled)); }
            set { BackingStore?.Set(nameof(UseCertificatesForOnPremisesAuthEnabled), value); }
        }
        /// <summary>Boolean value used to enable the Windows Hello security key as a logon credential.</summary>
        public bool? UseSecurityKeyForSignin {
            get { return BackingStore?.Get<bool?>(nameof(UseSecurityKeyForSignin)); }
            set { BackingStore?.Set(nameof(UseSecurityKeyForSignin), value); }
        }
        /// <summary>Boolean value that blocks Windows Hello for Business as a method for signing into Windows.</summary>
        public bool? WindowsHelloForBusinessBlocked {
            get { return BackingStore?.Get<bool?>(nameof(WindowsHelloForBusinessBlocked)); }
            set { BackingStore?.Set(nameof(WindowsHelloForBusinessBlocked), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsIdentityProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsIdentityProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enhancedAntiSpoofingForFacialFeaturesEnabled", n => { EnhancedAntiSpoofingForFacialFeaturesEnabled = n.GetBoolValue(); } },
                {"pinExpirationInDays", n => { PinExpirationInDays = n.GetIntValue(); } },
                {"pinLowercaseCharactersUsage", n => { PinLowercaseCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"pinMaximumLength", n => { PinMaximumLength = n.GetIntValue(); } },
                {"pinMinimumLength", n => { PinMinimumLength = n.GetIntValue(); } },
                {"pinPreviousBlockCount", n => { PinPreviousBlockCount = n.GetIntValue(); } },
                {"pinRecoveryEnabled", n => { PinRecoveryEnabled = n.GetBoolValue(); } },
                {"pinSpecialCharactersUsage", n => { PinSpecialCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"pinUppercaseCharactersUsage", n => { PinUppercaseCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"securityDeviceRequired", n => { SecurityDeviceRequired = n.GetBoolValue(); } },
                {"unlockWithBiometricsEnabled", n => { UnlockWithBiometricsEnabled = n.GetBoolValue(); } },
                {"useCertificatesForOnPremisesAuthEnabled", n => { UseCertificatesForOnPremisesAuthEnabled = n.GetBoolValue(); } },
                {"useSecurityKeyForSignin", n => { UseSecurityKeyForSignin = n.GetBoolValue(); } },
                {"windowsHelloForBusinessBlocked", n => { WindowsHelloForBusinessBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enhancedAntiSpoofingForFacialFeaturesEnabled", EnhancedAntiSpoofingForFacialFeaturesEnabled);
            writer.WriteIntValue("pinExpirationInDays", PinExpirationInDays);
            writer.WriteEnumValue<ConfigurationUsage>("pinLowercaseCharactersUsage", PinLowercaseCharactersUsage);
            writer.WriteIntValue("pinMaximumLength", PinMaximumLength);
            writer.WriteIntValue("pinMinimumLength", PinMinimumLength);
            writer.WriteIntValue("pinPreviousBlockCount", PinPreviousBlockCount);
            writer.WriteBoolValue("pinRecoveryEnabled", PinRecoveryEnabled);
            writer.WriteEnumValue<ConfigurationUsage>("pinSpecialCharactersUsage", PinSpecialCharactersUsage);
            writer.WriteEnumValue<ConfigurationUsage>("pinUppercaseCharactersUsage", PinUppercaseCharactersUsage);
            writer.WriteBoolValue("securityDeviceRequired", SecurityDeviceRequired);
            writer.WriteBoolValue("unlockWithBiometricsEnabled", UnlockWithBiometricsEnabled);
            writer.WriteBoolValue("useCertificatesForOnPremisesAuthEnabled", UseCertificatesForOnPremisesAuthEnabled);
            writer.WriteBoolValue("useSecurityKeyForSignin", UseSecurityKeyForSignin);
            writer.WriteBoolValue("windowsHelloForBusinessBlocked", WindowsHelloForBusinessBlocked);
        }
    }
}
