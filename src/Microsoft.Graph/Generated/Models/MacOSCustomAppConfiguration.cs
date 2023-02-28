using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSCustomAppConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Bundle id for targeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId {
            get { return BackingStore?.Get<string?>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#nullable restore
#else
        public string BundleId {
            get { return BackingStore?.Get<string>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#endif
        /// <summary>Configuration xml. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ConfigurationXml {
            get { return BackingStore?.Get<byte[]?>("configurationXml"); }
            set { BackingStore?.Set("configurationXml", value); }
        }
#nullable restore
#else
        public byte[] ConfigurationXml {
            get { return BackingStore?.Get<byte[]>("configurationXml"); }
            set { BackingStore?.Set("configurationXml", value); }
        }
#endif
        /// <summary>Configuration file name (.plist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new MacOSCustomAppConfiguration and sets the default values.
        /// </summary>
        public MacOSCustomAppConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSCustomAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteByteArrayValue("configurationXml", ConfigurationXml);
            writer.WriteStringValue("fileName", FileName);
        }
    }
}
