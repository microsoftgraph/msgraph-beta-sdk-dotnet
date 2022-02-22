using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class IpReferenceData : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public long? Asn { get; set; }
        public string City { get; set; }
        public string CountryOrRegionCode { get; set; }
        public string Organization { get; set; }
        public string State { get; set; }
        public string Vendor { get; set; }
        /// <summary>
        /// Instantiates a new ipReferenceData and sets the default values.
        /// </summary>
        public IpReferenceData() {
            AdditionalData = new Dictionary<string, object>();
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
