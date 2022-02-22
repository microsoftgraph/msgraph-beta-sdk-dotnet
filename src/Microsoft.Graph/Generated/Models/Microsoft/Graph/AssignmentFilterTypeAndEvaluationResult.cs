using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AssignmentFilterTypeAndEvaluationResult : IParsable {
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
