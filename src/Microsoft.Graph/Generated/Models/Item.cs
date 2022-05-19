using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class Item : Entity, IParsable {
        /// <summary>The baseUnitOfMeasureId property</summary>
        public string BaseUnitOfMeasureId {
            get { return BackingStore?.Get<string>(nameof(BaseUnitOfMeasureId)); }
            set { BackingStore?.Set(nameof(BaseUnitOfMeasureId), value); }
        }
        /// <summary>The blocked property</summary>
        public bool? Blocked {
            get { return BackingStore?.Get<bool?>(nameof(Blocked)); }
            set { BackingStore?.Set(nameof(Blocked), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The gtin property</summary>
        public string Gtin {
            get { return BackingStore?.Get<string>(nameof(Gtin)); }
            set { BackingStore?.Set(nameof(Gtin), value); }
        }
        /// <summary>The inventory property</summary>
        public decimal? Inventory {
            get { return BackingStore?.Get<decimal?>(nameof(Inventory)); }
            set { BackingStore?.Set(nameof(Inventory), value); }
        }
        /// <summary>The itemCategory property</summary>
        public Microsoft.Graph.Beta.Models.ItemCategory ItemCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemCategory>(nameof(ItemCategory)); }
            set { BackingStore?.Set(nameof(ItemCategory), value); }
        }
        /// <summary>The itemCategoryCode property</summary>
        public string ItemCategoryCode {
            get { return BackingStore?.Get<string>(nameof(ItemCategoryCode)); }
            set { BackingStore?.Set(nameof(ItemCategoryCode), value); }
        }
        /// <summary>The itemCategoryId property</summary>
        public string ItemCategoryId {
            get { return BackingStore?.Get<string>(nameof(ItemCategoryId)); }
            set { BackingStore?.Set(nameof(ItemCategoryId), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>(nameof(Number)); }
            set { BackingStore?.Set(nameof(Number), value); }
        }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>(nameof(Picture)); }
            set { BackingStore?.Set(nameof(Picture), value); }
        }
        /// <summary>The priceIncludesTax property</summary>
        public bool? PriceIncludesTax {
            get { return BackingStore?.Get<bool?>(nameof(PriceIncludesTax)); }
            set { BackingStore?.Set(nameof(PriceIncludesTax), value); }
        }
        /// <summary>The taxGroupCode property</summary>
        public string TaxGroupCode {
            get { return BackingStore?.Get<string>(nameof(TaxGroupCode)); }
            set { BackingStore?.Set(nameof(TaxGroupCode), value); }
        }
        /// <summary>The taxGroupId property</summary>
        public string TaxGroupId {
            get { return BackingStore?.Get<string>(nameof(TaxGroupId)); }
            set { BackingStore?.Set(nameof(TaxGroupId), value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The unitCost property</summary>
        public decimal? UnitCost {
            get { return BackingStore?.Get<decimal?>(nameof(UnitCost)); }
            set { BackingStore?.Set(nameof(UnitCost), value); }
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
        public static new Item CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"baseUnitOfMeasureId", n => { BaseUnitOfMeasureId = n.GetStringValue(); } },
                {"blocked", n => { Blocked = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"gtin", n => { Gtin = n.GetStringValue(); } },
                {"inventory", n => { Inventory = n.GetDecimalValue(); } },
                {"itemCategory", n => { ItemCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>(Microsoft.Graph.Beta.Models.ItemCategory.CreateFromDiscriminatorValue); } },
                {"itemCategoryCode", n => { ItemCategoryCode = n.GetStringValue(); } },
                {"itemCategoryId", n => { ItemCategoryId = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"priceIncludesTax", n => { PriceIncludesTax = n.GetBoolValue(); } },
                {"taxGroupCode", n => { TaxGroupCode = n.GetStringValue(); } },
                {"taxGroupId", n => { TaxGroupId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"unitCost", n => { UnitCost = n.GetDecimalValue(); } },
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
