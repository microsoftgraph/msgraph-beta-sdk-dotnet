using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Picture : Entity, IParsable {
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The contentType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType {
            get { return BackingStore?.Get<string?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public string ContentType {
            get { return BackingStore?.Get<string>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The height property</summary>
        public int? Height {
            get { return BackingStore?.Get<int?>("height"); }
            set { BackingStore?.Set("height", value); }
        }
        /// <summary>The width property</summary>
        public int? Width {
            get { return BackingStore?.Get<int?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Picture CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Picture();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"height", n => { Height = n.GetIntValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
