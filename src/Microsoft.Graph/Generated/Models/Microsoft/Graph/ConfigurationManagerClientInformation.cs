using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ConfigurationManagerClientInformation : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Configuration Manager Client Id from SCCM</summary>
        public string ClientIdentifier { get; set; }
        /// <summary>Configuration Manager Client blocked status from SCCM</summary>
        public bool? IsBlocked { get; set; }
        /// <summary>
        /// Instantiates a new configurationManagerClientInformation and sets the default values.
        /// </summary>
        public ConfigurationManagerClientInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientIdentifier", (o,n) => { (o as ConfigurationManagerClientInformation).ClientIdentifier = n.GetStringValue(); } },
                {"isBlocked", (o,n) => { (o as ConfigurationManagerClientInformation).IsBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientIdentifier", ClientIdentifier);
            writer.WriteBoolValue("isBlocked", IsBlocked);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
