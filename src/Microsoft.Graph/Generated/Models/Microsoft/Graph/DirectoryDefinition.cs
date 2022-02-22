using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DirectoryDefinition : Entity, IParsable {
        /// <summary>Read only value indicating what type of discovery the app supports. Possible values are: AttributeDataTypes, AttributeNames, AttributeReadOnly, None, ReferenceAttributes, UnknownFutureValue.</summary>
        public DirectoryDefinitionDiscoverabilities? Discoverabilities { get; set; }
        /// <summary>Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DiscoveryDateTime { get; set; }
        /// <summary>Name of the directory. Must be unique within the synchronization schema. Not nullable.</summary>
        public string Name { get; set; }
        /// <summary>Collection of objects supported by the directory.</summary>
        public List<ObjectDefinition> Objects { get; set; }
        public bool? ReadOnly { get; set; }
        /// <summary>Read only value that indicates version discovered. null if discovery has not yet occurred.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"discoverabilities", (o,n) => { (o as DirectoryDefinition).Discoverabilities = n.GetEnumValue<DirectoryDefinitionDiscoverabilities>(); } },
                {"discoveryDateTime", (o,n) => { (o as DirectoryDefinition).DiscoveryDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as DirectoryDefinition).Name = n.GetStringValue(); } },
                {"objects", (o,n) => { (o as DirectoryDefinition).Objects = n.GetCollectionOfObjectValues<ObjectDefinition>().ToList(); } },
                {"readOnly", (o,n) => { (o as DirectoryDefinition).ReadOnly = n.GetBoolValue(); } },
                {"version", (o,n) => { (o as DirectoryDefinition).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DirectoryDefinitionDiscoverabilities>("discoverabilities", Discoverabilities);
            writer.WriteDateTimeOffsetValue("discoveryDateTime", DiscoveryDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectDefinition>("objects", Objects);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteStringValue("version", Version);
        }
    }
}
