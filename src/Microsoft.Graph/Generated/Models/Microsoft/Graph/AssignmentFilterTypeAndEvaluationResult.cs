using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getAssignmentFiltersStatusDetails method.</summary>
    public class AssignmentFilterTypeAndEvaluationResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the filter type. Possible values are: none, include, exclude.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType { get; set; }
        /// <summary>Represents the evalaution result of the filter. Possible values are: unknown, match, notMatch, inconclusive, failure, notEvaluated.</summary>
        public AssignmentFilterEvaluationResult? EvaluationResult { get; set; }
        /// <summary>
        /// Instantiates a new assignmentFilterTypeAndEvaluationResult and sets the default values.
        /// </summary>
        public AssignmentFilterTypeAndEvaluationResult() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignmentFilterType", (o,n) => { (o as AssignmentFilterTypeAndEvaluationResult).AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"evaluationResult", (o,n) => { (o as AssignmentFilterTypeAndEvaluationResult).EvaluationResult = n.GetEnumValue<AssignmentFilterEvaluationResult>(); } },
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
