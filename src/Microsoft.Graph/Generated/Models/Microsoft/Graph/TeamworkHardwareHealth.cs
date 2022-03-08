using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkHardwareHealth : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The system health details for a teamworkDevice.</summary>
        public TeamworkPeripheralHealth ComputeHealth { get; set; }
        /// <summary>The health details about the HDMI ingest of a device.</summary>
        public TeamworkPeripheralHealth HdmiIngestHealth { get; set; }
        /// <summary>
        /// Instantiates a new teamworkHardwareHealth and sets the default values.
        /// </summary>
        public TeamworkHardwareHealth() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkHardwareHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkHardwareHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"computeHealth", (o,n) => { (o as TeamworkHardwareHealth).ComputeHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"hdmiIngestHealth", (o,n) => { (o as TeamworkHardwareHealth).HdmiIngestHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheralHealth>("computeHealth", ComputeHealth);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("hdmiIngestHealth", HdmiIngestHealth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
