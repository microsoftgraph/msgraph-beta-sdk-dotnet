using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class SalesOrderLine : Entity, IParsable {
        /// <summary>The account property</summary>
        public Microsoft.Graph.Beta.Models.Account Account {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Account>("account"); }
            set { BackingStore?.Set("account", value); }
        }
        /// <summary>The accountId property</summary>
        public string AccountId {
            get { return BackingStore?.Get<string>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
        /// <summary>The amountExcludingTax property</summary>
        public decimal? AmountExcludingTax {
            get { return BackingStore?.Get<decimal?>("amountExcludingTax"); }
            set { BackingStore?.Set("amountExcludingTax", value); }
        }
        /// <summary>The amountIncludingTax property</summary>
        public decimal? AmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("amountIncludingTax"); }
            set { BackingStore?.Set("amountIncludingTax", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>("discountAmount"); }
            set { BackingStore?.Set("discountAmount", value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>("discountAppliedBeforeTax"); }
            set { BackingStore?.Set("discountAppliedBeforeTax", value); }
        }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent {
            get { return BackingStore?.Get<decimal?>("discountPercent"); }
            set { BackingStore?.Set("discountPercent", value); }
        }
        /// <summary>The documentId property</summary>
        public string DocumentId {
            get { return BackingStore?.Get<string>("documentId"); }
            set { BackingStore?.Set("documentId", value); }
        }
        /// <summary>The invoiceDiscountAllocation property</summary>
        public decimal? InvoiceDiscountAllocation {
            get { return BackingStore?.Get<decimal?>("invoiceDiscountAllocation"); }
            set { BackingStore?.Set("invoiceDiscountAllocation", value); }
        }
        /// <summary>The invoicedQuantity property</summary>
        public decimal? InvoicedQuantity {
            get { return BackingStore?.Get<decimal?>("invoicedQuantity"); }
            set { BackingStore?.Set("invoicedQuantity", value); }
        }
        /// <summary>The invoiceQuantity property</summary>
        public decimal? InvoiceQuantity {
            get { return BackingStore?.Get<decimal?>("invoiceQuantity"); }
            set { BackingStore?.Set("invoiceQuantity", value); }
        }
        /// <summary>The item property</summary>
        public Microsoft.Graph.Beta.Models.Item Item {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Item>("item"); }
            set { BackingStore?.Set("item", value); }
        }
        /// <summary>The itemId property</summary>
        public string ItemId {
            get { return BackingStore?.Get<string>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
        /// <summary>The lineType property</summary>
        public string LineType {
            get { return BackingStore?.Get<string>("lineType"); }
            set { BackingStore?.Set("lineType", value); }
        }
        /// <summary>The netAmount property</summary>
        public decimal? NetAmount {
            get { return BackingStore?.Get<decimal?>("netAmount"); }
            set { BackingStore?.Set("netAmount", value); }
        }
        /// <summary>The netAmountIncludingTax property</summary>
        public decimal? NetAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>("netAmountIncludingTax"); }
            set { BackingStore?.Set("netAmountIncludingTax", value); }
        }
        /// <summary>The netTaxAmount property</summary>
        public decimal? NetTaxAmount {
            get { return BackingStore?.Get<decimal?>("netTaxAmount"); }
            set { BackingStore?.Set("netTaxAmount", value); }
        }
        /// <summary>The quantity property</summary>
        public decimal? Quantity {
            get { return BackingStore?.Get<decimal?>("quantity"); }
            set { BackingStore?.Set("quantity", value); }
        }
        /// <summary>The sequence property</summary>
        public int? Sequence {
            get { return BackingStore?.Get<int?>("sequence"); }
            set { BackingStore?.Set("sequence", value); }
        }
        /// <summary>The shipmentDate property</summary>
        public Date? ShipmentDate {
            get { return BackingStore?.Get<Date?>("shipmentDate"); }
            set { BackingStore?.Set("shipmentDate", value); }
        }
        /// <summary>The shippedQuantity property</summary>
        public decimal? ShippedQuantity {
            get { return BackingStore?.Get<decimal?>("shippedQuantity"); }
            set { BackingStore?.Set("shippedQuantity", value); }
        }
        /// <summary>The shipQuantity property</summary>
        public decimal? ShipQuantity {
            get { return BackingStore?.Get<decimal?>("shipQuantity"); }
            set { BackingStore?.Set("shipQuantity", value); }
        }
        /// <summary>The taxCode property</summary>
        public string TaxCode {
            get { return BackingStore?.Get<string>("taxCode"); }
            set { BackingStore?.Set("taxCode", value); }
        }
        /// <summary>The taxPercent property</summary>
        public decimal? TaxPercent {
            get { return BackingStore?.Get<decimal?>("taxPercent"); }
            set { BackingStore?.Set("taxPercent", value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>("totalTaxAmount"); }
            set { BackingStore?.Set("totalTaxAmount", value); }
        }
        /// <summary>The unitOfMeasureId property</summary>
        public string UnitOfMeasureId {
            get { return BackingStore?.Get<string>("unitOfMeasureId"); }
            set { BackingStore?.Set("unitOfMeasureId", value); }
        }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice {
            get { return BackingStore?.Get<decimal?>("unitPrice"); }
            set { BackingStore?.Set("unitPrice", value); }
        }
        /// <summary>
        /// Instantiates a new salesOrderLine and sets the default values.
        /// </summary>
        public SalesOrderLine() : base() {
            OdataType = "#microsoft.graph.salesOrderLine";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesOrderLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesOrderLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account", n => { Account = n.GetObjectValue<Microsoft.Graph.Beta.Models.Account>(Microsoft.Graph.Beta.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"amountExcludingTax", n => { AmountExcludingTax = n.GetDecimalValue(); } },
                {"amountIncludingTax", n => { AmountIncludingTax = n.GetDecimalValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"discountAppliedBeforeTax", n => { DiscountAppliedBeforeTax = n.GetBoolValue(); } },
                {"discountPercent", n => { DiscountPercent = n.GetDecimalValue(); } },
                {"documentId", n => { DocumentId = n.GetStringValue(); } },
                {"invoiceDiscountAllocation", n => { InvoiceDiscountAllocation = n.GetDecimalValue(); } },
                {"invoicedQuantity", n => { InvoicedQuantity = n.GetDecimalValue(); } },
                {"invoiceQuantity", n => { InvoiceQuantity = n.GetDecimalValue(); } },
                {"item", n => { Item = n.GetObjectValue<Microsoft.Graph.Beta.Models.Item>(Microsoft.Graph.Beta.Models.Item.CreateFromDiscriminatorValue); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"lineType", n => { LineType = n.GetStringValue(); } },
                {"netAmount", n => { NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", n => { NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", n => { NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", n => { Quantity = n.GetDecimalValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
                {"shipmentDate", n => { ShipmentDate = n.GetDateValue(); } },
                {"shippedQuantity", n => { ShippedQuantity = n.GetDecimalValue(); } },
                {"shipQuantity", n => { ShipQuantity = n.GetDecimalValue(); } },
                {"taxCode", n => { TaxCode = n.GetStringValue(); } },
                {"taxPercent", n => { TaxPercent = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                {"unitOfMeasureId", n => { UnitOfMeasureId = n.GetStringValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
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
            writer.WriteDecimalValue("amountExcludingTax", AmountExcludingTax);
            writer.WriteDecimalValue("amountIncludingTax", AmountIncludingTax);
            writer.WriteStringValue("description", Description);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteBoolValue("discountAppliedBeforeTax", DiscountAppliedBeforeTax);
            writer.WriteDecimalValue("discountPercent", DiscountPercent);
            writer.WriteStringValue("documentId", DocumentId);
            writer.WriteDecimalValue("invoiceDiscountAllocation", InvoiceDiscountAllocation);
            writer.WriteDecimalValue("invoicedQuantity", InvoicedQuantity);
            writer.WriteDecimalValue("invoiceQuantity", InvoiceQuantity);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Item>("item", Item);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteDateValue("shipmentDate", ShipmentDate);
            writer.WriteDecimalValue("shippedQuantity", ShippedQuantity);
            writer.WriteDecimalValue("shipQuantity", ShipQuantity);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteStringValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
