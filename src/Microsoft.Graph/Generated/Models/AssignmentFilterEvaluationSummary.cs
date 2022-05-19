using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represent result summary for assignment filter evaluation</summary>
    public class AssignmentFilterEvaluationSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The admin defined name for assignment filter.</summary>
        public string AssignmentFilterDisplayName {
            get { return BackingStore?.Get<string>(nameof(AssignmentFilterDisplayName)); }
            set { BackingStore?.Set(nameof(AssignmentFilterDisplayName), value); }
        }
        /// <summary>Unique identifier for the assignment filter object</summary>
        public string AssignmentFilterId {
            get { return BackingStore?.Get<string>(nameof(AssignmentFilterId)); }
            set { BackingStore?.Set(nameof(AssignmentFilterId), value); }
        }
        /// <summary>The time the assignment filter was last modified.</summary>
        public DateTimeOffset? AssignmentFilterLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AssignmentFilterLastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(AssignmentFilterLastModifiedDateTime), value); }
        }
        /// <summary>The platform for which this assignment filter is created. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.</summary>
        public DevicePlatformType? AssignmentFilterPlatform {
            get { return BackingStore?.Get<DevicePlatformType?>(nameof(AssignmentFilterPlatform)); }
            set { BackingStore?.Set(nameof(AssignmentFilterPlatform), value); }
        }
        /// <summary>Indicate filter type either include or exclude. Possible values are: none, include, exclude.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentFilterType?>(nameof(AssignmentFilterType)); }
            set { BackingStore?.Set(nameof(AssignmentFilterType), value); }
        }
        /// <summary>A collection of filter types and their corresponding evaluation results.</summary>
        public List<AssignmentFilterTypeAndEvaluationResult> AssignmentFilterTypeAndEvaluationResults {
            get { return BackingStore?.Get<List<AssignmentFilterTypeAndEvaluationResult>>(nameof(AssignmentFilterTypeAndEvaluationResults)); }
            set { BackingStore?.Set(nameof(AssignmentFilterTypeAndEvaluationResults), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The time assignment filter was evaluated.</summary>
        public DateTimeOffset? EvaluationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EvaluationDateTime)); }
            set { BackingStore?.Set(nameof(EvaluationDateTime), value); }
        }
        /// <summary>Assignment filter evaluation result. Possible values are: unknown, match, notMatch, inconclusive, failure, notEvaluated.</summary>
        public AssignmentFilterEvaluationResult? EvaluationResult {
            get { return BackingStore?.Get<AssignmentFilterEvaluationResult?>(nameof(EvaluationResult)); }
            set { BackingStore?.Set(nameof(EvaluationResult), value); }
        }
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluationSummary and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluationSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterDisplayName", n => { AssignmentFilterDisplayName = n.GetStringValue(); } },
                {"assignmentFilterId", n => { AssignmentFilterId = n.GetStringValue(); } },
                {"assignmentFilterLastModifiedDateTime", n => { AssignmentFilterLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignmentFilterPlatform", n => { AssignmentFilterPlatform = n.GetEnumValue<DevicePlatformType>(); } },
                {"assignmentFilterType", n => { AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"assignmentFilterTypeAndEvaluationResults", n => { AssignmentFilterTypeAndEvaluationResults = n.GetCollectionOfObjectValues<AssignmentFilterTypeAndEvaluationResult>(AssignmentFilterTypeAndEvaluationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"evaluationDateTime", n => { EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"evaluationResult", n => { EvaluationResult = n.GetEnumValue<AssignmentFilterEvaluationResult>(); } },
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
