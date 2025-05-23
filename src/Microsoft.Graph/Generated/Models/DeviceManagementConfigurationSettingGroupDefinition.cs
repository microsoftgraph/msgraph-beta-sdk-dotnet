// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DeviceManagementConfigurationSettingGroupDefinition : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDefinition, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Dependent child settings to this group of settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ChildIds
        {
            get { return BackingStore?.Get<List<string>?>("childIds"); }
            set { BackingStore?.Set("childIds", value); }
        }
#nullable restore
#else
        public List<string> ChildIds
        {
            get { return BackingStore?.Get<List<string>>("childIds"); }
            set { BackingStore?.Set("childIds", value); }
        }
#endif
        /// <summary>List of child settings that depend on this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy>? DependedOnBy
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy>?>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy>>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#endif
        /// <summary>List of Dependencies for the setting group</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn>? DependentOn
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn>?>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn> DependentOn
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn>>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionDefinition" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupCollectionDefinition(),
                _ => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childIds", n => { ChildIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("childIds", ChildIds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
        }
    }
}
#pragma warning restore CS0618
