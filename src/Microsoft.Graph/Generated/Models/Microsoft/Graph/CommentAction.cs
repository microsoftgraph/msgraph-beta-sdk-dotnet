using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CommentAction : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isReply", (o,n) => { (o as CommentAction).IsReply = n.GetBoolValue(); } },
                {"parentAuthor", (o,n) => { (o as CommentAction).ParentAuthor = n.GetObjectValue<IdentitySet>(); } },
                {"participants", (o,n) => { (o as CommentAction).Participants = n.GetCollectionOfObjectValues<IdentitySet>().ToList(); } },
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
