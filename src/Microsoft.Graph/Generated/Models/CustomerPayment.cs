using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class CustomerPayment : Entity, IParsable {
        /// <summary>The amount property</summary>
        public decimal? Amount {
            get { return BackingStore?.Get<decimal?>("amount"); }
            set { BackingStore?.Set("amount", value); }
        }
        /// <summary>The appliesToInvoiceId property</summary>
        public string AppliesToInvoiceId {
            get { return BackingStore?.Get<string>("appliesToInvoiceId"); }
            set { BackingStore?.Set("appliesToInvoiceId", value); }
        }
        /// <summary>The appliesToInvoiceNumber property</summary>
        public string AppliesToInvoiceNumber {
            get { return BackingStore?.Get<string>("appliesToInvoiceNumber"); }
            set { BackingStore?.Set("appliesToInvoiceNumber", value); }
        }
        /// <summary>The comment property</summary>
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
        /// <summary>The contactId property</summary>
        public string ContactId {
            get { return BackingStore?.Get<string>("contactId"); }
            set { BackingStore?.Set("contactId", value); }
        }
        /// <summary>The customer property</summary>
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>("customer"); }
            set { BackingStore?.Set("customer", value); }
        }
        /// <summary>The customerId property</summary>
        public string CustomerId {
            get { return BackingStore?.Get<string>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber {
            get { return BackingStore?.Get<string>("customerNumber"); }
            set { BackingStore?.Set("customerNumber", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The documentNumber property</summary>
        public string DocumentNumber {
            get { return BackingStore?.Get<string>("documentNumber"); }
            set { BackingStore?.Set("documentNumber", value); }
        }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>("externalDocumentNumber"); }
            set { BackingStore?.Set("externalDocumentNumber", value); }
        }
        /// <summary>The journalDisplayName property</summary>
        public string JournalDisplayName {
            get { return BackingStore?.Get<string>("journalDisplayName"); }
            set { BackingStore?.Set("journalDisplayName", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The lineNumber property</summary>
        public int? LineNumber {
            get { return BackingStore?.Get<int?>("lineNumber"); }
            set { BackingStore?.Set("lineNumber", value); }
        }
        /// <summary>The postingDate property</summary>
        public Date? PostingDate {
            get { return BackingStore?.Get<Date?>("postingDate"); }
            set { BackingStore?.Set("postingDate", value); }
        }
        /// <summary>
        /// Instantiates a new customerPayment and sets the default values.
        /// </summary>
        public CustomerPayment() : base() {
            OdataType = "#microsoft.graph.customerPayment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomerPayment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerPayment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"amount", n => { Amount = n.GetDecimalValue(); } },
                {"appliesToInvoiceId", n => { AppliesToInvoiceId = n.GetStringValue(); } },
                {"appliesToInvoiceNumber", n => { AppliesToInvoiceNumber = n.GetStringValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"contactId", n => { ContactId = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentNumber", n => { DocumentNumber = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"journalDisplayName", n => { JournalDisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lineNumber", n => { LineNumber = n.GetIntValue(); } },
                {"postingDate", n => { PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDecimalValue("amount", Amount);
            writer.WriteStringValue("appliesToInvoiceId", AppliesToInvoiceId);
            writer.WriteStringValue("appliesToInvoiceNumber", AppliesToInvoiceNumber);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("contactId", ContactId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerNumber", CustomerNumber);
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
