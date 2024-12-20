// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Choice Setting Value Constant Default Template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValueDefaultTemplate, IParsable
    {
        /// <summary>Option Children</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate>? Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate> Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>Default Constant Value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingDefinitionOptionId
        {
            get { return BackingStore?.Get<string?>("settingDefinitionOptionId"); }
            set { BackingStore?.Set("settingDefinitionOptionId", value); }
        }
#nullable restore
#else
        public string SettingDefinitionOptionId
        {
            get { return BackingStore?.Get<string>("settingDefinitionOptionId"); }
            set { BackingStore?.Set("settingDefinitionOptionId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValueConstantDefaultTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "settingDefinitionOptionId", n => { SettingDefinitionOptionId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate>("children", Children);
            writer.WriteStringValue("settingDefinitionOptionId", SettingDefinitionOptionId);
        }
    }
}
#pragma warning restore CS0618
