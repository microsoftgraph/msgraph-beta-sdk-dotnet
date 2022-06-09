using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(AdvancedThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(AdvancedThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceThreatProtectionEnabled)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionEnabled), value); }
        }
        /// <summary>Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>(nameof(DeviceThreatProtectionRequiredSecurityLevel)); }
            set { BackingStore?.Set(nameof(DeviceThreatProtectionRequiredSecurityLevel), value); }
        }
        /// <summary>Corresponds to the &apos;Block all incoming connections&apos; option.</summary>
        public bool? FirewallBlockAllIncoming {
            get { return BackingStore?.Get<bool?>(nameof(FirewallBlockAllIncoming)); }
            set { BackingStore?.Set(nameof(FirewallBlockAllIncoming), value); }
        }
        /// <summary>Whether the firewall should be enabled or not.</summary>
        public bool? FirewallEnabled {
            get { return BackingStore?.Get<bool?>(nameof(FirewallEnabled)); }
            set { BackingStore?.Set(nameof(FirewallEnabled), value); }
        }
        /// <summary>Corresponds to &apos;Enable stealth mode.&apos;</summary>
        public bool? FirewallEnableStealthMode {
            get { return BackingStore?.Get<bool?>(nameof(FirewallEnableStealthMode)); }
            set { BackingStore?.Set(nameof(FirewallEnableStealthMode), value); }
        }
        /// <summary>System and Privacy setting that determines which download locations apps can be run from on a macOS device. Possible values are: notConfigured, macAppStore, macAppStoreAndIdentifiedDevelopers, anywhere.</summary>
        public MacOSGatekeeperAppSources? GatekeeperAllowedAppSource {
            get { return BackingStore?.Get<MacOSGatekeeperAppSources?>(nameof(GatekeeperAllowedAppSource)); }
            set { BackingStore?.Set(nameof(GatekeeperAllowedAppSource), value); }
        }
        /// <summary>Maximum MacOS build version.</summary>
        public string OsMaximumBuildVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumBuildVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumBuildVersion), value); }
        }
        /// <summary>Maximum MacOS version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum MacOS build version.</summary>
        public string OsMinimumBuildVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumBuildVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumBuildVersion), value); }
        }
        /// <summary>Minimum MacOS version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Indicates whether or not to block simple passwords.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockSimple)); }
            set { BackingStore?.Set(nameof(PasswordBlockSimple), value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 65535</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>Minimum length of password. Valid values 4 to 14</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Whether or not to require a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequired)); }
            set { BackingStore?.Set(nameof(PasswordRequired), value); }
        }
        /// <summary>The required password type. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasswordRequiredType)); }
            set { BackingStore?.Set(nameof(PasswordRequiredType), value); }
        }
        /// <summary>Require encryption on Mac OS devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>Require that devices have enabled system integrity protection.</summary>
        public bool? SystemIntegrityProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(SystemIntegrityProtectionEnabled)); }
            set { BackingStore?.Set(nameof(SystemIntegrityProtectionEnabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"firewallBlockAllIncoming", n => { FirewallBlockAllIncoming = n.GetBoolValue(); } },
                {"firewallEnabled", n => { FirewallEnabled = n.GetBoolValue(); } },
                {"firewallEnableStealthMode", n => { FirewallEnableStealthMode = n.GetBoolValue(); } },
                {"gatekeeperAllowedAppSource", n => { GatekeeperAllowedAppSource = n.GetEnumValue<MacOSGatekeeperAppSources>(); } },
                {"osMaximumBuildVersion", n => { OsMaximumBuildVersion = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumBuildVersion", n => { OsMinimumBuildVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
                {"systemIntegrityProtectionEnabled", n => { SystemIntegrityProtectionEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("advancedThreatProtectionRequiredSecurityLevel", AdvancedThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("firewallBlockAllIncoming", FirewallBlockAllIncoming);
            writer.WriteBoolValue("firewallEnabled", FirewallEnabled);
            writer.WriteBoolValue("firewallEnableStealthMode", FirewallEnableStealthMode);
            writer.WriteEnumValue<MacOSGatekeeperAppSources>("gatekeeperAllowedAppSource", GatekeeperAllowedAppSource);
            writer.WriteStringValue("osMaximumBuildVersion", OsMaximumBuildVersion);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumBuildVersion", OsMinimumBuildVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
            writer.WriteBoolValue("systemIntegrityProtectionEnabled", SystemIntegrityProtectionEnabled);
        }
    }
}
