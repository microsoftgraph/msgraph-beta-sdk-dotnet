using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosWebContentFilterSpecificWebsitesAccess : IosWebContentFilterBase, IParsable {
        /// <summary>URL bookmarks which will be installed into built-in browser and user is only allowed to access websites through bookmarks. This collection can contain a maximum of 500 elements.</summary>
        public List<IosBookmark> SpecificWebsitesOnly {
            get { return BackingStore?.Get<List<IosBookmark>>("specificWebsitesOnly"); }
            set { BackingStore?.Set("specificWebsitesOnly", value); }
        }
        /// <summary>URL bookmarks which will be installed into built-in browser and user is only allowed to access websites through bookmarks. This collection can contain a maximum of 500 elements.</summary>
        public List<IosBookmark> WebsiteList {
            get { return BackingStore?.Get<List<IosBookmark>>("websiteList"); }
            set { BackingStore?.Set("websiteList", value); }
        }
        /// <summary>
        /// Instantiates a new IosWebContentFilterSpecificWebsitesAccess and sets the default values.
        /// </summary>
        public IosWebContentFilterSpecificWebsitesAccess() : base() {
            OdataType = "#microsoft.graph.iosWebContentFilterSpecificWebsitesAccess";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosWebContentFilterSpecificWebsitesAccess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosWebContentFilterSpecificWebsitesAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"specificWebsitesOnly", n => { SpecificWebsitesOnly = n.GetCollectionOfObjectValues<IosBookmark>(IosBookmark.CreateFromDiscriminatorValue)?.ToList(); } },
                {"websiteList", n => { WebsiteList = n.GetCollectionOfObjectValues<IosBookmark>(IosBookmark.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IosBookmark>("specificWebsitesOnly", SpecificWebsitesOnly);
            writer.WriteCollectionOfObjectValues<IosBookmark>("websiteList", WebsiteList);
        }
    }
}
