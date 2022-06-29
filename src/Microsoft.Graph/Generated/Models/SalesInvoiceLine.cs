using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SalesInvoiceLine : Entity, IParsable {
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
        /// <summary>The amountExcludingTax property</summary>
        public decimal? AmountExcludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(AmountExcludingTax)); }
            set { BackingStore?.Set(nameof(AmountExcludingTax), value); }
        }
        /// <summary>The amountIncludingTax property</summary>
        public decimal? AmountIncludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(AmountIncludingTax)); }
            set { BackingStore?.Set(nameof(AmountIncludingTax), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>(nameof(DiscountAmount)); }
            set { BackingStore?.Set(nameof(DiscountAmount), value); }
        }
        /// <summary>The discountAppliedBeforeTax property</summary>
        public bool? DiscountAppliedBeforeTax {
            get { return BackingStore?.Get<bool?>(nameof(DiscountAppliedBeforeTax)); }
            set { BackingStore?.Set(nameof(DiscountAppliedBeforeTax), value); }
        }
        /// <summary>The discountPercent property</summary>
        public decimal? DiscountPercent {
            get { return BackingStore?.Get<decimal?>(nameof(DiscountPercent)); }
            set { BackingStore?.Set(nameof(DiscountPercent), value); }
        }
        /// <summary>The documentId property</summary>
        public string DocumentId {
            get { return BackingStore?.Get<string>(nameof(DocumentId)); }
            set { BackingStore?.Set(nameof(DocumentId), value); }
        }
        /// <summary>The invoiceDiscountAllocation property</summary>
        public decimal? InvoiceDiscountAllocation {
            get { return BackingStore?.Get<decimal?>(nameof(InvoiceDiscountAllocation)); }
            set { BackingStore?.Set(nameof(InvoiceDiscountAllocation), value); }
        }
        /// <summary>The item property</summary>
        public Microsoft.Graph.Beta.Models.Item Item {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Item>(nameof(Item)); }
            set { BackingStore?.Set(nameof(Item), value); }
        }
        /// <summary>The itemId property</summary>
        public string ItemId {
            get { return BackingStore?.Get<string>(nameof(ItemId)); }
            set { BackingStore?.Set(nameof(ItemId), value); }
        }
        /// <summary>The lineType property</summary>
        public string LineType {
            get { return BackingStore?.Get<string>(nameof(LineType)); }
            set { BackingStore?.Set(nameof(LineType), value); }
        }
        /// <summary>The netAmount property</summary>
        public decimal? NetAmount {
            get { return BackingStore?.Get<decimal?>(nameof(NetAmount)); }
            set { BackingStore?.Set(nameof(NetAmount), value); }
        }
        /// <summary>The netAmountIncludingTax property</summary>
        public decimal? NetAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(NetAmountIncludingTax)); }
            set { BackingStore?.Set(nameof(NetAmountIncludingTax), value); }
        }
        /// <summary>The netTaxAmount property</summary>
        public decimal? NetTaxAmount {
            get { return BackingStore?.Get<decimal?>(nameof(NetTaxAmount)); }
            set { BackingStore?.Set(nameof(NetTaxAmount), value); }
        }
        /// <summary>The quantity property</summary>
        public decimal? Quantity {
            get { return BackingStore?.Get<decimal?>(nameof(Quantity)); }
            set { BackingStore?.Set(nameof(Quantity), value); }
        }
        /// <summary>The sequence property</summary>
        public int? Sequence {
            get { return BackingStore?.Get<int?>(nameof(Sequence)); }
            set { BackingStore?.Set(nameof(Sequence), value); }
        }
        /// <summary>The shipmentDate property</summary>
        public Date? ShipmentDate {
            get { return BackingStore?.Get<Date?>(nameof(ShipmentDate)); }
            set { BackingStore?.Set(nameof(ShipmentDate), value); }
        }
        /// <summary>The taxCode property</summary>
        public string TaxCode {
            get { return BackingStore?.Get<string>(nameof(TaxCode)); }
            set { BackingStore?.Set(nameof(TaxCode), value); }
        }
        /// <summary>The taxPercent property</summary>
        public decimal? TaxPercent {
            get { return BackingStore?.Get<decimal?>(nameof(TaxPercent)); }
            set { BackingStore?.Set(nameof(TaxPercent), value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>(nameof(TotalTaxAmount)); }
            set { BackingStore?.Set(nameof(TotalTaxAmount), value); }
        }
        /// <summary>The unitOfMeasureId property</summary>
        public string UnitOfMeasureId {
            get { return BackingStore?.Get<string>(nameof(UnitOfMeasureId)); }
            set { BackingStore?.Set(nameof(UnitOfMeasureId), value); }
        }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice {
            get { return BackingStore?.Get<decimal?>(nameof(UnitPrice)); }
            set { BackingStore?.Set(nameof(UnitPrice), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesInvoiceLine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesInvoiceLine();
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
                {"item", n => { Item = n.GetObjectValue<Microsoft.Graph.Beta.Models.Item>(Microsoft.Graph.Beta.Models.Item.CreateFromDiscriminatorValue); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"lineType", n => { LineType = n.GetStringValue(); } },
                {"netAmount", n => { NetAmount = n.GetDecimalValue(); } },
                {"netAmountIncludingTax", n => { NetAmountIncludingTax = n.GetDecimalValue(); } },
                {"netTaxAmount", n => { NetTaxAmount = n.GetDecimalValue(); } },
                {"quantity", n => { Quantity = n.GetDecimalValue(); } },
                {"sequence", n => { Sequence = n.GetIntValue(); } },
                {"shipmentDate", n => { ShipmentDate = n.GetDateValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Item>("item", Item);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("lineType", LineType);
            writer.WriteDecimalValue("netAmount", NetAmount);
            writer.WriteDecimalValue("netAmountIncludingTax", NetAmountIncludingTax);
            writer.WriteDecimalValue("netTaxAmount", NetTaxAmount);
            writer.WriteDecimalValue("quantity", Quantity);
            writer.WriteIntValue("sequence", Sequence);
            writer.WriteDateValue("shipmentDate", ShipmentDate);
            writer.WriteStringValue("taxCode", TaxCode);
            writer.WriteDecimalValue("taxPercent", TaxPercent);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteStringValue("unitOfMeasureId", UnitOfMeasureId);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
