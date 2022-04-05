using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class JournalLine : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account { get; set; }
        /// <summary>The accountId property</summary>
        public string AccountId { get; set; }
        /// <summary>The accountNumber property</summary>
        public string AccountNumber { get; set; }
        /// <summary>The amount property</summary>
        public decimal? Amount { get; set; }
        /// <summary>The comment property</summary>
        public string Comment { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The documentNumber property</summary>
        public string DocumentNumber { get; set; }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber { get; set; }
        /// <summary>The journalDisplayName property</summary>
        public string JournalDisplayName { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The lineNumber property</summary>
        public int? LineNumber { get; set; }
        /// <summary>The postingDate property</summary>
        public Date? PostingDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new JournalLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JournalLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as JournalLine).Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", (o,n) => { (o as JournalLine).AccountId = n.GetStringValue(); } },
                {"accountNumber", (o,n) => { (o as JournalLine).AccountNumber = n.GetStringValue(); } },
                {"amount", (o,n) => { (o as JournalLine).Amount = n.GetDecimalValue(); } },
                {"comment", (o,n) => { (o as JournalLine).Comment = n.GetStringValue(); } },
                {"description", (o,n) => { (o as JournalLine).Description = n.GetStringValue(); } },
                {"documentNumber", (o,n) => { (o as JournalLine).DocumentNumber = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as JournalLine).ExternalDocumentNumber = n.GetStringValue(); } },
                {"journalDisplayName", (o,n) => { (o as JournalLine).JournalDisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as JournalLine).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lineNumber", (o,n) => { (o as JournalLine).LineNumber = n.GetIntValue(); } },
                {"postingDate", (o,n) => { (o as JournalLine).PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Account>("account", Account);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteStringValue("accountNumber", AccountNumber);
            writer.WriteDecimalValue("amount", Amount);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("documentNumber", DocumentNumber);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteStringValue("journalDisplayName", JournalDisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("lineNumber", LineNumber);
            writer.WriteDateValue("postingDate", PostingDate);
        }
    }
}
