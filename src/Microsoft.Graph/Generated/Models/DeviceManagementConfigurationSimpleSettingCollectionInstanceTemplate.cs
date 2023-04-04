using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate : DeviceManagementConfigurationSettingInstanceTemplate, IParsable {
        /// <summary>Linked policy may append values which are not present in the template.</summary>
        public bool? AllowUnmanagedValues {
            get { return BackingStore?.Get<bool?>("allowUnmanagedValues"); }
            set { BackingStore?.Set("allowUnmanagedValues", value); }
        }
        /// <summary>Simple Setting Collection Value Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationSimpleSettingValueTemplate>? SimpleSettingCollectionValueTemplate {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSimpleSettingValueTemplate>?>("simpleSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("simpleSettingCollectionValueTemplate", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationSimpleSettingValueTemplate> SimpleSettingCollectionValueTemplate {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSimpleSettingValueTemplate>>("simpleSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("simpleSettingCollectionValueTemplate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowUnmanagedValues", n => { AllowUnmanagedValues = n.GetBoolValue(); } },
                {"simpleSettingCollectionValueTemplate", n => { SimpleSettingCollectionValueTemplate = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSimpleSettingValueTemplate>(DeviceManagementConfigurationSimpleSettingValueTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowUnmanagedValues", AllowUnmanagedValues);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSimpleSettingValueTemplate>("simpleSettingCollectionValueTemplate", SimpleSettingCollectionValueTemplate);
        }
    }
}
