using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class PropertyRule : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the operations to be performed during evaluation of a single propertyRule, where property and a string from the values collection are the respective operands. Possible values are: null, equals, notEquals, contains, notContains, lessThan, greaterThan, startsWith, unknownFutureValue. Required.</summary>
        public RuleOperation? Operation { get; set; }
        /// <summary>The property from the externalItem schema. Required.</summary>
        public string Property { get; set; }
        /// <summary>A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.</summary>
        public List<string> Values { get; set; }
        /// <summary>The join operator for evaluating multiple propertyRules. For example, if and is specified, then all propertyRules must be true for the propertyRule to be true. Possible values are: or, and. Required.</summary>
        public BinaryOperator? ValuesJoinedBy { get; set; }
        /// <summary>
        /// Instantiates a new propertyRule and sets the default values.
        /// </summary>
        public PropertyRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"operation", (o,n) => { (o as PropertyRule).Operation = n.GetEnumValue<RuleOperation>(); } },
                {"property", (o,n) => { (o as PropertyRule).Property = n.GetStringValue(); } },
                {"values", (o,n) => { (o as PropertyRule).Values = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"valuesJoinedBy", (o,n) => { (o as PropertyRule).ValuesJoinedBy = n.GetEnumValue<BinaryOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RuleOperation>("operation", Operation);
            writer.WriteStringValue("property", Property);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteEnumValue<BinaryOperator>("valuesJoinedBy", ValuesJoinedBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
