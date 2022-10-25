using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DocumentComment : Entity, IParsable {
        /// <summary>The content property</summary>
        public string Content {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The replies property</summary>
        public List<DocumentCommentReply> Replies {
            get { return BackingStore?.Get<List<DocumentCommentReply>>("replies"); }
            set { BackingStore?.Set("replies", value); }
        }
        /// <summary>
        /// Instantiates a new DocumentComment and sets the default values.
        /// </summary>
        public DocumentComment() : base() {
            OdataType = "#microsoft.graph.documentComment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DocumentComment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentComment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"replies", n => { Replies = n.GetCollectionOfObjectValues<DocumentCommentReply>(DocumentCommentReply.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteCollectionOfObjectValues<DocumentCommentReply>("replies", Replies);
        }
    }
}
