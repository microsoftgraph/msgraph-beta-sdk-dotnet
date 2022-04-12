using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the information about the property which is supported in crafting the rule of AssignmentFilter.</summary>
    public class AssignmentFilterSupportedProperty : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data type of the property.</summary>
        public string DataType { get; set; }
        /// <summary>Indicates whether the property is a collection type or not.</summary>
        public bool? IsCollection { get; set; }
        /// <summary>Name of the property.</summary>
        public string Name { get; set; }
        /// <summary>Regex string to do validation on the property value.</summary>
        public string PropertyRegexConstraint { get; set; }
        /// <summary>List of all supported operators on this property.</summary>
        public List<AssignmentFilterOperator?> SupportedOperators { get; set; }
        /// <summary>List of all supported values for this propery, empty if everything is supported.</summary>
        public List<string> SupportedValues { get; set; }
        /// <summary>
        /// Instantiates a new assignmentFilterSupportedProperty and sets the default values.
        /// </summary>
        public AssignmentFilterSupportedProperty() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignmentFilterSupportedProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterSupportedProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetStringValue(); } },
                {"isCollection", n => { IsCollection = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"propertyRegexConstraint", n => { PropertyRegexConstraint = n.GetStringValue(); } },
                {"supportedOperators", n => { SupportedOperators = n.GetCollectionOfEnumValues<AssignmentFilterOperator>().ToList(); } },
                {"supportedValues", n => { SupportedValues = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dataType", DataType);
            writer.WriteBoolValue("isCollection", IsCollection);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("propertyRegexConstraint", PropertyRegexConstraint);
            writer.WriteCollectionOfEnumValues<AssignmentFilterOperator>("supportedOperators", SupportedOperators);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedValues", SupportedValues);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
