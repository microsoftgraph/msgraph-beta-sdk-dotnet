using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkConfiguredPeripheral : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if the current peripheral is optional. If set to false, this property is also used as part of the calculation of the health state for the device.</summary>
        public bool? IsOptional { get; set; }
        public TeamworkPeripheral Peripheral { get; set; }
        /// <summary>
        /// Instantiates a new teamworkConfiguredPeripheral and sets the default values.
        /// </summary>
        public TeamworkConfiguredPeripheral() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isOptional", (o,n) => { (o as TeamworkConfiguredPeripheral).IsOptional = n.GetBoolValue(); } },
                {"peripheral", (o,n) => { (o as TeamworkConfiguredPeripheral).Peripheral = n.GetObjectValue<TeamworkPeripheral>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteObjectValue<TeamworkPeripheral>("peripheral", Peripheral);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
