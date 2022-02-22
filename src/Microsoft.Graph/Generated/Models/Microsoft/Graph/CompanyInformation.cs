using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CompanyInformation : Entity, IParsable {
        public PostalAddressType Address { get; set; }
        public string CurrencyCode { get; set; }
        public Date? CurrentFiscalYearStartDate { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        public string Industry { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Picture { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string Website { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as CompanyInformation).Address = n.GetObjectValue<PostalAddressType>(); } },
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
