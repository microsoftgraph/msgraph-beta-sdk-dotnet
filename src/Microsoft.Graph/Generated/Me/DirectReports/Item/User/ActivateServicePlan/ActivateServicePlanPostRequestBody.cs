using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.DirectReports.Item.User.ActivateServicePlan {
    /// <summary>Provides operations to call the activateServicePlan method.</summary>
    public class ActivateServicePlanPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The servicePlanId property</summary>
        public string ServicePlanId {
            get { return BackingStore?.Get<string>(nameof(ServicePlanId)); }
            set { BackingStore?.Set(nameof(ServicePlanId), value); }
        }
        /// <summary>The skuId property</summary>
        public string SkuId {
            get { return BackingStore?.Get<string>(nameof(SkuId)); }
            set { BackingStore?.Set(nameof(SkuId), value); }
        }
        /// <summary>
        /// Instantiates a new activateServicePlanPostRequestBody and sets the default values.
        /// </summary>
        public ActivateServicePlanPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ActivateServicePlanPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivateServicePlanPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"servicePlanId", n => { ServicePlanId = n.GetStringValue(); } },
                {"skuId", n => { SkuId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
