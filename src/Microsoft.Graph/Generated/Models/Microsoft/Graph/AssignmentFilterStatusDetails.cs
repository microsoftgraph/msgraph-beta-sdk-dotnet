using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AssignmentFilterStatusDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device properties used for filter evaluation during device check-in time.</summary>
        public List<KeyValuePair> DeviceProperties { get; set; }
        /// <summary>Evaluation result summaries for each filter associated to device and payload</summary>
        public List<AssignmentFilterEvaluationSummary> EvalutionSummaries { get; set; }
        /// <summary>Unique identifier for the device object.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Unique identifier for payload object.</summary>
        public string PayloadId { get; set; }
        /// <summary>Unique identifier for UserId object. Can be null</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new assignmentFilterStatusDetails and sets the default values.
        /// </summary>
        public AssignmentFilterStatusDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceProperties", (o,n) => { (o as AssignmentFilterStatusDetails).DeviceProperties = n.GetCollectionOfObjectValues<KeyValuePair>().ToList(); } },
                {"evalutionSummaries", (o,n) => { (o as AssignmentFilterStatusDetails).EvalutionSummaries = n.GetCollectionOfObjectValues<AssignmentFilterEvaluationSummary>().ToList(); } },
                {"managedDeviceId", (o,n) => { (o as AssignmentFilterStatusDetails).ManagedDeviceId = n.GetStringValue(); } },
                {"payloadId", (o,n) => { (o as AssignmentFilterStatusDetails).PayloadId = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AssignmentFilterStatusDetails).UserId = n.GetStringValue(); } },
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
