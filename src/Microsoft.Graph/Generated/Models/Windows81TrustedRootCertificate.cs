using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows81TrustedRootCertificate : DeviceConfiguration, IParsable {
        /// <summary>File name to display in UI.</summary>
        public string CertFileName {
            get { return BackingStore?.Get<string>("certFileName"); }
            set { BackingStore?.Set("certFileName", value); }
        }
        /// <summary>Possible values for the Certificate Destination Store.</summary>
        public CertificateDestinationStore? DestinationStore {
            get { return BackingStore?.Get<CertificateDestinationStore?>("destinationStore"); }
            set { BackingStore?.Set("destinationStore", value); }
        }
        /// <summary>Trusted Root Certificate</summary>
        public byte[] TrustedRootCertificate {
            get { return BackingStore?.Get<byte[]>("trustedRootCertificate"); }
            set { BackingStore?.Set("trustedRootCertificate", value); }
        }
        /// <summary>
        /// Instantiates a new windows81TrustedRootCertificate and sets the default values.
        /// </summary>
        public Windows81TrustedRootCertificate() : base() {
            OdataType = "#microsoft.graph.windows81TrustedRootCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows81TrustedRootCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81TrustedRootCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certFileName", n => { CertFileName = n.GetStringValue(); } },
                {"destinationStore", n => { DestinationStore = n.GetEnumValue<CertificateDestinationStore>(); } },
                {"trustedRootCertificate", n => { TrustedRootCertificate = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certFileName", CertFileName);
            writer.WriteEnumValue<CertificateDestinationStore>("destinationStore", DestinationStore);
            writer.WriteByteArrayValue("trustedRootCertificate", TrustedRootCertificate);
        }
    }
}
