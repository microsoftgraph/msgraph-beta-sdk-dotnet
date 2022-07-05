using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class FileDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fileName property</summary>
        public string FileName {
            get { return BackingStore?.Get<string>(nameof(FileName)); }
            set { BackingStore?.Set(nameof(FileName), value); }
        }
        /// <summary>The filePath property</summary>
        public string FilePath {
            get { return BackingStore?.Get<string>(nameof(FilePath)); }
            set { BackingStore?.Set(nameof(FilePath), value); }
        }
        /// <summary>The filePublisher property</summary>
        public string FilePublisher {
            get { return BackingStore?.Get<string>(nameof(FilePublisher)); }
            set { BackingStore?.Set(nameof(FilePublisher), value); }
        }
        /// <summary>The fileSize property</summary>
        public long? FileSize {
            get { return BackingStore?.Get<long?>(nameof(FileSize)); }
            set { BackingStore?.Set(nameof(FileSize), value); }
        }
        /// <summary>The issuer property</summary>
        public string Issuer {
            get { return BackingStore?.Get<string>(nameof(Issuer)); }
            set { BackingStore?.Set(nameof(Issuer), value); }
        }
        /// <summary>The sha1 property</summary>
        public string Sha1 {
            get { return BackingStore?.Get<string>(nameof(Sha1)); }
            set { BackingStore?.Set(nameof(Sha1), value); }
        }
        /// <summary>The sha256 property</summary>
        public string Sha256 {
            get { return BackingStore?.Get<string>(nameof(Sha256)); }
            set { BackingStore?.Set(nameof(Sha256), value); }
        }
        /// <summary>The signer property</summary>
        public string Signer {
            get { return BackingStore?.Get<string>(nameof(Signer)); }
            set { BackingStore?.Set(nameof(Signer), value); }
        }
        /// <summary>
        /// Instantiates a new fileDetails and sets the default values.
        /// </summary>
        public FileDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FileDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"filePublisher", n => { FilePublisher = n.GetStringValue(); } },
                {"fileSize", n => { FileSize = n.GetLongValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"sha1", n => { Sha1 = n.GetStringValue(); } },
                {"sha256", n => { Sha256 = n.GetStringValue(); } },
                {"signer", n => { Signer = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteStringValue("filePublisher", FilePublisher);
            writer.WriteLongValue("fileSize", FileSize);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("sha1", Sha1);
            writer.WriteStringValue("sha256", Sha256);
            writer.WriteStringValue("signer", Signer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
