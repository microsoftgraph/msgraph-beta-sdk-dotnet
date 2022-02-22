using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AndroidManagedStoreAppConfigurationSchema : Entity, IParsable {
        /// <summary>UTF8 encoded byte array containing example JSON string conforming to this schema that demonstrates how to set the configuration for this app</summary>
        public byte[] ExampleJson { get; set; }
        /// <summary>Collection of items each representing a named configuration option in the schema. It contains a flat list of all configuration.</summary>
        public List<AndroidManagedStoreAppConfigurationSchemaItem> NestedSchemaItems { get; set; }
        /// <summary>Collection of items each representing a named configuration option in the schema. It only contains the root-level configuration.</summary>
        public List<AndroidManagedStoreAppConfigurationSchemaItem> SchemaItems { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exampleJson", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchema).ExampleJson = n.GetByteArrayValue(); } },
                {"nestedSchemaItems", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchema).NestedSchemaItems = n.GetCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchemaItem>().ToList(); } },
                {"schemaItems", (o,n) => { (o as AndroidManagedStoreAppConfigurationSchema).SchemaItems = n.GetCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchemaItem>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("exampleJson", ExampleJson);
            writer.WriteCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchemaItem>("nestedSchemaItems", NestedSchemaItems);
            writer.WriteCollectionOfObjectValues<AndroidManagedStoreAppConfigurationSchemaItem>("schemaItems", SchemaItems);
        }
    }
}
