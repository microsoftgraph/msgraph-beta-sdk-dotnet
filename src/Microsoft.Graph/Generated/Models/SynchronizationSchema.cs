using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public class SynchronizationSchema : Entity, IParsable {
        /// <summary>Contains the collection of directories and all of their objects.</summary>
        public List<DirectoryDefinition> Directories {
            get { return BackingStore?.Get<List<DirectoryDefinition>>(nameof(Directories)); }
            set { BackingStore?.Set(nameof(Directories), value); }
        }
        /// <summary>A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.</summary>
        public List<SynchronizationRule> SynchronizationRules {
            get { return BackingStore?.Get<List<SynchronizationRule>>(nameof(SynchronizationRules)); }
            set { BackingStore?.Set(nameof(SynchronizationRules), value); }
        }
        /// <summary>The version of the schema, updated automatically with every schema change.</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SynchronizationSchema CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"directories", n => { Directories = n.GetCollectionOfObjectValues<DirectoryDefinition>(DirectoryDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"synchronizationRules", n => { SynchronizationRules = n.GetCollectionOfObjectValues<SynchronizationRule>(SynchronizationRule.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<DirectoryDefinition>("directories", Directories);
            writer.WriteCollectionOfObjectValues<SynchronizationRule>("synchronizationRules", SynchronizationRules);
            writer.WriteStringValue("version", Version);
        }
    }
}
