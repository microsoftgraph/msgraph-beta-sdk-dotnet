using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"extensionType", (o,n) => { (o as UnsupportedGroupPolicyExtension).ExtensionType = n.GetStringValue(); } },
                {"namespaceUrl", (o,n) => { (o as UnsupportedGroupPolicyExtension).NamespaceUrl = n.GetStringValue(); } },
                {"nodeName", (o,n) => { (o as UnsupportedGroupPolicyExtension).NodeName = n.GetStringValue(); } },
                {"settingScope", (o,n) => { (o as UnsupportedGroupPolicyExtension).SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
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
