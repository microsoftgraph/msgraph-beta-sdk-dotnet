using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class JoinMeetingIdSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isPasscodeRequired property</summary>
        public bool? IsPasscodeRequired { get; set; }
        /// <summary>The joinMeetingId property</summary>
        public string JoinMeetingId { get; set; }
        /// <summary>The passcode property</summary>
        public string Passcode { get; set; }
        /// <summary>
        /// Instantiates a new joinMeetingIdSettings and sets the default values.
        /// </summary>
        public JoinMeetingIdSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static JoinMeetingIdSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JoinMeetingIdSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isPasscodeRequired", n => { IsPasscodeRequired = n.GetBoolValue(); } },
                {"joinMeetingId", n => { JoinMeetingId = n.GetStringValue(); } },
                {"passcode", n => { Passcode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isPasscodeRequired", IsPasscodeRequired);
            writer.WriteStringValue("joinMeetingId", JoinMeetingId);
            writer.WriteStringValue("passcode", Passcode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
