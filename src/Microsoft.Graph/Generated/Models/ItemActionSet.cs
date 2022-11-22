using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemActionSet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A comment was added to the item.</summary>
        public CommentAction Comment {
            get { return BackingStore?.Get<CommentAction>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
        /// <summary>An item was created.</summary>
        public CreateAction Create {
            get { return BackingStore?.Get<CreateAction>("create"); }
            set { BackingStore?.Set("create", value); }
        }
        /// <summary>An item was deleted.</summary>
        public DeleteAction Delete {
            get { return BackingStore?.Get<DeleteAction>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
        /// <summary>An item was edited.</summary>
        public EditAction Edit {
            get { return BackingStore?.Get<EditAction>("edit"); }
            set { BackingStore?.Set("edit", value); }
        }
        /// <summary>A user was mentioned in the item.</summary>
        public MentionAction Mention {
            get { return BackingStore?.Get<MentionAction>("mention"); }
            set { BackingStore?.Set("mention", value); }
        }
        /// <summary>An item was moved.</summary>
        public MoveAction Move {
            get { return BackingStore?.Get<MoveAction>("move"); }
            set { BackingStore?.Set("move", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>An item was renamed.</summary>
        public RenameAction Rename {
            get { return BackingStore?.Get<RenameAction>("rename"); }
            set { BackingStore?.Set("rename", value); }
        }
        /// <summary>An item was restored.</summary>
        public RestoreAction Restore {
            get { return BackingStore?.Get<RestoreAction>("restore"); }
            set { BackingStore?.Set("restore", value); }
        }
        /// <summary>An item was shared.</summary>
        public ShareAction Share {
            get { return BackingStore?.Get<ShareAction>("share"); }
            set { BackingStore?.Set("share", value); }
        }
        /// <summary>An item was versioned.</summary>
        public VersionAction Version {
            get { return BackingStore?.Get<VersionAction>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new itemActionSet and sets the default values.
        /// </summary>
        public ItemActionSet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ItemActionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comment", n => { Comment = n.GetObjectValue<CommentAction>(CommentAction.CreateFromDiscriminatorValue); } },
                {"create", n => { Create = n.GetObjectValue<CreateAction>(CreateAction.CreateFromDiscriminatorValue); } },
                {"delete", n => { Delete = n.GetObjectValue<DeleteAction>(DeleteAction.CreateFromDiscriminatorValue); } },
                {"edit", n => { Edit = n.GetObjectValue<EditAction>(EditAction.CreateFromDiscriminatorValue); } },
                {"mention", n => { Mention = n.GetObjectValue<MentionAction>(MentionAction.CreateFromDiscriminatorValue); } },
                {"move", n => { Move = n.GetObjectValue<MoveAction>(MoveAction.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rename", n => { Rename = n.GetObjectValue<RenameAction>(RenameAction.CreateFromDiscriminatorValue); } },
                {"restore", n => { Restore = n.GetObjectValue<RestoreAction>(RestoreAction.CreateFromDiscriminatorValue); } },
                {"share", n => { Share = n.GetObjectValue<ShareAction>(ShareAction.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetObjectValue<VersionAction>(VersionAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CommentAction>("comment", Comment);
            writer.WriteObjectValue<CreateAction>("create", Create);
            writer.WriteObjectValue<DeleteAction>("delete", Delete);
            writer.WriteObjectValue<EditAction>("edit", Edit);
            writer.WriteObjectValue<MentionAction>("mention", Mention);
            writer.WriteObjectValue<MoveAction>("move", Move);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<RenameAction>("rename", Rename);
            writer.WriteObjectValue<RestoreAction>("restore", Restore);
            writer.WriteObjectValue<ShareAction>("share", Share);
            writer.WriteObjectValue<VersionAction>("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
