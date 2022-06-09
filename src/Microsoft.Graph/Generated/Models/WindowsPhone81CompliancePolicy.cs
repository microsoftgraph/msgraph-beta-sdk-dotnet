using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81CompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Maximum Windows Phone version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMaximumVersion)); }
            set { BackingStore?.Set(nameof(OsMaximumVersion), value); }
        }
        /// <summary>Minimum Windows Phone version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>(nameof(OsMinimumVersion)); }
            set { BackingStore?.Set(nameof(OsMinimumVersion), value); }
        }
        /// <summary>Whether or not to block syncing the calendar.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockSimple)); }
            set { BackingStore?.Set(nameof(PasswordBlockSimple), value); }
        }
        /// <summary>Number of days before the password expires.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasswordMinimumCharacterSetCount), value); }
        }
        /// <summary>Minimum length of passwords.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasswordMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
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
        /// <summary>Require encryption on windows phone devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>(nameof(StorageRequireEncryption)); }
            set { BackingStore?.Set(nameof(StorageRequireEncryption), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhone81CompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81CompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
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
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
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
        }
    }
}
