using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Item {
    public class Item : Entity, IParsable {
        public string BaseUnitOfMeasureId { get; set; }
        public bool? Blocked { get; set; }
        public string DisplayName { get; set; }
        public string Gtin { get; set; }
        public Decimal? Inventory { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.ItemCategory ItemCategory { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ItemCategoryId { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.Picture> Picture { get; set; }
        public bool? PriceIncludesTax { get; set; }
        public string TaxGroupCode { get; set; }
        public string TaxGroupId { get; set; }
        public string Type { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? UnitPrice { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"baseUnitOfMeasureId", (o,n) => { (o as Item).BaseUnitOfMeasureId = n.GetStringValue(); } },
                {"blocked", (o,n) => { (o as Item).Blocked = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as Item).DisplayName = n.GetStringValue(); } },
                {"gtin", (o,n) => { (o as Item).Gtin = n.GetStringValue(); } },
                {"inventory", (o,n) => { (o as Item).Inventory = n.GetDecimalValue(); } },
                {"itemCategory", (o,n) => { (o as Item).ItemCategory = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ItemCategory>(); } },
                {"itemCategoryCode", (o,n) => { (o as Item).ItemCategoryCode = n.GetStringValue(); } },
                {"itemCategoryId", (o,n) => { (o as Item).ItemCategoryId = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Item).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as Item).Number = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as Item).Picture = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Picture>().ToList(); } },
                {"priceIncludesTax", (o,n) => { (o as Item).PriceIncludesTax = n.GetBoolValue(); } },
                {"taxGroupCode", (o,n) => { (o as Item).TaxGroupCode = n.GetStringValue(); } },
                {"taxGroupId", (o,n) => { (o as Item).TaxGroupId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Item).Type = n.GetStringValue(); } },
                {"unitCost", (o,n) => { (o as Item).UnitCost = n.GetDecimalValue(); } },
                {"unitPrice", (o,n) => { (o as Item).UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("baseUnitOfMeasureId", BaseUnitOfMeasureId);
            writer.WriteBoolValue("blocked", Blocked);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("gtin", Gtin);
            writer.WriteDecimalValue("inventory", Inventory);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.ItemCategory>("itemCategory", ItemCategory);
            writer.WriteStringValue("itemCategoryCode", ItemCategoryCode);
            writer.WriteStringValue("itemCategoryId", ItemCategoryId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Picture>("picture", Picture);
            writer.WriteBoolValue("priceIncludesTax", PriceIncludesTax);
            writer.WriteStringValue("taxGroupCode", TaxGroupCode);
            writer.WriteStringValue("taxGroupId", TaxGroupId);
            writer.WriteStringValue("type", Type);
            writer.WriteDecimalValue("unitCost", UnitCost);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
