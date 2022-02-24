using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SecurityProviderStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? Enabled { get; set; }
        public string Endpoint { get; set; }
        public string Provider { get; set; }
        public string Region { get; set; }
        public string Vendor { get; set; }
        /// <summary>
        /// Instantiates a new securityProviderStatus and sets the default values.
        /// </summary>
        public SecurityProviderStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enabled", (o,n) => { (o as SecurityProviderStatus).Enabled = n.GetBoolValue(); } },
                {"endpoint", (o,n) => { (o as SecurityProviderStatus).Endpoint = n.GetStringValue(); } },
                {"provider", (o,n) => { (o as SecurityProviderStatus).Provider = n.GetStringValue(); } },
                {"region", (o,n) => { (o as SecurityProviderStatus).Region = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as SecurityProviderStatus).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("endpoint", Endpoint);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
