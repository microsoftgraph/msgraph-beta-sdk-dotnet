using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingGroupDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>Dependent child settings to this group of settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ChildIds {
            get { return BackingStore?.Get<List<string>?>("childIds"); }
            set { BackingStore?.Set("childIds", value); }
        }
#nullable restore
#else
        public List<string> ChildIds {
            get { return BackingStore?.Get<List<string>>("childIds"); }
            set { BackingStore?.Set("childIds", value); }
        }
#endif
        /// <summary>List of child settings that depend on this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationSettingDependedOnBy>? DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>?>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#endif
        /// <summary>List of Dependencies for the setting group</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationDependentOn>? DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>?>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationDependentOn> DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSettingGroupDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionDefinition" => new DeviceManagementConfigurationSettingGroupCollectionDefinition(),
                _ => new DeviceManagementConfigurationSettingGroupDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childIds", n => { ChildIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>(DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>(DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("childIds", ChildIds);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
        }
    }
}
