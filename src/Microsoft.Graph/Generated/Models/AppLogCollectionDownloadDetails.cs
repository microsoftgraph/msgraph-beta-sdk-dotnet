using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppLogCollectionDownloadDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>DecryptionAlgorithm for Content. Possible values are: aes256.</summary>
        public Microsoft.Graph.Beta.Models.AppLogDecryptionAlgorithm? AppLogDecryptionAlgorithm { get; set; }
        /// <summary>DecryptionKey as string</summary>
        public string DecryptionKey { get; set; }
        /// <summary>Download SAS Url for completed AppLogUploadRequest</summary>
        public string DownloadUrl { get; set; }
        /// <summary>
        /// Instantiates a new appLogCollectionDownloadDetails and sets the default values.
        /// </summary>
        public AppLogCollectionDownloadDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppLogCollectionDownloadDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppLogCollectionDownloadDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appLogDecryptionAlgorithm", (o,n) => { (o as AppLogCollectionDownloadDetails).AppLogDecryptionAlgorithm = n.GetEnumValue<AppLogDecryptionAlgorithm>(); } },
                {"decryptionKey", (o,n) => { (o as AppLogCollectionDownloadDetails).DecryptionKey = n.GetStringValue(); } },
                {"downloadUrl", (o,n) => { (o as AppLogCollectionDownloadDetails).DownloadUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AppLogDecryptionAlgorithm>("appLogDecryptionAlgorithm", AppLogDecryptionAlgorithm);
            writer.WriteStringValue("decryptionKey", DecryptionKey);
            writer.WriteStringValue("downloadUrl", DownloadUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
