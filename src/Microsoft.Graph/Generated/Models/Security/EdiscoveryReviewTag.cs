using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryReviewTag : Tag, IParsable {
        /// <summary>The childSelectability property</summary>
        public Microsoft.Graph.Beta.Models.Security.ChildSelectability? ChildSelectability { get; set; }
        /// <summary>The childTags property</summary>
        public List<EdiscoveryReviewTag> ChildTags { get; set; }
        /// <summary>The parent property</summary>
        public EdiscoveryReviewTag Parent { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryReviewTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryReviewTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childSelectability", n => { ChildSelectability = n.GetEnumValue<ChildSelectability>(); } },
                {"childTags", n => { ChildTags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue).ToList(); } },
                {"parent", n => { Parent = n.GetObjectValue<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChildSelectability>("childSelectability", ChildSelectability);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("childTags", ChildTags);
            writer.WriteObjectValue<EdiscoveryReviewTag>("parent", Parent);
        }
    }
}
