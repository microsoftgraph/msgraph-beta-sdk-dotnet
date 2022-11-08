using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementComplexSettingDefinition : DeviceManagementSettingDefinition, IParsable {
        /// <summary>The definitions of each property of the complex setting</summary>
        public List<string> PropertyDefinitionIds {
            get { return BackingStore?.Get<List<string>>("propertyDefinitionIds"); }
            set { BackingStore?.Set("propertyDefinitionIds", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementComplexSettingDefinition and sets the default values.
        /// </summary>
        public DeviceManagementComplexSettingDefinition() : base() {
            OdataType = "#microsoft.graph.deviceManagementComplexSettingDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementComplexSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementComplexSettingDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"propertyDefinitionIds", n => { PropertyDefinitionIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("propertyDefinitionIds", PropertyDefinitionIds);
        }
    }
}
