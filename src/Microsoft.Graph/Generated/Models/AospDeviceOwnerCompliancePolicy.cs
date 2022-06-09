using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Minimum Android security patch level.</summary>
        public string MinAndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>(nameof(MinAndroidSecurityPatchLevel)); }
            set { BackingStore?.Set(nameof(MinAndroidSecurityPatchLevel), value); }
        }
        /// <summary>Maximum Android version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum Android version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a password is required. Valid values 1 to 8640</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>Type of characters in password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Devices must not be jailbroken or rooted.</summary>
        public bool? SecurityBlockJailbrokenDevices {
            get { return BackingStore?.Get<bool?>(nameof(SecurityBlockJailbrokenDevices)); }
            set { BackingStore?.Set(nameof(SecurityBlockJailbrokenDevices), value); }
        }
        /// <summary>Require encryption on Android devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AospDeviceOwnerCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AospDeviceOwnerCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"securityBlockJailbrokenDevices", n => { SecurityBlockJailbrokenDevices = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("securityBlockJailbrokenDevices", SecurityBlockJailbrokenDevices);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
