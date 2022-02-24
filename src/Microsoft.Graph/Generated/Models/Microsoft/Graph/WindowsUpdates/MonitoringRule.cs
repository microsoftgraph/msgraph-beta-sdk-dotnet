using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class MonitoringRule : IParsable {
        /// <summary>The action triggered when the threshold for the given signal is met. Possible values are: alertError, pauseDeployment, unknownFutureValue.</summary>
        public MonitoringAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The signal to monitor. Possible values are: rollback, unknownFutureValue.</summary>
        public MonitoringSignal? Signal { get; set; }
        /// <summary>The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).</summary>
        public int? Threshold { get; set; }
        /// <summary>
        /// Instantiates a new monitoringRule and sets the default values.
        /// </summary>
        public MonitoringRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"action", (o,n) => { (o as MonitoringRule).Action = n.GetEnumValue<MonitoringAction>(); } },
                {"signal", (o,n) => { (o as MonitoringRule).Signal = n.GetEnumValue<MonitoringSignal>(); } },
                {"threshold", (o,n) => { (o as MonitoringRule).Threshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MonitoringAction>("action", Action);
            writer.WriteEnumValue<MonitoringSignal>("signal", Signal);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
