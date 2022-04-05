using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExpressionInputObject : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Definition of the test object.</summary>
        public ObjectDefinition Definition { get; set; }
        /// <summary>Property values of the test object.</summary>
        public List<StringKeyObjectValuePair> Properties { get; set; }
        /// <summary>
        /// Instantiates a new expressionInputObject and sets the default values.
        /// </summary>
        public ExpressionInputObject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExpressionInputObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpressionInputObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"definition", (o,n) => { (o as ExpressionInputObject).Definition = n.GetObjectValue<ObjectDefinition>(ObjectDefinition.CreateFromDiscriminatorValue); } },
                {"properties", (o,n) => { (o as ExpressionInputObject).Properties = n.GetCollectionOfObjectValues<StringKeyObjectValuePair>(StringKeyObjectValuePair.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ObjectDefinition>("definition", Definition);
            writer.WriteCollectionOfObjectValues<StringKeyObjectValuePair>("properties", Properties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
