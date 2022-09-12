using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CommentAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>If true, this activity was a reply to an existing comment thread.</summary>
        public bool? IsReply {
            get { return BackingStore?.Get<bool?>("isReply"); }
            set { BackingStore?.Set("isReply", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The identity of the user who started the comment thread.</summary>
        public IdentitySet ParentAuthor {
            get { return BackingStore?.Get<IdentitySet>("parentAuthor"); }
            set { BackingStore?.Set("parentAuthor", value); }
        }
        /// <summary>The identities of the users participating in this comment thread.</summary>
        public List<IdentitySet> Participants {
            get { return BackingStore?.Get<List<IdentitySet>>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
        /// <summary>
        /// Instantiates a new commentAction and sets the default values.
        /// </summary>
        public CommentAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.commentAction";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parentAuthor", n => { ParentAuthor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isReply", IsReply);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentitySet>("parentAuthor", ParentAuthor);
            writer.WriteCollectionOfObjectValues<IdentitySet>("participants", Participants);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
