using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The embedded SIM activation code as provided by the mobile operator.</summary>
    public class EmbeddedSIMActivationCode : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.</summary>
        public string IntegratedCircuitCardIdentifier {
            get { return BackingStore?.Get<string>("integratedCircuitCardIdentifier"); }
            set { BackingStore?.Set("integratedCircuitCardIdentifier", value); }
        }
        /// <summary>The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.</summary>
        public string MatchingIdentifier {
            get { return BackingStore?.Get<string>("matchingIdentifier"); }
            set { BackingStore?.Set("matchingIdentifier", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.</summary>
        public string SmdpPlusServerAddress {
            get { return BackingStore?.Get<string>("smdpPlusServerAddress"); }
            set { BackingStore?.Set("smdpPlusServerAddress", value); }
        }
        /// <summary>
        /// Instantiates a new embeddedSIMActivationCode and sets the default values.
        /// </summary>
        public EmbeddedSIMActivationCode() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.embeddedSIMActivationCode";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EmbeddedSIMActivationCode CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmbeddedSIMActivationCode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"integratedCircuitCardIdentifier", n => { IntegratedCircuitCardIdentifier = n.GetStringValue(); } },
                {"matchingIdentifier", n => { MatchingIdentifier = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"smdpPlusServerAddress", n => { SmdpPlusServerAddress = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("smdpPlusServerAddress", SmdpPlusServerAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
