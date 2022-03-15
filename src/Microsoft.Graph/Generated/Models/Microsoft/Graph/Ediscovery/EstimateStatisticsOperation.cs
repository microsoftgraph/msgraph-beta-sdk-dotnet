using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class EstimateStatisticsOperation : CaseOperation, IParsable {
        /// <summary>The estimated count of items for the sourceCollection that matched the content query.</summary>
        public int? IndexedItemCount { get; set; }
        /// <summary>The estimated size of items for the sourceCollection that matched the content query.</summary>
        public int? IndexedItemsSize { get; set; }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? MailboxCount { get; set; }
        /// <summary>The number of mailboxes that had search hits.</summary>
        public int? SiteCount { get; set; }
        /// <summary>eDiscovery collection, commonly known as a search.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection SourceCollection { get; set; }
        /// <summary>The estimated count of unindexed items for the collection.</summary>
        public int? UnindexedItemCount { get; set; }
        /// <summary>The estimated size of unindexed items for the collection.</summary>
        public int? UnindexedItemsSize { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EstimateStatisticsOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EstimateStatisticsOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"indexedItemCount", (o,n) => { (o as EstimateStatisticsOperation).IndexedItemCount = n.GetIntValue(); } },
                {"indexedItemsSize", (o,n) => { (o as EstimateStatisticsOperation).IndexedItemsSize = n.GetIntValue(); } },
                {"mailboxCount", (o,n) => { (o as EstimateStatisticsOperation).MailboxCount = n.GetIntValue(); } },
                {"siteCount", (o,n) => { (o as EstimateStatisticsOperation).SiteCount = n.GetIntValue(); } },
                {"sourceCollection", (o,n) => { (o as EstimateStatisticsOperation).SourceCollection = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
                {"unindexedItemCount", (o,n) => { (o as EstimateStatisticsOperation).UnindexedItemCount = n.GetIntValue(); } },
                {"unindexedItemsSize", (o,n) => { (o as EstimateStatisticsOperation).UnindexedItemsSize = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("indexedItemCount", IndexedItemCount);
            writer.WriteIntValue("indexedItemsSize", IndexedItemsSize);
            writer.WriteIntValue("mailboxCount", MailboxCount);
            writer.WriteIntValue("siteCount", SiteCount);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
            writer.WriteIntValue("unindexedItemCount", UnindexedItemCount);
            writer.WriteIntValue("unindexedItemsSize", UnindexedItemsSize);
        }
    }
}
