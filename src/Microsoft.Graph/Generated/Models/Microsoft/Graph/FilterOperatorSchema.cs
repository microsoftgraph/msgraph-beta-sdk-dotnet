using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the filterOperators method.</summary>
    public class FilterOperatorSchema : Entity, IParsable {
        /// <summary>Arity of the operator. Possible values are: Binary, Unary. The default is Binary.</summary>
        public ScopeOperatorType? Arity { get; set; }
        /// <summary>Possible values are: All, Any. Applies only to multivalued attributes. All means that all values must satisfy the condition. Any means that at least one value has to satisfy the condition. The default is All.</summary>
        public ScopeOperatorMultiValuedComparisonType? MultivaluedComparisonType { get; set; }
        /// <summary>Attribute types supported by the operator. Possible values are: Boolean, Binary, Reference, Integer, String.</summary>
        public List<AttributeType?> SupportedAttributeTypes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new FilterOperatorSchema CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FilterOperatorSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"arity", (o,n) => { (o as FilterOperatorSchema).Arity = n.GetEnumValue<ScopeOperatorType>(); } },
                {"multivaluedComparisonType", (o,n) => { (o as FilterOperatorSchema).MultivaluedComparisonType = n.GetEnumValue<ScopeOperatorMultiValuedComparisonType>(); } },
                {"supportedAttributeTypes", (o,n) => { (o as FilterOperatorSchema).SupportedAttributeTypes = n.GetCollectionOfEnumValues<AttributeType>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ScopeOperatorType>("arity", Arity);
            writer.WriteEnumValue<ScopeOperatorMultiValuedComparisonType>("multivaluedComparisonType", MultivaluedComparisonType);
            writer.WriteCollectionOfEnumValues<AttributeType>("supportedAttributeTypes", SupportedAttributeTypes);
        }
    }
}
