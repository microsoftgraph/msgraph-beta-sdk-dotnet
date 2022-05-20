using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the filterOperators method.</summary>
    public class FilterOperatorSchema : Entity, IParsable {
        /// <summary>Arity of the operator. Possible values are: Binary, Unary. The default is Binary.</summary>
        public ScopeOperatorType? Arity {
            get { return BackingStore?.Get<ScopeOperatorType?>(nameof(Arity)); }
            set { BackingStore?.Set(nameof(Arity), value); }
        }
        /// <summary>Possible values are: All, Any. Applies only to multivalued attributes. All means that all values must satisfy the condition. Any means that at least one value has to satisfy the condition. The default is All.</summary>
        public ScopeOperatorMultiValuedComparisonType? MultivaluedComparisonType {
            get { return BackingStore?.Get<ScopeOperatorMultiValuedComparisonType?>(nameof(MultivaluedComparisonType)); }
            set { BackingStore?.Set(nameof(MultivaluedComparisonType), value); }
        }
        /// <summary>Attribute types supported by the operator. Possible values are: Boolean, Binary, Reference, Integer, String.</summary>
        public List<string> SupportedAttributeTypes {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedAttributeTypes)); }
            set { BackingStore?.Set(nameof(SupportedAttributeTypes), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"arity", n => { Arity = n.GetEnumValue<ScopeOperatorType>(); } },
                {"multivaluedComparisonType", n => { MultivaluedComparisonType = n.GetEnumValue<ScopeOperatorMultiValuedComparisonType>(); } },
                {"supportedAttributeTypes", n => { SupportedAttributeTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("supportedAttributeTypes", SupportedAttributeTypes);
        }
    }
}
