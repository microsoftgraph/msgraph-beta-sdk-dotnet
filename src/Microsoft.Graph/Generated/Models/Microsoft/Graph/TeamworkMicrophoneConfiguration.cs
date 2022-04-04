using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkMicrophoneConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The defaultMicrophone property</summary>
        public TeamworkPeripheral DefaultMicrophone { get; set; }
        /// <summary>True if the configured microphone is optional. False if the microphone is not optional and the health state of the device should be computed.</summary>
        public bool? IsMicrophoneOptional { get; set; }
        /// <summary>The microphones property</summary>
        public List<TeamworkPeripheral> Microphones { get; set; }
        /// <summary>
        /// Instantiates a new teamworkMicrophoneConfiguration and sets the default values.
        /// </summary>
        public TeamworkMicrophoneConfiguration() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultMicrophone", (o,n) => { (o as TeamworkMicrophoneConfiguration).DefaultMicrophone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"isMicrophoneOptional", (o,n) => { (o as TeamworkMicrophoneConfiguration).IsMicrophoneOptional = n.GetBoolValue(); } },
                {"microphones", (o,n) => { (o as TeamworkMicrophoneConfiguration).Microphones = n.GetCollectionOfObjectValues<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
