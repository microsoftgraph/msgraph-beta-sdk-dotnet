using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CustomerPayment : Entity, IParsable {
        /// <summary>The amount property</summary>
        public decimal? Amount { get; set; }
        /// <summary>The appliesToInvoiceId property</summary>
        public string AppliesToInvoiceId { get; set; }
        /// <summary>The appliesToInvoiceNumber property</summary>
        public string AppliesToInvoiceNumber { get; set; }
        /// <summary>The comment property</summary>
        public string Comment { get; set; }
        /// <summary>The contactId property</summary>
        public string ContactId { get; set; }
        /// <summary>The customer property</summary>
        public Microsoft.Graph.Beta.Models.Customer Customer { get; set; }
        /// <summary>The customerId property</summary>
        public string CustomerId { get; set; }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber { get; set; }
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
        public static new CustomerPayment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerPayment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"amount", (o,n) => { (o as CustomerPayment).Amount = n.GetDecimalValue(); } },
                {"appliesToInvoiceId", (o,n) => { (o as CustomerPayment).AppliesToInvoiceId = n.GetStringValue(); } },
                {"appliesToInvoiceNumber", (o,n) => { (o as CustomerPayment).AppliesToInvoiceNumber = n.GetStringValue(); } },
                {"comment", (o,n) => { (o as CustomerPayment).Comment = n.GetStringValue(); } },
                {"contactId", (o,n) => { (o as CustomerPayment).ContactId = n.GetStringValue(); } },
                {"customer", (o,n) => { (o as CustomerPayment).Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", (o,n) => { (o as CustomerPayment).CustomerId = n.GetStringValue(); } },
                {"customerNumber", (o,n) => { (o as CustomerPayment).CustomerNumber = n.GetStringValue(); } },
                {"description", (o,n) => { (o as CustomerPayment).Description = n.GetStringValue(); } },
                {"documentNumber", (o,n) => { (o as CustomerPayment).DocumentNumber = n.GetStringValue(); } },
                {"externalDocumentNumber", (o,n) => { (o as CustomerPayment).ExternalDocumentNumber = n.GetStringValue(); } },
                {"journalDisplayName", (o,n) => { (o as CustomerPayment).JournalDisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CustomerPayment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lineNumber", (o,n) => { (o as CustomerPayment).LineNumber = n.GetIntValue(); } },
                {"postingDate", (o,n) => { (o as CustomerPayment).PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
