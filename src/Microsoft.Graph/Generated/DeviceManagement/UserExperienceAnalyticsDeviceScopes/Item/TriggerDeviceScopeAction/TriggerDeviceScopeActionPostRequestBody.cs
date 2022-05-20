using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScopes.Item.TriggerDeviceScopeAction {
    /// <summary>Provides operations to call the triggerDeviceScopeAction method.</summary>
    public class TriggerDeviceScopeActionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The actionName property</summary>
        public string ActionName {
            get { return BackingStore?.Get<string>(nameof(ActionName)); }
            set { BackingStore?.Set(nameof(ActionName), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceScopeId property</summary>
        public string DeviceScopeId {
            get { return BackingStore?.Get<string>(nameof(DeviceScopeId)); }
            set { BackingStore?.Set(nameof(DeviceScopeId), value); }
        }
        /// <summary>
        /// Instantiates a new triggerDeviceScopeActionPostRequestBody and sets the default values.
        /// </summary>
        public TriggerDeviceScopeActionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TriggerDeviceScopeActionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerDeviceScopeActionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"deviceScopeId", n => { DeviceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteStringValue("deviceScopeId", DeviceScopeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
