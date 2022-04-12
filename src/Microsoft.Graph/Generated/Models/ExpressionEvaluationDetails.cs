using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExpressionEvaluationDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents expression which has been evaluated.</summary>
        public string Expression { get; set; }
        /// <summary>Represents the details of the evaluation of the expression.</summary>
        public List<ExpressionEvaluationDetails> ExpressionEvaluationDetails_prop { get; set; }
        /// <summary>Represents the value of the result of the current expression.</summary>
        public bool? ExpressionResult { get; set; }
        /// <summary>Defines the name of the property and the value of that property.</summary>
        public Microsoft.Graph.Beta.Models.PropertyToEvaluate PropertyToEvaluate { get; set; }
        /// <summary>
        /// Instantiates a new expressionEvaluationDetails and sets the default values.
        /// </summary>
        public ExpressionEvaluationDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExpressionEvaluationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpressionEvaluationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expression", n => { Expression = n.GetStringValue(); } },
                {"expressionEvaluationDetails", n => { ExpressionEvaluationDetails_prop = n.GetCollectionOfObjectValues<ExpressionEvaluationDetails>(ExpressionEvaluationDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"expressionResult", n => { ExpressionResult = n.GetBoolValue(); } },
                {"propertyToEvaluate", n => { PropertyToEvaluate = n.GetObjectValue<Microsoft.Graph.Beta.Models.PropertyToEvaluate>(Microsoft.Graph.Beta.Models.PropertyToEvaluate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PropertyToEvaluate>("propertyToEvaluate", PropertyToEvaluate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
