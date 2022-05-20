using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the information about the property which is supported in crafting the rule of AssignmentFilter.</summary>
    public class AssignmentFilterSupportedProperty : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The data type of the property.</summary>
        public string DataType {
            get { return BackingStore?.Get<string>(nameof(DataType)); }
            set { BackingStore?.Set(nameof(DataType), value); }
        }
        /// <summary>Indicates whether the property is a collection type or not.</summary>
        public bool? IsCollection {
            get { return BackingStore?.Get<bool?>(nameof(IsCollection)); }
            set { BackingStore?.Set(nameof(IsCollection), value); }
        }
        /// <summary>Name of the property.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Regex string to do validation on the property value.</summary>
        public string PropertyRegexConstraint {
            get { return BackingStore?.Get<string>(nameof(PropertyRegexConstraint)); }
            set { BackingStore?.Set(nameof(PropertyRegexConstraint), value); }
        }
        /// <summary>List of all supported operators on this property.</summary>
        public List<string> SupportedOperators {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedOperators)); }
            set { BackingStore?.Set(nameof(SupportedOperators), value); }
        }
        /// <summary>List of all supported values for this propery, empty if everything is supported.</summary>
        public List<string> SupportedValues {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedValues)); }
            set { BackingStore?.Set(nameof(SupportedValues), value); }
        }
        /// <summary>
        /// Instantiates a new assignmentFilterSupportedProperty and sets the default values.
        /// </summary>
        public AssignmentFilterSupportedProperty() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
                {"supportedOperators", n => { SupportedOperators = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("supportedOperators", SupportedOperators);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedValues", SupportedValues);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
