using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.ManagedDevices.BulkSetCloudPcReviewStatus {
    /// <summary>Provides operations to call the bulkSetCloudPcReviewStatus method.</summary>
    public class BulkSetCloudPcReviewStatusPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceIds property</summary>
        public List<string> ManagedDeviceIds {
            get { return BackingStore?.Get<List<string>>("managedDeviceIds"); }
            set { BackingStore?.Set("managedDeviceIds", value); }
        }
        /// <summary>The reviewStatus property</summary>
        public CloudPcReviewStatus ReviewStatus {
            get { return BackingStore?.Get<CloudPcReviewStatus>("reviewStatus"); }
            set { BackingStore?.Set("reviewStatus", value); }
        }
        /// <summary>
        /// Instantiates a new bulkSetCloudPcReviewStatusPostRequestBody and sets the default values.
        /// </summary>
        public BulkSetCloudPcReviewStatusPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BulkSetCloudPcReviewStatusPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkSetCloudPcReviewStatusPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managedDeviceIds", n => { ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"reviewStatus", n => { ReviewStatus = n.GetObjectValue<CloudPcReviewStatus>(CloudPcReviewStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteObjectValue<CloudPcReviewStatus>("reviewStatus", ReviewStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
