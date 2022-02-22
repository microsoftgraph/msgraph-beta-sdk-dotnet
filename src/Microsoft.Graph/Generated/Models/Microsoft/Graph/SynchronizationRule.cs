using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SynchronizationRule : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.</summary>
        public bool? Editable { get; set; }
        /// <summary>Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.</summary>
        public string Id { get; set; }
        /// <summary>Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.</summary>
        public List<StringKeyStringValuePair> Metadata { get; set; }
        /// <summary>Human-readable name of the synchronization rule. Not nullable.</summary>
        public string Name { get; set; }
        /// <summary>Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.</summary>
        public List<ObjectMapping> ObjectMappings { get; set; }
        /// <summary>Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.</summary>
        public int? Priority { get; set; }
        /// <summary>Name of the source directory. Must match one of the directory definitions in synchronizationSchema.</summary>
        public string SourceDirectoryName { get; set; }
        /// <summary>Name of the target directory. Must match one of the directory definitions in synchronizationSchema.</summary>
        public string TargetDirectoryName { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationRule and sets the default values.
        /// </summary>
        public SynchronizationRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"editable", (o,n) => { (o as SynchronizationRule).Editable = n.GetBoolValue(); } },
                {"id", (o,n) => { (o as SynchronizationRule).Id = n.GetStringValue(); } },
                {"metadata", (o,n) => { (o as SynchronizationRule).Metadata = n.GetCollectionOfObjectValues<StringKeyStringValuePair>().ToList(); } },
                {"name", (o,n) => { (o as SynchronizationRule).Name = n.GetStringValue(); } },
                {"objectMappings", (o,n) => { (o as SynchronizationRule).ObjectMappings = n.GetCollectionOfObjectValues<ObjectMapping>().ToList(); } },
                {"priority", (o,n) => { (o as SynchronizationRule).Priority = n.GetIntValue(); } },
                {"sourceDirectoryName", (o,n) => { (o as SynchronizationRule).SourceDirectoryName = n.GetStringValue(); } },
                {"targetDirectoryName", (o,n) => { (o as SynchronizationRule).TargetDirectoryName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("editable", Editable);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectMapping>("objectMappings", ObjectMappings);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("sourceDirectoryName", SourceDirectoryName);
            writer.WriteStringValue("targetDirectoryName", TargetDirectoryName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
