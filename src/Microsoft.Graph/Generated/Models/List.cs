using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class List : BaseItem, IParsable {
        /// <summary>The recent activities that took place within this list.</summary>
        public List<ItemActivityOLD> Activities {
            get { return BackingStore?.Get<List<ItemActivityOLD>>(nameof(Activities)); }
            set { BackingStore?.Set(nameof(Activities), value); }
        }
        /// <summary>The collection of field definitions for this list.</summary>
        public List<ColumnDefinition> Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>>(nameof(Columns)); }
            set { BackingStore?.Set(nameof(Columns), value); }
        }
        /// <summary>The collection of content types present in this list.</summary>
        public List<ContentType> ContentTypes {
            get { return BackingStore?.Get<List<ContentType>>(nameof(ContentTypes)); }
            set { BackingStore?.Set(nameof(ContentTypes), value); }
        }
        /// <summary>The displayable title of the list.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].</summary>
        public Microsoft.Graph.Beta.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>(nameof(Drive)); }
            set { BackingStore?.Set(nameof(Drive), value); }
        }
        /// <summary>All items contained in the list.</summary>
        public List<ListItem> Items {
            get { return BackingStore?.Get<List<ListItem>>(nameof(Items)); }
            set { BackingStore?.Set(nameof(Items), value); }
        }
        /// <summary>Provides additional details about the list.</summary>
        public ListInfo List_prop {
            get { return BackingStore?.Get<ListInfo>(nameof(List_prop)); }
            set { BackingStore?.Set(nameof(List_prop), value); }
        }
        /// <summary>The collection of long running operations for the list.</summary>
        public List<RichLongRunningOperation> Operations {
            get { return BackingStore?.Get<List<RichLongRunningOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>(nameof(SharepointIds)); }
            set { BackingStore?.Set(nameof(SharepointIds), value); }
        }
        /// <summary>The set of subscriptions on the list.</summary>
        public List<Subscription> Subscriptions {
            get { return BackingStore?.Get<List<Subscription>>(nameof(Subscriptions)); }
            set { BackingStore?.Set(nameof(Subscriptions), value); }
        }
        /// <summary>If present, indicates that this is a system-managed list. Read-only.</summary>
        public SystemFacet System {
            get { return BackingStore?.Get<SystemFacet>(nameof(System)); }
            set { BackingStore?.Set(nameof(System), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new List CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new List();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<ListItem>(ListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", n => { List_prop = n.GetObjectValue<ListInfo>(ListInfo.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue).ToList(); } },
                {"system", n => { System = n.GetObjectValue<SystemFacet>(SystemFacet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<ListItem>("items", Items);
            writer.WriteObjectValue<ListInfo>("list", List_prop);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<SystemFacet>("system", System);
        }
    }
}
