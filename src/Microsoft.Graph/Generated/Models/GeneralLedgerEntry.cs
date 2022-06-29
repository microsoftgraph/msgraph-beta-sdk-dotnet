using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class GeneralLedgerEntry : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account>(nameof(Account)); }
            set { BackingStore?.Set(nameof(Account), value); }
        }
        /// <summary>The accountId property</summary>
        public string AccountId {
            get { return BackingStore?.Get<string>(nameof(AccountId)); }
            set { BackingStore?.Set(nameof(AccountId), value); }
        }
        /// <summary>The accountNumber property</summary>
        public string AccountNumber {
            get { return BackingStore?.Get<string>(nameof(AccountNumber)); }
            set { BackingStore?.Set(nameof(AccountNumber), value); }
        }
        /// <summary>The creditAmount property</summary>
        public decimal? CreditAmount {
            get { return BackingStore?.Get<decimal?>(nameof(CreditAmount)); }
            set { BackingStore?.Set(nameof(CreditAmount), value); }
        }
        /// <summary>The debitAmount property</summary>
        public decimal? DebitAmount {
            get { return BackingStore?.Get<decimal?>(nameof(DebitAmount)); }
            set { BackingStore?.Set(nameof(DebitAmount), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The documentNumber property</summary>
        public string DocumentNumber {
            get { return BackingStore?.Get<string>(nameof(DocumentNumber)); }
            set { BackingStore?.Set(nameof(DocumentNumber), value); }
        }
        /// <summary>The documentType property</summary>
        public string DocumentType {
            get { return BackingStore?.Get<string>(nameof(DocumentType)); }
            set { BackingStore?.Set(nameof(DocumentType), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The postingDate property</summary>
        public Date? PostingDate {
            get { return BackingStore?.Get<Date?>(nameof(PostingDate)); }
            set { BackingStore?.Set(nameof(PostingDate), value); }
        }
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
