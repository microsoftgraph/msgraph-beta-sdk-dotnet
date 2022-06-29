using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class EdiscoveryEstimateOperation : CaseOperation, IParsable {
        /// <summary>The estimated count of items for the search that matched the content query.</summary>
        public long? IndexedItemCount {
            get { return BackingStore?.Get<long?>(nameof(IndexedItemCount)); }
            set { BackingStore?.Set(nameof(IndexedItemCount), value); }
        }
        /// <summary>The estimated size of items for the search that matched the content query.</summary>
        public long? IndexedItemsSize {
            get { return BackingStore?.Get<long?>(nameof(IndexedItemsSize)); }
            set { BackingStore?.Set(nameof(IndexedItemsSize), value); }
        }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? MailboxCount {
            get { return BackingStore?.Get<int?>(nameof(MailboxCount)); }
            set { BackingStore?.Set(nameof(MailboxCount), value); }
        }
        /// <summary>eDiscovery search.</summary>
        public EdiscoverySearch Search {
            get { return BackingStore?.Get<EdiscoverySearch>(nameof(Search)); }
            set { BackingStore?.Set(nameof(Search), value); }
        }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? SiteCount {
            get { return BackingStore?.Get<int?>(nameof(SiteCount)); }
            set { BackingStore?.Set(nameof(SiteCount), value); }
        }
        /// <summary>The estimated count of unindexed items for the collection.</summary>
        public long? UnindexedItemCount {
            get { return BackingStore?.Get<long?>(nameof(UnindexedItemCount)); }
            set { BackingStore?.Set(nameof(UnindexedItemCount), value); }
        }
        /// <summary>The estimated size of unindexed items for the collection.</summary>
        public long? UnindexedItemsSize {
            get { return BackingStore?.Get<long?>(nameof(UnindexedItemsSize)); }
            set { BackingStore?.Set(nameof(UnindexedItemsSize), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryEstimateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryEstimateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"indexedItemCount", n => { IndexedItemCount = n.GetLongValue(); } },
                {"indexedItemsSize", n => { IndexedItemsSize = n.GetLongValue(); } },
                {"mailboxCount", n => { MailboxCount = n.GetIntValue(); } },
                {"search", n => { Search = n.GetObjectValue<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue); } },
                {"siteCount", n => { SiteCount = n.GetIntValue(); } },
                {"unindexedItemCount", n => { UnindexedItemCount = n.GetLongValue(); } },
                {"unindexedItemsSize", n => { UnindexedItemsSize = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("indexedItemCount", IndexedItemCount);
            writer.WriteLongValue("indexedItemsSize", IndexedItemsSize);
            writer.WriteIntValue("mailboxCount", MailboxCount);
            writer.WriteObjectValue<EdiscoverySearch>("search", Search);
            writer.WriteIntValue("siteCount", SiteCount);
            writer.WriteLongValue("unindexedItemCount", UnindexedItemCount);
            writer.WriteLongValue("unindexedItemsSize", UnindexedItemsSize);
        }
    }
}
