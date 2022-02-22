using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class EmbeddedSIMActivationCode : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.</summary>
        public string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary>The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.</summary>
        public string MatchingIdentifier { get; set; }
        /// <summary>The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.</summary>
        public string SmdpPlusServerAddress { get; set; }
        /// <summary>
        /// Instantiates a new embeddedSIMActivationCode and sets the default values.
        /// </summary>
        public EmbeddedSIMActivationCode() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"integratedCircuitCardIdentifier", (o,n) => { (o as EmbeddedSIMActivationCode).IntegratedCircuitCardIdentifier = n.GetStringValue(); } },
                {"matchingIdentifier", (o,n) => { (o as EmbeddedSIMActivationCode).MatchingIdentifier = n.GetStringValue(); } },
                {"smdpPlusServerAddress", (o,n) => { (o as EmbeddedSIMActivationCode).SmdpPlusServerAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("integratedCircuitCardIdentifier", IntegratedCircuitCardIdentifier);
            writer.WriteStringValue("matchingIdentifier", MatchingIdentifier);
            writer.WriteStringValue("smdpPlusServerAddress", SmdpPlusServerAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
