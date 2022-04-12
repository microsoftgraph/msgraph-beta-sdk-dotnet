using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GeneralLedgerEntry : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account { get; set; }
        /// <summary>The accountId property</summary>
        public string AccountId { get; set; }
        /// <summary>The accountNumber property</summary>
        public string AccountNumber { get; set; }
        /// <summary>The creditAmount property</summary>
        public decimal? CreditAmount { get; set; }
        /// <summary>The debitAmount property</summary>
        public decimal? DebitAmount { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The documentNumber property</summary>
        public string DocumentNumber { get; set; }
        /// <summary>The documentType property</summary>
        public string DocumentType { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The postingDate property</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"accountNumber", n => { AccountNumber = n.GetStringValue(); } },
                {"creditAmount", n => { CreditAmount = n.GetDecimalValue(); } },
                {"debitAmount", n => { DebitAmount = n.GetDecimalValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentNumber", n => { DocumentNumber = n.GetStringValue(); } },
                {"documentType", n => { DocumentType = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"postingDate", n => { PostingDate = n.GetDateValue(); } },
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
