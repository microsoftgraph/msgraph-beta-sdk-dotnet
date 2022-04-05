using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingSpeaker : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Bio of the speaker.</summary>
        public string Bio { get; set; }
        /// <summary>Display name of the speaker.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Instantiates a new meetingSpeaker and sets the default values.
        /// </summary>
        public MeetingSpeaker() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingSpeaker CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingSpeaker();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bio", (o,n) => { (o as MeetingSpeaker).Bio = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MeetingSpeaker).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bio", Bio);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
