using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ExpressionEvaluationDetails : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents expression which has been evaluated.</summary>
        public string Expression { get; set; }
        /// <summary>Represents the details of the evaluation of the expression.</summary>
        public List<ExpressionEvaluationDetails> ExpressionEvaluationDetails_prop { get; set; }
        /// <summary>Represents the value of the result of the current expression.</summary>
        public bool? ExpressionResult { get; set; }
        /// <summary>Defines the name of the property and the value of that property.</summary>
        public PropertyToEvaluate PropertyToEvaluate { get; set; }
        /// <summary>
        /// Instantiates a new expressionEvaluationDetails and sets the default values.
        /// </summary>
        public ExpressionEvaluationDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expression", (o,n) => { (o as ExpressionEvaluationDetails).Expression = n.GetStringValue(); } },
                {"expressionEvaluationDetails", (o,n) => { (o as ExpressionEvaluationDetails).ExpressionEvaluationDetails_prop = n.GetCollectionOfObjectValues<ExpressionEvaluationDetails>().ToList(); } },
                {"expressionResult", (o,n) => { (o as ExpressionEvaluationDetails).ExpressionResult = n.GetBoolValue(); } },
                {"propertyToEvaluate", (o,n) => { (o as ExpressionEvaluationDetails).PropertyToEvaluate = n.GetObjectValue<PropertyToEvaluate>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteCollectionOfObjectValues<ExpressionEvaluationDetails>("expressionEvaluationDetails", ExpressionEvaluationDetails_prop);
            writer.WriteBoolValue("expressionResult", ExpressionResult);
            writer.WriteObjectValue<PropertyToEvaluate>("propertyToEvaluate", PropertyToEvaluate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
