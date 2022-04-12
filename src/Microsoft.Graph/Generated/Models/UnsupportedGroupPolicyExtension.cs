using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnsupportedGroupPolicyExtension : Entity, IParsable {
        /// <summary>ExtensionType of the unsupported extension.</summary>
        public string ExtensionType { get; set; }
        /// <summary>Namespace Url of the unsupported extension.</summary>
        public string NamespaceUrl { get; set; }
        /// <summary>Node name of the unsupported extension.</summary>
        public string NodeName { get; set; }
        /// <summary>Setting Scope of the unsupported extension. Possible values are: unknown, device, user.</summary>
        public GroupPolicySettingScope? SettingScope { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnsupportedGroupPolicyExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnsupportedGroupPolicyExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"extensionType", n => { ExtensionType = n.GetStringValue(); } },
                {"namespaceUrl", n => { NamespaceUrl = n.GetStringValue(); } },
                {"nodeName", n => { NodeName = n.GetStringValue(); } },
                {"settingScope", n => { SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("extensionType", ExtensionType);
            writer.WriteStringValue("namespaceUrl", NamespaceUrl);
            writer.WriteStringValue("nodeName", NodeName);
            writer.WriteEnumValue<GroupPolicySettingScope>("settingScope", SettingScope);
        }
    }
}
