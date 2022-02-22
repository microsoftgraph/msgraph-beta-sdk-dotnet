using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class HybridAgentUpdaterConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if updater configuration will be skipped and the agent will receive an update when the next version of the agent is available.</summary>
        public bool? AllowUpdateConfigurationOverride { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DeferUpdateDateTime { get; set; }
        public UpdateWindow UpdateWindow { get; set; }
        /// <summary>
        /// Instantiates a new hybridAgentUpdaterConfiguration and sets the default values.
        /// </summary>
        public HybridAgentUpdaterConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowUpdateConfigurationOverride", (o,n) => { (o as HybridAgentUpdaterConfiguration).AllowUpdateConfigurationOverride = n.GetBoolValue(); } },
                {"deferUpdateDateTime", (o,n) => { (o as HybridAgentUpdaterConfiguration).DeferUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"updateWindow", (o,n) => { (o as HybridAgentUpdaterConfiguration).UpdateWindow = n.GetObjectValue<UpdateWindow>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowUpdateConfigurationOverride", AllowUpdateConfigurationOverride);
            writer.WriteDateTimeOffsetValue("deferUpdateDateTime", DeferUpdateDateTime);
            writer.WriteObjectValue<UpdateWindow>("updateWindow", UpdateWindow);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
