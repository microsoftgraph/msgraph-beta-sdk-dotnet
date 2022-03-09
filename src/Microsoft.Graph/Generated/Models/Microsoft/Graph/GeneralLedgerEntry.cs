using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class GeneralLedgerEntry : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Account Account { get; set; }
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmount { get; set; }
        public string Description { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentType { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public Date? PostingDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GeneralLedgerEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GeneralLedgerEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as GeneralLedgerEntry).Account = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>(MicrosoftGraphSdk.Models.Microsoft.Graph.Account.CreateFromDiscriminatorValue); } },
                {"accountId", (o,n) => { (o as GeneralLedgerEntry).AccountId = n.GetStringValue(); } },
                {"accountNumber", (o,n) => { (o as GeneralLedgerEntry).AccountNumber = n.GetStringValue(); } },
                {"creditAmount", (o,n) => { (o as GeneralLedgerEntry).CreditAmount = n.GetDecimalValue(); } },
                {"debitAmount", (o,n) => { (o as GeneralLedgerEntry).DebitAmount = n.GetDecimalValue(); } },
                {"description", (o,n) => { (o as GeneralLedgerEntry).Description = n.GetStringValue(); } },
                {"documentNumber", (o,n) => { (o as GeneralLedgerEntry).DocumentNumber = n.GetStringValue(); } },
                {"documentType", (o,n) => { (o as GeneralLedgerEntry).DocumentType = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GeneralLedgerEntry).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"postingDate", (o,n) => { (o as GeneralLedgerEntry).PostingDate = n.GetDateValue(); } },
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
            writer.WriteDecimalValue("creditAmount", CreditAmount);
            writer.WriteDecimalValue("debitAmount", DebitAmount);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("documentNumber", DocumentNumber);
            writer.WriteStringValue("documentType", DocumentType);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateValue("postingDate", PostingDate);
        }
    }
}
