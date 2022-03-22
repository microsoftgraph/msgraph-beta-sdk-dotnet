using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ParseExpressionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Error details, if expression evaluation resulted in an error.</summary>
        public PublicError Error { get; set; }
        /// <summary>A collection of values produced by the evaluation of the expression.</summary>
        public List<string> EvaluationResult { get; set; }
        /// <summary>true if the evaluation was successful.</summary>
        public bool? EvaluationSucceeded { get; set; }
        /// <summary>An attributeMappingSource object representing the parsed expression.</summary>
        public AttributeMappingSource ParsedExpression { get; set; }
        /// <summary>true if the expression was parsed successfully.</summary>
        public bool? ParsingSucceeded { get; set; }
        /// <summary>
        /// Instantiates a new parseExpressionResponse and sets the default values.
        /// </summary>
        public ParseExpressionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParseExpressionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"error", (o,n) => { (o as ParseExpressionResponse).Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"evaluationResult", (o,n) => { (o as ParseExpressionResponse).EvaluationResult = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"evaluationSucceeded", (o,n) => { (o as ParseExpressionResponse).EvaluationSucceeded = n.GetBoolValue(); } },
                {"parsedExpression", (o,n) => { (o as ParseExpressionResponse).ParsedExpression = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                {"parsingSucceeded", (o,n) => { (o as ParseExpressionResponse).ParsingSucceeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("evaluationResult", EvaluationResult);
            writer.WriteBoolValue("evaluationSucceeded", EvaluationSucceeded);
            writer.WriteObjectValue<AttributeMappingSource>("parsedExpression", ParsedExpression);
            writer.WriteBoolValue("parsingSucceeded", ParsingSucceeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
