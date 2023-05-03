using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// template insights definition
    /// </summary>
    public class DeviceManagementTemplateInsightsDefinition : Entity, IParsable {
        /// <summary>Setting insights in a template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementSettingInsightsDefinition>? SettingInsights {
            get { return BackingStore?.Get<List<DeviceManagementSettingInsightsDefinition>?>("settingInsights"); }
            set { BackingStore?.Set("settingInsights", value); }
        }
#nullable restore
#else
        public List<DeviceManagementSettingInsightsDefinition> SettingInsights {
            get { return BackingStore?.Get<List<DeviceManagementSettingInsightsDefinition>>("settingInsights"); }
            set { BackingStore?.Set("settingInsights", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementTemplateInsightsDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementTemplateInsightsDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"settingInsights", n => { SettingInsights = n.GetCollectionOfObjectValues<DeviceManagementSettingInsightsDefinition>(DeviceManagementSettingInsightsDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInsightsDefinition>("settingInsights", SettingInsights);
        }
    }
}
