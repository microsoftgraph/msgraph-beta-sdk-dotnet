using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkMicrophoneConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The defaultMicrophone property</summary>
        public TeamworkPeripheral DefaultMicrophone {
            get { return BackingStore?.Get<TeamworkPeripheral>("defaultMicrophone"); }
            set { BackingStore?.Set("defaultMicrophone", value); }
        }
        /// <summary>True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.</summary>
        public bool? IsMicrophoneOptional {
            get { return BackingStore?.Get<bool?>("isMicrophoneOptional"); }
            set { BackingStore?.Set("isMicrophoneOptional", value); }
        }
        /// <summary>The microphones property</summary>
        public List<TeamworkPeripheral> Microphones {
            get { return BackingStore?.Get<List<TeamworkPeripheral>>("microphones"); }
            set { BackingStore?.Set("microphones", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkMicrophoneConfiguration and sets the default values.
        /// </summary>
        public TeamworkMicrophoneConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkMicrophoneConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkMicrophoneConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkMicrophoneConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultMicrophone", n => { DefaultMicrophone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"isMicrophoneOptional", n => { IsMicrophoneOptional = n.GetBoolValue(); } },
                {"microphones", n => { Microphones = n.GetCollectionOfObjectValues<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("defaultMicrophone", DefaultMicrophone);
            writer.WriteBoolValue("isMicrophoneOptional", IsMicrophoneOptional);
            writer.WriteCollectionOfObjectValues<TeamworkPeripheral>("microphones", Microphones);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
