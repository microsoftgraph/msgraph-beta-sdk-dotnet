using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Presentation : Entity, IParsable {
        /// <summary>The comments property</summary>
        public List<DocumentComment> Comments {
            get { return BackingStore?.Get<List<DocumentComment>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
        /// <summary>
        /// Instantiates a new Presentation and sets the default values.
        /// </summary>
        public Presentation() : base() {
            OdataType = "#microsoft.graph.presentation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Presentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Presentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<DocumentComment>(DocumentComment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DocumentComment>("comments", Comments);
        }
    }
}
