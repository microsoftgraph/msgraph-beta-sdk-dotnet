using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkActivePeripherals : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The communicationSpeaker property</summary>
        public TeamworkPeripheral CommunicationSpeaker { get; set; }
        /// <summary>The contentCamera property</summary>
        public TeamworkPeripheral ContentCamera { get; set; }
        /// <summary>The microphone property</summary>
        public TeamworkPeripheral Microphone { get; set; }
        /// <summary>The roomCamera property</summary>
        public TeamworkPeripheral RoomCamera { get; set; }
        /// <summary>The speaker property</summary>
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"communicationSpeaker", n => { CommunicationSpeaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"contentCamera", n => { ContentCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"microphone", n => { Microphone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"roomCamera", n => { RoomCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"speaker", n => { Speaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
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
