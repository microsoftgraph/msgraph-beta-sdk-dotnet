using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkSpeakerConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TeamworkPeripheral DefaultCommunicationSpeaker { get; set; }
        public TeamworkPeripheral DefaultSpeaker { get; set; }
        /// <summary>True if the communication speaker is optional. Used to compute the health state if the communication speaker is not optional.</summary>
        public bool? IsCommunicationSpeakerOptional { get; set; }
        /// <summary>True if the configured speaker is optional. Used to compute the health state if the speaker is not optional.</summary>
        public bool? IsSpeakerOptional { get; set; }
        public List<TeamworkPeripheral> Speakers { get; set; }
        /// <summary>
        /// Instantiates a new teamworkSpeakerConfiguration and sets the default values.
        /// </summary>
        public TeamworkSpeakerConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkSpeakerConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSpeakerConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultCommunicationSpeaker", (o,n) => { (o as TeamworkSpeakerConfiguration).DefaultCommunicationSpeaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"defaultSpeaker", (o,n) => { (o as TeamworkSpeakerConfiguration).DefaultSpeaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"isCommunicationSpeakerOptional", (o,n) => { (o as TeamworkSpeakerConfiguration).IsCommunicationSpeakerOptional = n.GetBoolValue(); } },
                {"isSpeakerOptional", (o,n) => { (o as TeamworkSpeakerConfiguration).IsSpeakerOptional = n.GetBoolValue(); } },
                {"speakers", (o,n) => { (o as TeamworkSpeakerConfiguration).Speakers = n.GetCollectionOfObjectValues<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("defaultCommunicationSpeaker", DefaultCommunicationSpeaker);
            writer.WriteObjectValue<TeamworkPeripheral>("defaultSpeaker", DefaultSpeaker);
            writer.WriteBoolValue("isCommunicationSpeakerOptional", IsCommunicationSpeakerOptional);
            writer.WriteBoolValue("isSpeakerOptional", IsSpeakerOptional);
            writer.WriteCollectionOfObjectValues<TeamworkPeripheral>("speakers", Speakers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
