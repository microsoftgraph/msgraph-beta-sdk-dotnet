using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CompanyDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Address of the company.</summary>
        public PhysicalAddress Address { get; set; }
        /// <summary>Department Name within a company.</summary>
        public string Department { get; set; }
        /// <summary>Company name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Office Location of the person referred to.</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Pronunciation guide for the company name.</summary>
        public string Pronunciation { get; set; }
        /// <summary>Link to the company home page.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new companyDetail and sets the default values.
        /// </summary>
        public CompanyDetail() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CompanyDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanyDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as CompanyDetail).Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"department", (o,n) => { (o as CompanyDetail).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CompanyDetail).DisplayName = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as CompanyDetail).OfficeLocation = n.GetStringValue(); } },
                {"pronunciation", (o,n) => { (o as CompanyDetail).Pronunciation = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as CompanyDetail).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("pronunciation", Pronunciation);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
