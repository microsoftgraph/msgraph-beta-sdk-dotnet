using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class JournalLine : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Account Account { get; set; }
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Amount { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public string DocumentNumber { get; set; }
        public string ExternalDocumentNumber { get; set; }
        public string JournalDisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public int? LineNumber { get; set; }
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
                {"account", (o,n) => { (o as JournalLine).Account = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>(MicrosoftGraphSdk.Models.Microsoft.Graph.Account.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>("account", Account);
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
