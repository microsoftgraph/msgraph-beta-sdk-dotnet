using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The result of the triggered device scope action.</summary>
    public class DeviceScopeActionResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The triggered action name.</summary>
        public Microsoft.Graph.Beta.Models.DeviceScopeAction DeviceScopeAction { get; set; }
        /// <summary>The unique identifier of the device scope the action was triggered on.</summary>
        public string DeviceScopeId { get; set; }
        /// <summary>The message indicates the reason the device scope action failed to trigger.</summary>
        public string FailedMessage { get; set; }
        /// <summary>Indicates the status of the attempt device scope action. When succeeded, the action was succeessfully triggered, When failed, the action was failed to trigger.</summary>
        public DeviceScopeActionStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new deviceScopeActionResult and sets the default values.
        /// </summary>
        public DeviceScopeActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceScopeActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceScopeActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceScopeAction", n => { DeviceScopeAction = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceScopeAction>(Microsoft.Graph.Beta.Models.DeviceScopeAction.CreateFromDiscriminatorValue); } },
                {"deviceScopeId", n => { DeviceScopeId = n.GetStringValue(); } },
                {"failedMessage", n => { FailedMessage = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceScopeActionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceScopeAction>("deviceScopeAction", DeviceScopeAction);
            writer.WriteStringValue("deviceScopeId", DeviceScopeId);
            writer.WriteStringValue("failedMessage", FailedMessage);
            writer.WriteEnumValue<DeviceScopeActionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
