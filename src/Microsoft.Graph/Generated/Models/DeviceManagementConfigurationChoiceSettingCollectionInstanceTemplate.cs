using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Linked policy may append values which are not present in the template.</summary>
        public bool? AllowUnmanagedValues {
            get { return BackingStore?.Get<bool?>("allowUnmanagedValues"); }
            set { BackingStore?.Set("allowUnmanagedValues", value); }
        }
        /// <summary>Choice Setting Collection Value Template</summary>
        public List<DeviceManagementConfigurationChoiceSettingValueTemplate> ChoiceSettingCollectionValueTemplate {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationChoiceSettingValueTemplate>>("choiceSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("choiceSettingCollectionValueTemplate", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingCollectionInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowUnmanagedValues", n => { AllowUnmanagedValues = n.GetBoolValue(); } },
                {"choiceSettingCollectionValueTemplate", n => { ChoiceSettingCollectionValueTemplate = n.GetCollectionOfObjectValues<DeviceManagementConfigurationChoiceSettingValueTemplate>(DeviceManagementConfigurationChoiceSettingValueTemplate.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationChoiceSettingValueTemplate>("choiceSettingCollectionValueTemplate", ChoiceSettingCollectionValueTemplate);
        }
    }
}
