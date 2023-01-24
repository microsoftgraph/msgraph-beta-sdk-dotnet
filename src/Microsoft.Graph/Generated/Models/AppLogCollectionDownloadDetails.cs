using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppLogCollectionDownloadDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appLogDecryptionAlgorithm property</summary>
        public Microsoft.Graph.Beta.Models.AppLogDecryptionAlgorithm? AppLogDecryptionAlgorithm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppLogDecryptionAlgorithm?>("appLogDecryptionAlgorithm"); }
            set { BackingStore?.Set("appLogDecryptionAlgorithm", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DecryptionKey as string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecryptionKey {
            get { return BackingStore?.Get<string?>("decryptionKey"); }
            set { BackingStore?.Set("decryptionKey", value); }
        }
#nullable restore
#else
        public string DecryptionKey {
            get { return BackingStore?.Get<string>("decryptionKey"); }
            set { BackingStore?.Set("decryptionKey", value); }
        }
#endif
        /// <summary>Download SAS Url for completed AppLogUploadRequest</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadUrl {
            get { return BackingStore?.Get<string?>("downloadUrl"); }
            set { BackingStore?.Set("downloadUrl", value); }
        }
#nullable restore
#else
        public string DownloadUrl {
            get { return BackingStore?.Get<string>("downloadUrl"); }
            set { BackingStore?.Set("downloadUrl", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new appLogCollectionDownloadDetails and sets the default values.
        /// </summary>
        public AppLogCollectionDownloadDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppLogCollectionDownloadDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppLogCollectionDownloadDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appLogDecryptionAlgorithm", n => { AppLogDecryptionAlgorithm = n.GetEnumValue<AppLogDecryptionAlgorithm>(); } },
                {"decryptionKey", n => { DecryptionKey = n.GetStringValue(); } },
                {"downloadUrl", n => { DownloadUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AppLogDecryptionAlgorithm>("appLogDecryptionAlgorithm", AppLogDecryptionAlgorithm);
            writer.WriteStringValue("decryptionKey", DecryptionKey);
            writer.WriteStringValue("downloadUrl", DownloadUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
