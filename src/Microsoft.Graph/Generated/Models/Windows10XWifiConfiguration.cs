using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10XWifiConfiguration : DeviceManagementResourceAccessProfileBase, IParsable {
        /// <summary>ID to the Authentication Certificate</summary>
        public string AuthenticationCertificateId {
            get { return BackingStore?.Get<string>("authenticationCertificateId"); }
            set { BackingStore?.Set("authenticationCertificateId", value); }
        }
        /// <summary>Custom XML commands that configures the VPN connection. (UTF8 byte encoding)</summary>
        public byte[] CustomXml {
            get { return BackingStore?.Get<byte[]>("customXml"); }
            set { BackingStore?.Set("customXml", value); }
        }
        /// <summary>Custom Xml file name.</summary>
        public string CustomXmlFileName {
            get { return BackingStore?.Get<string>("customXmlFileName"); }
            set { BackingStore?.Set("customXmlFileName", value); }
        }
        /// <summary>
        /// Instantiates a new Windows10XWifiConfiguration and sets the default values.
        /// </summary>
        public Windows10XWifiConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10XWifiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10XWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10XWifiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationCertificateId", n => { AuthenticationCertificateId = n.GetStringValue(); } },
                {"customXml", n => { CustomXml = n.GetByteArrayValue(); } },
                {"customXmlFileName", n => { CustomXmlFileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationCertificateId", AuthenticationCertificateId);
            writer.WriteByteArrayValue("customXml", CustomXml);
            writer.WriteStringValue("customXmlFileName", CustomXmlFileName);
        }
    }
}
