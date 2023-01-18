using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScope.TriggerDeviceScopeAction {
    public class TriggerDeviceScopeActionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Trigger on the service to either START or STOP computing metrics data based on a device scope configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ActionName {
            get { return BackingStore?.Get<string?>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
#else
        public string ActionName {
            get { return BackingStore?.Get<string>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceScopeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DeviceScopeId {
            get { return BackingStore?.Get<string?>("deviceScopeId"); }
            set { BackingStore?.Set("deviceScopeId", value); }
        }
#else
        public string DeviceScopeId {
            get { return BackingStore?.Get<string>("deviceScopeId"); }
            set { BackingStore?.Set("deviceScopeId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new triggerDeviceScopeActionPostRequestBody and sets the default values.
        /// </summary>
        public TriggerDeviceScopeActionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteStringValue("deviceScopeId", DeviceScopeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
