using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ManagementCertificateWithThumbprint : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Base 64 encoded management certificate</summary>
        public string Certificate { get; set; }
        /// <summary>The thumbprint of the management certificate</summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// Instantiates a new managementCertificateWithThumbprint and sets the default values.
        /// </summary>
        public ManagementCertificateWithThumbprint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagementCertificateWithThumbprint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementCertificateWithThumbprint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificate", (o,n) => { (o as ManagementCertificateWithThumbprint).Certificate = n.GetStringValue(); } },
                {"thumbprint", (o,n) => { (o as ManagementCertificateWithThumbprint).Thumbprint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
