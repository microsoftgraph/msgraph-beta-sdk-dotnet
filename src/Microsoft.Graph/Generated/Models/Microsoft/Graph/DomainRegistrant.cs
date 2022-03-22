using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DomainRegistrant : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CountryOrRegionCode { get; set; }
        public string Organization { get; set; }
        public string Url { get; set; }
        public string Vendor { get; set; }
        /// <summary>
        /// Instantiates a new domainRegistrant and sets the default values.
        /// </summary>
        public DomainRegistrant() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DomainRegistrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainRegistrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"countryOrRegionCode", (o,n) => { (o as DomainRegistrant).CountryOrRegionCode = n.GetStringValue(); } },
                {"organization", (o,n) => { (o as DomainRegistrant).Organization = n.GetStringValue(); } },
                {"url", (o,n) => { (o as DomainRegistrant).Url = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as DomainRegistrant).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryOrRegionCode", CountryOrRegionCode);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
