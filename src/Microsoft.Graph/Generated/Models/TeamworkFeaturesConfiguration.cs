using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkFeaturesConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Email address to send logs and feedback.</summary>
        public string EmailToSendLogsAndFeedback { get; set; }
        /// <summary>True if auto screen shared is enabled.</summary>
        public bool? IsAutoScreenShareEnabled { get; set; }
        /// <summary>True if Bluetooth beaconing is enabled.</summary>
        public bool? IsBluetoothBeaconingEnabled { get; set; }
        /// <summary>True if hiding meeting names is enabled.</summary>
        public bool? IsHideMeetingNamesEnabled { get; set; }
        /// <summary>True if sending logs and feedback is enabled.</summary>
        public bool? IsSendLogsAndFeedbackEnabled { get; set; }
        /// <summary>
        /// Instantiates a new teamworkFeaturesConfiguration and sets the default values.
        /// </summary>
        public TeamworkFeaturesConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"emailToSendLogsAndFeedback", (o,n) => { (o as TeamworkFeaturesConfiguration).EmailToSendLogsAndFeedback = n.GetStringValue(); } },
                {"isAutoScreenShareEnabled", (o,n) => { (o as TeamworkFeaturesConfiguration).IsAutoScreenShareEnabled = n.GetBoolValue(); } },
                {"isBluetoothBeaconingEnabled", (o,n) => { (o as TeamworkFeaturesConfiguration).IsBluetoothBeaconingEnabled = n.GetBoolValue(); } },
                {"isHideMeetingNamesEnabled", (o,n) => { (o as TeamworkFeaturesConfiguration).IsHideMeetingNamesEnabled = n.GetBoolValue(); } },
                {"isSendLogsAndFeedbackEnabled", (o,n) => { (o as TeamworkFeaturesConfiguration).IsSendLogsAndFeedbackEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("emailToSendLogsAndFeedback", EmailToSendLogsAndFeedback);
            writer.WriteBoolValue("isAutoScreenShareEnabled", IsAutoScreenShareEnabled);
            writer.WriteBoolValue("isBluetoothBeaconingEnabled", IsBluetoothBeaconingEnabled);
            writer.WriteBoolValue("isHideMeetingNamesEnabled", IsHideMeetingNamesEnabled);
            writer.WriteBoolValue("isSendLogsAndFeedbackEnabled", IsSendLogsAndFeedbackEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
