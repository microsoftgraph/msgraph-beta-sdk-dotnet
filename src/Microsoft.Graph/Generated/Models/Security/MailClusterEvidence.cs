using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class MailClusterEvidence : AlertEvidence, IParsable {
        /// <summary>The clusterBy property</summary>
        public string ClusterBy {
            get { return BackingStore?.Get<string>(nameof(ClusterBy)); }
            set { BackingStore?.Set(nameof(ClusterBy), value); }
        }
        /// <summary>The clusterByValue property</summary>
        public string ClusterByValue {
            get { return BackingStore?.Get<string>(nameof(ClusterByValue)); }
            set { BackingStore?.Set(nameof(ClusterByValue), value); }
        }
        /// <summary>The emailCount property</summary>
        public long? EmailCount {
            get { return BackingStore?.Get<long?>(nameof(EmailCount)); }
            set { BackingStore?.Set(nameof(EmailCount), value); }
        }
        /// <summary>The networkMessageIds property</summary>
        public List<string> NetworkMessageIds {
            get { return BackingStore?.Get<List<string>>(nameof(NetworkMessageIds)); }
            set { BackingStore?.Set(nameof(NetworkMessageIds), value); }
        }
        /// <summary>The query property</summary>
        public string Query {
            get { return BackingStore?.Get<string>(nameof(Query)); }
            set { BackingStore?.Set(nameof(Query), value); }
        }
        /// <summary>The urn property</summary>
        public string Urn {
            get { return BackingStore?.Get<string>(nameof(Urn)); }
            set { BackingStore?.Set(nameof(Urn), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MailClusterEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailClusterEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clusterBy", n => { ClusterBy = n.GetStringValue(); } },
                {"clusterByValue", n => { ClusterByValue = n.GetStringValue(); } },
                {"emailCount", n => { EmailCount = n.GetLongValue(); } },
                {"networkMessageIds", n => { NetworkMessageIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"query", n => { Query = n.GetStringValue(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clusterBy", ClusterBy);
            writer.WriteStringValue("clusterByValue", ClusterByValue);
            writer.WriteLongValue("emailCount", EmailCount);
            writer.WriteCollectionOfPrimitiveValues<string>("networkMessageIds", NetworkMessageIds);
            writer.WriteStringValue("query", Query);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
