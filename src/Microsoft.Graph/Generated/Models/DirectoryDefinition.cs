using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the instantiate method.</summary>
    public class DirectoryDefinition : Entity, IParsable {
        /// <summary>Read only value indicating what type of discovery the app supports. Possible values are: AttributeDataTypes, AttributeNames, AttributeReadOnly, None, ReferenceAttributes, UnknownFutureValue.</summary>
        public DirectoryDefinitionDiscoverabilities? Discoverabilities {
            get { return BackingStore?.Get<DirectoryDefinitionDiscoverabilities?>(nameof(Discoverabilities)); }
            set { BackingStore?.Set(nameof(Discoverabilities), value); }
        }
        /// <summary>Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DiscoveryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DiscoveryDateTime)); }
            set { BackingStore?.Set(nameof(DiscoveryDateTime), value); }
        }
        /// <summary>Name of the directory. Must be unique within the synchronization schema. Not nullable.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Collection of objects supported by the directory.</summary>
        public List<ObjectDefinition> Objects {
            get { return BackingStore?.Get<List<ObjectDefinition>>(nameof(Objects)); }
            set { BackingStore?.Set(nameof(Objects), value); }
        }
        /// <summary>The readOnly property</summary>
        public bool? ReadOnly {
            get { return BackingStore?.Get<bool?>(nameof(ReadOnly)); }
            set { BackingStore?.Set(nameof(ReadOnly), value); }
        }
        /// <summary>Read only value that indicates version discovered. null if discovery has not yet occurred.</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"discoverabilities", n => { Discoverabilities = n.GetEnumValue<DirectoryDefinitionDiscoverabilities>(); } },
                {"discoveryDateTime", n => { DiscoveryDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"objects", n => { Objects = n.GetCollectionOfObjectValues<ObjectDefinition>(ObjectDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
