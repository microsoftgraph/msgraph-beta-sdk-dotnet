using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkFeaturesConfiguration : IParsable {
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
