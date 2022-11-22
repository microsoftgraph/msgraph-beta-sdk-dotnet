using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class EstimateStatisticsOperation : CaseOperation, IParsable {
        /// <summary>The estimated count of items for the sourceCollection that matched the content query.</summary>
        public long? IndexedItemCount {
            get { return BackingStore?.Get<long?>("indexedItemCount"); }
            set { BackingStore?.Set("indexedItemCount", value); }
        }
        /// <summary>The estimated size of items for the sourceCollection that matched the content query.</summary>
        public long? IndexedItemsSize {
            get { return BackingStore?.Get<long?>("indexedItemsSize"); }
            set { BackingStore?.Set("indexedItemsSize", value); }
        }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? MailboxCount {
            get { return BackingStore?.Get<int?>("mailboxCount"); }
            set { BackingStore?.Set("mailboxCount", value); }
        }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? SiteCount {
            get { return BackingStore?.Get<int?>("siteCount"); }
            set { BackingStore?.Set("siteCount", value); }
        }
        /// <summary>eDiscovery collection, commonly known as a search.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection SourceCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>("sourceCollection"); }
            set { BackingStore?.Set("sourceCollection", value); }
        }
        /// <summary>The estimated count of unindexed items for the collection.</summary>
        public long? UnindexedItemCount {
            get { return BackingStore?.Get<long?>("unindexedItemCount"); }
            set { BackingStore?.Set("unindexedItemCount", value); }
        }
        /// <summary>The estimated size of unindexed items for the collection.</summary>
        public long? UnindexedItemsSize {
            get { return BackingStore?.Get<long?>("unindexedItemsSize"); }
            set { BackingStore?.Set("unindexedItemsSize", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EstimateStatisticsOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EstimateStatisticsOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"indexedItemCount", n => { IndexedItemCount = n.GetLongValue(); } },
                {"indexedItemsSize", n => { IndexedItemsSize = n.GetLongValue(); } },
                {"mailboxCount", n => { MailboxCount = n.GetIntValue(); } },
                {"siteCount", n => { SiteCount = n.GetIntValue(); } },
                {"sourceCollection", n => { SourceCollection = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>(Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
                {"unindexedItemCount", n => { UnindexedItemCount = n.GetLongValue(); } },
                {"unindexedItemsSize", n => { UnindexedItemsSize = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("indexedItemCount", IndexedItemCount);
            writer.WriteLongValue("indexedItemsSize", IndexedItemsSize);
            writer.WriteIntValue("mailboxCount", MailboxCount);
            writer.WriteIntValue("siteCount", SiteCount);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
            writer.WriteLongValue("unindexedItemCount", UnindexedItemCount);
            writer.WriteLongValue("unindexedItemsSize", UnindexedItemsSize);
        }
    }
}
