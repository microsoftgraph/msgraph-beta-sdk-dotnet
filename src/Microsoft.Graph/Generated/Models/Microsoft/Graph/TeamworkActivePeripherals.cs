using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkActivePeripherals : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TeamworkPeripheral CommunicationSpeaker { get; set; }
        public TeamworkPeripheral ContentCamera { get; set; }
        public TeamworkPeripheral Microphone { get; set; }
        public TeamworkPeripheral RoomCamera { get; set; }
        public TeamworkPeripheral Speaker { get; set; }
        /// <summary>
        /// Instantiates a new teamworkActivePeripherals and sets the default values.
        /// </summary>
        public TeamworkActivePeripherals() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkActivePeripherals CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkActivePeripherals();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"communicationSpeaker", (o,n) => { (o as TeamworkActivePeripherals).CommunicationSpeaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"contentCamera", (o,n) => { (o as TeamworkActivePeripherals).ContentCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"microphone", (o,n) => { (o as TeamworkActivePeripherals).Microphone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"roomCamera", (o,n) => { (o as TeamworkActivePeripherals).RoomCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"speaker", (o,n) => { (o as TeamworkActivePeripherals).Speaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("communicationSpeaker", CommunicationSpeaker);
            writer.WriteObjectValue<TeamworkPeripheral>("contentCamera", ContentCamera);
            writer.WriteObjectValue<TeamworkPeripheral>("microphone", Microphone);
            writer.WriteObjectValue<TeamworkPeripheral>("roomCamera", RoomCamera);
            writer.WriteObjectValue<TeamworkPeripheral>("speaker", Speaker);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
