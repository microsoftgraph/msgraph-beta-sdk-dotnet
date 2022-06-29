using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSecretSettingValue : DeviceManagementConfigurationSimpleSettingValue, IParsable {
        /// <summary>Value of the secret setting.</summary>
        public string Value {
            get { return BackingStore?.Get<string>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
        /// <summary>Gets or sets a value indicating the encryption state of the Value property. Possible values are: invalid, notEncrypted, encryptedValueToken.</summary>
        public DeviceManagementConfigurationSecretSettingValueState? ValueState {
            get { return BackingStore?.Get<DeviceManagementConfigurationSecretSettingValueState?>(nameof(ValueState)); }
            set { BackingStore?.Set(nameof(ValueState), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSecretSettingValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSecretSettingValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetStringValue(); } },
                {"valueState", n => { ValueState = n.GetEnumValue<DeviceManagementConfigurationSecretSettingValueState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("value", Value);
            writer.WriteEnumValue<DeviceManagementConfigurationSecretSettingValueState>("valueState", ValueState);
        }
    }
}
