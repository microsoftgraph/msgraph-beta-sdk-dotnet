using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttributeMappingParameterSchema : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The given parameter can be provided multiple times (for example, multiple input strings in the Concatenate(string,string,...) function).</summary>
        public bool? AllowMultipleOccurrences { get; set; }
        /// <summary>Parameter name.</summary>
        public string Name { get; set; }
        /// <summary>true if the parameter is required; otherwise false.</summary>
        public bool? Required { get; set; }
        /// <summary>Possible values are: Boolean, Binary, Reference, Integer, String. Default is String.</summary>
        public AttributeType? Type { get; set; }
        /// <summary>
        /// Instantiates a new attributeMappingParameterSchema and sets the default values.
        /// </summary>
        public AttributeMappingParameterSchema() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttributeMappingParameterSchema CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeMappingParameterSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowMultipleOccurrences", (o,n) => { (o as AttributeMappingParameterSchema).AllowMultipleOccurrences = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as AttributeMappingParameterSchema).Name = n.GetStringValue(); } },
                {"required", (o,n) => { (o as AttributeMappingParameterSchema).Required = n.GetBoolValue(); } },
                {"type", (o,n) => { (o as AttributeMappingParameterSchema).Type = n.GetEnumValue<AttributeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleOccurrences", AllowMultipleOccurrences);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("required", Required);
            writer.WriteEnumValue<AttributeType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
