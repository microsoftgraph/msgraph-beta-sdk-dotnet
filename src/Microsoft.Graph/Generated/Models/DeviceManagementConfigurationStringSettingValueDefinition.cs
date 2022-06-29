using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationStringSettingValueDefinition : DeviceManagementConfigurationSettingValueDefinition, IParsable {
        /// <summary>Pre-defined format of the string. Possible values are: none, email, guid, ip, base64, url, version, xml, date, time, binary, regEx, json, dateTime, surfaceHub.</summary>
        public DeviceManagementConfigurationStringFormat? Format {
            get { return BackingStore?.Get<DeviceManagementConfigurationStringFormat?>(nameof(Format)); }
            set { BackingStore?.Set(nameof(Format), value); }
        }
        /// <summary>Regular expression or any xml or json schema that the input string should match</summary>
        public string InputValidationSchema {
            get { return BackingStore?.Get<string>(nameof(InputValidationSchema)); }
            set { BackingStore?.Set(nameof(InputValidationSchema), value); }
        }
        /// <summary>Specifies whether the setting needs to be treated as a secret. Settings marked as yes will be encrypted in transit and at rest and will be displayed as asterisks when represented in the UX.</summary>
        public bool? IsSecret {
            get { return BackingStore?.Get<bool?>(nameof(IsSecret)); }
            set { BackingStore?.Set(nameof(IsSecret), value); }
        }
        /// <summary>Maximum length of string. Valid values 0 to 87516</summary>
        public long? MaximumLength {
            get { return BackingStore?.Get<long?>(nameof(MaximumLength)); }
            set { BackingStore?.Set(nameof(MaximumLength), value); }
        }
        /// <summary>Minimum length of string. Valid values 0 to 87516</summary>
        public long? MinimumLength {
            get { return BackingStore?.Get<long?>(nameof(MinimumLength)); }
            set { BackingStore?.Set(nameof(MinimumLength), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationStringSettingValueDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationStringSettingValueDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"format", n => { Format = n.GetEnumValue<DeviceManagementConfigurationStringFormat>(); } },
                {"inputValidationSchema", n => { InputValidationSchema = n.GetStringValue(); } },
                {"isSecret", n => { IsSecret = n.GetBoolValue(); } },
                {"maximumLength", n => { MaximumLength = n.GetLongValue(); } },
                {"minimumLength", n => { MinimumLength = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementConfigurationStringFormat>("format", Format);
            writer.WriteStringValue("inputValidationSchema", InputValidationSchema);
            writer.WriteBoolValue("isSecret", IsSecret);
            writer.WriteLongValue("maximumLength", MaximumLength);
            writer.WriteLongValue("minimumLength", MinimumLength);
        }
    }
}
