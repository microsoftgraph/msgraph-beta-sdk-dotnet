using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkHardwareConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TeamworkPeripheral Compute { get; set; }
        public TeamworkPeripheral HdmiIngest { get; set; }
        /// <summary>The CPU model on the device.</summary>
        public string ProcessorModel { get; set; }
        /// <summary>
        /// Instantiates a new teamworkHardwareConfiguration and sets the default values.
        /// </summary>
        public TeamworkHardwareConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkHardwareConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkHardwareConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"compute", (o,n) => { (o as TeamworkHardwareConfiguration).Compute = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"hdmiIngest", (o,n) => { (o as TeamworkHardwareConfiguration).HdmiIngest = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"processorModel", (o,n) => { (o as TeamworkHardwareConfiguration).ProcessorModel = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("compute", Compute);
            writer.WriteObjectValue<TeamworkPeripheral>("hdmiIngest", HdmiIngest);
            writer.WriteStringValue("processorModel", ProcessorModel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
