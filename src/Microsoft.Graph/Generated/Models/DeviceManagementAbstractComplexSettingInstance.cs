using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementAbstractComplexSettingInstance : DeviceManagementSettingInstance, IParsable {
        /// <summary>The definition ID for the chosen implementation of this complex setting</summary>
        public string ImplementationId {
            get { return BackingStore?.Get<string>("implementationId"); }
            set { BackingStore?.Set("implementationId", value); }
        }
        /// <summary>The values that make up the complex setting</summary>
        public List<DeviceManagementSettingInstance> Value {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementAbstractComplexSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementAbstractComplexSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementAbstractComplexSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementAbstractComplexSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementAbstractComplexSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"implementationId", n => { ImplementationId = n.GetStringValue(); } },
                {"value", n => { Value = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("implementationId", ImplementationId);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("value", Value);
        }
    }
}
