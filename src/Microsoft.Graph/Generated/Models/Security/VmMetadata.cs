using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class VmMetadata : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cloudProvider property</summary>
        public VmCloudProvider? CloudProvider {
            get { return BackingStore?.Get<VmCloudProvider?>(nameof(CloudProvider)); }
            set { BackingStore?.Set(nameof(CloudProvider), value); }
        }
        /// <summary>The resourceId property</summary>
        public string ResourceId {
            get { return BackingStore?.Get<string>(nameof(ResourceId)); }
            set { BackingStore?.Set(nameof(ResourceId), value); }
        }
        /// <summary>The subscriptionId property</summary>
        public string SubscriptionId {
            get { return BackingStore?.Get<string>(nameof(SubscriptionId)); }
            set { BackingStore?.Set(nameof(SubscriptionId), value); }
        }
        /// <summary>The vmId property</summary>
        public string VmId {
            get { return BackingStore?.Get<string>(nameof(VmId)); }
            set { BackingStore?.Set(nameof(VmId), value); }
        }
        /// <summary>
        /// Instantiates a new vmMetadata and sets the default values.
        /// </summary>
        public VmMetadata() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VmMetadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VmMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cloudProvider", n => { CloudProvider = n.GetEnumValue<VmCloudProvider>(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"vmId", n => { VmId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VmCloudProvider>("cloudProvider", CloudProvider);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("vmId", VmId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
