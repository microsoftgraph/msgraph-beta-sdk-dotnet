using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the directory singleton.</summary>
    public class CustomSecurityAttributeDefinition : Entity, IParsable {
        /// <summary>Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.</summary>
        public List<AllowedValue> AllowedValues { get; set; }
        /// <summary>Name of the attribute set. Case insensitive.</summary>
        public string AttributeSet { get; set; }
        /// <summary>Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.</summary>
        public string Description { get; set; }
        /// <summary>Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.</summary>
        public bool? IsCollection { get; set; }
        /// <summary>Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values. Cannot be changed later.</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.</summary>
        public string Name { get; set; }
        /// <summary>Specifies whether the custom security attribute is active or deactivated. Acceptable values are Available and Deprecated. Can be changed later.</summary>
        public string Status { get; set; }
        /// <summary>Data type for the custom security attribute values. Supported types are Boolean, Integer, and String. Cannot be changed later.</summary>
        public string Type { get; set; }
        /// <summary>Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.</summary>
        public bool? UsePreDefinedValuesOnly { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomSecurityAttributeDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomSecurityAttributeDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedValues", (o,n) => { (o as CustomSecurityAttributeDefinition).AllowedValues = n.GetCollectionOfObjectValues<AllowedValue>(AllowedValue.CreateFromDiscriminatorValue).ToList(); } },
                {"attributeSet", (o,n) => { (o as CustomSecurityAttributeDefinition).AttributeSet = n.GetStringValue(); } },
                {"description", (o,n) => { (o as CustomSecurityAttributeDefinition).Description = n.GetStringValue(); } },
                {"isCollection", (o,n) => { (o as CustomSecurityAttributeDefinition).IsCollection = n.GetBoolValue(); } },
                {"isSearchable", (o,n) => { (o as CustomSecurityAttributeDefinition).IsSearchable = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as CustomSecurityAttributeDefinition).Name = n.GetStringValue(); } },
                {"status", (o,n) => { (o as CustomSecurityAttributeDefinition).Status = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CustomSecurityAttributeDefinition).Type = n.GetStringValue(); } },
                {"usePreDefinedValuesOnly", (o,n) => { (o as CustomSecurityAttributeDefinition).UsePreDefinedValuesOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AllowedValue>("allowedValues", AllowedValues);
            writer.WriteStringValue("attributeSet", AttributeSet);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isCollection", IsCollection);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteBoolValue("usePreDefinedValuesOnly", UsePreDefinedValuesOnly);
        }
    }
}
