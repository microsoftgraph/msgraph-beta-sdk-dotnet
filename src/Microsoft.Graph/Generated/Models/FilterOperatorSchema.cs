using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class FilterOperatorSchema : Entity, IParsable {
        /// <summary>The arity property</summary>
        public ScopeOperatorType? Arity {
            get { return BackingStore?.Get<ScopeOperatorType?>("arity"); }
            set { BackingStore?.Set("arity", value); }
        }
        /// <summary>The multivaluedComparisonType property</summary>
        public ScopeOperatorMultiValuedComparisonType? MultivaluedComparisonType {
            get { return BackingStore?.Get<ScopeOperatorMultiValuedComparisonType?>("multivaluedComparisonType"); }
            set { BackingStore?.Set("multivaluedComparisonType", value); }
        }
        /// <summary>Attribute types supported by the operator. Possible values are: Boolean, Binary, Reference, Integer, String.</summary>
        public List<AttributeType?> SupportedAttributeTypes {
            get { return BackingStore?.Get<List<AttributeType?>>("supportedAttributeTypes"); }
            set { BackingStore?.Set("supportedAttributeTypes", value); }
        }
        /// <summary>
        /// Instantiates a new FilterOperatorSchema and sets the default values.
        /// </summary>
        public FilterOperatorSchema() : base() {
            OdataType = "#microsoft.graph.filterOperatorSchema";
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
                {"supportedAttributeTypes", n => { SupportedAttributeTypes = n.GetCollectionOfEnumValues<AttributeType>()?.ToList(); } },
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
