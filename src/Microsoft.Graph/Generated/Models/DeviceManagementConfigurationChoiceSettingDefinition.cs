using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationChoiceSettingDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>Default option for the choice setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultOptionId {
            get { return BackingStore?.Get<string?>("defaultOptionId"); }
            set { BackingStore?.Set("defaultOptionId", value); }
        }
#nullable restore
#else
        public string DefaultOptionId {
            get { return BackingStore?.Get<string>("defaultOptionId"); }
            set { BackingStore?.Set("defaultOptionId", value); }
        }
#endif
        /// <summary>Options for the setting that can be selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationOptionDefinition>? Options {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationOptionDefinition>?>("options"); }
            set { BackingStore?.Set("options", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationOptionDefinition> Options {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationOptionDefinition>>("options"); }
            set { BackingStore?.Set("options", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationChoiceSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionDefinition" => new DeviceManagementConfigurationChoiceSettingCollectionDefinition(),
                _ => new DeviceManagementConfigurationChoiceSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultOptionId", n => { DefaultOptionId = n.GetStringValue(); } },
                {"options", n => { Options = n.GetCollectionOfObjectValues<DeviceManagementConfigurationOptionDefinition>(DeviceManagementConfigurationOptionDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultOptionId", DefaultOptionId);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationOptionDefinition>("options", Options);
        }
    }
}
