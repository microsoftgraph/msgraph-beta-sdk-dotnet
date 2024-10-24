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
    /// Instance of a GroupSetting
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationGroupSettingInstance : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance, IParsable
    {
        /// <summary>The groupSettingValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue? GroupSettingValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue?>("groupSettingValue"); }
            set { BackingStore?.Set("groupSettingValue", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue GroupSettingValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue>("groupSettingValue"); }
            set { BackingStore?.Set("groupSettingValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingInstance"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationGroupSettingInstance() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationGroupSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "groupSettingValue", n => { GroupSettingValue = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingValue>("groupSettingValue", GroupSettingValue);
        }
    }
}
#pragma warning restore CS0618
