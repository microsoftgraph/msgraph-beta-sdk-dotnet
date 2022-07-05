using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RegistryValueEvidence : AlertEvidence, IParsable {
        /// <summary>The registryHive property</summary>
        public string RegistryHive {
            get { return BackingStore?.Get<string>(nameof(RegistryHive)); }
            set { BackingStore?.Set(nameof(RegistryHive), value); }
        }
        /// <summary>The registryKey property</summary>
        public string RegistryKey {
            get { return BackingStore?.Get<string>(nameof(RegistryKey)); }
            set { BackingStore?.Set(nameof(RegistryKey), value); }
        }
        /// <summary>The registryValue property</summary>
        public string RegistryValue {
            get { return BackingStore?.Get<string>(nameof(RegistryValue)); }
            set { BackingStore?.Set(nameof(RegistryValue), value); }
        }
        /// <summary>The registryValueName property</summary>
        public string RegistryValueName {
            get { return BackingStore?.Get<string>(nameof(RegistryValueName)); }
            set { BackingStore?.Set(nameof(RegistryValueName), value); }
        }
        /// <summary>The registryValueType property</summary>
        public string RegistryValueType {
            get { return BackingStore?.Get<string>(nameof(RegistryValueType)); }
            set { BackingStore?.Set(nameof(RegistryValueType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RegistryValueEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistryValueEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"registryHive", n => { RegistryHive = n.GetStringValue(); } },
                {"registryKey", n => { RegistryKey = n.GetStringValue(); } },
                {"registryValue", n => { RegistryValue = n.GetStringValue(); } },
                {"registryValueName", n => { RegistryValueName = n.GetStringValue(); } },
                {"registryValueType", n => { RegistryValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("registryHive", RegistryHive);
            writer.WriteStringValue("registryKey", RegistryKey);
            writer.WriteStringValue("registryValue", RegistryValue);
            writer.WriteStringValue("registryValueName", RegistryValueName);
            writer.WriteStringValue("registryValueType", RegistryValueType);
        }
    }
}
