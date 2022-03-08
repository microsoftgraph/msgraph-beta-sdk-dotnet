using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Applications.Item.Synchronization.Jobs.Item.Schema.ParseExpression {
    /// <summary>Provides operations to call the parseExpression method.</summary>
    public class ParseExpressionRequestBody : IParsable, IAdditionalDataHolder {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParseExpressionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expression", (o,n) => { (o as ParseExpressionRequestBody).Expression = n.GetStringValue(); } },
                {"targetAttributeDefinition", (o,n) => { (o as ParseExpressionRequestBody).TargetAttributeDefinition = n.GetObjectValue<AttributeDefinition>(AttributeDefinition.CreateFromDiscriminatorValue); } },
                {"testInputObject", (o,n) => { (o as ParseExpressionRequestBody).TestInputObject = n.GetObjectValue<ExpressionInputObject>(ExpressionInputObject.CreateFromDiscriminatorValue); } },
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
