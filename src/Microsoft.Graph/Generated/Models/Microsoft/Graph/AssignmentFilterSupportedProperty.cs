using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getSupportedProperties method.</summary>
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dataType", (o,n) => { (o as AssignmentFilterSupportedProperty).DataType = n.GetStringValue(); } },
                {"isCollection", (o,n) => { (o as AssignmentFilterSupportedProperty).IsCollection = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as AssignmentFilterSupportedProperty).Name = n.GetStringValue(); } },
                {"propertyRegexConstraint", (o,n) => { (o as AssignmentFilterSupportedProperty).PropertyRegexConstraint = n.GetStringValue(); } },
                {"supportedOperators", (o,n) => { (o as AssignmentFilterSupportedProperty).SupportedOperators = n.GetCollectionOfEnumValues<AssignmentFilterOperator>().ToList(); } },
                {"supportedValues", (o,n) => { (o as AssignmentFilterSupportedProperty).SupportedValues = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
