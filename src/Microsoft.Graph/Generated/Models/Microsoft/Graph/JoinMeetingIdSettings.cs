using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class JoinMeetingIdSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? IsPasscodeRequired { get; set; }
        public string JoinMeetingId { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isPasscodeRequired", (o,n) => { (o as JoinMeetingIdSettings).IsPasscodeRequired = n.GetBoolValue(); } },
                {"joinMeetingId", (o,n) => { (o as JoinMeetingIdSettings).JoinMeetingId = n.GetStringValue(); } },
                {"passcode", (o,n) => { (o as JoinMeetingIdSettings).Passcode = n.GetStringValue(); } },
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
