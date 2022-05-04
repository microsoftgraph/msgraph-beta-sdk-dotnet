using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScopes.Item.TriggerDeviceScopeAction {
    /// <summary>Provides operations to call the triggerDeviceScopeAction method.</summary>
    public class TriggerDeviceScopeActionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The actionName property</summary>
        public DeviceScopeAction ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceScopeId property</summary>
        public string DeviceScopeId { get; set; }
        /// <summary>
        /// Instantiates a new triggerDeviceScopeActionRequestBody and sets the default values.
        /// </summary>
        public TriggerDeviceScopeActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TriggerDeviceScopeActionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerDeviceScopeActionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetObjectValue<DeviceScopeAction>(DeviceScopeAction.CreateFromDiscriminatorValue); } },
                {"deviceScopeId", n => { DeviceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceScopeAction>("actionName", ActionName);
            writer.WriteStringValue("deviceScopeId", DeviceScopeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
