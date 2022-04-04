using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CompanyInformation : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address { get; set; }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode { get; set; }
        /// <summary>The currentFiscalYearStartDate property</summary>
        public Date? CurrentFiscalYearStartDate { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The email property</summary>
        public string Email { get; set; }
        /// <summary>The faxNumber property</summary>
        public string FaxNumber { get; set; }
        /// <summary>The industry property</summary>
        public string Industry { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>The picture property</summary>
        public byte[] Picture { get; set; }
        /// <summary>The taxRegistrationNumber property</summary>
        public string TaxRegistrationNumber { get; set; }
        /// <summary>The website property</summary>
        public string Website { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CompanyInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanyInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as CompanyInformation).Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as CompanyInformation).CurrencyCode = n.GetStringValue(); } },
                {"currentFiscalYearStartDate", (o,n) => { (o as CompanyInformation).CurrentFiscalYearStartDate = n.GetDateValue(); } },
                {"displayName", (o,n) => { (o as CompanyInformation).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as CompanyInformation).Email = n.GetStringValue(); } },
                {"faxNumber", (o,n) => { (o as CompanyInformation).FaxNumber = n.GetStringValue(); } },
                {"industry", (o,n) => { (o as CompanyInformation).Industry = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CompanyInformation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"phoneNumber", (o,n) => { (o as CompanyInformation).PhoneNumber = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as CompanyInformation).Picture = n.GetByteArrayValue(); } },
                {"taxRegistrationNumber", (o,n) => { (o as CompanyInformation).TaxRegistrationNumber = n.GetStringValue(); } },
                {"website", (o,n) => { (o as CompanyInformation).Website = n.GetStringValue(); } },
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
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDateValue("currentFiscalYearStartDate", CurrentFiscalYearStartDate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteStringValue("industry", Industry);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteByteArrayValue("picture", Picture);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("website", Website);
        }
    }
}
