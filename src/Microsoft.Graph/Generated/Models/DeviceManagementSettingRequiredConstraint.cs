using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingRequiredConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>List of value which means not configured for the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? NotConfiguredValue {
            get { return BackingStore?.Get<string?>("notConfiguredValue"); }
            set { BackingStore?.Set("notConfiguredValue", value); }
        }
#else
        public string NotConfiguredValue {
            get { return BackingStore?.Get<string>("notConfiguredValue"); }
            set { BackingStore?.Set("notConfiguredValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementSettingRequiredConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingRequiredConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingRequiredConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingRequiredConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingRequiredConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"notConfiguredValue", n => { NotConfiguredValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("notConfiguredValue", NotConfiguredValue);
        }
    }
}
