using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class HybridAgentUpdaterConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if updater configuration will be skipped and the agent will receive an update when the next version of the agent is available.</summary>
        public bool? AllowUpdateConfigurationOverride { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DeferUpdateDateTime { get; set; }
        /// <summary>The updateWindow property</summary>
        public Microsoft.Graph.Beta.Models.UpdateWindow UpdateWindow { get; set; }
        /// <summary>
        /// Instantiates a new hybridAgentUpdaterConfiguration and sets the default values.
        /// </summary>
        public HybridAgentUpdaterConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HybridAgentUpdaterConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HybridAgentUpdaterConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowUpdateConfigurationOverride", n => { AllowUpdateConfigurationOverride = n.GetBoolValue(); } },
                {"deferUpdateDateTime", n => { DeferUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"updateWindow", n => { UpdateWindow = n.GetObjectValue<Microsoft.Graph.Beta.Models.UpdateWindow>(Microsoft.Graph.Beta.Models.UpdateWindow.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UpdateWindow>("updateWindow", UpdateWindow);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
