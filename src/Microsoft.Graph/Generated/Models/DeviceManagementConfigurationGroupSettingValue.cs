using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Value of the GroupSetting</summary>
    public class DeviceManagementConfigurationGroupSettingValue : DeviceManagementConfigurationSettingValue, IParsable {
        /// <summary>Collection of child setting instances contained within this GroupSetting</summary>
        public List<DeviceManagementConfigurationSettingInstance> Children {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingInstance>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationGroupSettingValue and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingValue() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationGroupSettingValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationGroupSettingValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"children", n => { Children = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingInstance>(DeviceManagementConfigurationSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingInstance>("children", Children);
        }
    }
}
