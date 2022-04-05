using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Item {
    public class Item : Entity, IParsable {
        /// <summary>The baseUnitOfMeasureId property</summary>
        public string BaseUnitOfMeasureId { get; set; }
        /// <summary>The blocked property</summary>
        public bool? Blocked { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The gtin property</summary>
        public string Gtin { get; set; }
        /// <summary>The inventory property</summary>
        public decimal? Inventory { get; set; }
        /// <summary>The itemCategory property</summary>
        public Microsoft.Graph.Beta.Models.ItemCategory ItemCategory { get; set; }
        /// <summary>The itemCategoryCode property</summary>
        public string ItemCategoryCode { get; set; }
        /// <summary>The itemCategoryId property</summary>
        public string ItemCategoryId { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture { get; set; }
        /// <summary>The priceIncludesTax property</summary>
        public bool? PriceIncludesTax { get; set; }
        /// <summary>The taxGroupCode property</summary>
        public string TaxGroupCode { get; set; }
        /// <summary>The taxGroupId property</summary>
        public string TaxGroupId { get; set; }
        /// <summary>The type property</summary>
        public string Type { get; set; }
        /// <summary>The unitCost property</summary>
        public decimal? UnitCost { get; set; }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Item CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
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
                {"itemCategory", (o,n) => { (o as Item).ItemCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>(Microsoft.Graph.Beta.Models.ItemCategory.CreateFromDiscriminatorValue); } },
                {"itemCategoryCode", (o,n) => { (o as Item).ItemCategoryCode = n.GetStringValue(); } },
                {"itemCategoryId", (o,n) => { (o as Item).ItemCategoryId = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Item).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as Item).Number = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as Item).Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>("itemCategory", ItemCategory);
            writer.WriteStringValue("itemCategoryCode", ItemCategoryCode);
            writer.WriteStringValue("itemCategoryId", ItemCategoryId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("priceIncludesTax", PriceIncludesTax);
            writer.WriteStringValue("taxGroupCode", TaxGroupCode);
            writer.WriteStringValue("taxGroupId", TaxGroupId);
            writer.WriteStringValue("type", Type);
            writer.WriteDecimalValue("unitCost", UnitCost);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
