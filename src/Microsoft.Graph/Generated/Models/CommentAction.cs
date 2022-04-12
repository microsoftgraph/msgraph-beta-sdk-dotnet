using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CommentAction : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If true, this activity was a reply to an existing comment thread.</summary>
        public bool? IsReply { get; set; }
        /// <summary>The identity of the user who started the comment thread.</summary>
        public IdentitySet ParentAuthor { get; set; }
        /// <summary>The identities of the users participating in this comment thread.</summary>
        public List<IdentitySet> Participants { get; set; }
        /// <summary>
        /// Instantiates a new commentAction and sets the default values.
        /// </summary>
        public CommentAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CommentAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommentAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isReply", n => { IsReply = n.GetBoolValue(); } },
                {"parentAuthor", n => { ParentAuthor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isReply", IsReply);
            writer.WriteObjectValue<IdentitySet>("parentAuthor", ParentAuthor);
            writer.WriteCollectionOfObjectValues<IdentitySet>("participants", Participants);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
