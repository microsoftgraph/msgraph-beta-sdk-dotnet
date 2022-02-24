using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.EvaluateAssignmentFilter {
    public class EvaluateAssignmentFilterRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AssignmentFilterEvaluateRequest Data { get; set; }
        /// <summary>
        /// Instantiates a new evaluateAssignmentFilterRequestBody and sets the default values.
        /// </summary>
        public EvaluateAssignmentFilterRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"data", (o,n) => { (o as EvaluateAssignmentFilterRequestBody).Data = n.GetObjectValue<AssignmentFilterEvaluateRequest>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AssignmentFilterEvaluateRequest>("data", Data);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
