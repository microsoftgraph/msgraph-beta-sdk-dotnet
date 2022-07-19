using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkActivePeripherals : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The communicationSpeaker property</summary>
        public TeamworkPeripheral CommunicationSpeaker {
            get { return BackingStore?.Get<TeamworkPeripheral>("communicationSpeaker"); }
            set { BackingStore?.Set("communicationSpeaker", value); }
        }
        /// <summary>The contentCamera property</summary>
        public TeamworkPeripheral ContentCamera {
            get { return BackingStore?.Get<TeamworkPeripheral>("contentCamera"); }
            set { BackingStore?.Set("contentCamera", value); }
        }
        /// <summary>The microphone property</summary>
        public TeamworkPeripheral Microphone {
            get { return BackingStore?.Get<TeamworkPeripheral>("microphone"); }
            set { BackingStore?.Set("microphone", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The roomCamera property</summary>
        public TeamworkPeripheral RoomCamera {
            get { return BackingStore?.Get<TeamworkPeripheral>("roomCamera"); }
            set { BackingStore?.Set("roomCamera", value); }
        }
        /// <summary>The speaker property</summary>
        public TeamworkPeripheral Speaker {
            get { return BackingStore?.Get<TeamworkPeripheral>("speaker"); }
            set { BackingStore?.Set("speaker", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkActivePeripherals and sets the default values.
        /// </summary>
        public TeamworkActivePeripherals() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkActivePeripherals";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkPeripheral>("roomCamera", RoomCamera);
            writer.WriteObjectValue<TeamworkPeripheral>("speaker", Speaker);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
