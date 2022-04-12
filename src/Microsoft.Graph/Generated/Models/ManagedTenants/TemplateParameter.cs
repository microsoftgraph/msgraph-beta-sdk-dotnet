using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TemplateParameter : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description for the template parameter. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the template parameter. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The allowed values for the template parameter represented by a serialized string of JSON. Optional. Read-only.</summary>
        public string JsonAllowedValues { get; set; }
        /// <summary>The default value for the template parameter represented by a serialized string of JSON. Required. Read-only.</summary>
        public string JsonDefaultValue { get; set; }
        /// <summary>The data type for the template parameter.. Possible values are: string, integer, boolean, guid, stringCollection, integerCollection, booleanCollection, guidCollection, unknownFutureValue. Required. Read-only.</summary>
        public ManagementParameterValueType? ValueType { get; set; }
        /// <summary>
        /// Instantiates a new templateParameter and sets the default values.
        /// </summary>
        public TemplateParameter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TemplateParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemplateParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"jsonAllowedValues", n => { JsonAllowedValues = n.GetStringValue(); } },
                {"jsonDefaultValue", n => { JsonDefaultValue = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<ManagementParameterValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("jsonAllowedValues", JsonAllowedValues);
            writer.WriteStringValue("jsonDefaultValue", JsonDefaultValue);
            writer.WriteEnumValue<ManagementParameterValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
