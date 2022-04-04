using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Picture : Entity, IParsable {
        /// <summary>The content property</summary>
        public byte[] Content { get; set; }
        /// <summary>The contentType property</summary>
        public string ContentType { get; set; }
        /// <summary>The height property</summary>
        public int? Height { get; set; }
        /// <summary>The width property</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Picture CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Picture();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as Picture).Content = n.GetByteArrayValue(); } },
                {"contentType", (o,n) => { (o as Picture).ContentType = n.GetStringValue(); } },
                {"height", (o,n) => { (o as Picture).Height = n.GetIntValue(); } },
                {"width", (o,n) => { (o as Picture).Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("height", Height);
            writer.WriteIntValue("width", Width);
        }
    }
}
