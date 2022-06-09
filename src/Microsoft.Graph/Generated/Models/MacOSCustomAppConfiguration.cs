using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSCustomAppConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Bundle id for targeting.</summary>
        public string BundleId {
            get { return BackingStore?.Get<string>(nameof(BundleId)); }
            set { BackingStore?.Set(nameof(BundleId), value); }
        }
        /// <summary>Configuration xml. (UTF8 encoded byte array)</summary>
        public byte[] ConfigurationXml {
            get { return BackingStore?.Get<byte[]>(nameof(ConfigurationXml)); }
            set { BackingStore?.Set(nameof(ConfigurationXml), value); }
        }
        /// <summary>Configuration file name (.plist</summary>
        public string FileName {
            get { return BackingStore?.Get<string>(nameof(FileName)); }
            set { BackingStore?.Set(nameof(FileName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSCustomAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSCustomAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"configurationXml", n => { ConfigurationXml = n.GetByteArrayValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteByteArrayValue("configurationXml", ConfigurationXml);
            writer.WriteStringValue("fileName", FileName);
        }
    }
}
