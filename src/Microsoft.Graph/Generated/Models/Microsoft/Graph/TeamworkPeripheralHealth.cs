using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkPeripheralHealth : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The connected state and time since the peripheral device was connected.</summary>
        public TeamworkConnection Connection { get; set; }
        /// <summary>True if the peripheral is optional. Used for health computation.</summary>
        public bool? IsOptional { get; set; }
        public TeamworkPeripheral Peripheral { get; set; }
        /// <summary>
        /// Instantiates a new teamworkPeripheralHealth and sets the default values.
        /// </summary>
        public TeamworkPeripheralHealth() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"connection", (o,n) => { (o as TeamworkPeripheralHealth).Connection = n.GetObjectValue<TeamworkConnection>(); } },
                {"isOptional", (o,n) => { (o as TeamworkPeripheralHealth).IsOptional = n.GetBoolValue(); } },
                {"peripheral", (o,n) => { (o as TeamworkPeripheralHealth).Peripheral = n.GetObjectValue<TeamworkPeripheral>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkConnection>("connection", Connection);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteObjectValue<TeamworkPeripheral>("peripheral", Peripheral);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
