using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class ListItem : BaseItem, IParsable {
        /// <summary>The list of recent activities that took place on this item.</summary>
        public List<ItemActivityOLD> Activities {
            get { return BackingStore?.Get<List<ItemActivityOLD>>(nameof(Activities)); }
            set { BackingStore?.Set(nameof(Activities), value); }
        }
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>(nameof(Analytics)); }
            set { BackingStore?.Set(nameof(Analytics), value); }
        }
        /// <summary>The content type of this list item</summary>
        public ContentTypeInfo ContentType {
            get { return BackingStore?.Get<ContentTypeInfo>(nameof(ContentType)); }
            set { BackingStore?.Set(nameof(ContentType), value); }
        }
        /// <summary>The deleted property</summary>
        public Microsoft.Graph.Beta.Models.Deleted Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Deleted>(nameof(Deleted)); }
            set { BackingStore?.Set(nameof(Deleted), value); }
        }
        /// <summary>Version information for a document set version created by a user.</summary>
        public List<DocumentSetVersion> DocumentSetVersions {
            get { return BackingStore?.Get<List<DocumentSetVersion>>(nameof(DocumentSetVersions)); }
            set { BackingStore?.Set(nameof(DocumentSetVersions), value); }
        }
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]</summary>
        public Microsoft.Graph.Beta.Models.DriveItem DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DriveItem>(nameof(DriveItem)); }
            set { BackingStore?.Set(nameof(DriveItem), value); }
        }
        /// <summary>The values of the columns set on this list item.</summary>
        public FieldValueSet Fields {
            get { return BackingStore?.Get<FieldValueSet>(nameof(Fields)); }
            set { BackingStore?.Set(nameof(Fields), value); }
        }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>(nameof(SharepointIds)); }
            set { BackingStore?.Set(nameof(SharepointIds), value); }
        }
        /// <summary>The list of previous versions of the list item.</summary>
        public List<ListItemVersion> Versions {
            get { return BackingStore?.Get<List<ListItemVersion>>(nameof(Versions)); }
            set { BackingStore?.Set(nameof(Versions), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"deleted", n => { Deleted = n.GetObjectValue<Microsoft.Graph.Beta.Models.Deleted>(Microsoft.Graph.Beta.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<DocumentSetVersion>(DocumentSetVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.DriveItem>(Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"fields", n => { Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<ListItemVersion>(ListItemVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ItemActivityOLD>("activities", Activities);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Deleted>("deleted", Deleted);
            writer.WriteCollectionOfObjectValues<DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ListItemVersion>("versions", Versions);
        }
    }
}
