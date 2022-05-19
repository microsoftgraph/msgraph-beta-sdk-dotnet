using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the filter type and evalaution result of the filter.</summary>
    public class AssignmentFilterTypeAndEvaluationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Represents the filter type. Possible values are: none, include, exclude.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentFilterType?>(nameof(AssignmentFilterType)); }
            set { BackingStore?.Set(nameof(AssignmentFilterType), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the evalaution result of the filter. Possible values are: unknown, match, notMatch, inconclusive, failure, notEvaluated.</summary>
        public AssignmentFilterEvaluationResult? EvaluationResult {
            get { return BackingStore?.Get<AssignmentFilterEvaluationResult?>(nameof(EvaluationResult)); }
            set { BackingStore?.Set(nameof(EvaluationResult), value); }
        }
        /// <summary>
        /// Instantiates a new assignmentFilterTypeAndEvaluationResult and sets the default values.
        /// </summary>
        public AssignmentFilterTypeAndEvaluationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentFilterTypeAndEvaluationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterTypeAndEvaluationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterType", n => { AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"evaluationResult", n => { EvaluationResult = n.GetEnumValue<AssignmentFilterEvaluationResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("assignmentFilterType", AssignmentFilterType);
            writer.WriteEnumValue<AssignmentFilterEvaluationResult>("evaluationResult", EvaluationResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
