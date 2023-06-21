using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Deprecated
    /// </summary>
    public class Windows10PFXImportCertificateProfile : DeviceConfiguration, IParsable {
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public KeyStorageProviderOption? KeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>("keyStorageProvider"); }
            set { BackingStore?.Set("keyStorageProvider", value); }
        }
        /// <summary>
        /// Instantiates a new windows10PFXImportCertificateProfile and sets the default values.
        /// </summary>
        public Windows10PFXImportCertificateProfile() : base() {
            OdataType = "#microsoft.graph.windows10PFXImportCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10PFXImportCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10PFXImportCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"keyStorageProvider", n => { KeyStorageProvider = n.GetEnumValue<KeyStorageProviderOption>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<KeyStorageProviderOption>("keyStorageProvider", KeyStorageProvider);
        }
    }
}
