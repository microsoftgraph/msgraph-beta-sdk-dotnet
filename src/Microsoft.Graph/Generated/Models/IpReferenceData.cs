using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IpReferenceData : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The asn property</summary>
        public long? Asn { get; set; }
        /// <summary>The city property</summary>
        public string City { get; set; }
        /// <summary>The countryOrRegionCode property</summary>
        public string CountryOrRegionCode { get; set; }
        /// <summary>The organization property</summary>
        public string Organization { get; set; }
        /// <summary>The state property</summary>
        public string State { get; set; }
        /// <summary>The vendor property</summary>
        public string Vendor { get; set; }
        /// <summary>
        /// Instantiates a new ipReferenceData and sets the default values.
        /// </summary>
        public IpReferenceData() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IpReferenceData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpReferenceData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"asn", (o,n) => { (o as IpReferenceData).Asn = n.GetLongValue(); } },
                {"city", (o,n) => { (o as IpReferenceData).City = n.GetStringValue(); } },
                {"countryOrRegionCode", (o,n) => { (o as IpReferenceData).CountryOrRegionCode = n.GetStringValue(); } },
                {"organization", (o,n) => { (o as IpReferenceData).Organization = n.GetStringValue(); } },
                {"state", (o,n) => { (o as IpReferenceData).State = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as IpReferenceData).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("asn", Asn);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegionCode", CountryOrRegionCode);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
