using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.TermStore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
        public List<ColumnDefinition> Columns { get; set; }
        /// <summary>The collection of content types defined for this site.</summary>
        public List<ContentType> ContentTypes { get; set; }
        public Deleted Deleted { get; set; }
        /// <summary>The full title for the site. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The default drive (document library) for this site.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Drive Drive { get; set; }
        /// <summary>The collection of drives (document libraries) under this site.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Drive> Drives { get; set; }
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
        public List<ColumnDefinition> ExternalColumns { get; set; }
        /// <summary>Used to address any item contained in this site. This collection can't be enumerated.</summary>
        public List<BaseItem> Items { get; set; }
        /// <summary>The collection of lists under this site.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.List> Lists { get; set; }
        /// <summary>Calls the OneNote service for notebook related operations.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Onenote Onenote { get; set; }
        /// <summary>The collection of long running operations for the site.</summary>
        public List<RichLongRunningOperation> Operations { get; set; }
        /// <summary>The collection of pages in the SitePages list in this site.</summary>
        public List<SitePage> Pages { get; set; }
        /// <summary>The permissions associated with the site. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Permission> Permissions { get; set; }
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Root Root { get; set; }
        public SiteSettings Settings { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public SharepointIds SharepointIds { get; set; }
        /// <summary>Provides details about the site's site collection. Available only on the root site. Read-only.</summary>
        public SiteCollection SiteCollection { get; set; }
        /// <summary>The collection of the sub-sites under this site.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Site> Sites { get; set; }
        /// <summary>The default termStore under this site.</summary>
        public Store TermStore { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"analytics", (o,n) => { (o as Site).Analytics = n.GetObjectValue<ItemAnalytics>(); } },
                {"columns", (o,n) => { (o as Site).Columns = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"contentTypes", (o,n) => { (o as Site).ContentTypes = n.GetCollectionOfObjectValues<ContentType>().ToList(); } },
                {"deleted", (o,n) => { (o as Site).Deleted = n.GetObjectValue<Deleted>(); } },
                {"displayName", (o,n) => { (o as Site).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as Site).Drive = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Drive>(); } },
                {"drives", (o,n) => { (o as Site).Drives = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Drive>().ToList(); } },
                {"externalColumns", (o,n) => { (o as Site).ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>().ToList(); } },
                {"items", (o,n) => { (o as Site).Items = n.GetCollectionOfObjectValues<BaseItem>().ToList(); } },
                {"lists", (o,n) => { (o as Site).Lists = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.List>().ToList(); } },
                {"onenote", (o,n) => { (o as Site).Onenote = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Onenote>(); } },
                {"operations", (o,n) => { (o as Site).Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>().ToList(); } },
                {"pages", (o,n) => { (o as Site).Pages = n.GetCollectionOfObjectValues<SitePage>().ToList(); } },
                {"permissions", (o,n) => { (o as Site).Permissions = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Permission>().ToList(); } },
                {"root", (o,n) => { (o as Site).Root = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Root>(); } },
                {"settings", (o,n) => { (o as Site).Settings = n.GetObjectValue<SiteSettings>(); } },
                {"sharepointIds", (o,n) => { (o as Site).SharepointIds = n.GetObjectValue<SharepointIds>(); } },
                {"siteCollection", (o,n) => { (o as Site).SiteCollection = n.GetObjectValue<SiteCollection>(); } },
                {"sites", (o,n) => { (o as Site).Sites = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Site>().ToList(); } },
                {"termStore", (o,n) => { (o as Site).TermStore = n.GetObjectValue<Store>(); } },
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
            writer.WriteObjectValue<Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.List>("lists", Lists);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<SitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Permission>("permissions", Permissions);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Root>("root", Root);
            writer.WriteObjectValue<SiteSettings>("settings", Settings);
            writer.WriteObjectValue<SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
        }
    }
}
