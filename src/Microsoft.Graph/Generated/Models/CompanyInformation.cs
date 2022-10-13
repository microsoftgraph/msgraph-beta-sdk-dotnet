using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class CompanyInformation : Entity, IParsable {
        /// <summary>The address property</summary>
        public PostalAddressType Address {
            get { return BackingStore?.Get<PostalAddressType>("address"); }
            set { BackingStore?.Set("address", value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
        /// <summary>The currentFiscalYearStartDate property</summary>
        public Date? CurrentFiscalYearStartDate {
            get { return BackingStore?.Get<Date?>("currentFiscalYearStartDate"); }
            set { BackingStore?.Set("currentFiscalYearStartDate", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The email property</summary>
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
        /// <summary>The faxNumber property</summary>
        public string FaxNumber {
            get { return BackingStore?.Get<string>("faxNumber"); }
            set { BackingStore?.Set("faxNumber", value); }
        }
        /// <summary>The industry property</summary>
        public string Industry {
            get { return BackingStore?.Get<string>("industry"); }
            set { BackingStore?.Set("industry", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
        /// <summary>The picture property</summary>
        public byte[] Picture {
            get { return BackingStore?.Get<byte[]>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
        /// <summary>The taxRegistrationNumber property</summary>
        public string TaxRegistrationNumber {
            get { return BackingStore?.Get<string>("taxRegistrationNumber"); }
            set { BackingStore?.Set("taxRegistrationNumber", value); }
        }
        /// <summary>The website property</summary>
        public string Website {
            get { return BackingStore?.Get<string>("website"); }
            set { BackingStore?.Set("website", value); }
        }
        /// <summary>
        /// Instantiates a new companyInformation and sets the default values.
        /// </summary>
        public CompanyInformation() : base() {
            OdataType = "#microsoft.graph.companyInformation";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currentFiscalYearStartDate", n => { CurrentFiscalYearStartDate = n.GetDateValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"faxNumber", n => { FaxNumber = n.GetStringValue(); } },
                {"industry", n => { Industry = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetByteArrayValue(); } },
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
