using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression {
    /// <summary>
    /// Provides operations to call the parseExpression method.
    /// </summary>
    public class ParseExpressionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expression property</summary>
        public string Expression {
            get { return BackingStore?.Get<string>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
        /// <summary>The targetAttributeDefinition property</summary>
        public AttributeDefinition TargetAttributeDefinition {
            get { return BackingStore?.Get<AttributeDefinition>("targetAttributeDefinition"); }
            set { BackingStore?.Set("targetAttributeDefinition", value); }
        }
        /// <summary>The testInputObject property</summary>
        public ExpressionInputObject TestInputObject {
            get { return BackingStore?.Get<ExpressionInputObject>("testInputObject"); }
            set { BackingStore?.Set("testInputObject", value); }
        }
        /// <summary>
        /// Instantiates a new parseExpressionPostRequestBody and sets the default values.
        /// </summary>
        public ParseExpressionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParseExpressionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expression", n => { Expression = n.GetStringValue(); } },
                {"targetAttributeDefinition", n => { TargetAttributeDefinition = n.GetObjectValue<AttributeDefinition>(AttributeDefinition.CreateFromDiscriminatorValue); } },
                {"testInputObject", n => { TestInputObject = n.GetObjectValue<ExpressionInputObject>(ExpressionInputObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteObjectValue<AttributeDefinition>("targetAttributeDefinition", TargetAttributeDefinition);
            writer.WriteObjectValue<ExpressionInputObject>("testInputObject", TestInputObject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
