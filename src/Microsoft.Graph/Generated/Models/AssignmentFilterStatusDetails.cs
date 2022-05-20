using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represent status details for device and payload and all associated applied filters.</summary>
    public class AssignmentFilterStatusDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device properties used for filter evaluation during device check-in time.</summary>
        public List<KeyValuePair> DeviceProperties {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(DeviceProperties)); }
            set { BackingStore?.Set(nameof(DeviceProperties), value); }
        }
        /// <summary>Evaluation result summaries for each filter associated to device and payload</summary>
        public List<AssignmentFilterEvaluationSummary> EvalutionSummaries {
            get { return BackingStore?.Get<List<AssignmentFilterEvaluationSummary>>(nameof(EvalutionSummaries)); }
            set { BackingStore?.Set(nameof(EvalutionSummaries), value); }
        }
        /// <summary>Unique identifier for the device object.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>Unique identifier for payload object.</summary>
        public string PayloadId {
            get { return BackingStore?.Get<string>(nameof(PayloadId)); }
            set { BackingStore?.Set(nameof(PayloadId), value); }
        }
        /// <summary>Unique identifier for UserId object. Can be null</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Instantiates a new AssignmentFilterStatusDetails and sets the default values.
        /// </summary>
        public AssignmentFilterStatusDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentFilterStatusDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterStatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceProperties", n => { DeviceProperties = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"evalutionSummaries", n => { EvalutionSummaries = n.GetCollectionOfObjectValues<AssignmentFilterEvaluationSummary>(AssignmentFilterEvaluationSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<KeyValuePair>("deviceProperties", DeviceProperties);
            writer.WriteCollectionOfObjectValues<AssignmentFilterEvaluationSummary>("evalutionSummaries", EvalutionSummaries);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
