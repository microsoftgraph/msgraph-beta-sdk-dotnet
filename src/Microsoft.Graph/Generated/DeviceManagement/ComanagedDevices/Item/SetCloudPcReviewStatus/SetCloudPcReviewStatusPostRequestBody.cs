using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SetCloudPcReviewStatus {
    /// <summary>Provides operations to call the setCloudPcReviewStatus method.</summary>
    public class SetCloudPcReviewStatusPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The reviewStatus property</summary>
        public CloudPcReviewStatus ReviewStatus {
            get { return BackingStore?.Get<CloudPcReviewStatus>(nameof(ReviewStatus)); }
            set { BackingStore?.Set(nameof(ReviewStatus), value); }
        }
        /// <summary>
        /// Instantiates a new setCloudPcReviewStatusPostRequestBody and sets the default values.
        /// </summary>
        public SetCloudPcReviewStatusPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetCloudPcReviewStatusPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetCloudPcReviewStatusPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"reviewStatus", n => { ReviewStatus = n.GetObjectValue<CloudPcReviewStatus>(CloudPcReviewStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CloudPcReviewStatus>("reviewStatus", ReviewStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
