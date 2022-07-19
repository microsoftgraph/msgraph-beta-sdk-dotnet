using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Linked policy may append values which are not present in the template.</summary>
        public bool? AllowUnmanagedValues {
            get { return BackingStore?.Get<bool?>("allowUnmanagedValues"); }
            set { BackingStore?.Set("allowUnmanagedValues", value); }
        }
        /// <summary>Group Setting Collection Value Template</summary>
        public List<DeviceManagementConfigurationGroupSettingValueTemplate> GroupSettingCollectionValueTemplate {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationGroupSettingValueTemplate>>("groupSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("groupSettingCollectionValueTemplate", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingCollectionInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationGroupSettingCollectionInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowUnmanagedValues", n => { AllowUnmanagedValues = n.GetBoolValue(); } },
                {"groupSettingCollectionValueTemplate", n => { GroupSettingCollectionValueTemplate = n.GetCollectionOfObjectValues<DeviceManagementConfigurationGroupSettingValueTemplate>(DeviceManagementConfigurationGroupSettingValueTemplate.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowUnmanagedValues", AllowUnmanagedValues);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationGroupSettingValueTemplate>("groupSettingCollectionValueTemplate", GroupSettingCollectionValueTemplate);
        }
    }
}
