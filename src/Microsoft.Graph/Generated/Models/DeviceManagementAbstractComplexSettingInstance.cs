using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementAbstractComplexSettingInstance : DeviceManagementSettingInstance, IParsable {
        /// <summary>The definition ID for the chosen implementation of this complex setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ImplementationId {
            get { return BackingStore?.Get<string?>("implementationId"); }
            set { BackingStore?.Set("implementationId", value); }
        }
#else
        public string ImplementationId {
            get { return BackingStore?.Get<string>("implementationId"); }
            set { BackingStore?.Set("implementationId", value); }
        }
#endif
        /// <summary>The values that make up the complex setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementSettingInstance>? Value {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#else
        public List<DeviceManagementSettingInstance> Value {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementAbstractComplexSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementAbstractComplexSettingInstance() : base() {
            OdataType = "#microsoft.graph.deviceManagementAbstractComplexSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"value", n => { Value = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("implementationId", ImplementationId);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("value", Value);
        }
    }
}
