using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Base type for a setting instance</summary>
    public class DeviceManagementSettingInstance : Entity, IParsable {
        /// <summary>The ID of the setting definition for this instance</summary>
        public string DefinitionId {
            get { return BackingStore?.Get<string>("definitionId"); }
            set { BackingStore?.Set("definitionId", value); }
        }
        /// <summary>JSON representation of the value</summary>
        public string ValueJson {
            get { return BackingStore?.Get<string>("valueJson"); }
            set { BackingStore?.Set("valueJson", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementAbstractComplexSettingInstance" => new DeviceManagementAbstractComplexSettingInstance(),
                "#microsoft.graph.deviceManagementBooleanSettingInstance" => new DeviceManagementBooleanSettingInstance(),
                "#microsoft.graph.deviceManagementCollectionSettingInstance" => new DeviceManagementCollectionSettingInstance(),
                "#microsoft.graph.deviceManagementComplexSettingInstance" => new DeviceManagementComplexSettingInstance(),
                "#microsoft.graph.deviceManagementIntegerSettingInstance" => new DeviceManagementIntegerSettingInstance(),
                "#microsoft.graph.deviceManagementStringSettingInstance" => new DeviceManagementStringSettingInstance(),
                _ => new DeviceManagementSettingInstance(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definitionId", n => { DefinitionId = n.GetStringValue(); } },
                {"valueJson", n => { ValueJson = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteStringValue("valueJson", ValueJson);
        }
    }
}
