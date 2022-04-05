using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Vendor : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address { get; set; }
        /// <summary>The balance property</summary>
        public decimal? Balance { get; set; }
        /// <summary>The blocked property</summary>
        public string Blocked { get; set; }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currencyId property</summary>
        public string CurrencyId { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The number property</summary>
        public string Number { get; set; }
        /// <summary>The paymentMethod property</summary>
        public Microsoft.Graph.Beta.Models.PaymentMethod PaymentMethod { get; set; }
        /// <summary>The paymentMethodId property</summary>
        public string PaymentMethodId { get; set; }
        /// <summary>The paymentTerm property</summary>
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm { get; set; }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture { get; set; }
        /// <summary>The taxLiable property</summary>
        public bool? TaxLiable { get; set; }
        /// <summary>The taxRegistrationNumber property</summary>
        public string TaxRegistrationNumber { get; set; }
        /// <summary>The website property</summary>
        public string Website { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Vendor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Vendor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as Vendor).Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"balance", (o,n) => { (o as Vendor).Balance = n.GetDecimalValue(); } },
                {"blocked", (o,n) => { (o as Vendor).Blocked = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as Vendor).Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as Vendor).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as Vendor).CurrencyId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Vendor).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as Vendor).Email = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Vendor).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as Vendor).Number = n.GetStringValue(); } },
                {"paymentMethod", (o,n) => { (o as Vendor).PaymentMethod = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentMethod>(Microsoft.Graph.Beta.Models.PaymentMethod.CreateFromDiscriminatorValue); } },
                {"paymentMethodId", (o,n) => { (o as Vendor).PaymentMethodId = n.GetStringValue(); } },
                {"paymentTerm", (o,n) => { (o as Vendor).PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as Vendor).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as Vendor).PhoneNumber = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as Vendor).Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"taxLiable", (o,n) => { (o as Vendor).TaxLiable = n.GetBoolValue(); } },
                {"taxRegistrationNumber", (o,n) => { (o as Vendor).TaxRegistrationNumber = n.GetStringValue(); } },
                {"website", (o,n) => { (o as Vendor).Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteDecimalValue("balance", Balance);
            writer.WriteStringValue("blocked", Blocked);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentMethod>("paymentMethod", PaymentMethod);
            writer.WriteStringValue("paymentMethodId", PaymentMethodId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("taxLiable", TaxLiable);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("website", Website);
        }
    }
}
