using Microsoft.Graph.Beta.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>(nameof(Analytics)); }
            set { BackingStore?.Set(nameof(Analytics), value); }
        }
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
        public List<ColumnDefinition> Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>>(nameof(Columns)); }
            set { BackingStore?.Set(nameof(Columns), value); }
        }
        /// <summary>The collection of content types defined for this site.</summary>
        public List<ContentType> ContentTypes {
            get { return BackingStore?.Get<List<ContentType>>(nameof(ContentTypes)); }
            set { BackingStore?.Set(nameof(ContentTypes), value); }
        }
        /// <summary>The deleted property</summary>
        public Microsoft.Graph.Beta.Models.Deleted Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Deleted>(nameof(Deleted)); }
            set { BackingStore?.Set(nameof(Deleted), value); }
        }
        /// <summary>The full title for the site. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The default drive (document library) for this site.</summary>
        public Microsoft.Graph.Beta.Models.Drive Drive {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>(nameof(Drive)); }
            set { BackingStore?.Set(nameof(Drive), value); }
        }
        /// <summary>The collection of drives (document libraries) under this site.</summary>
        public List<Microsoft.Graph.Beta.Models.Drive> Drives {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Drive>>(nameof(Drives)); }
            set { BackingStore?.Set(nameof(Drives), value); }
        }
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
        public List<ColumnDefinition> ExternalColumns {
            get { return BackingStore?.Get<List<ColumnDefinition>>(nameof(ExternalColumns)); }
            set { BackingStore?.Set(nameof(ExternalColumns), value); }
        }
        /// <summary>Used to address any item contained in this site. This collection cannot be enumerated.</summary>
        public List<BaseItem> Items {
            get { return BackingStore?.Get<List<BaseItem>>(nameof(Items)); }
            set { BackingStore?.Set(nameof(Items), value); }
        }
        /// <summary>The collection of lists under this site.</summary>
        public List<List> Lists {
            get { return BackingStore?.Get<List<List>>(nameof(Lists)); }
            set { BackingStore?.Set(nameof(Lists), value); }
        }
        /// <summary>Calls the OneNote service for notebook related operations.</summary>
        public Microsoft.Graph.Beta.Models.Onenote Onenote {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Onenote>(nameof(Onenote)); }
            set { BackingStore?.Set(nameof(Onenote), value); }
        }
        /// <summary>The collection of long running operations for the site.</summary>
        public List<RichLongRunningOperation> Operations {
            get { return BackingStore?.Get<List<RichLongRunningOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The collection of pages in the SitePages list in this site.</summary>
        public List<SitePage> Pages {
            get { return BackingStore?.Get<List<SitePage>>(nameof(Pages)); }
            set { BackingStore?.Set(nameof(Pages), value); }
        }
        /// <summary>The permissions associated with the site. Nullable.</summary>
        public List<Permission> Permissions {
            get { return BackingStore?.Get<List<Permission>>(nameof(Permissions)); }
            set { BackingStore?.Set(nameof(Permissions), value); }
        }
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Root Root {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Root>(nameof(Root)); }
            set { BackingStore?.Set(nameof(Root), value); }
        }
        /// <summary>The settings on this site. Read-only.</summary>
        public SiteSettings Settings {
            get { return BackingStore?.Get<SiteSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>(nameof(SharepointIds)); }
            set { BackingStore?.Set(nameof(SharepointIds), value); }
        }
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SiteCollection SiteCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SiteCollection>(nameof(SiteCollection)); }
            set { BackingStore?.Set(nameof(SiteCollection), value); }
        }
        /// <summary>The collection of the sub-sites under this site.</summary>
        public List<Site> Sites {
            get { return BackingStore?.Get<List<Site>>(nameof(Sites)); }
            set { BackingStore?.Set(nameof(Sites), value); }
        }
        /// <summary>The termStore under this site.</summary>
        public Store TermStore {
            get { return BackingStore?.Get<Store>(nameof(TermStore)); }
            set { BackingStore?.Set(nameof(TermStore), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Site CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<Microsoft.Graph.Beta.Models.Deleted>(Microsoft.Graph.Beta.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"externalColumns", n => { ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue).ToList(); } },
                {"lists", n => { Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue).ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<Microsoft.Graph.Beta.Models.Onenote>(Microsoft.Graph.Beta.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<SitePage>(SitePage.CreateFromDiscriminatorValue).ToList(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Beta.Models.Root>(Microsoft.Graph.Beta.Models.Root.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<SiteSettings>(SiteSettings.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", n => { SiteCollection = n.GetObjectValue<Microsoft.Graph.Beta.Models.SiteCollection>(Microsoft.Graph.Beta.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue).ToList(); } },
                {"termStore", n => { TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<SitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Root>("root", Root);
            writer.WriteObjectValue<SiteSettings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
        }
    }
}
