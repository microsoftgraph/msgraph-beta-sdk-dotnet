using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ListItem : BaseItem, IParsable {
        /// <summary>The list of recent activities that took place on this item.</summary>
        public List<ItemActivityOLD> Activities { get; set; }
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>The content type of this list item</summary>
        public ContentTypeInfo ContentType { get; set; }
        /// <summary>The deleted property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted Deleted { get; set; }
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem DriveItem { get; set; }
        /// <summary>The values of the columns set on this list item.</summary>
        public FieldValueSet Fields { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>The list of previous versions of the list item.</summary>
        public List<ListItemVersion> Versions { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activities", (o,n) => { (o as ListItem).Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"analytics", (o,n) => { (o as ListItem).Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"contentType", (o,n) => { (o as ListItem).ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"deleted", (o,n) => { (o as ListItem).Deleted = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>(MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted.CreateFromDiscriminatorValue); } },
                {"driveItem", (o,n) => { (o as ListItem).DriveItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
                {"fields", (o,n) => { (o as ListItem).Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as ListItem).SharepointIds = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>(MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"versions", (o,n) => { (o as ListItem).Versions = n.GetCollectionOfObjectValues<ListItemVersion>(ListItemVersion.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ListItemVersion>("versions", Versions);
        }
    }
}
