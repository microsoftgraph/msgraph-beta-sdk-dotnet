using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.TermStore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>The collection of content types defined for this site.</summary>
        public List<ContentType> ContentTypes { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted Deleted { get; set; }
        /// <summary>The full title for the site. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The default drive (document library) for this site.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Drive Drive { get; set; }
        /// <summary>The collection of drives (document libraries) under this site.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Drive> Drives { get; set; }
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
        public List<ColumnDefinition> ExternalColumns { get; set; }
        /// <summary>Used to address any item contained in this site. This collection can't be enumerated.</summary>
        public List<BaseItem> Items { get; set; }
        /// <summary>The collection of lists under this site.</summary>
        public List<List> Lists { get; set; }
        /// <summary>Calls the OneNote service for notebook related operations.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Onenote Onenote { get; set; }
        /// <summary>The collection of long running operations for the site.</summary>
        public List<RichLongRunningOperation> Operations { get; set; }
        /// <summary>The collection of pages in the SitePages list in this site.</summary>
        public List<SitePage> Pages { get; set; }
        /// <summary>The permissions associated with the site. Nullable.</summary>
        public List<Permission> Permissions { get; set; }
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Root Root { get; set; }
        public SiteSettings Settings { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>Provides details about the site's site collection. Available only on the root site. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SiteCollection SiteCollection { get; set; }
        /// <summary>The collection of the sub-sites under this site.</summary>
        public List<Site> Sites { get; set; }
        /// <summary>The default termStore under this site.</summary>
        public Store TermStore { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"analytics", (o,n) => { (o as Site).Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", (o,n) => { (o as Site).Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"contentTypes", (o,n) => { (o as Site).ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"deleted", (o,n) => { (o as Site).Deleted = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>(MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as Site).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as Site).Drive = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Drive>(MicrosoftGraphSdk.Models.Microsoft.Graph.Drive.CreateFromDiscriminatorValue); } },
                {"drives", (o,n) => { (o as Site).Drives = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Drive>(MicrosoftGraphSdk.Models.Microsoft.Graph.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"externalColumns", (o,n) => { (o as Site).ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"items", (o,n) => { (o as Site).Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue).ToList(); } },
                {"lists", (o,n) => { (o as Site).Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue).ToList(); } },
                {"onenote", (o,n) => { (o as Site).Onenote = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Onenote>(MicrosoftGraphSdk.Models.Microsoft.Graph.Onenote.CreateFromDiscriminatorValue); } },
                {"operations", (o,n) => { (o as Site).Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"pages", (o,n) => { (o as Site).Pages = n.GetCollectionOfObjectValues<SitePage>(SitePage.CreateFromDiscriminatorValue).ToList(); } },
                {"permissions", (o,n) => { (o as Site).Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"root", (o,n) => { (o as Site).Root = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Root>(MicrosoftGraphSdk.Models.Microsoft.Graph.Root.CreateFromDiscriminatorValue); } },
                {"settings", (o,n) => { (o as Site).Settings = n.GetObjectValue<SiteSettings>(SiteSettings.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as Site).SharepointIds = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>(MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", (o,n) => { (o as Site).SiteCollection = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SiteCollection>(MicrosoftGraphSdk.Models.Microsoft.Graph.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", (o,n) => { (o as Site).Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue).ToList(); } },
                {"termStore", (o,n) => { (o as Site).TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<SitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Root>("root", Root);
            writer.WriteObjectValue<SiteSettings>("settings", Settings);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
        }
    }
}
