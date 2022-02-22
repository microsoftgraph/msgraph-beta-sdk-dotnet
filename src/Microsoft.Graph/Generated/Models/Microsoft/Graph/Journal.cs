using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Journal : Entity, IParsable {
        public MicrosoftGraph.Models.Microsoft.Graph.Account Account { get; set; }
        public string BalancingAccountId { get; set; }
        public string BalancingAccountNumber { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public List<JournalLine> JournalLines { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as Journal).Account = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Account>(); } },
                {"balancingAccountId", (o,n) => { (o as Journal).BalancingAccountId = n.GetStringValue(); } },
                {"balancingAccountNumber", (o,n) => { (o as Journal).BalancingAccountNumber = n.GetStringValue(); } },
                {"code", (o,n) => { (o as Journal).Code = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Journal).DisplayName = n.GetStringValue(); } },
                {"journalLines", (o,n) => { (o as Journal).JournalLines = n.GetCollectionOfObjectValues<JournalLine>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Journal).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Account>("account", Account);
            writer.WriteStringValue("balancingAccountId", BalancingAccountId);
            writer.WriteStringValue("balancingAccountNumber", BalancingAccountNumber);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<JournalLine>("journalLines", JournalLines);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
