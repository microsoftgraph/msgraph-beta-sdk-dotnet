using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class Item : Entity, IParsable {
        /// <summary>The baseUnitOfMeasureId property</summary>
        public Guid? BaseUnitOfMeasureId {
            get { return BackingStore?.Get<Guid?>("baseUnitOfMeasureId"); }
            set { BackingStore?.Set("baseUnitOfMeasureId", value); }
        }
        /// <summary>The blocked property</summary>
        public bool? Blocked {
            get { return BackingStore?.Get<bool?>("blocked"); }
            set { BackingStore?.Set("blocked", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The gtin property</summary>
        public string Gtin {
            get { return BackingStore?.Get<string>("gtin"); }
            set { BackingStore?.Set("gtin", value); }
        }
        /// <summary>The inventory property</summary>
        public decimal? Inventory {
            get { return BackingStore?.Get<decimal?>("inventory"); }
            set { BackingStore?.Set("inventory", value); }
        }
        /// <summary>The itemCategory property</summary>
        public Microsoft.Graph.Beta.Models.ItemCategory ItemCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ItemCategory>("itemCategory"); }
            set { BackingStore?.Set("itemCategory", value); }
        }
        /// <summary>The itemCategoryCode property</summary>
        public string ItemCategoryCode {
            get { return BackingStore?.Get<string>("itemCategoryCode"); }
            set { BackingStore?.Set("itemCategoryCode", value); }
        }
        /// <summary>The itemCategoryId property</summary>
        public Guid? ItemCategoryId {
            get { return BackingStore?.Get<Guid?>("itemCategoryId"); }
            set { BackingStore?.Set("itemCategoryId", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
        /// <summary>The priceIncludesTax property</summary>
        public bool? PriceIncludesTax {
            get { return BackingStore?.Get<bool?>("priceIncludesTax"); }
            set { BackingStore?.Set("priceIncludesTax", value); }
        }
        /// <summary>The taxGroupCode property</summary>
        public string TaxGroupCode {
            get { return BackingStore?.Get<string>("taxGroupCode"); }
            set { BackingStore?.Set("taxGroupCode", value); }
        }
        /// <summary>The taxGroupId property</summary>
        public Guid? TaxGroupId {
            get { return BackingStore?.Get<Guid?>("taxGroupId"); }
            set { BackingStore?.Set("taxGroupId", value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The unitCost property</summary>
        public decimal? UnitCost {
            get { return BackingStore?.Get<decimal?>("unitCost"); }
            set { BackingStore?.Set("unitCost", value); }
        }
        /// <summary>The unitPrice property</summary>
        public decimal? UnitPrice {
            get { return BackingStore?.Get<decimal?>("unitPrice"); }
            set { BackingStore?.Set("unitPrice", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Item CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"baseUnitOfMeasureId", n => { BaseUnitOfMeasureId = n.GetGuidValue(); } },
                {"blocked", n => { Blocked = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"gtin", n => { Gtin = n.GetStringValue(); } },
                {"inventory", n => { Inventory = n.GetDecimalValue(); } },
                {"itemCategory", n => { ItemCategory = n.GetObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>(Microsoft.Graph.Beta.Models.ItemCategory.CreateFromDiscriminatorValue); } },
                {"itemCategoryCode", n => { ItemCategoryCode = n.GetStringValue(); } },
                {"itemCategoryId", n => { ItemCategoryId = n.GetGuidValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                {"priceIncludesTax", n => { PriceIncludesTax = n.GetBoolValue(); } },
                {"taxGroupCode", n => { TaxGroupCode = n.GetStringValue(); } },
                {"taxGroupId", n => { TaxGroupId = n.GetGuidValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"unitCost", n => { UnitCost = n.GetDecimalValue(); } },
                {"unitPrice", n => { UnitPrice = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("baseUnitOfMeasureId", BaseUnitOfMeasureId);
            writer.WriteBoolValue("blocked", Blocked);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("gtin", Gtin);
            writer.WriteDecimalValue("inventory", Inventory);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ItemCategory>("itemCategory", ItemCategory);
            writer.WriteStringValue("itemCategoryCode", ItemCategoryCode);
            writer.WriteGuidValue("itemCategoryId", ItemCategoryId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("priceIncludesTax", PriceIncludesTax);
            writer.WriteStringValue("taxGroupCode", TaxGroupCode);
            writer.WriteGuidValue("taxGroupId", TaxGroupId);
            writer.WriteStringValue("type", Type);
            writer.WriteDecimalValue("unitCost", UnitCost);
            writer.WriteDecimalValue("unitPrice", UnitPrice);
        }
    }
}
