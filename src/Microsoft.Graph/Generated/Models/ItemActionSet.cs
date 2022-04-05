using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemActionSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A comment was added to the item.</summary>
        public CommentAction Comment { get; set; }
        /// <summary>An item was created.</summary>
        public CreateAction Create { get; set; }
        /// <summary>An item was deleted.</summary>
        public DeleteAction Delete { get; set; }
        /// <summary>An item was edited.</summary>
        public EditAction Edit { get; set; }
        /// <summary>A user was mentioned in the item.</summary>
        public MentionAction Mention { get; set; }
        /// <summary>An item was moved.</summary>
        public MoveAction Move { get; set; }
        /// <summary>An item was renamed.</summary>
        public RenameAction Rename { get; set; }
        /// <summary>An item was restored.</summary>
        public RestoreAction Restore { get; set; }
        /// <summary>An item was shared.</summary>
        public ShareAction Share { get; set; }
        /// <summary>An item was versioned.</summary>
        public VersionAction Version { get; set; }
        /// <summary>
        /// Instantiates a new itemActionSet and sets the default values.
        /// </summary>
        public ItemActionSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ItemActionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as ItemActionSet).Comment = n.GetObjectValue<CommentAction>(CommentAction.CreateFromDiscriminatorValue); } },
                {"create", (o,n) => { (o as ItemActionSet).Create = n.GetObjectValue<CreateAction>(CreateAction.CreateFromDiscriminatorValue); } },
                {"delete", (o,n) => { (o as ItemActionSet).Delete = n.GetObjectValue<DeleteAction>(DeleteAction.CreateFromDiscriminatorValue); } },
                {"edit", (o,n) => { (o as ItemActionSet).Edit = n.GetObjectValue<EditAction>(EditAction.CreateFromDiscriminatorValue); } },
                {"mention", (o,n) => { (o as ItemActionSet).Mention = n.GetObjectValue<MentionAction>(MentionAction.CreateFromDiscriminatorValue); } },
                {"move", (o,n) => { (o as ItemActionSet).Move = n.GetObjectValue<MoveAction>(MoveAction.CreateFromDiscriminatorValue); } },
                {"rename", (o,n) => { (o as ItemActionSet).Rename = n.GetObjectValue<RenameAction>(RenameAction.CreateFromDiscriminatorValue); } },
                {"restore", (o,n) => { (o as ItemActionSet).Restore = n.GetObjectValue<RestoreAction>(RestoreAction.CreateFromDiscriminatorValue); } },
                {"share", (o,n) => { (o as ItemActionSet).Share = n.GetObjectValue<ShareAction>(ShareAction.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as ItemActionSet).Version = n.GetObjectValue<VersionAction>(VersionAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CommentAction>("comment", Comment);
            writer.WriteObjectValue<CreateAction>("create", Create);
            writer.WriteObjectValue<DeleteAction>("delete", Delete);
            writer.WriteObjectValue<EditAction>("edit", Edit);
            writer.WriteObjectValue<MentionAction>("mention", Mention);
            writer.WriteObjectValue<MoveAction>("move", Move);
            writer.WriteObjectValue<RenameAction>("rename", Rename);
            writer.WriteObjectValue<RestoreAction>("restore", Restore);
            writer.WriteObjectValue<ShareAction>("share", Share);
            writer.WriteObjectValue<VersionAction>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
