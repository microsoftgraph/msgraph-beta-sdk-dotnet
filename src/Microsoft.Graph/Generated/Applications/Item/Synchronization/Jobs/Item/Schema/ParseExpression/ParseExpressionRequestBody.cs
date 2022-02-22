using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Applications.Item.Synchronization.Jobs.Item.Schema.ParseExpression {
    public class ParseExpressionRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Expression { get; set; }
        public AttributeDefinition TargetAttributeDefinition { get; set; }
        public ExpressionInputObject TestInputObject { get; set; }
        /// <summary>
        /// Instantiates a new parseExpressionRequestBody and sets the default values.
        /// </summary>
        public ParseExpressionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expression", (o,n) => { (o as ParseExpressionRequestBody).Expression = n.GetStringValue(); } },
                {"targetAttributeDefinition", (o,n) => { (o as ParseExpressionRequestBody).TargetAttributeDefinition = n.GetObjectValue<AttributeDefinition>(); } },
                {"testInputObject", (o,n) => { (o as ParseExpressionRequestBody).TestInputObject = n.GetObjectValue<ExpressionInputObject>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteObjectValue<AttributeDefinition>("targetAttributeDefinition", TargetAttributeDefinition);
            writer.WriteObjectValue<ExpressionInputObject>("testInputObject", TestInputObject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
