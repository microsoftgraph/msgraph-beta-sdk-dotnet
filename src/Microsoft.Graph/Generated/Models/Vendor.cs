using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class Vendor : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address {
            get { return BackingStore?.Get<PostalAddressType>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>The balance property</summary>
        public decimal? Balance {
            get { return BackingStore?.Get<decimal?>(nameof(Balance)); }
            set { BackingStore?.Set(nameof(Balance), value); }
        }
        /// <summary>The blocked property</summary>
        public string Blocked {
            get { return BackingStore?.Get<string>(nameof(Blocked)); }
            set { BackingStore?.Set(nameof(Blocked), value); }
        }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>(nameof(Currency)); }
            set { BackingStore?.Set(nameof(Currency), value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>(nameof(CurrencyCode)); }
            set { BackingStore?.Set(nameof(CurrencyCode), value); }
        }
        /// <summary>The currencyId property</summary>
        public string CurrencyId {
            get { return BackingStore?.Get<string>(nameof(CurrencyId)); }
            set { BackingStore?.Set(nameof(CurrencyId), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The email property</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
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
        /// <summary>The paymentMethod property</summary>
        public Microsoft.Graph.Beta.Models.PaymentMethod PaymentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentMethod>(nameof(PaymentMethod)); }
            set { BackingStore?.Set(nameof(PaymentMethod), value); }
        }
        /// <summary>The paymentMethodId property</summary>
        public string PaymentMethodId {
            get { return BackingStore?.Get<string>(nameof(PaymentMethodId)); }
            set { BackingStore?.Set(nameof(PaymentMethodId), value); }
        }
        /// <summary>The paymentTerm property</summary>
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm>(nameof(PaymentTerm)); }
            set { BackingStore?.Set(nameof(PaymentTerm), value); }
        }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId {
            get { return BackingStore?.Get<string>(nameof(PaymentTermsId)); }
            set { BackingStore?.Set(nameof(PaymentTermsId), value); }
        }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>The picture property</summary>
        public List<Microsoft.Graph.Beta.Models.Picture> Picture {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Picture>>(nameof(Picture)); }
            set { BackingStore?.Set(nameof(Picture), value); }
        }
        /// <summary>The taxLiable property</summary>
        public bool? TaxLiable {
            get { return BackingStore?.Get<bool?>(nameof(TaxLiable)); }
            set { BackingStore?.Set(nameof(TaxLiable), value); }
        }
        /// <summary>The taxRegistrationNumber property</summary>
        public string TaxRegistrationNumber {
            get { return BackingStore?.Get<string>(nameof(TaxRegistrationNumber)); }
            set { BackingStore?.Set(nameof(TaxRegistrationNumber), value); }
        }
        /// <summary>The website property</summary>
        public string Website {
            get { return BackingStore?.Get<string>(nameof(Website)); }
            set { BackingStore?.Set(nameof(Website), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"balance", n => { Balance = n.GetDecimalValue(); } },
                {"blocked", n => { Blocked = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"paymentMethod", n => { PaymentMethod = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentMethod>(Microsoft.Graph.Beta.Models.PaymentMethod.CreateFromDiscriminatorValue); } },
                {"paymentMethodId", n => { PaymentMethodId = n.GetStringValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Picture>(Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"taxLiable", n => { TaxLiable = n.GetBoolValue(); } },
                {"taxRegistrationNumber", n => { TaxRegistrationNumber = n.GetStringValue(); } },
                {"website", n => { Website = n.GetStringValue(); } },
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
