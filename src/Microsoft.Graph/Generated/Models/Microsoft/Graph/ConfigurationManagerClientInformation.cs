using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class ConfigurationManagerClientInformation : IParsable, IAdditionalDataHolder {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConfigurationManagerClientInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerClientInformation();
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
