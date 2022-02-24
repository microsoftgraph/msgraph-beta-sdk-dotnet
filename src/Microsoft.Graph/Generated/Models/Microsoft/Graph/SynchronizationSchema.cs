using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationSchema : Entity, IParsable {
        /// <summary>Contains the collection of directories and all of their objects.</summary>
        public List<DirectoryDefinition> Directories { get; set; }
        /// <summary>A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.</summary>
        public List<SynchronizationRule> SynchronizationRules { get; set; }
        /// <summary>The version of the schema, updated automatically with every schema change.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"directories", (o,n) => { (o as SynchronizationSchema).Directories = n.GetCollectionOfObjectValues<DirectoryDefinition>().ToList(); } },
                {"synchronizationRules", (o,n) => { (o as SynchronizationSchema).SynchronizationRules = n.GetCollectionOfObjectValues<SynchronizationRule>().ToList(); } },
                {"version", (o,n) => { (o as SynchronizationSchema).Version = n.GetStringValue(); } },
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
