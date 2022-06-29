using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class FileClassificationRequest : Entity, IParsable {
        /// <summary>The file property</summary>
        public byte[] FileObject {
            get { return BackingStore?.Get<byte[]>(nameof(FileObject)); }
            set { BackingStore?.Set(nameof(FileObject), value); }
        }
        /// <summary>The sensitiveTypeIds property</summary>
        public List<string> SensitiveTypeIds {
            get { return BackingStore?.Get<List<string>>(nameof(SensitiveTypeIds)); }
            set { BackingStore?.Set(nameof(SensitiveTypeIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new FileClassificationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileClassificationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"file", n => { FileObject = n.GetByteArrayValue(); } },
                {"sensitiveTypeIds", n => { SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("file", FileObject);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
        }
    }
}
