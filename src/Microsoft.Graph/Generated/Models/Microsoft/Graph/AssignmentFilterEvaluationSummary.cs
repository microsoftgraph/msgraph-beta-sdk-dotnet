using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getAssignmentFiltersStatusDetails method.</summary>
    public class AssignmentFilterEvaluationSummary : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin defined name for assignment filter.</summary>
        public string AssignmentFilterDisplayName { get; set; }
        /// <summary>Unique identifier for the assignment filter object</summary>
        public string AssignmentFilterId { get; set; }
        /// <summary>The time the assignment filter was last modified.</summary>
        public DateTimeOffset? AssignmentFilterLastModifiedDateTime { get; set; }
        /// <summary>The platform for which this assignment filter is created. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? AssignmentFilterPlatform { get; set; }
        /// <summary>Indicate filter type either include or exclude. Possible values are: none, include, exclude.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType { get; set; }
        /// <summary>A collection of filter types and their corresponding evaluation results.</summary>
        public List<AssignmentFilterTypeAndEvaluationResult> AssignmentFilterTypeAndEvaluationResults { get; set; }
        /// <summary>The time assignment filter was evaluated.</summary>
        public DateTimeOffset? EvaluationDateTime { get; set; }
        /// <summary>Assignment filter evaluation result. Possible values are: unknown, match, notMatch, inconclusive, failure, notEvaluated.</summary>
        public AssignmentFilterEvaluationResult? EvaluationResult { get; set; }
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluationSummary and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluationSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentFilterEvaluationSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterEvaluationSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentFilterDisplayName", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterDisplayName = n.GetStringValue(); } },
                {"assignmentFilterId", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterId = n.GetStringValue(); } },
                {"assignmentFilterLastModifiedDateTime", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignmentFilterPlatform", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterPlatform = n.GetEnumValue<DevicePlatformType>(); } },
                {"assignmentFilterType", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"assignmentFilterTypeAndEvaluationResults", (o,n) => { (o as AssignmentFilterEvaluationSummary).AssignmentFilterTypeAndEvaluationResults = n.GetCollectionOfObjectValues<AssignmentFilterTypeAndEvaluationResult>(AssignmentFilterTypeAndEvaluationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluationDateTime", (o,n) => { (o as AssignmentFilterEvaluationSummary).EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"evaluationResult", (o,n) => { (o as AssignmentFilterEvaluationSummary).EvaluationResult = n.GetEnumValue<AssignmentFilterEvaluationResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignmentFilterDisplayName", AssignmentFilterDisplayName);
            writer.WriteStringValue("assignmentFilterId", AssignmentFilterId);
            writer.WriteDateTimeOffsetValue("assignmentFilterLastModifiedDateTime", AssignmentFilterLastModifiedDateTime);
            writer.WriteEnumValue<DevicePlatformType>("assignmentFilterPlatform", AssignmentFilterPlatform);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("assignmentFilterType", AssignmentFilterType);
            writer.WriteCollectionOfObjectValues<AssignmentFilterTypeAndEvaluationResult>("assignmentFilterTypeAndEvaluationResults", AssignmentFilterTypeAndEvaluationResults);
            writer.WriteDateTimeOffsetValue("evaluationDateTime", EvaluationDateTime);
            writer.WriteEnumValue<AssignmentFilterEvaluationResult>("evaluationResult", EvaluationResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
